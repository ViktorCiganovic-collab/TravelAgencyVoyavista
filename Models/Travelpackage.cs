namespace TravelAgencyVoyavista.Models
{
    public class Travelpackage
    {
        public int TravelpackageId { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public int Price { get; set; }

        public int Availablerooms { get; set; }

        public string imgUrl { get; set; }
        

        // Navigation property to access all orders related to this travel package
        public ICollection<Order> Orders { get; set; }  // One Travelpackage can have many Orders

        // Navigation property to access all images related to this travel package
        public ICollection<Image> Images { get; set; }  // One Travelpackage can have many Images

    }
}
