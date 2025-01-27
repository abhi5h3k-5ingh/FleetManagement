namespace fleetmanagement.entities
{
    public class Driver
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? License { get; set; }

        public Driver(string name, string license)
        {
            Name = name;
            License = license;
        }
    }
}
