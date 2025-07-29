// See https://aka.ms/new-console-template for more information

using _7B.Services;
using System.Globalization;

var host = "127.0.0.1";
var user = "demo";
var password = "demo";
var filename = $"report_{DateTime.Now:yyyyMMdd}.json";
string jsonPath = $"C:/Users/Michael/source/repos/7B/jsonfiles/{filename}";

var dataManagement = new DataManagementService();
var report = dataManagement.RequestReportData();

var reportService = new ReportService();
reportService.SaveReport(report);

reportService.ExportToJson(jsonPath);

var ftpService = new FTPService(host, user, password);

Console.WriteLine("Escribe el nombre del archivo que enviarás");
filename = Console.ReadLine();

ftpService.upload($"report_{DateTime.Now:yyyyMMdd_HHmm}.json", jsonPath);


