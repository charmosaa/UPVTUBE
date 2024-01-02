using System;
using System.Collections.Generic;
using UPVTube.Entities;

namespace UpvTube.BusinessLogic.Services
{
    public interface IUPVTubeService
    {
        void RegisterNewUser(string email, string fullname, string nick, string password);
        void Login(string nick, string password);
        void Logout();
        bool IsLoggedIn();
        bool isTeacherLogged();
        bool isUPVMemberLogged();
        void UploadNewContent(string contentURI, string description, bool isPublic, string title, ICollection<Subject> subjects);
        ICollection<Content> SearchContent(DateTime startDate, DateTime endDate, string ownerNick, string titleKeyword, Subject subject);
        ICollection<Content> GetAllContents();
        ICollection<Subject> GetAllSubjects();
        Visualization GetLastUserVisualization(Content content);
        Content DisplayContentDetails(int id);
        void AddReviewToPendingContent(Content content, string justification);
        void RemoveAllData();
        void DBInitialization();
    }
}
