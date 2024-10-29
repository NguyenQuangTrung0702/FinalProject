using FinalProject.Properties;
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
    public partial class Menu : Form
    {
        private Form currentFormChild;
        public Menu()
        {
            InitializeComponent();
        }

        private void btnMenu_Collapse_Click(object sender, EventArgs e)
        {
            btnMenu_Collapse.Visible = false;
            btnMenu_Expand.Visible = true;
            pnlMenu.Visible = false;
            pnlMenu.Width = 260;
            transition.ShowSync(pnlMenu);
        }

        private void btnMenu_Expand_Click(object sender, EventArgs e)
        {
            btnMenu_Collapse.Visible = true;
            btnMenu_Expand.Visible = false;
            pnlMenu.Visible = false;
            pnlMenu.Width = 80;
            transition.ShowSync(pnlMenu);
        }

        private void openChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(childForm);
            pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new Home());
            SetButtonHoverEffect(btnHome, Properties.Resources.icons8_home_100__2_);
        }

        private void SetButtonHoverEffect(Guna.UI2.WinForms.Guna2Button activeButton, Image activeImage)
        {
            foreach (Control control in pnlMenu.Controls)
            {
                if (control is Guna.UI2.WinForms.Guna2Button btn)
                {
                    btn.FillColor = Color.FromArgb(3, 76, 172); 
                    btn.ForeColor = Color.White; 
                }
            }

            activeButton.FillColor = Color.White; 
            activeButton.ForeColor = Color.FromArgb(3, 76, 172); 
            activeButton.Image = activeImage;
        }
    }
}
