using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.models
{
    /// <summary>
    /// Represents one person - class
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Unique ID of person model
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The first name of the person
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The last name of the person
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The email address of the person
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// The cellphone address of the person
        /// </summary>
        public string CellphoneNumber { get; set; }

        public PersonModel() { }

        public PersonModel(string firstName, string lastName, string emailAddress, string cellphoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            CellphoneNumber = cellphoneNumber;
        }
    }
}
