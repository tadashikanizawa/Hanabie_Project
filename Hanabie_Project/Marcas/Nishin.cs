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





        public static List<Tools> CarregarCSV()
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
                    var match = Regex.Match(values[0], @"^([A-Za-z]+)(\d+)$");
                    if (match.Success)
                    {
                        string groupValue = match.Groups[2].Value;
                        string firstNumber = Regex.Match(groupValue, @"\d+").Value;
                        item.Laminas = int.Parse(firstNumber);
                    }
                     item.ID = values[0]; 
                    // Processa segunda coluna
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

    }
}
