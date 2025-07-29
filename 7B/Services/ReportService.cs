using _7B.Data;
using _7B.Models;
using _7B.DTOs;
using System.Text.Json;

namespace _7B.Services
{
    public class ReportService
    {
        public void SaveReport(Report report)
        {
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();          
                db.Reports.Add(report);
                db.SaveChanges();
                Console.WriteLine($"Informe guardado");
            }            
        }
        public void ExportToJson(string filePath)
        {
            using (var db = new AppDbContext())
            {
                var reportDto = db.Reports.OrderByDescending(r => r.ReportDate).Select(
                    r => new
                    {
                        r.ReportDate,
                        r.Position,
                        r.ReportResponsible,
                        r.TotalAssets,
                        r.TotalLiabilities,
                        r.RegulatoryCapital,
                        r.SolvencyRatio
                    }).FirstOrDefault();
                if (reportDto == null)
                {
                    Console.WriteLine("No hay reportes registrados");
                }
                string jsonString = JsonSerializer.Serialize(reportDto, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonString);

                Console.WriteLine($"Reporte exportado a {filePath}");

            }
        }

    }
}
