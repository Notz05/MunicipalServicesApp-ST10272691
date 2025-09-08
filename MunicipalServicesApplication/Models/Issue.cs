using System;
using System.Collections.Generic;

namespace MunicipalServicesApplication.Models
{
    /// <summary>
    /// Represents a reported issue in the municipal services system
    /// </summary>
    public class Issue
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public List<string> AttachedFiles { get; set; }
        public DateTime DateReported { get; set; }
        public string Status { get; set; }

        public Issue()
        {
            AttachedFiles = new List<string>();
            DateReported = DateTime.Now;
            Status = "Submitted";
        }

        public Issue(string location, string category, string description) : this()
        {
            Location = location;
            Category = category;
            Description = description;
        }

        public override string ToString()
        {
            return $"Issue #{Id}: {Category} at {Location} - {Status}";
        }
    }
}
