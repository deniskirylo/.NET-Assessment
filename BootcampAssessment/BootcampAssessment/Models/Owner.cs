namespace BootcampAssessment.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String LastName { get; set; }
        public String DriverLicense { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
        public ICollection<OwnerCategory> OwnerCategories { get; set; }

    }
}
