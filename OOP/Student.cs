using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Student
    {
        private Name name;
        private AcademicDetails academicDetails;
        private Address address;

        //Properties
        public Address studentAddress { get; set; }
        public Name StudentName { get; set; }
        public AcademicDetails studentDetails { get; set; }
        public BioData Bio { get; set; }
        public Department StudentDepartment { get; set; }

        //Constructor
        public Student(Address Studentaddress, AcademicDetails StudentDetails, Department studentDepartment, Name studentName, BioData bios)
        {
           studentAddress= Studentaddress;
           studentDetails = StudentDetails;
           StudentDepartment = studentDepartment;
           StudentName = studentName;
           Bio = bios;

            
        }
        public Student(BioData bios)
        {
           
            Bio = bios;


        }

        public Student(Name name)
        {
            // TODO: Complete member initialization
            this.name = name;
        }

        public Student(AcademicDetails academicDetails)
        {
            // TODO: Complete member initialization
            this.academicDetails = academicDetails;
        }

        public Student(Address address)
        {
            // TODO: Complete member initialization
            this.address = address;
        }
    }

    public class Name
    {
        //Properties
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Othername { get; set; }
        public  string Fullname { get; set; }
        public string Initials { get; set; }

        //Constructor
        public  Name(string sname, string fname, string oname ="")
        {
            Surname = sname.ToUpper();
            Firstname = fname.ToUpper();
            Othername = oname.ToUpper();
            Fullname = Surname + " " + Firstname + " " + Othername;
            if (string.IsNullOrEmpty(oname))
            {
                Initials = Surname.Substring(0,1) + "." + Firstname.Substring(0,1) ;

            }
            else
            {
                Initials = Surname.Substring(0, 1) + "." + Firstname.Substring(0, 1) + "." + Othername.Substring(0,1);

            }
            
        }
    }

    public class Department
    {
        //properties
        public static string Name { get; set; }
        public string Faculty { get; set; }

        //Constructor
        public Department(string name)
        {
            Name = name;
        }
    }
    public class AcademicDetails
    {
        public string JambNumber { get; set; }
        public string StudentType { get; set; }
        
        public int BioId { get; set; }
        public string MatricNo { get; set; }
        public string StudentDepartment { get; set; }
        
        public string DeptOption { get; set; }


        public AcademicDetails(string Jnumber, string Stype,  String Matnum,  string Deptoption="" )
        {   
            JambNumber = Jnumber;
            StudentType = Stype;
            MatricNo = Matnum;
            DeptOption = Deptoption;
            StudentDepartment = Department.Name;


        }
    }
    public  class BioData
    {
        

        public Name SName { get; set; }
        public string DOB { get; set;}
        public string Nationality {get; set;}
        public string Sname { get; set; }
        

        public BioData( string dob, string nationality){

            
            DOB = DOB;
            Nationality = nationality;
            //Sname = SName.Fullname;

           
            

    }

        


    }
    public class Address
    {
        public string Phone { get; set; }
        public string Email { get; set; }
        public string no {get; set;}
        public string streetName {get; set;}

        public string CityTown {get; set;}
        public string PostCode {get; set;}
        public Address(string phoneNo, string email, string houseNo, string StreetName,string postcode, string CityOrTown)
        {
            Phone = phoneNo;
            Email = email;
            no = houseNo;
            streetName = StreetName;
            CityTown = CityOrTown;
            PostCode = postcode;
        }
    }
}
