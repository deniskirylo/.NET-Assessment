namespace BootcampAssessment.Models
{
    public class OwnerCategory
    {
        public int OwnerId { get; set; }
        public int VehicleId { get; set; }
        public Owner Owner { get; set; }
        public Vehicle Vehicle { get; set; }   
        
    }
}
