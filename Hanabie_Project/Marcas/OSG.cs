using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hanabie_Project.Marcas
{
    internal class OSG: Tools
    {
        public int Shanko { get; set; } 



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
                    item.Kataban = int.Parse(values[1], CultureInfo.InvariantCulture);
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
                    item.Kataban = int.Parse(values[1], CultureInfo.InvariantCulture);
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
                    item.Kataban = int.Parse(values[1], CultureInfo.InvariantCulture);
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
