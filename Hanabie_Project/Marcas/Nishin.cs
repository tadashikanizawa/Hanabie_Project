using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hanabie_Project.Marcas
{
    public class Nishin: Tools
    {

        public string Page { get; set; }





        public static List<Tools> CarregarEndmill()
        {
            var bindingList = new List<Tools>();
            string arquivoCSV = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Nishin - Endmill.csv");

            using (var reader = new StreamReader(arquivoCSV))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (values.Length < 2) continue;

                    var item = new Nishin();


                    // Processa primeira coluna
                    var match = Regex.Match(values[0], @"^([A-Za-z-]*?)(\d)\d*([A-Za-z-]*)$");
                    if (match.Success)
                    {
                       // item.ID = match.Groups[1].Value + match.Groups[2].Value + match.Groups[3].Value;
                        item.Laminas = int.Parse(match.Groups[2].Value);
                    }
                    
                        item.ID = values[0];
                    


                    var parts = values[1].Split('×');

                    if (parts.Length > 0) item.Kei = float.Parse(parts[0].Replace("φ", ""),CultureInfo.InvariantCulture );
                    if (parts.Length > 1) item.Kubushita = float.Parse(parts[1],CultureInfo.InvariantCulture);
                    if (parts.Length > 2) item.Kado = float.Parse(parts[2],CultureInfo.InvariantCulture);
                    item.Hachou = float.Parse(values[2], CultureInfo.InvariantCulture);
                    item.Zenchou = float.Parse(values[3], CultureInfo.InvariantCulture);
                    item.Page = values[4];
                    item.Mark = Marks.日進ツール.ToString();
                    item.Type = Types.エンドミル.ToString();

                    bindingList.Add(item);
                }
            }

            return bindingList;
        }
        public static List<Tools> CarregarBallEndmill()
        {
            var bindingList = new List<Tools>();
            string arquivoCSV = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Nishin - BallEndmill.csv");

            using (var reader = new StreamReader(arquivoCSV))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (values.Length < 2) continue;

                    var item = new Nishin();

              
                        item.Laminas = 2;
                    
                    item.ID = values[0];
                    // Processa segunda coluna
                    var parts = values[1].Split('×');

                   if (parts.Length > 0) item.Kado = float.Parse(parts[0].Replace("R", ""), CultureInfo.InvariantCulture);
                    item.Kei = item.Kado * 2;
                    if (parts.Length > 1) item.Kubushita = float.Parse(parts[1], CultureInfo.InvariantCulture);
                   if (parts.Length > 2) item.Kado = float.Parse(parts[2], CultureInfo.InvariantCulture);
                    item.Hachou = float.Parse(values[2], CultureInfo.InvariantCulture);
                    item.Zenchou = float.Parse(values[3], CultureInfo.InvariantCulture);
                    item.Page = values[4];
                    item.Mark = Marks.日進ツール.ToString();
                    item.Type = Types.ボールエンドミル.ToString();
                    
                    bindingList.Add(item);
                }
            }

            return bindingList;
        }
        public static List<Tools> CarregarRadiusEndmill()
        {
            var bindingList = new List<Tools>();
            string arquivoCSV = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Nishin - RadiusEndmill.csv");

            using (var reader = new StreamReader(arquivoCSV))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (values.Length < 2) continue;

                    var item = new Nishin();


                    // Processa primeira coluna
                    var match = Regex.Match(values[0], @"^([A-Za-z-]*?)(\d)\d*([A-Za-z-]*)$");
                    if (match.Success)
                    {
                      //  item.ID = match.Groups[1].Value + match.Groups[2].Value + match.Groups[3].Value;
                        item.Laminas = int.Parse(match.Groups[2].Value);
                    }
                  
                        item.ID = values[0];
                    


                    var parts = values[1].Split('×');

                    if (parts.Length > 0) item.Kei = float.Parse(parts[0].Replace("φ", ""), CultureInfo.InvariantCulture);
                    if (parts.Length > 1) item.Kado = float.Parse(parts[1].Replace("R", ""), CultureInfo.InvariantCulture);
                    if (parts.Length > 2) item.Kubushita = float.Parse(parts[2], CultureInfo.InvariantCulture);
                    item.Hachou = float.Parse(values[2], CultureInfo.InvariantCulture);
                    item.Zenchou = float.Parse(values[3], CultureInfo.InvariantCulture);
                    item.Page = values[4];
                    item.Mark = Marks.日進ツール.ToString();
                    item.Type = Types.ラジアスエンドミル.ToString();
                    bindingList.Add(item);
                }
            }

            return bindingList;
        }
    }
}
