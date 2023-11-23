using System;
using System.Collections.Generic;
using System.Linq;
using UPVTube.Entities;
using UPVTube.Persistence;
using UPVTube.Services;

namespace UpvTube.BusinessLogic.Services
{
    public class UPVTubeService : IUPVTubeService
    {

        private readonly IDAL dal;
        private Member logged;

        public UPVTubeService(IDAL dal) {
            this.dal = dal;
            this.logged = null;
        }

        public void addReviewToPendingContent()
        {
            throw new System.NotImplementedException();
        }

        public Content displayContentDetails(int id)
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

        public void login(string nick, string password)
        {
            if(logged != null)
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

        public void logout()
        {
            if (logged == null)
            {
                throw new ServiceException("No member is logged.");
            }

            logged.LastAccessDate = DateTime.Now;
            dal.Commit();

            logged = null;
        }

        public void registerNewUser(string email, string fullname, string nick, string password)
        {
            if (dal.GetWhere<Member>((member) => member.Nick == nick || member.Email == email) == null)
            {
                dal.Insert<Member>(new Member(email, fullname, DateTime.Now, nick, password));
                dal.Commit();
            }
            else throw new ServiceException("Member already exists.");
        }

        public void searchContent()
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Subject> getAllSubjects()
        {
            return dal.GetAll<Subject>().ToList();
        }

        public void uploadNewContent(string contentURI, string description, bool isPublic, string title, ICollection<Subject> subjects)
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

            Content newContent = new Content(contentURI, description, isPublic, title, DateTime.Now, logged);
            newContent.Subjects = subjects;
            logged.AddContent(newContent);

            dal.Insert(newContent);
            dal.Commit();
        }
    }
}
