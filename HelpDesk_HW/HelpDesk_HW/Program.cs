using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            List <HelpDeskCalls> help_desk_calls = new List<HelpDeskCalls>()
            {
                //first object
                new HelpDeskCalls{Description = "Student's laptop has a virus", Date = "01/13/19",
                  Status = Status.InProg, Priority= Priority.High, Person = "Jeff", Notes=""},

                 //second object
                 new HelpDeskCalls{Description = "Student's iphone screen is cracked", Date = "02/14/19",
                  Status = Status.NotStarted, Priority= Priority.Medium, Person = "Joe", Notes=""},

                  //third object
                  new HelpDeskCalls{Description = "Student forgot password to his account", Date = "02/01/19",
                  Status = Status.Completed, Priority= Priority.High, Person = "Jack", Notes=""},

                   //fourth object
                   new HelpDeskCalls{Description = "Student having trouble finding there school GPA online", Date = "01/29/19",
                  Status = Status.Unresolved, Priority= Priority.Low, Person = "Jill", Notes=""},

                    //fifth object
                    new HelpDeskCalls{Description = "Student is having trouble printing", Date = "01/17/19",
                  Status = Status.InProg, Priority= Priority.Medium, Person = "Jacob", Notes=""},
                    


            };

           

            //call the void method
            PrintInfo(help_desk_calls);

            //pause
            Console.ReadLine();

        }//end static void main



        private static void PrintInfo(List<HelpDeskCalls> help_desk_calls)
        {

            foreach (var info1 in help_desk_calls)
            {
                switch (info1.Status)
                {
                    case Status.NotStarted:

                        info1.Notes = "Just reported";
                     
                        break;
                    case Status.InProg:
                        info1.Notes = "Help Desk personnel on scene";
                       
                        break;
                    case Status.Completed:
                        info1.Notes = "Ticket is complete";
                       
                        break;
                    case Status.Unresolved:
                        info1.Notes = "Ongoing investigation";
                       
                        break;
                    default:
                        break;
                }//end switch


               
            }//end foreach

                foreach (var info2 in help_desk_calls)
                {
                switch (info2.Priority)
                {
                    case Priority.Low:
                    
                        Console.WriteLine("Priority Description: The problem is on the back-burner.");
                        break;
                    case Priority.Medium:
                        Console.WriteLine("Priority Description: The problem is important.");
                        break;
                    case Priority.High:
                        Console.WriteLine("Priority Description: The problem is critical.");
                        break;
                    default:
                        break;
                }//end switch

                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("{0} {1} {2} {3}",
                   "Description: ", info2.Description, "Date: ", info2.Date);
                Console.WriteLine();
                   Console.WriteLine("{0} {1} {3} {4} {5} {6} {7}", "Status: ",
                   info2.Status, "Priority: ", info2.Priority, 
                   "Student who reported: ", info2.Person, " Notes: ", info2.Notes);
                Console.WriteLine("------------------------------------------------");
            }//end foreach


        }//end class

        class HelpDeskCalls
    {
        public String Description { get; set; }
        public String Date { get; set; }     
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        public String Person { get; set; }
        public String Notes { get; set; }




    }//end class

    enum Priority
    {
        Low,
        Medium,
        High


    }//end enum

    enum Status
    {
        NotStarted,
        InProg,
        Completed,
        Unresolved

    }//end enum



    }//end namespace
}