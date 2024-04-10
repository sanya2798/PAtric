using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtric
{
    public partial class Button_bar : Form
    {
        // CONTROLL
        bool userCollapse = true;
        bool homeCollapse = true;
        bool registrationCollapse = true;
        bool laboratoryCollapse = true;
        bool warehouseCollapse = true;
        bool bookkeepingCollapse = true;

        private Form activeForm;
        private Main_menu mainMenu;
        public Button_bar(Main_menu menu)
        {
            InitializeComponent();
            this.mainMenu = menu;
        }

        private void Button_bar_Load(object sender, EventArgs e)
        {
        }

        private bool OpenButtonContainer(Panel container, Timer timer, bool collapse)
        {
            if (collapse)
            {
                container.Height += 10;

                if (container.Height == container.MaximumSize.Height)
                {
                    collapse = false;
                    timer.Stop();
                    return collapse;
                }
                else return collapse;
            }
            else
            {
                container.Height -= 10;

                if (container.Height == container.MinimumSize.Height)
                {
                    collapse = true;
                    timer.Stop();
                    return collapse;
                }
                else return collapse;
            }
        }

        private void UserTimer_Tick(object sender, EventArgs e)
        {
            userCollapse = OpenButtonContainer(UserContainer, UserTimer, userCollapse);
        }

        private void HomeTimer_Tick(object sender, EventArgs e)
        {
            homeCollapse = OpenButtonContainer(HomeContainer, HomeTimer, homeCollapse);
        }

        private void RegistrationTimer_Tick(object sender, EventArgs e)
        {
            registrationCollapse = OpenButtonContainer(RegistrationContainer, RegistrationTimer, registrationCollapse);
        }

        private void LaboratoryTimer_Tick(object sender, EventArgs e)
        {
            laboratoryCollapse = OpenButtonContainer(LaboratoryContainer, LaboratoryTimer, laboratoryCollapse);
        }
        private void WarehouseTimer_Tick(object sender, EventArgs e)
        {
            warehouseCollapse = OpenButtonContainer(WarehouseContainer, WarehouseTimer, warehouseCollapse);
        }
        private void BookkeepingTimer_Tick(object sender, EventArgs e)
        {
            bookkeepingCollapse = OpenButtonContainer(BookkeepingContainer, BookkeepingTimer, bookkeepingCollapse);
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            UserTimer.Start();
            //OpenChildForm(mainMenu.panelDesctop, new Repair_work());
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            HomeTimer.Start();
            //OpenChildForm(mainMenu.panelDesctop, new Repair_work());
        }
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            RegistrationTimer.Start();
            //OpenChildForm(mainMenu.panelDesctop, new Repair_work());
        }
        private void buttonLaboratory_Click(object sender, EventArgs e)
        {
            LaboratoryTimer.Start();
            //OpenChildForm(mainMenu.panelDesctop, new Repair_work());
        }
        private void buttonWarehouse_Click(object sender, EventArgs e)
        {
            WarehouseTimer.Start();
            //OpenChildForm(mainMenu.panelDesctop, new Repair_work());
        }
        private void buttonBookkeeping_Click(object sender, EventArgs e)
        {
            BookkeepingTimer.Start();
            //OpenChildForm(mainMenu.panelDesctop, new Repair_work());
        }
    }
}
