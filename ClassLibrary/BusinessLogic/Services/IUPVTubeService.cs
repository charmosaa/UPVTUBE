using UPVTube.Entities;

namespace UpvTube.BusinessLogic.Services
{
    interface IUPVTubeService
    {
        void registerNewUser(string email, string fullname, string nick, string password);
        void login(string nick, string password);
        void logout();
        void uploadNewContent(string contentURI, string description, bool isPublic, string title, ICollection<Subject> subjects);
        public ICollection<Content> searchContent(DateTime startDate, DateTime endDate, string ownerNick, string titleKeyword, Subject subject);
        IEnumerable<Content> getAllContents();
        Content displayContentDetails(int id);
        void addReviewToPendingContent();
    }
}
