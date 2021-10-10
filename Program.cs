using System;
using System.Collections.Generic;

namespace Homework_10102564_ข้อ2
{
    enum Menu
    {
        Registerstudent = 1,
        Registerteacher,
        Showinfo,
    }
    
    class Program
    {
        static public listData Getlist;
        static void Main(string[] args)
        {
            PreparePersonListWhenProgramIsLoad();
            Menupage();
        }
        static public void PreparePersonListWhenProgramIsLoad()
        {
            Program.Getlist = new listData();
        }

        static void Menupage()
        {
            Console.Clear();      
            Console.WriteLine("Welcome to Student activity registration system.");
            Console.WriteLine("-------------------------------------------------------");
           
            Console.WriteLine("1. Register new student.");
            Console.WriteLine("2. Register new Teacher.");
            Console.WriteLine("3. ShowInformation.");

            Userselectmenu();
        }
        static void Userselectmenu()
        {
            Console.WriteLine("Select Menu :");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            Choosenmenu(menu);
        }
        static void Choosenmenu(Menu menu)  
        {
            if (menu == Menu.Registerstudent)
            {
                Student();
            }
            else if (menu == Menu.Registerteacher)
            {
                Teacher();
            }
            else if (menu == Menu.Showinfo)
            {
                ShowInfo();
            }
            else
            {
                ShowIncorrectmenu();
            }
        }
        static void Student()
        {
            Console.WriteLine("Register Student.");
            Console.WriteLine("----------------------");
            Console.WriteLine("");
            Inputdata();
        }
        static void Teacher()
        {
            Console.WriteLine("Register Teacher.");
            Console.WriteLine("----------------------");
            Console.WriteLine("");
            Inputdata();
        }
        static void Inputdata()
        {
            string Name;
            Console.Write("Name:");
            Name = Console.ReadLine();
            string Lastname;
            Console.Write("Lastname:");
            Lastname = Console.ReadLine();
            string Address;
            Console.Write("Address:");
            Address = Console.ReadLine();
            string Gender;
            Console.Write("Gender:");
            Gender = Console.ReadLine();
            string Citizenid;
            Console.Write("Citizenid:");
            Citizenid = Console.ReadLine();
            string Phonenumber;
            Console.Write("Phonenumber:");
            Phonenumber = Console.ReadLine();
            string Email;
            Console.Write("Email:");
            Email = Console.ReadLine();


            User data = new User(Name, Lastname, Address, Gender, Citizenid, Phonenumber, Email);
            Program.Getlist.Inputdata(data);
            Menupage();

        }
        static void ShowInfo()
        {
            Console.WriteLine("ShowInformation.");
            Console.WriteLine("----------------------");
            Console.WriteLine("");
            Program.Getlist.Showdata();
            
        }
        
        
        
        static void ShowIncorrectmenu()   
        {
            Console.Clear();
            Console.WriteLine("Invalid");
            Console.WriteLine("1 Register Student.");
            Console.WriteLine("2 Register Teacher. ");
            Console.WriteLine("3 ShowInformation. ");

            Userselectmenu();
        }
     
       
    }
    class User
    {
        public string Name;
        public string Lastname;
        public string Address;
        public string Gender;
        public string CitizenID;
        public string Phonenumber;
        public string Email;
        public User(string valuename, string valuelastname, string valueaddress, string valuegender, string valuecitizenid, string valuephonenumber, string valueemail)
        {
            Name = valuename;
            Lastname = valuelastname;
            Address = valueaddress;
            Gender = valuegender;
            CitizenID = valuecitizenid;
            Phonenumber = valuephonenumber;
            Email = valueemail;

        }
    }


    class listData
    {

        public List<User> Getlist;
        public listData()
        {
            Getlist = new List<User>();
        }
        public void Inputdata(User getData)
        {
            Getlist.Add(getData);
        }
        public void Showdata()
        {

            foreach (User show in Getlist)
            {

                Console.WriteLine("Name:" + show.Name);
                Console.WriteLine("Lastname:" + show.Lastname);
                Console.WriteLine("Address:" + show.Address);
                Console.WriteLine("Gender:" + show.Gender);
                Console.WriteLine("CitizenID:" + show.CitizenID);
                Console.WriteLine("Phonenumber:" + show.Phonenumber);
                Console.WriteLine("Email:" + show.Email);

            }
        }


    }
}
