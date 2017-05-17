namespace PMSystem.Entities
{
    public class UserCustomFieldSelection
    {
        public UserCustomFieldSelection()
        {
            Name = string.Empty;
            Value = string.Empty;
        }

        public int Id { get; set; }

        public int CustomFieldId { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }
        
        public int SortOrder { get; set; }

    }
}