namespace InvestmentAnalyzer.Core.Model
{
    public class Property
    {
        public Guid PropertyId { get; set; }
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public double SizeM2 { get; set; }
        public int Rooms { get; set; }
        public int YearBuilt { get; set; }
        public string EnergyLabel { get; set; } = string.Empty;
        public string PropertyType { get; set; } = string.Empty;

        public Investment? Investment { get; set; }
        public ICollection<InvestmentAnalysis> InvestmentAnalyses { get; set; } = [];
    }
}