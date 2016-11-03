using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        //declare class wide accessed variables
        static int id = 0;
        static String matricNum = "student/" + id;     
        static List<string> Biolist = new List<string>();
        static string fname, lname, oname, deptOption, pcode, JambReg, Full_Part, DOB, Nationality, level, phone, email, city, housenum, street, dept;
        static string reply;
        static void Main(string[] args)
        {
            GetInfo();//call the first method

            Console.ReadKey();
        }

        private static void GetInfo(){
            //collect info
            Console.WriteLine(" Enter information on  Student ");
            Console.WriteLine();

            Console.Write("whats your first name:");
            fname = Console.ReadLine();
            Biolist.Insert(id, fname);

            Console.Write("whats your last name:");
            lname = Console.ReadLine();
            Biolist.Insert(id, lname);

            Console.Write("Other names?:");
            oname = Console.ReadLine();
            Biolist.Insert(id, oname);

            Console.Write("Date of birth:");
            DOB = Console.ReadLine();
            Biolist.Insert(id, DOB);

            Console.Write("Nationality?:");
            Nationality = Console.ReadLine();
            Biolist.Insert(id, Nationality);

            Console.Write("Level:");
            level = Console.ReadLine();
            Biolist.Insert(id, level);


            Console.Write("Phone?:");
            phone = Console.ReadLine();

            Biolist.Insert(id, phone);

            Console.Write("Email?:");
            email = Console.ReadLine();
            Biolist.Insert(id, email);

            Console.Write("City?:");
            city = Console.ReadLine();
            Biolist.Insert(id, city);

            Console.Write("Housenum?:");
            housenum = Console.ReadLine();
            Biolist.Insert(id, housenum);

            Console.Write("Street?:");
            street = Console.ReadLine();

            Console.Write("Postcode?:");
            pcode = Console.ReadLine();
            Biolist.Insert(id, pcode);

            Console.Write("Jamb Reg?:");
            JambReg = Console.ReadLine();
            Biolist.Insert(id, JambReg);

            Console.Write("Fulltime or part time?:");
            Full_Part = Console.ReadLine();
            Biolist.Insert(id, Full_Part);

            Console.Write("Department?:");
            dept = Console.ReadLine();
            Biolist.Insert(id, dept);

            Console.Write("Department Option?:");
            deptOption = Console.ReadLine();
            Biolist.Insert(id, deptOption);
            Biolist.Insert(id, matricNum);
            id = id + 1;//this will automatically change the matric number for the next student

            //Interact with user....Call a dialog method
            Dialog();
        }

        public static void Dialog()
        {
            //new request
            Console.WriteLine("1. Create Another Record");
            Console.WriteLine("2. View Record");
            Console.WriteLine("3. Exit");
            reply = Console.ReadLine();

            switch (reply)
            {
                case "1":
                    GetInfo();
                    break;
                case "2":
                    View();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Error("You Have Entered An Invalid Character Try Again");
                    
                    Dialog();
                    break;
            }
            
            
        }
        private static void Error(String Emsg)
        {
            Console.WriteLine(Emsg);
            Console.Beep();
            return;
        }
        private static void View()
        {
            Address Saddress = new Address(phone, email, housenum, street, pcode, city);
            AcademicDetails Sacad = new AcademicDetails(JambReg, Full_Part, matricNum, deptOption);
            Department mydept = new Department(dept);
            Name name = new Name(lname, fname, oname);
            BioData biod = new BioData(DOB, Nationality);
            Student chisom = new Student(Saddress, Sacad, mydept, name, biod);
            

            Console.WriteLine("1. View All");
            Console.WriteLine("2. View only Biodata");
            Console.WriteLine("3. View only Address");
            Console.WriteLine("4. View only Academic Details");
            Console.WriteLine("5. View Student Name");
            Console.WriteLine("6. Go Back");
            string answer=Console.ReadLine();

            switch(answer)
            {
                case "1":

                    //gets the number of students in the Biolist
                    int y = Biolist.Count / 16;

                    for (int p = 1; p <= y; p++)
                    {
                        for (int i = Biolist.Count - 1; i >= (15) * (y - 1); i--)
                        {
                            do
                            {
                                Console.Write("\t" + Biolist[i]);
                                y = y - 1;
                            } while (i>=0);
                            
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Dialog();

                    break;
                case"2":
                    Console.Write(chisom.StudentName.Fullname+"\t");
                    Console.Write(chisom.studentAddress.Phone + "\t");
                    Console.Write(chisom.studentDetails.MatricNo + "\t");
                    Console.WriteLine(chisom.Bio.DOB + "\t");
                    View();
                    break;
                case "3":
                    Console.Write(chisom.studentAddress.no + "\t");
                    Console.Write(chisom.studentAddress.streetName + "\t");
                    Console.Write(chisom.studentAddress.CityTown + "\t");
                    Console.Write(chisom.studentAddress.PostCode + "\t");
                    Console.WriteLine(chisom.studentAddress.Email + "\t");
                    View();
                    break;
                case "4":
                    Console.Write(chisom.studentDetails.MatricNo + "\t");
                    Console.Write(chisom.StudentDepartment + "\t");
                    Console.WriteLine(chisom.StudentDepartment.Faculty + "\t");
                    View();
                    break;
                case"5":
                    Console.Write(chisom.StudentName.Fullname + "\t");
                    Console.WriteLine(chisom.StudentName.Initials + "\t");
                    View();
                    break;
                case "6":
                    Dialog();
                    break;
                default:
                    Error(" You have selected either selected an Invalid Option or Punched a wrong Key");

                    break;

            }

        }
        
    }

}
