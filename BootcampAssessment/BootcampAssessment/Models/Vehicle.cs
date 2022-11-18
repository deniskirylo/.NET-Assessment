namespace BootcampAssessment.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public String Brand { get; set; }
        public String Vin { get; set; }
        public String Colour { get; set; }
        public DateTime Year { get; set; }
        public ICollection<Claim> Claims { get; set; }
        public ICollection<OwnerCategory> OwnerCategories { get; set; }


    }
}
