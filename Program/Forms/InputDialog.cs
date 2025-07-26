using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Logic;
namespace WinFormsApp1.Forms
{
    internal partial class InputDialog : Form
    {
        private CarManager manager;
        int Temp {  get; set; }
        public InputDialog(CarManager manager, int temp)
        {
            InitializeComponent();
            this.manager = manager;
            this.Temp = temp;
        }

        private void CancelBtn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SendBtn(object sender, EventArgs e)
        {
            int userId;
            string message;
            bool success;

            if(int.TryParse(idBox.Text, out userId))
            {
                if (Temp == 0)
                {
                    success = manager.Rent(userId, out message);
                    this.Close();

                }
                else
                {
                    success = manager.Return(userId, out message);
                }
                MessageBox.Show(message, success ? "Success" : "Error", MessageBoxButtons.OK, success ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Id must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
    }
}
