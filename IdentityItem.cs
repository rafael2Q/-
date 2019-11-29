namespace SqlServerTestApp
{
    public class IdentityItem
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public IdentityItem(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}