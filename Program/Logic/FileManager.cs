using WinFormsApp1.Models;
namespace WinFormsApp1.Logic
{
    internal class FileManager
    {
        private string path = "cars.txt";

        public void Save(List<Car> cars)
        {
            if (cars == null || cars.Count == 0)
            {
                MessageBox.Show("List is empty", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    sw.WriteLine($"{cars[i].Mark};{cars[i].Model};{cars[i].YearOfProduction};{cars[i].Accessibility}");
                }
            }

            MessageBox.Show("List saved", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<Car> Load()
        {
            List<Car> list = new();
            if (!File.Exists(path))
            {
                
                return list;
            }
            int year;
            bool temp;
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                var data = lines[i].Split(';');
                if(data.Length < 4)
                {
                    MessageBox.Show($"File error on line {i+1}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                if(int.TryParse(data[2], out year) && bool.TryParse(data[3], out temp))
                {
                    try 
                    { 
                        list.Add(new Car(data[0], data[1], year, temp));
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show($"File error on line {i + 1}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
                }
                else
                {
                    MessageBox.Show($"File error on line {i + 1}: invalid year or accessibility format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return list;

        }

        public static void SaveRaport(Label available, Label rented, Label all)
        {
            using (StreamWriter sw = new StreamWriter("report.txt"))
            {
                try 
                { 
                    sw.WriteLine($"number of available cars: {available.Text}");
                    sw.WriteLine($"number of rented cars:  {rented.Text}");
                    sw.WriteLine($"all cars {all.Text}");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
    }
}
