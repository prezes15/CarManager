
using WinFormsApp1.Logic;
namespace WinFormsApp1.Forms
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.BackgroundImage = Image.FromFile(@"D:\image.png");
            //this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        CarManager manager = new CarManager();
        FileManager fileService = new FileManager();
        private void BtnClick1(object sender, EventArgs e)
        {
            markaBox.Visible = true;
            modelBox.Visible = true;
            rokBox.Visible = true;
            markaLabel.Visible = true;
            modelLabel.Visible = true;
            rokLabel.Visible = true;
            acceptBtn.Visible = true;
            listView1.Visible = false;


        }
        private void BtnClick2(object sender, EventArgs e)
        {
            idBox.Visible = true;
            idLabel.Visible = true;
            markaBox.Visible = false;
            rokBox.Visible = false;
            markaLabel.Visible = false;
            rokLabel.Visible = false;
            acceptBtn.Visible = true;
            listView1.Visible = false;

            idBox.Clear();

        }
        private void BtnClick3(object sender, EventArgs e)
        {
            HideAllButtons();
            ShowCarList();
        }
        private void RentReturnBtn(object sender, EventArgs e)
        {


            if (((Button)sender).Text == "Rent")
            {
                InputDialog newForm = new InputDialog(manager, 0);
                newForm.Show();

            }
            else
            {
                InputDialog newForm = new InputDialog(manager, 1);
                newForm.Show();
            }
        }
        private void ConfirmBtn(object sender, EventArgs e)
        {
            if (markaBox.Visible && rokBox.Visible)
            {
                try
                {
                    manager.Add(markaBox.Text, modelBox.Text, rokBox.Text);
                    MessageBox.Show("Car added!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                markaBox.Clear();
                modelBox.Clear();
                rokBox.Clear();
                HideAllButtons();

            }
            else if (idLabel.Visible && idBox.Visible)
            {
                string message;
                bool usunieto = manager.Drop(idBox.Text, out message);

                if (usunieto)
                {
                    MessageBox.Show(message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    idBox.Clear();
                    idBox.Visible = false;
                    idLabel.Visible = false;
                    acceptBtn.Visible = false;
                }
                else if (!usunieto)
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ShowCarList()
        {
            if (manager.Cars.Count != 0)
            {
                listView1.Items.Clear();
                for (int i = 0; i < manager.Cars.Count; i++)
                {
                    
                    var item = new ListViewItem(manager.Cars[i].Id.ToString());
                    item.SubItems.Add(manager.Cars[i].Mark);
                    item.SubItems.Add(manager.Cars[i].Model);
                    item.SubItems.Add(manager.Cars[i].YearOfProduction.ToString());
                    if (manager.Cars[i].Accessibility)
                    {
                        item.SubItems.Add("yes");
                    }
                    else if (!manager.Cars[i].Accessibility)
                    {
                        item.SubItems.Add("no");
                    }
                    
                    listView1.Items.Add(item);
                    listView1.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("There are no cars in the database", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HideAllButtons()
        {
            markaBox.Visible = false;
            modelBox.Visible = false;
            rokBox.Visible = false;
            markaLabel.Visible = false;
            modelLabel.Visible = false;
            rokLabel.Visible = false;
            acceptBtn.Visible = false;
            listView1.Visible = false;
            idBox.Visible = false;
            idLabel.Visible = false;


        }
        private void SaveBtn(object sender, EventArgs e)
        {
            fileService.Save(manager.GetAll());
        }
        private void LoadBtn(object sender, EventArgs e)
        {
            manager.Load(fileService.Load());
            ShowCarList();
        }
        private void RaportBtn(object sender, EventArgs e)
        {
            if (manager.Cars == null || manager.Cars.Count == 0)
            {
                MessageBox.Show("there are no cars in the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form2 newForm = new Form2(manager);
            newForm.Show();

        }
        private void CloseBtn(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
