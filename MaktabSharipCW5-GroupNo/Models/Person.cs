using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabSharipCW5_GroupNo.Models
{
    public class Person
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string City { get; set; }
        public string EmailAddress { get; set; }

        public string ToWrite()
        { return Name + " " + LastName + " " + NationalCode + " " + Mobile + " " + Address + " " + Age.ToString()+ " " + Gender.ToString() + " " + City + " " + EmailAddress; }

    }
}
