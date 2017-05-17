namespace PMSystem.Entities
{
    public class Status
    {
        public Status()
        {
            Name = string.Empty;
            ImageUrl = string.Empty;
        }

        public int Id { get; set; }

        public bool IsClosedState { get; set; }

        public int ProjectId { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }
 
        public int SortOrder { get; set; }

    }
}
