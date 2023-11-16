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

        public UPVTubeService(IDAL dal)
        {
            this.dal = dal;
            this.logged = null;
        }

        public void addReviewToPendingContent()
        {
            throw new System.NotImplementedException();
        }

        public void displayContentDetails()
        {
            throw new System.NotImplementedException();
        }

        public void login()
        {
            throw new System.NotImplementedException();
        }

        public void logout()
        {
            throw new System.NotImplementedException();
        }

        public void registerNewUser()
        {
            throw new System.NotImplementedException();
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
