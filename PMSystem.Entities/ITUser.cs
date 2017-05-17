using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PMSystem.Entities
{
    [XmlRoot("User")]
    public class ITUser
    {
        private string _displayName;
        private string _firstName;
        private string _lastName;

        public Guid Id { get; set; }

        public bool IsApproved { get; set; }

        public DateTime LastLoginDate { get; set; }

        public DateTime CreationDate { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string DisplayName
        {
            get { return (_displayName == string.Empty) ? UserName : _displayName; }
            set { _displayName = value; }
        }

        public ITUser() { }

        public ITUser(Guid userId, string userName, string firstName, string lastName, string displayName, DateTime creationDate, DateTime lastLoginDate, bool isApproved)
        {
            Id = userId;
            UserName = userName;
            _displayName = displayName;
            CreationDate = creationDate;
            _firstName = firstName;
            _lastName = lastName;
            IsApproved = isApproved;
            LastLoginDate = lastLoginDate;
        }

        public ITUser(Guid userId, string userName, string displayName)
            : this(userId, userName, string.Empty, string.Empty, displayName, DateTime.MinValue, DateTime.MinValue, true)
        { }

        public ITUser(Guid userId, string userName, string displayName, string email)
            : this(userId, userName, string.Empty, string.Empty, displayName, DateTime.MinValue, DateTime.MinValue, true)
        {
            Email = email;
        }
    }
}
