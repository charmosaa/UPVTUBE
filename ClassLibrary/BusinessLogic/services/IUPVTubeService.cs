using UPVTube.Entities;

namespace UpvTube.BusinessLogic.Services
{
    interface IUPVTubeService
    {
        void registerNewUser();
        void login();
        void logout();
        void uploadNewContent();
        void searchContent();
        void displayContentDetails();
        void addReviewToPendingContent(Content content, string justification);
    }
}
