using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerKullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Dell\\Downloads\\TARKAN ft. Mahmut Orhan - Her Şey Fani.webm";
            pictureBox1.ImageLocation = "C:\\Users\\Public\\Pictures\\Sample Pictures\\Laleler.jpg";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Dell\\Downloads\\Kubilay Aka feat. Hayko Cepkin - GAMZENDEKİ ÇUKUR (Çukur Dizi Müziği) (Official Music Video) (1).webm";
            pictureBox1.ImageLocation = "C:\\Users\\Public\\Pictures\\Sample Pictures\\Penguenler.jpg";
        }
    }
}
