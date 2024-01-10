using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Contexts;
using UPVTube.Entities;
using UPVTube.Persistence;
using UPVTube.Services;

namespace UpvTube.BusinessLogic.Services
{
    public class UPVTubeService : IUPVTubeService
    {

        private readonly IDAL dal;
        private Member logged;

        public UPVTubeService(IDAL dal)
        {
            this.dal = dal;
            this.logged = null;
        }

        public bool IsLoggedIn()
        {
            return logged != null;
        }

        public bool isTeacherLogged()
        {
            return logged != null && Domains.IsTeacherDomain(logged.Email);
        }

        public bool isUPVMemberLogged()
        {
            return logged != null && Domains.IsUPVMemberDomain(logged.Email);
        }

        public void RemoveAllData()
        {
            this.logged = null;
            this.dal.RemoveAllData();
            dal.Commit();
        }

        public void Commit()
        {
            this.dal.Commit();
        }

        public void AddSubject(Subject subject)
        {
            // Restriction: Not two subjects with the same code
            if (dal.GetById<Subject>(subject.Code) == null)
            {
                // Restriction: Not two courses with same name
                if (!dal.GetWhere<Subject>(x => x.Name == subject.Name).Any())
                {
                    // Inserting in the DB
                    dal.Insert<Subject>(subject);
                    dal.Commit();
                }
                else
                    throw new ServiceException("Subject with name " + subject.Name + " already exists.");
            }
            else
                throw new ServiceException("Subject with code " + subject.Code + " already exists.");
        }

        public void DBInitialization()
        {
            this.RemoveAllData();
            Subject s1 = new Subject(11555, "Ingeniería del software", "ISW");
            AddSubject(s1);
            Subject s2 = new Subject(11553, "Arquitectura e ingeniería de computadores", "AIC");
            AddSubject(s2);
            Subject s3 = new Subject(11548, "Bases de datos y sistemas de información", "BDA");
            AddSubject(s3);
            Subject s4 = new Subject(11560, "Sistemas inteligentes", "SIN");
            AddSubject(s4);

            RegisterNewUser("example@gmail.com", "Karol Waliszewski", "kwalisz", "upv2023");
            RegisterNewUser("lmantov@inf.upv.es", "Leonardo Mantovani", "lmantov", "passw0rd");
            RegisterNewUser("mlopian@inf.upv.es", "Martyna Lopianiak", "mlopian", "12345678");
            RegisterNewUser("fjaen@dsic.upv.es", "Francisco Javier Jaén Martínez", "fjaen", "upv2023");

            // Already authorized
            Login("fjaen", "upv2023");
            UploadNewContent("https://upv.es", "The UPV Website", true, "UPV Website", new List<Subject> { s4 });
            UploadNewContent("https://poliformat.upv.es", "The PoliformaT platform", false, "PoliformaT", new List<Subject> { s2 });
            Logout();

            // To be authorized
            Login("mlopian", "12345678");
            UploadNewContent("https://example.com", "Example content", true, "Example Content", new List<Subject> { s1, s3 });
            UploadNewContent("https://dev.azure.com", "Azure DevOps Website", true, "Azure DevOps", new List<Subject> { s1 });
            Logout();
        }

        public void AddReviewToPendingContent(Content content, string justification)
        {
            if (logged == null)
            {
                throw new ServiceException("Unathorized");
            }

            if (!Domains.IsTeacherDomain(logged.Email))
            {
                throw new ServiceException("You don't have the permissions to review content.");
            }

            Evaluation eval = new Evaluation(DateTime.Now, justification, logged, content);
            content.Evaluation = eval;
            logged.Evaluations.Add(eval);
            if (justification == null)
            {
                content.Authorized = Authorized.Yes;
            }
            else
            {
                content.Authorized = Authorized.No;
            }
            dal.Insert<Evaluation>(eval);
            dal.Commit();
        }

        public void AddSubscription(Member creator)
        {
            if(!isUPVMemberLogged())
                throw new ServiceException("You are not a UPV member. \nYou can not subscribe!");
            if (logged.SubscribedTo.Contains(creator))
                throw new ServiceException("You already subscribe to this user!");
            logged.SubscribedTo.Add(creator);
            creator.Subscriptors.Add(logged);
        }

        public void RemoveSubscription(Member creator)
        {
            if (!logged.SubscribedTo.Contains(creator))
                throw new ServiceException("You do not subscribe to this user!");
            logged.SubscribedTo.Remove(creator);
            creator.Subscriptors.Remove(logged);
        }

        public Content DisplayContentDetails(int id)
        {
            if (logged == null)
            {
                throw new ServiceException("Unauthorized");
            }

            Content content = dal.GetById<Content>(id);

            if (content == null)
            {
                throw new ServiceException("Content with id " + id + " does not exists.");
            }

            return content;
        }

        public void Login(string nick, string password)
        {
            if (logged != null)
            {
                throw new ServiceException("User is already logged in.");
            }

            Member memberToBeLogged = dal.GetWhere<Member>((member) => member.Nick == nick && member.Password == password).FirstOrDefault();
            if (memberToBeLogged != null)
            {
                logged = memberToBeLogged;
            }
            else throw new ServiceException("Wrong login credentials");
        }

        public void Logout()
        {
            if (logged == null)
            {
                throw new ServiceException("No member is logged.");
            }

            logged.LastAccessDate = DateTime.Now;
            dal.Commit();

            logged = null;
        }

        public void RegisterNewUser(string email, string fullname, string nick, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(nick) || string.IsNullOrEmpty(password))
                throw new ServiceException("Some data is missing - insert all the fields");
            else
            {
                if (dal.GetWhere<Member>((member) => member.Nick == nick).Count() > 0)
                    throw new ServiceException("Member with this nick already exists.");

                else if (dal.GetWhere<Member>((member) => member.Email == email).Count() > 0)
                    throw new ServiceException("Member with this email already exists.");
                else
                {
                    dal.Insert<Member>(new Member(email, fullname, DateTime.Now, nick, password));
                    dal.Commit();
                }
            }
        }

        public ICollection<Content> GetAllContents()
        {
            return dal.GetAll<Content>().ToList();
        }

        public ICollection<Content> GetSubscribedContents()
        {
            IEnumerable<Content> contents = GetAllContents();
            contents = contents.Where<Content>(c => c.Authorized == 0);
            if (logged.LastAccessDate != null)
            {
                contents = contents.Where(c => c.UploadDate.Date >= logged.LastAccessDate.Date);
            }
            contents = contents.Where<Content>(content => logged.SubscribedTo.Contains(content.Owner));

            return contents.ToList();
        }

        public ICollection<Content> SearchContent(DateTime startDate, DateTime endDate, string ownerNick, string titleKeyword, Subject subject, Authorized? status)
        {
            if (logged == null)
            {
                throw new ServiceException("Unathorized");
            }

            IEnumerable<Content> contents = dal.GetAll<Content>();
            // Filter by public/private access
            if (!Domains.IsUPVMemberDomain(logged.Email))
            {
                contents = contents.Where(c => c.IsPublic == true);
            }
            // Filter by upload date range
            if (startDate != null && endDate != null)
            {
                contents = contents.Where(c => c.UploadDate.Date >= startDate.Date && c.UploadDate.Date <= endDate.Date);
            }
            // Filter by owner nick
            if (!string.IsNullOrEmpty(ownerNick))
            {
                contents = contents.Where(c => c.Owner.Nick.Contains(ownerNick));
            }
            // Filter by title keyword
            if (!string.IsNullOrEmpty(titleKeyword))
            {
                if (exactTitleMatch)
                {
                    contents = contents.Where(c => c.Title == titleKeyword);
                }
                else
                {
                    contents = contents.Where(c => c.Title.Contains(titleKeyword));
                }
            }
            // Filter by subject 
            if (subject != null)
            {
                contents = contents.Where(c => c.Subjects.Contains(subject));
            }
            // Filter by status
            if (status != null)
            {
                contents = contents.Where(c => c.Authorized == status);
            }

            return contents.ToList();
        }

        public ICollection<Subject> GetAllSubjects()
        {
            return dal.GetAll<Subject>().ToList();
        }

        public Visualization GetLastUserVisualization(Content content)
        {
            List<Visualization> userViews = content.Visualizations.Where<Visualization>(v => v.Member.Nick == logged.Nick).ToList();
            userViews.Sort((x, y) => DateTime.Compare(x.VisualizationDate, y.VisualizationDate));
            return (userViews.Count == 0) ? null : userViews.Last();
        }

        public void RegisterVisualization(Content content)
        {
            if (logged == null)
            {
                throw new ServiceException("Unathorized");
            }
            else if (content == null)
            {
                throw new ServiceException("Cannot register a visualization for a null content");
            }
            Visualization newView = new Visualization(DateTime.Now, content, logged);
            content.Visualizations.Add(newView);
            logged.Visualizations.Add(newView);

            dal.Insert(newView);
            dal.Commit();
        }

        public ICollection<Content> GetViewsHistory()
        {
            List<Visualization> userViews = logged.Visualizations.ToList();
            userViews.Sort((x, y) => DateTime.Compare(y.VisualizationDate, x.VisualizationDate));  // sort the views in descending order
            return userViews.Select(v => v.Content).Distinct().ToList();  // return the viewed content
        }

        public void UploadNewContent(string contentURI, string description, bool isPublic, string title, ICollection<Subject> subjects)
        {
            if (logged == null)
            {
                throw new ServiceException("You have to be logged in.");
            }

            if (!Domains.IsUPVMemberDomain(logged.Email))
            {
                throw new ServiceException("You have to be a UPV member.");
            }

            if (subjects.Count() > 3)
            {
                throw new ServiceException("You can't add more than 3 subjects.");
            }

            if (contentURI == null || contentURI == "")
            {
                throw new ServiceException("Content URI can't be empty.");
            }

            if (title == null || title == "")
            {
                throw new ServiceException("Title can't be empty");
            }

            Content newContent = new Content(contentURI, description, isPublic, title, DateTime.Now, logged);
            newContent.Subjects = subjects;
            logged.AddContent(newContent);

            dal.Insert(newContent);
            dal.Commit();
        }
        public Member GetLoggedUser()
        {
            return logged;
        }

    }
}
