using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PMSystem.Entities;

namespace PMSystem.ViewModels.Projects
{
    public class IssuesViewModel
    {
        public IssuesViewModel()
        {
            Issues = new List<Issue>();
            Issues.Add(new Issue() {ProjectName = "Новый проект", StatusName = "Открыта", Title = "Добавить новые данные в проект",AssignedDisplayName = "Петров Петр",CreatorUserName = "Иванов Иван"});
            Issues.Add(new Issue() {ProjectName = "Старый проект", StatusName = "Закрыта", Title = "Создать новый проект",AssignedDisplayName = "Сидоров Олег",CreatorUserName = "Иванов Иван"});

        }
        public List<Issue> Issues { get; set; }
    }
}