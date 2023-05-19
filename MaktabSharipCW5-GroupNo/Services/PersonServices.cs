using MaktabSharipCW5_GroupNo.Entities;
using MaktabSharipCW5_GroupNo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MaktabSharipCW5_GroupNo.Services
{
    class PersonServices
    {
        public List<Person> getFemalByAge(int age)
        {
            return PoepleList.people.FindAll(x => x.Age >= age);
        }
        public List<Person> getRipoSortedByAge()
        {
            return PoepleList.people.OrderBy(Person => Person.Age).ToList();
        }
        public List<string> getRipoByCity(string city)
        {
            return PoepleList.people.FindAll(Person => Person.City == city).Select(Person => Person.Name + Person.LastName).ToList();

        }
        public List<Person> getByNameStartChar(string firstchar)
        {
            return PoepleList.people.FindAll(x => x.Name.StartsWith(firstchar));

        }
        public List<string> getInvalidEmail()
        {

            return PoepleList.people.FindAll(x => checkEmail(x.EmailAddress)).Select(x => x.EmailAddress).ToList();
        }
        private bool checkEmail(string email)
        {
            return !Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        }
    }
}
