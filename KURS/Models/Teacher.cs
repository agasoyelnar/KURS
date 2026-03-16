using System;

namespace KURS
{


    class Teacher
    {

        
        private int id;
        private string name;
        private string surname;
        private string subject;
        private string experience;
        private string groupNumber;
        private DateTime birthDate;
        private string address;
        private string phoneNumber;
        private string email;
        private string username;







        
        public string Name { get { return name; } private set { name = value; } }
        public string Surname { get { return surname; } private set { surname = value; } }
        public string Subject { get { return subject; } private set { subject = value; } }
        public string Username { get { return username; } private set { username = value; } }
        public string GroupNumber { get { return groupNumber; } private set { groupNumber = value; } }
        public DateTime BirthDate { get { return birthDate; } private set { birthDate = value; } }
        public string Address { get { return address; } private set { address = value; } }
        public string PhoneNumber { get { return phoneNumber; } private set { phoneNumber = value; } }
        public string Email { get { return email; } private set { email = value; } }

        
        public Teacher(int id, string name, string surname, string subject, string experience,
            string groupNumber, DateTime birthDate, string address, string phoneNumber, string email, string username)
        {


            this.id = id;
            this.Name = name;
            this.Surname = surname;
            this.Subject = subject;
            this.username = username;
            this.GroupNumber = groupNumber;
            this.BirthDate = birthDate;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;






        }
    }
}



