using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PMSystem.ViewModels.Admin
{
    public class AccountViewModel
    {
        public AccountViewModel()
        {
            Users = new List<UserViewModel>();

            Users.Add(new UserViewModel() {DateCreated = DateTime.Now, Email = "ivanov@mycompany.com", IsAuthorized = true, User = "Иванов Иван", UserName = "ivanov"});
            Users.Add(new UserViewModel() {DateCreated = DateTime.Now, Email = "petrov@mycompany.com", IsAuthorized = true, User = "Петров Петр", UserName = "petrow"});
            Users.Add(new UserViewModel() {DateCreated = DateTime.Now, Email = "sidorov@mycompany.com", IsAuthorized = true, User = "Сидоров Олег", UserName = "sidorov"});
        }

        public List<UserViewModel> Users { get; set; }
    }

    public class UserViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Имя пользователя")]
        public String UserName { get; set; }

        public String User { get; set; }

        public string Email { get; set; }

        public DateTime DateCreated { get; set; }

        public bool IsAuthorized { get; set; }
    }
}