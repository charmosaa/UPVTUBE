using UPVTube.Persistence;

namespace UpvTube.BusinessLogic.Services
{
    public class UPVTubeService : IUPVTubeService
    {

        private readonly IDAL dal;

        public UPVTubeService(IDAL dal) {
            this.dal = dal;
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

        public void uploadNewContent()
        {
            throw new System.NotImplementedException();
        }
    }
}
