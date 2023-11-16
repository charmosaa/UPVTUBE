using System;
using System.Collections.Generic;
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

        public void login(string nick, string password)
        {
            if(logged != null)
            {
                throw new ServiceException("User is already logged in.");
            }

            Member memberToBeLogged = dal.GetWhere<Member>((member) => member.Nick == nick && member.Password == password).FirstOrDefault();
            if (memberToBeLogged != null)
            {
                logged = memberToBeLogged;
            }
            else throw new ServiceException("Wrong login credentials");
        }

        public void logout()
        {
            if (logged != null)
            {
                throw new ServiceException("No member is logged.");
            }

            logged.LastAccessDate = DateTime.Now;
            dal.Commit();

            logged = null;
        }

        public void registerNewUser(string email, string fullname, string nick, string password)
        {
            if (dal.GetWhere<Member>((member) => member.Nick == nick || member.Email == email) == null)
            {
                dal.Insert<Member>(new Member(email, fullname, DateTime.Now, nick, password));
                dal.Commit();
            }
            else throw new ServiceException("Member already exists.");
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
