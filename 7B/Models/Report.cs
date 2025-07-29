namespace _7B.Models
{
    public class Report
    {
        public int Id { get; set; }

        // Fecha de Informe
        public DateTime ReportDate { get; set; }

        // Informacion de entidad Autorizada
        public string ReportResponsible { get; set; }
        public string Position { get; set; }

        // Estado financiero
        public decimal TotalAssets { get; set; }
        public decimal TotalLiabilities { get; set; }
        public decimal RegulatoryCapital { get; set; }
        public double SolvencyRatio { get; set; }

    }
}
