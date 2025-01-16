namespace TravelAgencyVoyavista.Models
{
    public class Order
    {

        public int OrderId { get; set; } //primary key (is created automatically each time we add a row to this table)

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public int numberOfPersons { get; set; }

        public bool paymentStatus { get; set; } = false;

        public bool orderActive { get; set; } = false;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal TotalCost { get; set; }

        public Travelpackage Travelpackage { get; set; } //reference to the Room table 
        public int TravelpackageId { get; set; } // the foreign key which links an order to a specific room in the table Rooms
    }
}
