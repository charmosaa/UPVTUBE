using UpvTube.BusinessLogic.Services;
using UPVTube.Entities;
using UPVTube.Persistence;

IUPVTubeService service = new UPVTubeService(new EntityFrameworkDAL(new UPVTubeDbContext()));

Console.WriteLine("Hello, World!");

service.DBInitialization();
service.Login("lmantov", "passw0rd");

List<Content> contents = service.SearchContent(DateTime.Parse("01/01/2000"), DateTime.Now, null, null, null).ToList<Content>();

service.UploadNewContent("https://youtube.com", "Example content uploaded by student", true, "Student Content Example", new List<Subject> { });

service.Logout();

service.Login("fjaen", "UPV2023");

List<Content> allContents = service.GetAllContents().ToList<Content>();

Content toReview = allContents[allContents.Count - 1];

service.AddReviewToPendingContent(toReview, "I don't like it");

Console.WriteLine("Goodbye");