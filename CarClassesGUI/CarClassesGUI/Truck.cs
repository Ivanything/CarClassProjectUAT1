using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarClassesGUI
{
    public class Truck : Car
    {
        public int cargo = 0;
        private string dropOffLocation = "";
        public Truck(string n, string c, bool e, string dropOff) : base(n, c, e)
        {
            dropOffLocation = dropOff;

            Random rand = new Random();
            maxFuel += 4 + rand.Next() % 3;// 4-6 More fuel for Trucks

            fuel = maxFuel;// Set fuel to full
        }

        public override void ArrivalFunction(string place)
        {
            if (place == dropOffLocation)
            {// When location IS drop off location, remove all cargo
                cargo = 0;
                MessageBox.Show("The truck's cargo has all been dropped off.");
                return;
            }
            Random r = new Random();
            cargo += r.Next() % 3;// 0-2 cargo per location
            MessageBox.Show("The truck now has " + cargo + " cargo and has to reach " + dropOffLocation + ".");
        }

        public override bool getCrashRandom()
        {
            Random r = new Random();
            if (cargo > 5)
            {// If too much cargo, need extra fuel to reach destination
                fuel--;
            }
            return r.Next() % 30 < cargo;
        }

        public override string getCrashDescription()
        {
            return "crashed and exploded and all " + cargo + " cargo was lost.";
        }

        public override string getPutAwayDescription()
        {
            return "was put away along with the " + cargo + " cargo.";
        }

        public override string getVehicle()
        {
            return " truck ";
        }
    }
}
