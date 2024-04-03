using System;

namespace SomerenModel
{
    public class Student
    {
        public int Id { get; set; }     // database id
        public string Lastname { get; set; }

        public string Firstname { get; set; }
        public int Number { get; set; } // StudentNumber, e.g. 474791
        public DateTime BirthDate { get; set; }


        public Student(int Id, string Lastname, string Firstname)
        {
            this.Id = Id;
            this.Lastname = Lastname;
            this.Firstname = Firstname;
            //this.BirthDate = Birthdate;
        }
    }
}