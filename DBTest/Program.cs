using System;
using System.Data.Entity.Validation;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UPVTube.Entities;
using UPVTube.Persistence;

namespace DBTest
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                new Program();
            }
            catch (Exception e)
            {
                printError(e);
            }
            Console.WriteLine("\nPress a key to exit...");
            Console.ReadLine();
        }

        static void printError(Exception e)
        {
            while (e != null)
            {
                if (e is DbEntityValidationException)
                {
                    DbEntityValidationException dbe = (DbEntityValidationException)e;

                    foreach (var eve in dbe.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                                ve.PropertyName,
                                eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                                ve.ErrorMessage);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
                e = e.InnerException;
            }
        }


        Program()
        {
            IDAL dal = new EntityFrameworkDAL(new UPVTubeDbContext());

            CreateSampleDB(dal);

        }

        private void CreateSampleDB(IDAL dal)
        {
            // Remove all data from DB
            dal.RemoveAllData();

            Console.WriteLine("\n// CREATING A MEMBER - STUDENT");

            // public Member(String email, string fullName, DateTime lastAccessDate, string nick, string password)

            Member a1 = new Member("bart@inf.upv.es", "Bart Simpson", DateTime.Now, "Bart", "1234");
            dal.Insert<Member>(a1);
            dal.Commit();

            Console.WriteLine("\n// CREATING A CONTENT");
            //public Content(string contentURI, string description, bool isPublic, string title, DateTime uploadDate, Member owner)

            Content c1 = new Content("http://fake.uri.es", "Inheritance driven polymorphism explained", true, "Polymorphism", DateTime.Now, a1);
            a1.AddContent(c1);  // Hay que implementar el método AddContent(Content c) en Member
            dal.Insert<Content>(c1);
            dal.Commit();

            Console.WriteLine("\n// CREATING A MEMBER - PROFESSOR");
            // public Member(String email, string fullName, DateTime lastAccessDate, string nick, string password)

            Member p1 = new Member("john@inf.upv.es", "John Doe", DateTime.Now, "Prof", "4321");
            dal.Insert<Member>(p1);
            dal.Commit();

            Console.WriteLine("\n// CREATING A EVALUATION");
            // public Evaluation(DateTime evaluationDate, string rejectionReason, Member censor, Content content)

            Evaluation e1 = new Evaluation(DateTime.Now, null, p1, c1);
            c1.Evaluation = e1;
            p1.Evaluations.Add(e1);
            dal.Insert<Evaluation>(e1);
            dal.Commit();

            Console.WriteLine("\n// CREATING A VISUALIZATION");
            // public Visualization(DateTime dateTime, Content content, Member member)

            Visualization v1 = new Visualization(DateTime.Now, c1, p1);
            c1.Visualizations.Add(v1);
            p1.Visualizations.Add(v1);
            dal.Insert<Visualization>(v1);
            dal.Commit();

            Console.WriteLine("\n// CREATING A COMMENT");
            // public Comment(string Text, DateTime WritingDate, Content Content, Member Writer)

            Comment cm1 = new Comment("This is awesome!", DateTime.Now, c1, a1);
            c1.Comments.Add(cm1);
            a1.Comments.Add(cm1);
            dal.Insert<Comment>(cm1);
            dal.Commit();

            Console.WriteLine("\n// CREATING A SUBJECT");
            // public Subject(int code, string fullName, string name)

            Subject s1 = new Subject(1, "Software Engineering", "ISW");
            s1.Contents.Add(c1);
            c1.Subjects.Add(s1);
            dal.Insert<Subject>(s1);
            dal.Commit();

            Console.WriteLine("A new video has been uploaded to: " + c1.ContentURI + " created by " + c1.Owner.FullName);

            Console.ReadKey();
        }

    }
}
