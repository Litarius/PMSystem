using System;

namespace PMSystem.Entities
{
    public class NotificationUser
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DisplayName { get; set; }

        public string Password { get; set; }

        public DateTime CreationDate { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public bool IsApproved { get; set; }
    }
}
