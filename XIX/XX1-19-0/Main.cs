using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XX1_19_0
{
    public partial class Main : Form
    {
 
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control.Size.Height != control.Size.Width)
            { // To ensure the Form remains square (Height = Width) use this -->.control.Size.Height != control.Size.Width
                control.Size = new Size(1380,788);
                this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            }
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to close application ?", "ERG-SAT-XXI",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                /* terminates all message loops and closes all windows thus giving your forms 
                 * the possibility to execute their cleanup code (in Form.OnClose etc).*/
                Application.Exit();
            }
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button_WOC6_Click(object sender, EventArgs e)
        {
            if (button_WOC6.Text.Equals("Connect"))
            {
                 button_WOC6.Text = "Disconnect";
            }
            else if (button_WOC6.Text.Equals("Disconnect"))
            {
                button_WOC6.Text = "Connect";
            }   
        }

        //methode here 



    }
}
