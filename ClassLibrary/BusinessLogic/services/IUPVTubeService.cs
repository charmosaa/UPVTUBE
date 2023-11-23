using System;
using System.Collections.Generic;
using UPVTube.Entities;

namespace UpvTube.BusinessLogic.Services
{
    interface IUPVTubeService
    {
        void registerNewUser();
        void login();
        void logout();
        void uploadNewContent();
        ICollection<Content> searchContent(DateTime startDate, DateTime endDate, string ownerNick, string titleKeyword, Subject subject);
        void displayContentDetails();
        void addReviewToPendingContent();
    }
}
