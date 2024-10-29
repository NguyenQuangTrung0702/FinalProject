using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            pnlAdd.Visible = false;
            pnlProfile.Visible = false;
            this.Click += new EventHandler(Dashboard_Click);
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            Point mousePosition = this.PointToClient(Cursor.Position);

            if (!pnlAdd.Bounds.Contains(mousePosition))
            {
                pnlAdd.Visible = false;
            }

            if (!pnlProfile.Bounds.Contains(mousePosition))
            {
                pnlProfile.Visible = false;
            }
        }

        private void UpdateButtonColors_1(Guna.UI2.WinForms.Guna2Button selectedButton)
        {
            foreach (Control control in selectedButton.Parent.Controls)
            {
                if (control is Guna.UI2.WinForms.Guna2Button button &&
                    (button == btnAll || button == btn7Days || button == btnDueToday || button == btnOverdue))
                {
                    button.FillColor = Color.White;
                    button.ForeColor = Color.Black;
                }
            }

            selectedButton.FillColor = Color.FromArgb(3, 76, 172);
            selectedButton.ForeColor = Color.White;
        }

        private void UpdateButtonColors_2(Guna.UI2.WinForms.Guna2Button selectedButton)
        {
            foreach (Control control in selectedButton.Parent.Controls)
            {
                if (control is Guna.UI2.WinForms.Guna2Button button &&
                    (button == btnCreatedByMe || button == btnAssignedToMe))
                {
                    button.FillColor = Color.White;
                    button.ForeColor = Color.Black;
                }
            }

            selectedButton.FillColor = Color.FromArgb(3, 76, 172);
            selectedButton.ForeColor = Color.White;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            btnAll.Click += (s, args) => UpdateButtonColors_1(btnAll);
            btn7Days.Click += (s, args) => UpdateButtonColors_1(btn7Days);
            btnDueToday.Click += (s, args) => UpdateButtonColors_1(btnDueToday);
            btnOverdue.Click += (s, args) => UpdateButtonColors_1(btnOverdue);
            btnAssignedToMe.Click += (s, args) => UpdateButtonColors_2(btnAssignedToMe);
            btnCreatedByMe.Click += (s, args) => UpdateButtonColors_2(btnCreatedByMe);
        }

        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = !pnlAdd.Visible;
            if (pnlAdd.Visible)
            {
                pnlAdd.BringToFront();
            }
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            pnlProfile.Visible = !pnlProfile.Visible;
            if (pnlProfile.Visible)
            {
                pnlProfile.BringToFront();
            }
        }
    }
}
