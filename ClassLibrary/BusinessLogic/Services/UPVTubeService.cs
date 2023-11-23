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

        public void addReviewToPendingContent(Content content, bool approved, string justification)
        {
            if (approved && justification == null)
            {
                throw new ServiceException("You must provide a justification for rejecting a content.");
            }
            else
            {
                Evaluation eval = new Evaluation(DateTime.Now, justification, logged, content);
                content.Evaluation = eval;
                dal.Insert<Evaluation>(eval);
                dal.Commit();
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
