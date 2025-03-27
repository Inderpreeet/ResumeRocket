using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeRocket.Models
{

    
    internal class UserProfile
    {
    }

    using System;

/// <summary>
/// Represents a user's profile information including personal details.
/// This class is essential for generating resumes with personal contact details.
/// </summary>
public class UserProfile
    {
        public string FirstName { get; set; } // User's first name
        public string LastName { get; set; }  // User's last name
        public string Email { get; set; }     // User's email address
        public string Phone { get; set; }     // User's phone number
        public string Address { get; set; }   // User's residential address
        public string Summary { get; set; }   // Brief professional summary

        public UserProfile() { }
    }

}
