using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFADuckHunt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PictureBox pbOrdek = new PictureBox();
        PictureBox pbKopek = new PictureBox();
        Random rnd = new Random();
        const int varsayilanAtis = 5;
        int atisHakki = varsayilanAtis;
        int toplamAtis = 0;
        int vurulanOrdek = 0;
        int toplamOrdek = 0;
        int kacanOrdek = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            SesCal(WFADuckHunt.Properties.Resources.ses_intro);

            //Ordek PictureBox
            pbOrdek.Image = WFADuckHunt.Properties.Resources.ordek;
            pbOrdek.Width = pbOrdek.Height = 100;
            pbOrdek.SizeMode = PictureBoxSizeMode.Zoom;
            pbOrdek.Click += pb_Click;
            pnlHavaSahasi.Controls.Add(pbOrdek);


            //Köpek PictureBox
            pbKopek.Width = 200;
            pbKopek.Height = 100;
            pbKopek.Top = this.Height;
            pbKopek.Left = (pnlHavaSahasi.Width / 2) - (pbKopek.Width / 2);
            pnlHavaSahasi.Controls.Add(pbKopek);
            pbKopek.SizeMode = PictureBoxSizeMode.Zoom;

            tmrYatay.Start();
            tmrDikey.Start();

            AtisHakkiDoldur();
        }

        private void AtisHakkiDoldur()
        {
            atisHakki = varsayilanAtis;
            flpAtisHakki.Controls.Clear();

            for (int i = 0; i < atisHakki; i++)
            {
                Label lbl = new Label();
                lbl.Height = 30;
                lbl.Width = 10;
                lbl.BackColor = Color.Black;
                flpAtisHakki.Controls.Add(lbl);
            }
        }

        void pb_Click(object sender, EventArgs e)
        {
            if (atisHakki > 0)
            {
                SesCal(WFADuckHunt.Properties.Resources.ses_ordekolmesi);

                if (Convert.ToBoolean(pbOrdek.Tag))
                    pbOrdek.Image = WFADuckHunt.Properties.Resources.olu_ordek_sag;
                else
                    pbOrdek.Image = WFADuckHunt.Properties.Resources.olu_ordek_sol;

                tmrDikey.Stop();
                tmrYatay.Stop();

                tmrDusus.Start();

                toplamAtis++;
                lblToplamAtis.Text = string.Format("Toplam Atış : {0}", toplamAtis.ToString());
                vurulanOrdek++;
                lblVurulanOrdek.Text = string.Format("Vurulan Ördek : {0}", vurulanOrdek.ToString());
                toplamOrdek++;
                lblToplamOrdek.Text = string.Format("Toplam Ördek : {0}", toplamOrdek.ToString());

                atisHakki--;
                flpAtisHakki.Controls.RemoveAt(flpAtisHakki.Controls.Count - 1);
            }
        }

        int yatayHiz = 5;
        private void tmrYatay_Tick(object sender, EventArgs e)
        {
            if (atisHakki > 0)
            {
                if (pbOrdek.Image == null)
                {
                    pbOrdek.Image = WFADuckHunt.Properties.Resources.ordek;
                    pbOrdek.Left = rnd.Next(pnlHavaSahasi.Left, pnlHavaSahasi.Right);
                    pbOrdek.Top = rnd.Next(pnlHavaSahasi.Top, pnlHavaSahasi.Bottom);
                }

                if (pbOrdek.Left <= 0)
                {
                    yatayHiz = 5;
                    pbOrdek.Tag = true;
                    pbOrdek.Image = WFADuckHunt.Properties.Resources.ordek;
                }
                else if (pbOrdek.Right > this.Width)
                {
                    yatayHiz = -5;
                    pbOrdek.Tag = false;
                    pbOrdek.Image = WFADuckHunt.Properties.Resources.ters_ordek;
                }

                pbOrdek.Left += yatayHiz;
            }
            else
            {
                pbOrdek.Left += 5;
                OrdekSayisiKontrolu();
            }
        }

        int dikeyHiz = 5;
        private void tmrDikey_Tick(object sender, EventArgs e)
        {
            if (atisHakki > 0)
            {
                if (pbOrdek.Image == null)
                {
                    pbOrdek.Image = WFADuckHunt.Properties.Resources.ordek;
                    pbOrdek.Left = rnd.Next(pnlHavaSahasi.Left, pnlHavaSahasi.Right);
                    pbOrdek.Top = rnd.Next(pnlHavaSahasi.Top, pnlHavaSahasi.Bottom);
                }

                if (pbOrdek.Top <= 0)
                    dikeyHiz = 5;
                else if (pbOrdek.Bottom > (this.Height - 200))
                    dikeyHiz = -5;

                pbOrdek.Top += dikeyHiz;
            }
            else
            {
                pbOrdek.Top -= 5;
                OrdekSayisiKontrolu();
            }
        }

        private void OrdekSayisiKontrolu()
        {
            if (pbOrdek.Bottom < 0 || pbOrdek.Right > pnlHavaSahasi.Right)
            {
                tmrDikey.Stop();
                tmrYatay.Stop();
                kacanOrdek++;
                toplamOrdek++;
                lblToplamOrdek.Text = string.Format("Toplam Ördek : {0}", toplamOrdek.ToString());
                lblKacanOrdek.Text = string.Format("Kaçan Ördek : {0}", kacanOrdek.ToString());

                SesCal(WFADuckHunt.Properties.Resources.ses_kotukopek);
                pbKopek.Image = WFADuckHunt.Properties.Resources.kopek1;
                tmrKopekCikis.Start();
            }
        }

        private void tmrDusus_Tick(object sender, EventArgs e)
        {
            if (pbOrdek.Bottom >= this.Height)
            {
                tmrDusus.Stop();
                pbOrdek.Image = null;

                SesCal(WFADuckHunt.Properties.Resources.ses_iyikopek);
                pbKopek.Image = WFADuckHunt.Properties.Resources.kopek2;
                tmrKopekCikis.Start();
            }
            else
            {
                pbOrdek.Top += 5;
            }
        }

        private void tmrKopekCikis_Tick(object sender, EventArgs e)
        {
            pbKopek.Top -= 5;
            if (pbKopek.Top <= 300)
            {
                tmrKopekCikis.Stop();
                System.Threading.Thread.Sleep(2000);
                tmrKopekGiris.Start();
            }
        }

        private void tmrKopekGiris_Tick(object sender, EventArgs e)
        {
            pbKopek.Top += 5;
            if (pbKopek.Top >= 400)
            {
                tmrKopekGiris.Stop();
                AtisHakkiDoldur();
                System.Threading.Thread.Sleep(2000);

                if (atisHakki > 0)
                {
                    tmrDikey.Start();
                    tmrYatay.Start();
                }
                else
                {
                    MessageBox.Show("Tüm atış haklarınızı harcadınız.");
                }
            }
        }

        private void pnlHavaSahasi_Click(object sender, EventArgs e)
        {
            if (atisHakki > 0)
            {
                SesCal(WFADuckHunt.Properties.Resources.ses_ates);

                toplamAtis++;
                lblToplamAtis.Text = string.Format("Toplam Atış : {0}", toplamAtis.ToString());

                atisHakki--;
                if (atisHakki > -1)
                {
                    flpAtisHakki.Controls.RemoveAt(flpAtisHakki.Controls.Count - 1);
                }
            }
        }

        void SesCal(Stream item)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.Stream = item;
            sp.Play();
        }

        private void pnlHavaSahasi_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
