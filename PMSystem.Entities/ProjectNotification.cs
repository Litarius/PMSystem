namespace PMSystem.Entities
{
    public class ProjectNotification
    {
        public ProjectNotification()
        {
            NotificationUsername = string.Empty;
            ProjectName = string.Empty;
            NotificationEmail = string.Empty;
        }

        public string NotificationDisplayName { get; set; }

        public int Id { get; set; }

        public int ProjectId { get; set; }

        public string NotificationUsername { get; set; }

        public string ProjectName { get; set; }

        public string NotificationEmail { get; set; }

    }
}
