using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
            CurrentlyUserlabel.Text = frmLogin.LoginName;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UserControlEmployeeMainMenu menu = new UserControlEmployeeMainMenu();
            DashBoardPannel.Controls.Clear();
            menu.Dock = DockStyle.Fill;
            DashBoardPannel.Controls.Add(menu);
        }
    }
}
