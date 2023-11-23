using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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

        public ICollection<Content> searchContent (DateTime startDate, DateTime endDate, string ownerNick, string titleKeyword, Subject subject)
        {
            if(logged != null)
            {
                IEnumerable<Content> contents = dal.GetAll<Content>();

                // Filter by upload date range
                if (startDate != null && endDate != null)
                    contents = contents.Where(c => c.UploadDate >= startDate && c.UploadDate <= endDate);


                // Filter by owner nick
                if (!string.IsNullOrEmpty(ownerNick))
                {
                    Member owner = dal.GetById<Member>(ownerNick);
                    contents = contents.Where(c => c.Owner == owner);
                }

                // Filter by title keyword
                if (!string.IsNullOrEmpty(titleKeyword))
                    contents = contents.Where(c => c.Title.Contains(titleKeyword));

                // Filter by subject 
                if (subject != null)
                    contents =contents.Where(c => c.Subjects.Contains(subject));

                return contents.ToList();
                
            }
            else throw new ServiceException("unlogged user"); ;
        }

        public void uploadNewContent()
        {
            throw new System.NotImplementedException();
        }
    }
}
