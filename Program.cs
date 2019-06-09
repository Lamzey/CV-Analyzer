using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //This appli enables applicant to submit their C.V and either get a job interview or not immediately they submit

            Console.Write("Welcome To C.V Analyzer");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Please Note That Your Reply Comes Immediately and You Will Be Notified If You're Qualified For An Interview Or Not");
            Console.WriteLine("");
            Console.WriteLine("");
            string job_title = "Job Title; Information, Communcation and Technology";
            Console.WriteLine(job_title);
            Console.WriteLine("");
            Console.WriteLine("Please follow the intructions");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Enter Your Full Name (e.g, Lamzey Aribido): ");
            string name = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Enter Your Nationality: ");
            string nationality = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Enter Your Date of birth (e.g, 11/10/1990): ");
            string date_of_birth = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Enter Your Course of Study: ");
            string course_of_study = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Enter Your Educational Level (e.g, B.Sc, M.Sc): ");
            string eductional_level = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Enter Your Relevant Skills: ");
            string skills = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Enter Your Years Of Experience: ");
            string YOE = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Enter Your Likes and Dislikes: ");
            string LAD = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("References (Provide Only Two: ");
            Console.WriteLine("");
            Console.Write("Enter Full Name (e.g, Lamzey Aribido): ");
            string name1 = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Enter Occupation: ");
            string occupation1 = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Enter Full Name (e.g, Lamzey Aribido): ");
            string name2 = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Enter Occupation: ");
            string occupation2 = Console.ReadLine();
            Console.WriteLine("");


            Console.WriteLine("Please cross check your information");
            Console.WriteLine("");

            Console.Write("Full Name: ");
            Console.WriteLine(name);
            Console.WriteLine("");
            Console.Write("Nationality: ");
            Console.WriteLine(nationality);
            Console.WriteLine("");
            Console.Write("Date of birth: ");
            Console.WriteLine(date_of_birth);
            Console.WriteLine("");
            Console.Write("Course of Study: ");
            Console.WriteLine(course_of_study);
            Console.WriteLine("");
            Console.Write("Educational Level: ");
            Console.WriteLine(eductional_level);
            Console.WriteLine("");
            Console.Write("Relevant Skills: ");
            Console.WriteLine(skills.ToUpper());
            Console.WriteLine("");
            Console.Write("Years Of Experience: ");
            Console.WriteLine(YOE);
            Console.WriteLine("");
            Console.Write("Likes and Dislikes: ");
            Console.WriteLine(LAD);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("References: ");
            Console.WriteLine("");
            Console.Write(name1);
            Console.WriteLine("");
            Console.Write(occupation1);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write(name2);
            Console.WriteLine("");
            Console.Write(occupation2);
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Would You Like To Continue Or Edit?");
            Console.WriteLine("");
            Console.WriteLine("Enter Continue or Edit: ");
            string entry = Console.ReadLine();


            if (entry == "Edit")
            {
                Console.WriteLine("Please follow the intructions very carefully");
                Console.WriteLine("");
                Console.Write("Enter Your Full Name (e.g, Lamzey Aribido): ");
                name = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Enter Your Nationality: ");
                nationality = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Enter Your Date of birth (e.g, 11/10/1990): ");
                date_of_birth = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Enter Your Course of Study: ");
                course_of_study = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Enter Your Educational Level (e.g, B.Sc, M.Sc): ");
                eductional_level = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Enter Your Relevant Skills: ");
                skills = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Enter Your Years Of Experience: ");
                YOE = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Enter Your Likes and Dislikes: ");
                LAD = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("");

                Console.Write("References (Provide Only Two: ");
                Console.WriteLine("");
                Console.Write("Enter Full Name (e.g, Lamzey Aribido): ");
                name1 = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Enter Occupation: ");
                occupation1 = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Enter Full Name (e.g, Lamzey Aribido): ");
                name2 = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Enter Occupation: ");
                occupation2 = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine("Please cross check your information");
                Console.WriteLine("");

                Console.Write("Full Name: ");
                Console.WriteLine(name);
                Console.WriteLine("");
                Console.Write("Nationality: ");
                Console.WriteLine(nationality);
                Console.WriteLine("");
                Console.Write("Date of birth: ");
                Console.WriteLine(date_of_birth);
                Console.WriteLine("");
                Console.Write("Course of Study: ");
                Console.WriteLine(course_of_study);
                Console.WriteLine("");
                Console.Write("Educational Level: ");
                Console.WriteLine(eductional_level);
                Console.WriteLine("");
                Console.Write("Relevant Skills: ");
                Console.WriteLine(skills.ToUpper());
                Console.WriteLine("");
                Console.Write("Years Of Experience: ");
                Console.WriteLine(YOE);
                Console.WriteLine("");
                Console.Write("Likes and Dislikes: ");
                Console.WriteLine(LAD);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("References: ");
                Console.WriteLine("");
                Console.Write("Full Name: ");
                name1 = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Occupation: ");
                occupation1 = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("Full Name: ");
                name2 = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Occupation: ");
                occupation2 = Console.ReadLine();
                Console.WriteLine("");
            }
            else
            {
                string schedule = ("10/6/2019, 10:00am prompt");
            Console.WriteLine("Congratulations " + name + " , You have been granted an interview with us with " + job_title + " on " + schedule);
            }
           
            //string[] course = new course [8] {
            //"Software Engineering", "Computer Science", "Information Technology", "Computer Engineering", "Business Informatics", "Information Science", "System Engineering", "Cyber Security"
            //};

            //if (course_of_study = course)
            //{
            //    Console.WriteLine("Please Wait While We are Processing Your Information");
            //}
            //else
            //{
            //    Console.WriteLine("We are sorry, We won't be able to continue with you");
            //}

            //if (eductional_level = ["Associate Degree", "Diploma", "Bachelors", "Masters"])
            //{
            //    Console.WriteLine("Please Wait While We are Processing Your Information");
            //}
            //else
            //{
            //    Console.WriteLine("We are sorry, We won't be able to continue with you");
            //}

            //if (skills = ["ms word", "python", "java", "javascript", "html5", "css3", "ruby", "csharp", "c++", "aws", "c", "cyber security", "php"])
            //{
            //    Console.WriteLine("Congratulations, you have been slated for an interview with us");
            //}
            //else
            //{
            //    Console.WriteLine("We are sorry, We won't be able to continue with you");
            //}
            Console.ReadKey();
        }
    }
}