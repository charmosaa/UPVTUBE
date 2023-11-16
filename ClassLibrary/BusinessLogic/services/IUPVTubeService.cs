using System.Collections.Generic;
using UPVTube.Entities;

namespace UpvTube.BusinessLogic.Services
{
    interface IUPVTubeService
    {
        void registerNewUser();
        void login();
        void logout();
        void uploadNewContent(string contentURI, string description, bool isPublic, string title, ICollection<Subject> subjects);
        void searchContent();
        void displayContentDetails();
        void addReviewToPendingContent();
    }
}
