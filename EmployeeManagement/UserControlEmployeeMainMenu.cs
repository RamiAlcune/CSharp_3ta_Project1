using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class UserControlEmployeeMainMenu : UserControl
    {
        public UserControlEmployeeMainMenu()
        {
            InitializeComponent();
        }

        private void UserControlEmployeeMainMenu_Load(object sender, EventArgs e)
        {
            dgvMain.DefaultCellStyle.BackColor = Color.White;
            dgvMain.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvMain.DefaultCellStyle.ForeColor = Color.Black;
            dgvMain.DefaultCellStyle.SelectionBackColor = Color.FromArgb(98, 106, 122);
            dgvMain.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvMain.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.DataSource = clsListData.GetAllEmployees();
            dgvMain.Columns["ID"].Width = 50;
            dgvMain.Columns["FullName"].Width = 200;
            dgvMain.Columns["Age"].Width = 50;
            dgvMain.Columns["Salary"].Width = 100;
            dgvMain.Columns["Gender"].Width = 75;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(tbSearchBox.Text);
            clsListData DataByID = clsListData.Find(ID);
            if (DataByID != null)
            {
                MessageBox.Show(DataByID.FullName);
            }
        }
    }
}
