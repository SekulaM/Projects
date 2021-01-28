using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeSimulation2
{
    public class Student
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //these are the skills of a student which will determine whether he/she passes the exam of a given subject
        public int English { get; set; }
        public int Math { get; set; }
        public int Cramming { get; set; }

        //these are the subject, each semester has 3 subjects
        public string BusinessEnglish1 { get; set; }
        public string AboutUS { get; set; }
        public string PodnikovaEkonomika { get; set; }
        public string BusinessEnglish2 { get; set; }
        public string AboutUK { get; set; }
        public string Ucetnictvi { get; set; }
        public string BusinessEnglish3 { get; set; }
        public string USLiterature { get; set; }
        public string Finance { get; set; }
        public string BusinessEnglish4 { get; set; }
        public string UKLiterature { get; set; }
        public string Marketing { get; set; }
        public string AverageGrade { get; set; }
        public int TotalPoints { get; set; }
    }
}
