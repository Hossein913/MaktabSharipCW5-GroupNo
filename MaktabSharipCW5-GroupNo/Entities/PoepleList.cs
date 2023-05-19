using MaktabSharipCW5_GroupNo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabSharipCW5_GroupNo.Entities
{
    public static class PoepleList
    {
        public static List<Person> people = new List<Person>
        {
            new Person{Id =0,Name ="Ali",LastName ="Ahmadi",NationalCode ="5778825412",Mobile ="09194526774",Address ="Iran - Tehran",Age =20,Gender =Gender.male ,City ="Tehran",EmailAddress ="1@g.com" },
            new Person{Id =1,Name ="zahar",LastName ="Ahmadi",NationalCode ="5778825412",Mobile ="09194526774",Address ="Iran - Tehran",Age =40,Gender =Gender.female ,City ="shiraz",EmailAddress ="2g.com" },
            new Person{Id =1,Name ="Zhaleh",LastName ="Ahmadi",NationalCode ="5778825412",Mobile ="09194526774",Address ="Iran - Tehran",Age =35,Gender =Gender.female,City ="shiraz",EmailAddress ="3@g.com" },
            new Person{Id =2,Name ="Reza",LastName ="Ahmadi",NationalCode ="5778825412",Mobile ="09194526774",Address ="Iran - Tehran",Age =25,Gender =Gender.male ,City ="Tehran",EmailAddress ="4@g.com" },
            new Person{Id =3,Name ="Fateme",LastName ="Ahmadi",NationalCode ="5778825412",Mobile ="09194526774",Address ="Iran - Tehran",Age =20,Gender =Gender.female ,City ="shiraz",EmailAddress ="Tehran1gcom" }
        };
    }
}
