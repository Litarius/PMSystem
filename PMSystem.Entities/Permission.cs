namespace PMSystem.Entities
{
    public class Permission : BaseEntity
    {
        public Permission(int id, string name, string key)
        {
            Id = id;
            Name = name;
            Key = key;
        }

        public string Name { get; private set; }

        public string Key { get; private set; }

    }
}
