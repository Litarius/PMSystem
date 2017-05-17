namespace PMSystem.Entities
{
    public class Resolution
    {
        public Resolution()
        {
            Name = string.Empty;
            ImageUrl = string.Empty;
        }

       public int Id { get; set; }

        public string Name { get; set; }

        public int SortOrder { get; set; }

        public int ProjectId { get; set; }

        public string ImageUrl { get; set; }
    }
}
