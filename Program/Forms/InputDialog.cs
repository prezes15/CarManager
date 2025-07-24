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

        }

        private void SendBtn(object sender, EventArgs e)
        {
            string userModel = modelBox.Text;
            string message;
            bool success;
            if (Temp == 0)
            {
                success = manager.Rent(userModel, out message);
                
            }
            else
            {
                success = manager.Return(userModel, out message);
            }
            MessageBox.Show(message, success ? "Success" : "Error", MessageBoxButtons.OK, success ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }
        
    }
}
