using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _7B.DTOs
{
    public class ReportDto
    {
       
        public DateTime ReportDate { get; set; }
        public string ReportResponsible { get; set; }
        public string Position { get; set; }
        public decimal TotalAssets { get; set; }
        public decimal TotalLiabilities { get; set; }
        public decimal RegulatoryCapital { get; set; }
        public double SolvencyRatio { get; set; }
    }
}
