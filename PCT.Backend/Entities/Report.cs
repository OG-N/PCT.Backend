namespace PCT.Backend.Entities
{
    public class Report
    {
        public double AllRecords { get; set; }
        public double Approved { get; set; }
        public double Pending { get; set; }
        public double Rejected { get; set; }
        public double Products { get; set; }
        public double Locations { get; set; }
        public double Stakeholders { get; set; }
        public double Transport { get; set; }
        public double Carriers { get; set; }
        public double UnitsOfMeasure { get; set; }
        public double Categories { get; set; }
        public dynamic? ProductsChart { get; set; }
    }
}
