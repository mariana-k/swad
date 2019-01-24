using System;
using GalaSoft.MvvmLight;

namespace CD4_Kyrkosh.ViewModel
{
    public class Person2 : ViewModelBase
    {
        private Person person;

        public string FirstName { get => person.FirstName; set { person.FirstName = value; RaisePropertyChanged(); } }
        public string LastName { get => person.LastName; set { person.LastName = value; RaisePropertyChanged(); } }
        public DateTime BirthDate { get => person.BirthDate; set { person.BirthDate = value; RaisePropertyChanged(); } }
        public int SSN { get => person.SSN; set { person.SSN = value; RaisePropertyChanged(); } }

        public Person2(string firstName, string lastName, DateTime birthDate, int ssn)
        {
            this.person = new Person(firstName, lastName,  birthDate, ssn);
        }


        public Person ConvertBack()
        {
            return person;
        }

    }
}