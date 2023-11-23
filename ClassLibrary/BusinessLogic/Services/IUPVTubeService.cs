using UPVTube.Entities;

namespace UpvTube.BusinessLogic.Services
{
    interface IUPVTubeService
    {
        void registerNewUser(string email, string fullname, string nick, string password);
        void login(string nick, string password);
        void logout();
        void uploadNewContent(string contentURI, string description, bool isPublic, string title, ICollection<Subject> subjects);
        void searchContent();
        Content displayContentDetails(int id);
        void addReviewToPendingContent();
    }
}
