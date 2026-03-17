using System;

namespace MyApp.Models
{
    public class Teacher
    {
        public string username;
        public string firstname;
        public string lastname;
        public string departmentName;
        public string subject;
        public DateTime birthdate;
        public string address;
        public string phoneNumber;
        public string email;
        public string password;

        
        public Teacher(string username, string firstname, string lastname,
                       string departmentName, string subject, DateTime birthdate,
                       string address, string phoneNumber, string email, string password)
        {
            this.username = username;
            this.firstname = firstname;
            this.lastname = lastname;
            this.departmentName = departmentName;
            this.subject = subject;
            this.birthdate = birthdate;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.password = password;
        }

        
        public Teacher(string firstname, string lastname, string email,
                       string password, string username, string phoneNumber)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.password = password;
            this.username = username;
            this.phoneNumber = phoneNumber;
        }

        
        public Teacher(string firstname, string lastname, string email,
                       string password, string username, DateTime birthdate, string subject)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.password = password;
            this.username = username;
            this.birthdate = birthdate;
            this.subject = subject;
        }

        

        public string GetName()
        {
            return firstname + " " + lastname;
        }

        public string GetSubject()
        {
            return subject;
        }

        public string GetTeacher()
        {
            return $"Name: {firstname} {lastname}, Email: {email}, Username: {username}";
        }

        public string GetEmail()
        {
            return email;
        }

        public DateTime GetBirthdate()
        {
            return birthdate;
        }

        public string GetContact()
        {
            return $"Phone: {phoneNumber}, Email: {email}";
        }
    }
}