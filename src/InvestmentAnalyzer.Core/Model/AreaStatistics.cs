namespace InvestmentAnalyzer.Core.Model
{
    public class AreaStatistics
    {
        public Guid AreaStatisticsId { get; set; }
        public string ZipCode { get; set; } = string.Empty;
        public decimal AvgPricePerM2 { get; set; }
        public decimal AvgRentPerM2 { get; set; }
        public decimal PriceGrowth1Y { get; set; }
        public decimal PriceGrowth5Y { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}