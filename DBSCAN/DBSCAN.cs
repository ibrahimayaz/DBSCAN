using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSCAN
{
    public class DBSCAN
    {
        private double Eps;
        private int MinPts;
        public double[][] Data;
        public List<List<int>> komsuNoktalar;
        public Dictionary<int, bool> kumelenecekNoktalar;
        public double[] kumeSonuc;
        public List<int> gurultuluNoktalar;
        public DBSCAN(double[][] data, int minPts, double eps)
        {
            Eps = eps;
            MinPts = minPts;
            Data = data;
            Hesapla();
        }


        private void Hesapla()
        {
            komsuNoktalar = new List<List<int>>();
            kumelenecekNoktalar = new Dictionary<int, bool>();
            gurultuluNoktalar = new List<int>();

            for (int i = 0; i < Data.Length; i++)
            {
                komsuNoktalar.Add(KomsuBul(i));
            }


            for (int i = 0; i < komsuNoktalar.Count; i++)
            {
                if (komsuNoktalar[i].Count >= MinPts)
                {
                    kumelenecekNoktalar.Add(i, false);
                }
                else
                {
                    gurultuluNoktalar.Add(i);
                }
            }

            KumeBul(kumelenecekNoktalar, komsuNoktalar);
        }

        private void KumeBul(Dictionary<int, bool> kumelenecekNoktalar, List<List<int>> komsuNoktalar)
        {
            Dictionary<int, int> kumeBilgisi = new Dictionary<int, int>();
            int kumeId = 0;
            int k = 1;
            bool durum = false;
            if (kumelenecekNoktalar.Count>0)
            {
                durum = true;
            }

            while (durum)
            {
                bool d = false;
                for (int i = 0; i < kumelenecekNoktalar.Count; i++)
                {
                    if (kumelenecekNoktalar[kumelenecekNoktalar.ElementAt(i).Key]==false)
                    {
                        var kume1 = komsuNoktalar[kumelenecekNoktalar.ElementAt(kumeId).Key];
                        var kume2 = komsuNoktalar[kumelenecekNoktalar.ElementAt(i).Key];

                        var fark = kume1.Except(kume2);
                        if (fark.Count() == 0)
                        {
                            if (kumelenecekNoktalar[kumelenecekNoktalar.ElementAt(i).Key] == false)
                            {
                                d = true;
                                kumeBilgisi.Add(kumelenecekNoktalar.ElementAt(i).Key, k);
                                kumelenecekNoktalar[kumelenecekNoktalar.ElementAt(i).Key] = true;
                            }
                            else
                            {
                                d = false;
                            }
                        }
                        else
                        {
                            d = false;
                        }
                    }
                    else
                    {
                        d = false;
                    }
                    
                }
                kumeId++;
                if (d)
                {
                    k++;
                }
                var temp = kumelenecekNoktalar.Where(x => x.Value == false).ToDictionary(y => y.Key, y => y.Value);
                if (temp.Count == 0)
                {
                    durum = false;
                    kumeSonuc = new double[Data.Length];

                    for (int i = 0; i < kumeBilgisi.Count; i++)
                    {
                        kumeSonuc[kumeBilgisi.ElementAt(i).Key] = kumeBilgisi.ElementAt(i).Value;
                    }
                    break;
                }

            }
            if (kumeSonuc==null)
            {
                kumeSonuc = new double[Data.Length];
                for (int i = 0; i < gurultuluNoktalar.Count; i++)
                {
                    kumeSonuc[i] = 0;
                } 
            }
        }

        private List<int> KomsuBul(int dataId)
        {
            List<int> noktalar = new List<int>();
            for (int i = 0; i < Data.Length; i++)
            {
                if (Dist(Data[i], Data[dataId]) <= Eps)
                {
                    noktalar.Add(i);
                }

            }
            return noktalar;
        }

        private double Dist(double[] x1, double[] x2)
        {
            double sonuc = 0;
            for (int i = 0; i < x1.Length; i++)
            {
                sonuc += (x1[i] - x2[i]) * (x1[i] - x2[i]);
            }
            return Math.Sqrt(sonuc);
        }
    }
}
