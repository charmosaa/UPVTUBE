using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpvTube
{
    public static class Messages
    {
        #region GUI

        // UPVTube base form
        public const string InfoDBInitialized = "Database has been initialized!";
        public const string InfoDBCleared = "Database has been cleared!";
        public const string InfoLoggedOut = "You have been logged out!";

        // Log in form
        public const string InfoLoginSuccess = "User logged in!";

        // Register form
        public const string InfoRegisterSuccess = "User registered!";

        // Single content form
        public const string InfoContentIsAuthorized = "Content is authorized.";
        public const string InfoContentIsNotAuthorized = "Content is not authorized.";
        public const string InfoCreatorSubscribed = "Creator added to your subscriptions.";
        public const string InfoCreatorUnsubscribed = "Creator removed from your subscriptions.";

        // Evaluation rejection form
        public const string ErrorNoReasonOfRejection = "Give a reason of rejection.";
        public const string InfoEvaluationAddSuccess = "Evaluation of the content has been added.\nEmail has been sent.";

        // Upload new content form
        public const string InfoUploadContentSuccess = "New Content Uploaded Successfully!\nWould you like to add another one?\nIf not, the content list will open.";
        public const string ErrorMoreThan3Subjects = "You can only select up to 3 subjects.";

        #endregion


        #region UPVTubeService

        public const string ErrorSubjectNameAlreadyExists = "Subject with name {0} already exists.";
        public const string ErrorSubjectCodeAlreadyExists = "Subject with code {0} already exists.";
        public const string ErrorUnauthorized = "Unauthorized!";
        public const string ErrorNoPermissions = "You don't have the permissions to review content.";
        public const string ErrotNoUPVMemberCannotSubscribe = "You are not a UPV member. \nYou can not subscribe!";
        public const string ErrorAlreadySubscribed = "You are already subscribed to this user!";
        public const string ErrorAlreadyUnsubscribed = "You aren't subscribed to this user!";
        public const string ErrorContentWithIdDoesNotExist = "Content with id {0} does not exist.";
        public const string ErrorUserAlreadyLoggedIn = "User is already logged in.";
        public const string ErrorWrongLoginCreadentials = "Wrong login credentials.";
        public const string ErrorNoUserLoggedIn = "No user is logged in.";
        public const string ErrorDataMissing = "Some data is missing - insert all the fields.";
        public const string ErrorMemberNickAlreadyExists = "Member with this nick already exists.";
        public const string ErrorMemberEmailAlreadyExists = "Member with this email already exists.";
        public const string ErrorNullContentVisualization = "Cannot register a visualization for a null content.";
        public const string ErrorHaveToBeLoggedIn = "You have to be logged in.";
        public const string ErrorHaveToBeUPVMember = "You have to be a UPV member.";
        public const string ErrorURIEmpty = "Content URI can't be empty.";
        public const string ErrorTitleEmpty = "Title can't be empty.";

        #endregion
    }
}
