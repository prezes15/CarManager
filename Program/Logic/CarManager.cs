using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Logic
{
    internal class CarManager
    {
        private int indexId = 1;
        private List<Car> cars = new List<Car>();
        public IReadOnlyList<Car> Cars => cars.AsReadOnly();
        public bool Drop(string model)
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
            Car car = new Car(indexId, mark, model, rokProdukcji, true);
            indexId++;
            cars.Add(car);
        }
        public bool Rent(string userModel, out string message)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Model == userModel)
                {
                    if (cars[i].Accessibility)
                    {
                        cars[i].Accessibility = false;
                        message = "The vehicle was rented";
                        return true;
                    }
                    else
                    {
                        message = "The vehicle is already rented";
                        return false;
                    }
                    
                }
            }
            message = "Vehicle not found";
            return false;


        }
        public bool Return(string userModel, out string message)
        {
            
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Model == userModel)
                {
                    if (!cars[i].Accessibility)
                    {
                        cars[i].Accessibility = true;
                        message = "The vehicle was returned";
                        return true;
                    }
                    else
                    {
                        message = "The vehicle has already been returned";
                        return false;
                    }
                    
                }
            }
            message = "Vehicle not found";
            return false;
        }
        public void Load(List<Car> data)
        {
            cars = data;
        }
        public List<Car> GetAll()
        {
            return cars;
        }
        public (int Available, int Rented, int Total) GenerateReport()
        {
            int available = cars.Count(c => c.Accessibility);
            int rented = cars.Count - available;
            return (available, rented, cars.Count);
        }
    }
}
