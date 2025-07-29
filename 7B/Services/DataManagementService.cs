using _7B.Models;
using System.Globalization;

namespace _7B.Services
{
    public class DataManagementService 
    {
        
        public Report RequestReportData()
        {
            var report = new Report
            {
                ReportDate = DateTime.Now,
                ReportResponsible = ReadString("Responsable del Informe"),
                Position = ReadString("Posicion del Responsable"),
                TotalAssets = ReadDecimal("Activos Totales"),
                TotalLiabilities = ReadDecimal("Pasivos Totales"),
                RegulatoryCapital = ReadDecimal("Capital Regulatorio"),
                SolvencyRatio = ReadDouble("Ratio de solvencia (%)")
            };
            return report;


        }

        static string ReadString(string message)
        {
            Console.Write($"{message}: ");
            return Console.ReadLine();
        }

        static decimal ReadDecimal(string message)
        {
            decimal value;
            Console.Write($"{message}: ");
            while (!decimal.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out value))
            {
                Console.Write($"Invalid value. {message}: ");
            }
            return value;
        }

        static double ReadDouble(string message)
        {
            double value;
            Console.Write($"{message}: ");
            while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out value))
            {
                Console.Write($"Invalid value. {message}: ");
            }
            return value;
        }


        static int ReadInt(string message)
        {
            int value;
            Console.Write($"{message}: ");
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write($"Invalid value. {message}: ");
            }
            return value;
        }

    }
}
