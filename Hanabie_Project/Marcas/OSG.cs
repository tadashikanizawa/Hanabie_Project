using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hanabie_Project.Marcas
{
    internal class OSG: Tools
    {
        public string Page { get; set; }
        public static List<OSG> LoadProductsFromXml(string xmlFilePath)
        {
            XDocument xmlDoc = XDocument.Load(xmlFilePath);
            var products = xmlDoc.Descendants("Table")
                                 .Elements("TR")
                                 .Where(tr => tr.Elements("TH").Any() && tr.Elements("TD").Any(td => ContainsNumber(td.Value))) // Seleciona as linhas que contêm elementos <TH> e contêm algum número em <TD>
                                 .Select(tr =>
                                 {
                                     var keiAndKubushita = tr.Elements("TD").ElementAtOrDefault(0)?.Value.Split(new[] { '×' }, StringSplitOptions.RemoveEmptyEntries);

                                     var keiMatches = Regex.Match(keiAndKubushita?.ElementAtOrDefault(0)?.Trim() ?? "", @"(?<number>[-+]?\d*\.?\d+)(?<letters>[a-zA-Z]*)");
                                     float.TryParse(keiMatches.Groups["number"].Value, out float kei);
                                     string keiLetters = keiMatches.Groups["letters"].Value;

                                     var kubushitaMatches = Regex.Match(keiAndKubushita?.ElementAtOrDefault(1)?.Trim() ?? "", @"(?<number>[-+]?\d*\.?\d+)(?<letters>[a-zA-Z]*)");
                                     float.TryParse(kubushitaMatches.Groups["number"].Value, out float kubushita);
                                     string kubushitaLetters = kubushitaMatches.Groups["letters"].Value;

                                     float.TryParse(tr.Elements("TD").ElementAtOrDefault(1)?.Value, out float hachou);
                                     int.TryParse(tr.Elements("TD").ElementAtOrDefault(2)?.Value, out int zenchou);
                                     int.TryParse(tr.Elements("TD").ElementAtOrDefault(3)?.Value, out int shanko);

                                     return new OSG
                                     {
                                         ID = tr.Elements("TH").FirstOrDefault()?.Value,
                                         Kei = kei,
                                         //KeiLetters = keiLetters,
                                         Kubushita = kubushita,
                                         //KubushitaLetters = kubushitaLetters,
                                         Hachou = hachou,
                                         Zenchou = zenchou,
                                         Shanko = shanko,
                                         Page = tr.Elements("TD").ElementAtOrDefault(4)?.Value,
                                         Mark = Marks.OSG.ToString(),
                                     Type = Types.エンドミル.ToString(),
                                     };
                                 })
                                 .ToList();

            return products;
        }


        //public static List<OSG> LoadProductsFromXml(string xmlFilePath)
        //{
        //    XDocument xmlDoc = XDocument.Load(xmlFilePath);
        //    var products = xmlDoc.Descendants("Table")
        //                         .Elements("TR")
        //                         .Where(tr => tr.Elements("TH").Any() && tr.Elements("TD").Any(td => ContainsNumber(td.Value))) // Seleciona as linhas que contêm elementos <TH> e contêm algum número em <TD>
        //                         .Select(tr =>
        //                         {
        //                             var keiAndKubushita = tr.Elements("TD").ElementAtOrDefault(0)?.Value.Split(new[] { '×' }, StringSplitOptions.RemoveEmptyEntries);
        //                             float.TryParse(keiAndKubushita?.ElementAtOrDefault(0)?.Trim(), out float kei);
        //                             float.TryParse(keiAndKubushita?.ElementAtOrDefault(1)?.Trim(), out float kubushita);
        //                             float.TryParse(tr.Elements("TD").ElementAtOrDefault(1)?.Value, out float hachou);
        //                             int.TryParse(tr.Elements("TD").ElementAtOrDefault(2)?.Value, out int zenchou);
        //                             int.TryParse(tr.Elements("TD").ElementAtOrDefault(3)?.Value, out int shanko);

        //                             return new OSG
        //                             {
        //                                 ID = tr.Elements("TH").FirstOrDefault()?.Value,
        //                                 Kei = kei,
        //                                 Kubushita = kubushita,
        //                                 Hachou = hachou,
        //                                 Zenchou = zenchou,
        //                                 Shanko = shanko,
        //                                 Page = tr.Elements("TD").ElementAtOrDefault(4)?.Value,
        //                                 Mark = Marks.OSG.ToString(),
        //                                 Type = Types.エンドミル.ToString(),
        //                             };
        //                         })
        //                         .ToList();

        //    return products;
        //}


        private static bool ContainsNumber(string input)
        {
            return Regex.IsMatch(input, @"\d");
        }

        public static List<Tools> CarregarVMFE()
        {
            var bindingList = new List<Tools>();
            string arquivoCSV = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "OSG - AE-VMFE.csv");

            using (var reader = new StreamReader(arquivoCSV))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (values.Length < 2) continue;

                    var item = new OSG();
                    item.ID = values[0];
                    item.Kataban = values[1];
                    var parts = values[2].Split('×');

                    if (parts.Length > 0) item.Kei = float.Parse(parts[0].Replace("φ", ""), CultureInfo.InvariantCulture);
                    if (parts.Length > 1) item.Kado = float.Parse(parts[1].Replace("R",""), CultureInfo.InvariantCulture);
                    if (parts.Length > 2) item.Kubushita = float.Parse(parts[2], CultureInfo.InvariantCulture);
                    item.Zenchou = float.Parse(values[3], CultureInfo.InvariantCulture);
                    item.Hachou = float.Parse(values[4], CultureInfo.InvariantCulture);
                    item.Shanko = int.Parse(values[5], CultureInfo.InvariantCulture);
                    item.Laminas = int.Parse(values[6],CultureInfo.InvariantCulture);
                    item.Mark = Marks.OSG.ToString();
                    item.Type = Types.ラジアスエンドミル.ToString();

                    bindingList.Add(item);
                }
            }

            return bindingList;
        }
        public static List<Tools> CarregarVML()
        {
            var bindingList = new List<Tools>();
            string arquivoCSV = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "OSG - AE-VML.csv");

            using (var reader = new StreamReader(arquivoCSV))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (values.Length < 2) continue;

                    var item = new OSG();
                    item.ID = values[0];
                    item.Kataban = values[1];
                    var parts = values[2].Split('×');

                    if (parts.Length > 0) item.Kei = float.Parse(parts[0].Replace("φ", ""), CultureInfo.InvariantCulture);
                    if (parts.Length > 1) item.Hachou = float.Parse(parts[1].Replace("- N", ""), CultureInfo.InvariantCulture);
                    if (parts.Length > 2) if (parts[2].Contains("R")){ item.Kado = float.Parse(parts[2].Replace("R", ""), CultureInfo.InvariantCulture); }
                    else { item.Kado = 0; }
                    item.Zenchou = float.Parse(values[3], CultureInfo.InvariantCulture);
                    item.Shanko = int.Parse(values[4], CultureInfo.InvariantCulture);
                    item.Laminas = int.Parse(values[5], CultureInfo.InvariantCulture);
                    item.Mark = Marks.OSG.ToString();
                    if(item.Kado != 0)
                    { 
                    item.Type = Types.ラジアスエンドミル.ToString();
                    }
                    else { item.Type = Types.エンドミル.ToString(); }
                    bindingList.Add(item);
                }
            }

            return bindingList;
        }
        public static List<Tools> CarregarVMS()
        {
            var bindingList = new List<Tools>();
            string arquivoCSV = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "OSG - AE-VMS.csv");

            using (var reader = new StreamReader(arquivoCSV))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (values.Length < 2) continue;

                    var item = new OSG();
                    item.ID = values[0];
                    item.Kataban = values[1];
                    var parts = values[2].Replace("- RA", "").Split('×');

                    if (parts.Length > 0) item.Kei = float.Parse(parts[0].Replace("φ", ""), CultureInfo.InvariantCulture);
                    if (parts.Length > 1) if (parts[1].Contains("R")) { item.Kado = float.Parse(parts[1].Replace("R", ""), CultureInfo.InvariantCulture); }
                        else { item.Kubushita = float.Parse(parts[1].Replace("φ", ""), CultureInfo.InvariantCulture); }
               
                    item.Zenchou = float.Parse(values[3], CultureInfo.InvariantCulture);
                    item.Hachou = float.Parse(values[4], CultureInfo.InvariantCulture);
                    float shanko;
                    if (float.TryParse(values[5], out shanko))
                    {
                        shanko = (float)Math.Ceiling(shanko);
                        item.Shanko = (int)shanko;
                    }
                
                    item.Laminas = 4;
                    item.Mark = Marks.OSG.ToString();
                    if (item.Kado != 0)
                    {
                        item.Type = Types.ラジアスエンドミル.ToString();
                    }
                    else { item.Type = Types.エンドミル.ToString(); }
                    bindingList.Add(item);
                }
            }

            return bindingList;
        }
    }
}
