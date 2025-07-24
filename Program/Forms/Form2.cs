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
    partial class Form2 : Form
    {
        private CarManager manager;

        internal Form2(CarManager manager)
        {
            InitializeComponent();
            this.manager = manager;
            RaportDo();
        }

        private void CloseBtn(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RaportDo()
        {
            var report = manager.GenerateReport();
            available.Text = report.Available.ToString();
            rented.Text = report.Rented.ToString();
            all.Text = report.Total.ToString();
        }
        private void SaveToRaportBtn(object sender, EventArgs e)
        {
            if(manager.Cars == null || manager.Cars.Count == 0)
            {
                MessageBox.Show("there are no cars in the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FileManager.SaveRaport(available, rented, all);
        }   
    }
}
