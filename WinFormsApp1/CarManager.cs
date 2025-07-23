using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class CarManager
    {
        private List<Car> cars = new List<Car>();
        public IReadOnlyList<Car> Cars => cars.AsReadOnly();
        public bool Usun(string model)
        {

            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Model == model)
                {
                    cars.RemoveAt(i);

                    return true;

                }
            }
            return false;

        }
        public void Add(string mark, string model, string year)
        {
            if (!int.TryParse(year, out int rokProdukcji))
            {
                throw new FormatException("The year must be an integer");
            }
            Car samochod = new Car(mark, model, rokProdukcji, true);
            cars.Add(samochod);
        }
        public void Rent(string userModel)
        {

            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Model == userModel)
                {
                    if (cars[i].Accessibility)
                    {
                        cars[i].Accessibility = false;
                        MessageBox.Show("The vehicle was rented", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The vehicle is already rented", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    return;
                }
            }
            MessageBox.Show("Vehicle not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }
        public void Return(string userModel)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Model == userModel)
                {
                    if (!cars[i].Accessibility)
                    {
                        cars[i].Accessibility = true;
                        MessageBox.Show("The vehicle was returned", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The vehicle has already been returned", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }
            }
            MessageBox.Show("Vehicle not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Load(List<Car> data)
        {
            cars = data;
        }
        public List<Car> GetAll()
        {
            return cars;
        }

        public void Raport(Label available, Label rented, Label all)
        {
                       
            int availableTemp = 0;
            int rentedTemp = 0;
            for(int i = 0; i < cars.Count;i++)
            {
                if (cars[i].Accessibility)
                {
                    availableTemp++;
                }
                else
                {
                    rentedTemp++;
                }
            }
            int allTemp = availableTemp + rentedTemp;
            available.Text = availableTemp.ToString();
            rented.Text = rentedTemp.ToString();
            all.Text = allTemp.ToString();
        }
    }
}
