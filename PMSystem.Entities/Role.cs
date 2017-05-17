namespace PMSystem.Entities
{
    public class Role
    {
        public Role()
        {
            Name = string.Empty;
            Description = string.Empty;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int ProjectId { get; set; }

        public string Description { get; set; }

        public bool AutoAssign { get; set; }
    }
}
