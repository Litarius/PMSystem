using System;

namespace PMSystem.Entities
{
	public class ProjectMailbox
	{
        public ProjectMailbox()
        {
            Mailbox = string.Empty;
            AssignToUserName = string.Empty;
            AssignToDisplayName = string.Empty;
            IssueTypeName = string.Empty;
        }

	    public int Id { get; set; }

	    public string Mailbox { get; set; }

	    public int ProjectId { get; set; }

	    public Guid AssignToId { get; set; }

	    public int IssueTypeId { get; set; }

        public int CategoryId { get; set; }
        
	    public string AssignToDisplayName { get; set; }

	    public string AssignToUserName { get; set; }

	    public string IssueTypeName { get; set; }

        public string CategoryName { get; set; }

	}
}
