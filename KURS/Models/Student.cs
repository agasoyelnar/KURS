using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace KURS.Models
{
    internal class Student
    {
        string username;
        string firstname;
        string lastname;
        int groupNumber;
        int birthdate;
        string adress;
        string phoneNumber; 
        string email;
        string password;
        int score;

        public Student(string username, string firstname, string lastname, int groupNumber,
                       int birthdate, string adress, string phoneNumber, string email,
                       string password, int score)
        {
            this.username = username;
            this.firstname = firstname;
            this.lastname = lastname;
            this.groupNumber = groupNumber;
            this.birthdate = birthdate;
            this.adress = adress;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.password = password;
            this.score = score;
        }

        public Student(string firstname, string lastname, string email, string password,
                     string username, string phoneNumber)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.password = password;
            this.username = username;
            this.phoneNumber = phoneNumber;
        }

        public Student(string firstname, string lastname, string email, string password,
                   string username, int birthdate, int groupNumber)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.password = password;
            this.username = username;
            this.birthdate = birthdate;
            this.groupNumber = groupNumber;
        }
        public string GetName()
        {
            return $"{firstname} {lastname}";
        }
        public string GetGroup()
        {
            return groupNumber.ToString(); 
        }
        public string GetStudent()
        {
            return $"{firstname}{lastname}{email}{username}";
        }

        public string GetEmail()
        {
            return email;
        }
        public string GetBirthDay()
        {
            return birthdate.ToString();
        }
        public string GetContact()
        {
            return $"{phoneNumber} {email}";
        }
    }
}

