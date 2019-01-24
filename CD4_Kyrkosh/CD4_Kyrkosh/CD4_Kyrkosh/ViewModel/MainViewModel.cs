using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;

namespace CD4_Kyrkosh.ViewModel
{
    
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<Person2> persons = new ObservableCollection<Person2>();
        private string firstName = "";
        private string lastName = "";
        private int ssn;
        private string birthDate;
        private RelayCommand addToListBtnCommand;
        private RelayCommand loadDataBtnClickedCommand;
        private RelayCommand saveDataBtnClickedCommand;
        private string pathToFile;
        private const string fileName = @"items.csv";

        public MainViewModel()
        {
            SaveDataBtnClickedCommand = new RelayCommand(SaveItems, () => { return persons.Count > 0; });
            LoadDataBtnClickedCommand = new RelayCommand(LoadItems, () => { return isFile(); });

            addToListBtnCommand = new RelayCommand(
                () =>
                {
                    persons.Add(new Person2(
                 lastName,
                 firstName,
                DateTime.Parse(birthDate,
                          System.Globalization.CultureInfo.InvariantCulture),
                ssn));
                }, () => { return (lastName.Length > 2); });
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int SSN { get => ssn; set => ssn = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
        public RelayCommand AddToListBtnCommand { get => addToListBtnCommand; set => addToListBtnCommand = value; }
        public RelayCommand LoadDataBtnClickedCommand { get => loadDataBtnClickedCommand; set => loadDataBtnClickedCommand = value; }
        public RelayCommand SaveDataBtnClickedCommand { get => saveDataBtnClickedCommand; set => saveDataBtnClickedCommand = value; }
        public ObservableCollection<Person2> Persons { get => persons; set => persons = value; }

        public List<Person> Load()
        {
            List<Person> temp = new List<Person>();

            String[] lines = File.ReadAllLines(pathToFile + fileName);
            foreach (var item in lines)
            {
                var content = item.Split(';');
                temp.Add(new Person(content[2], content[1], DateTime.Parse(content[0],
                                  CultureInfo.InvariantCulture), int.Parse(content[3])));
            }
            return temp;
        }

        public void Delete()
        {
            if (File.Exists(pathToFile + fileName))
            {
                File.Delete(pathToFile + fileName);
            }
        }

        private void LoadItems()
        {
            Persons.Clear();
            foreach (var item in Load())
            {
                Persons.Add(new Person2(item.LastName, item.FirstName, item.BirthDate, item.SSN));
            }
        }

        public void Save(Person person)
        {
            File.AppendAllText(pathToFile + fileName, String.Format("{0};{1};{2};{3}\r\n",
                person.BirthDate,
                person.FirstName,
                person.LastName,
                person.SSN));
        }
        
        private void SaveItems()
        {
            Delete();
            foreach (var item in Persons)
            {
                Save(item.ConvertBack());
            }
        }
        public bool isFile()
        {
            return File.Exists(pathToFile + fileName);
        }
    }
}