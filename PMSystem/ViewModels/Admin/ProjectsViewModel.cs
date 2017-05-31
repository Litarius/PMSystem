using System.Collections.Generic;
using PMSystem.Entities;

namespace PMSystem.ViewModels.Admin
{
    public class ProjectsViewModel
    {
        public ProjectsViewModel()
        {
            Projects = new List<Project>();
        }

        public List<Project> Projects { get; set; }
    }
}