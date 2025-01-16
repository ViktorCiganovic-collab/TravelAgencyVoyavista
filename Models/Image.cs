namespace TravelAgencyVoyavista.Models
{
    public class Image
    {

        public int imageId { get; set; }

        public string ImgURL { get; set; }

        public Travelpackage Travelpackage { get; set; } //reference to the Room table 

        public int TravelpackageId { get; set; }
    }
}
