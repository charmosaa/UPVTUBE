using System;
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

        public void addReviewToPendingContent(Content content, string justification)
        {
            if (logged == null)
            {
                throw new ServiceException("You have to be logged in to review content.");
            }
            else if (!Domains.IsTeacherDomain(logged.Email))
            {
                throw new ServiceException("You don't have the permissions to review content.");
            }
            else
            {
                Evaluation eval = new Evaluation(DateTime.Now, justification, logged, content);
                content.Evaluation = eval;
                dal.Insert<Evaluation>(eval);
                dal.Commit();

                // TODO: send an email to the content owner indicating the result of the review
            }
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

        public void uploadNewContent()
        {
            throw new System.NotImplementedException();
        }
    }
}
