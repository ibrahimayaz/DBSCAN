
using System.Linq;
using System.IO;

namespace DBSCAN
{
    public class Veri
    {

        /// <summary>
        /// Wholesale customers data setine göre ayarlanmıştır.
        /// Veri setinin özellik sayısına göre bu fonksiyon düzenlenmelidir.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static double[][] Oku(string filePath, char ayrac)
        {
            var data = from row in File.ReadAllLines(filePath)
            select (row.Split(ayrac)).ToList();
            double[][] veri = new double[data.Count()][];
            int satir = 0;
            foreach (var item in data)
            {
                veri[satir] = new double[item.Count];
                for (int kolon = 0; kolon < item.Count; kolon++)
                {
                    veri[satir][kolon] = double.Parse(item[kolon]);
                }
                satir++;
            }

            //int i=0;
            //foreach (var item in data)
            //{
            //    veri[i] = new double[] {
            //        double.Parse(item[0]),
            //        double.Parse(item[1]),
            //        double.Parse(item[2]),
            //        double.Parse(item[3]),
            //        double.Parse(item[4]),
            //        double.Parse(item[5]),
            //    };
            //    i++;
            //}
            return veri;
        }
    }
}
