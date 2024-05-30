using DataParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParser.Model
{
    public class Person
    {
        public string Firstname { get; set; }
        public int Middlename { get; set; }
        public string Lastname { get; set; }
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - DateofBirth.Year;

                if (DateofBirth.Date > today.AddYears(-age)) age--;

                return age;
            }
        }
        public string Email { get; set; }
        public DateTime DateofBirth { get; set; }                
    }
}
