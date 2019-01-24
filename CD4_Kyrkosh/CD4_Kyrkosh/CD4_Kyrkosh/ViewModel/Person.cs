using System;

namespace CD4_Kyrkosh.ViewModel
{
    public class Person
    {
        private String firstName;
        private String lastName;
        
        private DateTime birthDate;
        private int ssn;


        public Person(string lastname, string firstname, DateTime birthdate, int SSN)
        {
            this.LastName = lastname;
            this.FirstName = firstname;
            this.BirthDate = birthdate;
            this.SSN = SSN;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public int SSN { get => ssn; set => ssn = value; }
    }
}