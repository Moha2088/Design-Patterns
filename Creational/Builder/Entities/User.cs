using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Entities;
public class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Degree { get; set; } = null!;

    public char Gender { get; set; }



    public User(int Id, string Name, string Email, string Degree, char Gender)
    {
        this.Id = Id;
        this.Name = Name;
        this.Email = Email;
        this.Degree = Degree;
        this.Gender = Gender;
    }

    public class UserBuilder
    {
        private int Id;

        private string Name;

        private string Email;

        private string Degree;

        private char Gender;



        public UserBuilder setId(int Id)
        {
            this.Id = Id;
            return this;
        }

        public UserBuilder setName(string Name)
        {
            this.Name = Name;
            return this;
        }

        public UserBuilder setEmail(string Email)
        {
            this.Email = Email;
            return this;
        }

        public UserBuilder setDegree(string Degree)
        {
            this.Degree = Degree;
            return this;
        }

        public UserBuilder setGender(char Gender)
        {
            this.Gender = Gender;
            return this;
        }

        public User Build()
        {
            return new User(Id, Name, Email, Degree, Gender);
        }
    }
}
