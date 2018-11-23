using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceAndTransporting
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);  //Timer'ın her saniyesinde Progress barı 4'er 4'er büyüt.
            
            if(progressBar1.Value == 100)   //Progres bar tamamlandığında
            {
                timer1.Stop();      //Timerı durdur
                this.Close();       //Splash formu kapat
                LoginForm frm = new LoginForm(); //Login form nesnesini tanımla
                frm.Show();         //Login formu aç.
            }
        }


    }
}
