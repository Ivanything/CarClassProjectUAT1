using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarClassesGUI
{
    public class Bus : Car
    {
        public int people = 0;
        public Bus(string n, string c, bool e) : base(n, c, e)
        {
            Random rand = new Random();
            maxFuel += 2 + rand.Next() % 3;// 2-4 More fuel for Buses

            fuel = maxFuel;// Set fuel to full
        }

        public override void ArrivalFunction(string place)
        {
            Random r = new Random();
            int amountGained = r.Next() % 4;// Gain 0-3 people
            int amountLost = Math.Min(people, r.Next() % 3);// Lose 0-2 people, clamp amount lost so it can't be negative
            people += amountGained - amountLost;// Add and subtract the people
            MessageBox.Show("The bus dropped off " + amountLost + " people and picked up " + amountGained +
                " people and now has " + people + " people riding the bus.");
        }

        public override bool getCrashRandom()
        {
            Random r = new Random();
            if (people > 5)
            {// If too many people, need extra fuel to reach destination
                fuel--;
            }
            return r.Next() % 30 < 2 + people;
        }

        public override string getCrashDescription()
        {
            // Change description if there is 0 or 1 passenger
            if (people == 0)
            {
                return "crashed and exploded with thankfully no passengers inside.";
            }
            else if (people == 1)
            {
                return "crashed and exploded and the 1 passenger died.";
            }
            return "crashed and exploded and all " + people + " passengers died.";
        }

        public override string getPutAwayDescription()
        {
            // Change description if there is 0 or 1 passenger
            if (people == 0)
            {
                return "was put away.";
            }
            else if (people == 1)
            {
                return "was put away along with your 1 single passenger. THEY WILL NEVER ESCAPE";
            }
            return "was put away along with the " + people + " people. THEY WILL NEVER ESCAPE";
        }

        public override string getVehicle()
        {
            return " bus ";
        }
    }
}
