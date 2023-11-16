namespace UpvTube.BusinessLogic.Services
{
    interface IUPVTubeService
    {
        void registerNewUser(string email, string nick, string password);
        void login(string nick, string password);
        void logout();
        void uploadNewContent();
        void searchContent();
        void displayContentDetails();
        void addReviewToPendingContent();
    }
}
