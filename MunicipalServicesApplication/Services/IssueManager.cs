using System;
using System.Collections.Generic;
using System.Linq;
using MunicipalServicesApplication.Models;

namespace MunicipalServicesApplication.Services
{
    /// <summary>
    /// Manages the collection of reported issues
    /// </summary>
    public class IssueManager
    {
        private static IssueManager _instance;
        private List<Issue> _issues;
        private int _nextId;

        private IssueManager()
        {
            _issues = new List<Issue>();
            _nextId = 1;
        }

        public static IssueManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new IssueManager();
                return _instance;
            }
        }

        public void AddIssue(Issue issue)
        {
            issue.Id = _nextId++;
            _issues.Add(issue);
        }

        public List<Issue> GetAllIssues()
        {
            return _issues.ToList();
        }

        public Issue GetIssueById(int id)
        {
            return _issues.FirstOrDefault(i => i.Id == id);
        }

        public int GetTotalIssuesCount()
        {
            return _issues.Count;
        }

        public List<string> GetAvailableCategories()
        {
            return new List<string>
            {
                "Sanitation",
                "Roads",
                "Utilities",
                "Water Supply",
                "Electricity",
                "Street Lighting",
                "Parks and Recreation",
                "Public Safety",
                "Waste Management",
                "Other"
            };
        }
    }
}
