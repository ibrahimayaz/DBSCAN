using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DBSCAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double[][] data;
        private DBSCAN d;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            d = new DBSCAN(data, int.Parse(txt_minPts.Text), double.Parse(txt_eps.Text));
                
            
            dg_sonucTablosu.DataSource = data.Select((x,y) =>
                        new
                        {
                            SıraNo = y,
                            Fresh = x[0],
                            Milk = x[1],
                            Grocery = x[2],
                            Frozen = x[3],
                            Detergents_Paper = x[4],
                            Delicassen = x[5],
                            SonucKumesi = d.kumeSonuc[y]==0? "Gürültü" : d.kumeSonuc[y]+".Küme"
                        }).ToList();



            var kumeSayilari=d.kumeSonuc.GroupBy(x => x).Select(p => new
            {
                KumeNo=p.Key, Sayisi=p.Count()
            }).ToList();
            dg_kumeBilgileri.DataSource = kumeSayilari.OrderBy(x=>x.KumeNo).ToList();
        }

        private void btn_veriSetiniSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Veri setini seçiniz";
            openFileDialog1.Filter = "Dosya Seçin(*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        data = Veri.Oku(path, char.Parse(txt_ayrac.Text));
                        dg_sonucTablosu.DataSource = data.Select((x,y) =>
                        new
                        {
                            SıraNo = y,
                            Fresh = x[0],
                            Milk = x[1],
                            Grocery = x[2],
                            Frozen = x[3],
                            Detergents_Paper = x[4],
                            Delicassen = x[5]
                        }).ToList();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen belgeyi karşıya yükleyin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
