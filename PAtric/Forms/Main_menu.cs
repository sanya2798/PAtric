using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtric
{
    public partial class Main_menu : Form
    {
        // OBJECTS
        private Form activeForm;
        

        // CONTROLL
        bool sidebarExpand, homeCollapse, saleCollapse;
        private Button currentButton;

        public Main_menu()
        {
            InitializeComponent();
        }

        private void Main_menu_Load(object sender, EventArgs e)
        {
            OpenChildForm(this.panelMenuButton, new Button_bar(this));
        }
        public void OpenChildForm(Panel panel, Form childForm) //, object btnSender
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
