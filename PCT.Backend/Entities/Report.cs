namespace PCT.Backend.Entities
{
    public class Report
    {
        public double AllRecords { get; set; }
        public double Approved { get; set; }
        public double Pending { get; set; }
        public double Rejected { get; set; }
        public dynamic? ProductsChart { get; set; }
    }
}
