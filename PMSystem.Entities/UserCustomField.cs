using System;

namespace PMSystem.Entities
{
    public class UserCustomField
    {
        public UserCustomField()
        {
            Name = String.Empty;
            Value = String.Empty;
        }

        public int Id { get; set; }

        public string Name { get; set; }

      //  public ValidationDataType DataType { get; set; }

      //  public CustomFieldType FieldType { get; set; }

        public bool Required { get; set; }

        public string Value { get; set; }
    }
}
