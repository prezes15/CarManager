using Microsoft.VisualBasic;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"D:\image.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        CarManager manager = new CarManager();
        private void BtnClick1(object sender, EventArgs e)
        {
            markaBox.Visible = true;
            modelBox.Visible = true;
            rokBox.Visible = true;
            markaLabel.Visible = true;
            modelLabel.Visible = true;
            rokLabel.Visible = true;
            zatwierdzButton.Visible = true;
            listView1.Visible = false;

        }
        private void BtnClick2(object sender, EventArgs e)
        {
            modelBox.Visible = true;
            modelLabel.Visible = true;
            markaBox.Visible = false;
            rokBox.Visible = false;
            markaLabel.Visible = false;
            rokLabel.Visible = false;
            zatwierdzButton.Visible = true;
            listView1.Visible = false;

            modelBox.Clear();

        }
        private void BtnClick3(object sender, EventArgs e)
        {
            HideAllButtons();
            ShowCarList();
        }
        private void RentBtn(object sender, EventArgs e)
        {
            HideAllButtons();

            string userModel = Interaction.InputBox("Specify the model for rent", "InputBox", "");
            manager.Rent(userModel);
        }
        private void ReturnBtn(object sender, EventArgs e)
        {
            HideAllButtons();

            string userModel = Interaction.InputBox("Specify the model for rent", "InputBox", "");
            manager.Return(userModel);
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
            else if (modelBox.Visible && !markaBox.Visible)
            {
                bool usunieto = manager.Usun(modelBox.Text);

                if (usunieto)
                {
                    MessageBox.Show("Car removed!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    modelBox.Clear();
                    modelBox.Visible = false;
                    modelLabel.Visible = false;
                    zatwierdzButton.Visible = false;
                }
                else if (!usunieto)
                {
                    MessageBox.Show("There is no such car", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    var item = new ListViewItem(manager.Cars[i].Mark);
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
            zatwierdzButton.Visible = false;
            listView1.Visible = false;
            saveBtn.Visible = false;
            loadBtn.Visible = false;
        }

        FileManager fileService = new FileManager();


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
            if(manager.Cars == null || manager.Cars.Count == 0)
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
