using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeRocket.Models
{
    internal class Experience
    {
    }

    using System;

/// <summary>
/// Represents a user's work experience, including job title, company, and duration.
/// This class is used to store multiple experiences in a resume.
/// </summary>
public class Experience
    {
        public string JobTitle { get; set; }   // Name of the position
        public string Company { get; set; }    // Name of the company
        public string Location { get; set; }   // Job location (city, country)
        public DateTime StartDate { get; set; } // Job start date
        public DateTime EndDate { get; set; }   // Job end date (null if current job)
        public string Responsibilities { get; set; } // Key responsibilities in the job

        public Experience() { }
    }

}
