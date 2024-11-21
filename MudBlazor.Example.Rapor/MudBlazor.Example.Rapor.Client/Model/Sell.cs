namespace MudBlazor.Example.Rapor.Client.Model
{
    public class Sell
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CustomerId { get; set; }
        public string ProductName { get; set; }
        public string Status { get; set; }
        public string OrderType { get; set; }

        public string Plate { get; set; }
        public string Location { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TotalPiece { get; set; }
        public decimal TotalAmount { get; set; }

    }
}
