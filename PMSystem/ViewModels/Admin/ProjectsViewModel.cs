using System;
using System.Collections.Generic;
using PMSystem.Entities;

namespace PMSystem.ViewModels.Admin
{
    public class ProjectsViewModel
    {
        public ProjectsViewModel()
        {
            Projects = new List<Project>();
            Projects.Add(new Project() { Name = "Новый проект", DateCreated = DateTime.Now, Description = "Новый проект", ManagerDisplayName = "Сидоров Олег" , CreatorUserName = "Иванов Иван"});
           // Projects.Add(new Project() { Name = "Старый проект", DateCreated = DateTime.Now, Description = "Старый проект", ManagerDisplayName = "Петров Петр", CreatorUserName = "Иванов Иван" });
 
        }

        public List<Project> Projects { get; set; }
    }
}