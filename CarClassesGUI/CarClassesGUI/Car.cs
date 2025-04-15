using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarClassesGUI
{
    public class Car
    {
        // Properties
        public string carOwnerName;
        public float fuel;
        public float maxFuel;
        public string carColor;
        public bool isElectric;

        public Car(string n, string c, bool e)
        {
            carOwnerName = n;
            carColor = c;
            isElectric = e;// Set all properties

            Random rand = new Random();
            // Choose more fuel for Electric cars
            if (isElectric)
            {
                maxFuel = 5 + rand.Next() % 5;// from 5 to 9
            }
            else
            {
                maxFuel = 4 + rand.Next() % 3;// from 4-6
            }
            fuel = maxFuel;// Set fuel to full
        }

        public void Refuel(bool electric)
        {
            if (isElectric && !electric)
            {// If fuel station is not electric but your car is electric, it doesn't work
                MessageBox.Show("This Gas Station has no Charging Station");
            }
            else
            {
                fuel = maxFuel;
            }
        }

        public bool didDriveSafe()
        {
            if (fuel > 0)
            {
                fuel--;// Remove one fuel
                Random r = new Random();
                if (r.Next() % 10 == 0) return false;// 10% chance of crashing the car
            }
            else
            {// If fuel is less 0 or less then the car crashes
                return false;
            }

            return true;// If doesn't return early, then everything is fine
        }
    }
}
