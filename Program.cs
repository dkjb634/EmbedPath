// See https://aka.ms/new-console-template for more information
using System.Reflection;

var allRecources = Assembly.GetExecutingAssembly().GetManifestResourceNames();
foreach (var s in allRecources)
{
    Console.WriteLine(s);
}