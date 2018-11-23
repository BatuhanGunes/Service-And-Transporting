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
    public partial class PanelForm : Form
    {

    
        // Açılışta başlangıç Child form olarak mainPage sayfasını atadık
        public PanelForm()
        {
            InitializeComponent();


            Child_MainPage main_page = new Child_MainPage();    //Form nesnesini tanımlıyoruz
            main_page.MdiParent = this;     //Tanımladığımız Form nesnesini panel formunun child formu olarak tanımlıyoruz.
            OpenFormInPanel(main_page);     //Panel içerisinde form açma işlemlerimizin olduğu methodu çağırıyoruz.

        }

        // Çıkış yap butonuna tıklandığında Kullanıcıyı giriş sayfasına döndürür.
        private void LogOutMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.Show();
        }



        private void FinnishMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    //Uygulamayı kapat
        }


        //panel icerisinde sürekli form açıp kapayacağımız için bu işlemleri tekrar tekrar yazmamak adına
        //Değişim esnasında gerekicek bütün kodlamaları bir method içerisinde topluyoruz.
        private void OpenFormInPanel(Form ParameterForm)
        {

            panel1.Controls.Clear();                //Panel içerisindeki işlemleri temizliyoruz(Açık olan formu gizler)
            ParameterForm.TopLevel = false;         //Üst pencere olarak gösterilmesini engeller(Mdi child..)
            panel1.Controls.Add(ParameterForm);     //panel içerisine parametre olarak aldığımız form nesnesini ekliyoruz.
            ParameterForm.Show();                   //Eklediğimiz formu gösteriyoruz.
            ParameterForm.Dock = DockStyle.Fill;    //Parametre olarak aldığımız formun Panel içerisine dolduruyoruz.
            ParameterForm.BringToFront();           //Parametre formumuzu ön plana atıyoruz.

        }


        // Staff Forms Menu item yönlendirmeleri
        private void MainPageMenuItem_Click(object sender, EventArgs e)
        {
            Child_MainPage main_page = new Child_MainPage();
            main_page.MdiParent = this;
            OpenFormInPanel(main_page);
        }

        private void VehiclePageMenuItem_Click(object sender, EventArgs e)
        {
            Child_VehicleInfo vehiclePage = new Child_VehicleInfo();
            vehiclePage.MdiParent = this;
            OpenFormInPanel(vehiclePage);
        }


        // Staff-Costomers Forms Menu item yönlendirmeleri
        // Address menu item yönlendirmeleri
        private void PlaceListMenuItem_Click(object sender, EventArgs e)
        {
            Child_AddressList AddressListPage = new Child_AddressList();
            AddressListPage.MdiParent = this;
            OpenFormInPanel(AddressListPage);
        }

        
        // Costomers menu item yönlendirmeleri
        private void CostomersListMenuItem_Click(object sender, EventArgs e)
        {
            Child_CostomerList CostListPage = new Child_CostomerList();
            CostListPage.MdiParent = this;
            OpenFormInPanel(CostListPage);
        }

        private void StudentsAddMenuItem_Click(object sender, EventArgs e)
        {
            Child_StudentAdd StudentAddPage = new Child_StudentAdd();
            StudentAddPage.MdiParent = this;
            OpenFormInPanel(StudentAddPage);
        }

        private void CostomersAddMenuItem_Click(object sender, EventArgs e)
        {
            Child_CostomerAdd CostAddPage = new Child_CostomerAdd();
            CostAddPage.MdiParent = this;
            OpenFormInPanel(CostAddPage);
        }


        // Admin Forms Menu item yönlendirmeleri
        // Vehicle menu item yönlendirmeleri
        private void VehicleListMenuItem_Click(object sender, EventArgs e)
        {
            Child_VehicleList VehicleListPage = new Child_VehicleList();
            VehicleListPage.MdiParent = this;
            OpenFormInPanel(VehicleListPage);
        }

        private void VehicleAddMenuItem_Click(object sender, EventArgs e)
        {
            Child_VehicleAdd VehicleAddPage = new Child_VehicleAdd();
            VehicleAddPage.MdiParent = this;
            OpenFormInPanel(VehicleAddPage);
        }

        // Task Menu item yönlendirmeleri
        private void MissionListMenuItem_Click(object sender, EventArgs e)
        {
            Child_TaskList TaskListPage = new Child_TaskList();
            TaskListPage.MdiParent = this;
            OpenFormInPanel(TaskListPage);
        }

        private void MissionAddMenuItem_Click(object sender, EventArgs e)
        {
            Child_TaskAdd TaskAddPage = new Child_TaskAdd();
            TaskAddPage.MdiParent = this;
            OpenFormInPanel(TaskAddPage);
        }

        // Staff menu item yönlendirmeleri
        private void StaffListMenuItem_Click(object sender, EventArgs e)
        {
            Child_StaffList StaffListPage = new Child_StaffList();
            StaffListPage.MdiParent = this;
            OpenFormInPanel(StaffListPage);
        }

        private void StaffAddMenuItem_Click(object sender, EventArgs e)
        {
            Child_StaffAdd StaffAddPage = new Child_StaffAdd();
            StaffAddPage.MdiParent = this;
            OpenFormInPanel(StaffAddPage);
        }

        // Costomers all list menu item yönlendirmeleri
        private void CostomersPageMenuItem_Click(object sender, EventArgs e)
        {
            Child_CostomersAllList AllCostListPage = new Child_CostomersAllList();
            AllCostListPage.MdiParent = this;
            OpenFormInPanel(AllCostListPage);
        }
    }
}
