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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }


        private void Exits_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    //Uygulamayı kapatır.
        }

        //  Panel formuna geçiş yapar
        private void LogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanelForm form = new PanelForm();
            form.Show();
          
        }
    }
}
