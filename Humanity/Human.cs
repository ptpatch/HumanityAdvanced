using System;
using System.Text;

namespace Humanity
{
    class Human
    {
         
        private const int FirstNameMinLength = 4;
        private const int LastNameMinLength = 3;

        private string firstName;
        private string lastName;

        public Gender? HumanGender { get; set; }
        
        private string FirstName
        {
            set
            {
                //if (char.IsLower(value[0]))
                //{
                //    throw new ArgumentException($"Expected upper case letter! Argument: {nameof(this.firstName)}");
                //}

                if (value.Length < FirstNameMinLength)
                {
                    throw new ArgumentException($"Expected length at least {FirstNameMinLength} symbols! Argument: {nameof(this.firstName)}");
                }
                firstName = char.ToUpper(value[0]) + value.Substring(1);
                //this.firstName = value;
            }
        } // If firstSimbol is not a letter ???

        private string LastName // If firstSimbol is not a letter ???
        {
            set
            {
                //if (char.IsLower(value[0]))
                //{
                //    throw new ArgumentException($"Expected upper case letter! Argument: {nameof(lastName)}");
                //}

                if (value.Length < LastNameMinLength)
                {
                    throw new ArgumentException($"Expected length at least {LastNameMinLength} symbols! Argument: {nameof(lastName)}"); // Space in the Constraint's example ???
                }
                lastName = char.ToUpper(value[0]) + value.Substring(1);
                //this.lastName = value;
            }
        }

        public Human(string firstName, string lastName, Gender humanGender)
        {
            FirstName = firstName;
            LastName = lastName;
            HumanGender = humanGender;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"First Name: {this.firstName}")
                .AppendLine($"Last Name: {this.lastName}")
                .AppendLine($"Gender: {this.HumanGender}");

            return sb.ToString();
        }
    }
}

