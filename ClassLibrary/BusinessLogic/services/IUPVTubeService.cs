using UPVTube.Entities;

namespace UpvTube.BusinessLogic.Services
{
    interface IUPVTubeService
    {
        void registerNewUser(string email, string fullname, string nick, string password);
        void login(string nick, string password);
        void logout();
        void uploadNewContent();
        void searchContent();
        Content displayContentDetails(int id);
        void addReviewToPendingContent();
    }
}
