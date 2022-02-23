using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje5._39_AdamAsmacaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string harfler = "A,B,C,Ç,D,E,F,G,Ğ,H,I,İ,O,J,K,L,M,N,O,Ö,P,R,S,Ş,T,U,Ü,V,Y,Z";
        string sehirler =
            "ADANA,ADIYAMAN,AFYONKARAHİSAR,AĞRI,AKSARAY,AMASYA,ANKARA,ANTALYA,ARDAHAN,ARTVİN,AYDIN," +
            "BALIKESİR,BARTIN,BATMAN,BAYBURT,BİLECİK,BİNGÖL,BİTLİS,BOLU,BURDUR,BURSA,ÇANAKKALE," +
            "ÇANKIRI,ÇORUM,DENİZLİ,DİYARBAKIR,DÜZCE,EDİRNE,ELAZIĞ,ERZİNCAN,ERZURUM,ESKİŞEHİR," +
            "GAZİANTEP,GİRESUN,GÜMÜŞHANE,HAKKARİ,HATAY,IĞDIR,ISPARTA,İSTANBUL,İZMİR,KAHRAMANMARAŞ," +
            "KARABÜK,KARAMAN,KARS,KASTAMONU,KAYSERİ,KIRIKKALE,KIRKLARELİ,KIRŞEHİR,KİLİS,KOCAELİ," +
            "KONYA,KÜTAHYA,MALATYA,MANİSA,MARDİN,MERSİN,MUĞLA,MUŞ,NEVŞEHİR,NİĞDE,ORDU,OSMANİYE,RİZE," +
            "SAKARYA,SAMSUN,SİİRT,SİNOP,SİVAS,ŞIRNAK,TEKİRDAĞ,TOKAT,TRABZON,TUNCELİ,ŞANLIURFA,UŞAK," +
            "VAN,YALOVA,YOZGAT,ZONGULDAK";
        int yanlisHarfSayisi = 0, gorunenHarfSayisi = 0;
        string sehir; 

        private void Form1_Load(object sender, EventArgs e)
        {
            pbAdamAsilmasi.SizeMode = PictureBoxSizeMode.StretchImage;
            flpHarfler.Enabled = false;
            for(int i = 0; i < harfler.Split(',').Length; i++)
            {
                Button btnHarf = new Button();
                btnHarf.Size = new Size(35, 35);
                btnHarf.Text = harfler.Split(',')[i];
                btnHarf.Click += new EventHandler(btnHarf_Click);
                flpHarfler.Controls.Add(btnHarf);
            }
        }


        private void btnHarf_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            Button btnSecilenHarf = sender as Button;
            btnSecilenHarf.Enabled = false;
            foreach (Control lbl in  pnlSoru.Controls)
            {
                if(btnSecilenHarf.Text == lbl.Tag.ToString())
                {
                    lbl.Text = lbl.Tag.ToString();
                    gorunenHarfSayisi++;
                    sayac++;
                }
            }

            if(sayac == 0)
            {
                yanlisHarfSayisi++;
                pbAdamAsilmasi.Image = Image.FromFile("adamAsmacaResimleri\\"
                    + yanlisHarfSayisi.ToString() + ".png");
            }

            if(gorunenHarfSayisi == sehir.Length)
            {
                MessageBox.Show("Kazandınız!");
                flpHarfler.Enabled = false;
            }
            if(yanlisHarfSayisi == 6)
            {
                foreach (Control lbl in pnlSoru.Controls)
                    lbl.Text = lbl.Tag.ToString();

                MessageBox.Show("Kaybettiniz..");
                flpHarfler.Enabled = false;
            }
        
        }
        private void btnBasla_Click(object sender, EventArgs e)
        {
            pnlSoru.Controls.Clear();

            flpHarfler.Enabled = true;
            yanlisHarfSayisi = 0;
            gorunenHarfSayisi = 0;

            foreach (Control btn in flpHarfler.Controls)
                btn.Enabled = true;

            Random rnd = new Random();
            int sehirSiraNo = rnd.Next(0, 80);
            sehir = sehirler.Split(',')[sehirSiraNo];

            for (int i = 0; i < sehir.Length; i++)
            {
                Label lblHarf = new Label();
                lblHarf.Font = new Font("Microsoft Sans Serif", 20);
                lblHarf.Text = "_";
                lblHarf.Tag = sehir[i].ToString();
                lblHarf.Height = 50;
                lblHarf.Width = 30;
                lblHarf.Location = new Point((i * lblHarf.Width), 0);
                pnlSoru.Controls.Add(lblHarf);
            }
        }


    }
}
