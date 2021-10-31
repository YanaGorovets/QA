using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQA_03_1
{
    interface IDisplayable
    {
        void IDisplayable();
    }
    enum Reason
    {
        FamilyReasons,
        ProfessionalGrowthLack,
        LowSalary,
        BadTeamMicroclimate,
        LackManagementUnderstanding,
        Other
    }

    class Candidate : IDisplayable
    {
        static int count = 1;
        public int id;
        public string FirstName;
        public string LastName;
        public string JobTitle;
        public string JobDescription;
        public double JobSalary;
        public Reason DismissalReason;
        string FullName;

        public void IDisplayable()
        {
            Console.WriteLine($"Hello, I am {FullName}.");
            Console.WriteLine($"I want to be a {JobTitle} ({JobDescription}) with a salary from {JobSalary}");
            Console.WriteLine($"I quit my previous job a reason of {DismissalReason}");
        }
        public Candidate(string FirstName, string LastName, string JobTitle, string JobDescription, double JobSalary, string DismissalReason)
        {
            id = count;
            count++;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.JobTitle = JobTitle;
            this.JobDescription = JobDescription;
            this.JobSalary = JobSalary;
            FullName = $"{FirstName} {LastName}";
            Enum.TryParse(DismissalReason, true, out this.DismissalReason);
        }
        public static Candidate enterCandidate()
        {
            Console.WriteLine("Enter firstname: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter lastName: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter titleJob: ");
            string titleJob = Console.ReadLine();
            Console.WriteLine("Enter descriptionJob: ");
            string descriptionJob = Console.ReadLine();
            Console.WriteLine("Enter dismissalReason: ");
            string dismissalReason = Console.ReadLine();
            Console.WriteLine("Enter salary: ");
            double salary = Console.Read();
            return new Candidate(firstName, lastName, titleJob, descriptionJob, salary, dismissalReason);
        }
    }

    class Employee : Candidate
    {
        Company co;

        public Employee(string FirstName, string LastName, string JobTitle, string JobDescription, double JobSalary, string DismissalReason, Company company) : base(FirstName, LastName, JobTitle, JobDescription, JobSalary, DismissalReason)
        {
            co = company;
        }
        public Employee(Candidate candidate, Company company) : base(candidate.FirstName, candidate.LastName, candidate.JobTitle, candidate.JobDescription, candidate.JobSalary, candidate.DismissalReason.ToString())
        {
            co = company;
        }
    }
    class Company
    {
        public string Name;
        public string Country;
        public string City;
        public string Adress;

        public Company(string name, string country, string city, string adress)
        {
            Name = name;
            Country = country;
            City = city;
            Adress = adress;
        }

        public static Company enterCompany()
        {
            Console.WriteLine("Enter Name: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Country: ");
            string Country = Console.ReadLine();
            Console.WriteLine("Enter City: ");
            string City = Console.ReadLine();
            Console.WriteLine("Enter Adress: ");
            string Adress = Console.ReadLine();
            return new Company(Name, Country, City, Adress);
        }
    }

    class Program
    {
        const int maxCandidat = 10;
        const int maxEmployee = 10;

        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Random rnd = new Random();
            int count = rnd.Next() % maxCandidat + 1;
            Console.WriteLine(count);

            Candidate[] candidates = new Candidate[count];
            for (int i = 0; i < count; i++)
            {
                candidates[i] = Candidate.enterCandidate();
                candidates[i].IDisplayable();
            }

            count = rnd.Next() % maxCandidat + 1;
            Console.WriteLine(count);

            Employee[] employes = new Employee[count];
            for (int i = 0; i < count; i++)
            {
                employes[i] = new Employee(Candidate.enterCandidate(), Company.enterCompany());
                employes[i].IDisplayable();
            }

            Console.ReadLine();
        }
    }
}

