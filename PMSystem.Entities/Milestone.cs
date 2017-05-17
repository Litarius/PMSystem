using System;

namespace PMSystem.Entities
{
    public class Milestone
    {
        public Milestone()
        {
            Name = string.Empty;
            ImageUrl = string.Empty;
            Notes = string.Empty;
        }

        public int Id { get; set; }

        public int ProjectId { get; set; }

        public string Name { get; set; }

        public int SortOrder { get; set; }

        public string ImageUrl { get; set; }

        public string Notes { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public bool IsCompleted { get; set; }
    }
}
