using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hanabie_Project.Marcas
{
    public class Onion: Tools
    {
        public static List<Tools> CarregarBall()
        {
            var bindingList = new List<Tools>();
            string arquivoCSV = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Onion-Ball.csv");

            using (var reader = new StreamReader(arquivoCSV))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (values.Length < 2) continue;

                    var item = new Onion();


                    var parte = values[0].Split(" ");

                    item.ID = parte[0];
                    item.Kataban = parte[1];
                    item.Kado = float.Parse(values[1].Replace("R", ""),CultureInfo.InvariantCulture);
                    item.Kei = item.Kado * 2;
                    if (values[2].Length > 0)
                    {
                        item.Kubushita = float.Parse(values[2], CultureInfo.InvariantCulture);
                    }
                    item.Hachou = float.Parse(values[3], CultureInfo.InvariantCulture);
                    item.Zenchou = int.Parse(values[6], CultureInfo.InvariantCulture);
                    item.Shanko = int.Parse(values[7],CultureInfo.InvariantCulture);
                    item.Laminas = 2;
                    item.Mark = Marks.ユニオン.ToString();
                    item.Type = Types.ボールエンドミル.ToString();

                    bindingList.Add(item);
                }
            }

            return bindingList;
        }
    }
}
