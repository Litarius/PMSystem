namespace PMSystem.Entities
{

    public class Priority
    {
        public Priority()
        {
            Name = string.Empty;
            ImageUrl = string.Empty;
        }

        public int Id { get; set; }

        public int ProjectId { get; set; }

        public int SortOrder { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }
    }
}
