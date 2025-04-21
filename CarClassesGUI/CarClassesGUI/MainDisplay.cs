using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarClassesGUI
{
    public partial class MainDisplay : Form
    {
        Car currentCar = null;
        string[] colors = new string[] { "red", "blue", "yellow", "green", "black", "white" };
        int selectedColor;// Color selection
        int selectedCarType = 0;

        string[] placeNames = new string[] { "New Gas Station", "Abandonded Gas Station", "Normal Gas Station", 
            "Hospital", "Park", "House", "Store"};
        int[] placeTypes = new int[] { 2, 1, 1, 0 ,0 ,0 ,0 };
        // Place types and names of places
        int place;
        // Index for which place is being selected
        public MainDisplay()
        {
            InitializeComponent();
        }

        private void MainDisplay_Load(object sender, EventArgs e)
        {
            lbLogs.Items.Clear();
            DisplayDescription();
        }

        public void DisplayDescription()
        {
            if (currentCar == null)
            {// Display if there is a no car
                lbCarDescription.Text = "No Car is Available";
                return;
            }

            lbCarDescription.Text = currentCar.carOwnerName + "'s " + currentCar.carColor;
            if (currentCar.isElectric)
            {
                lbCarDescription.Text += " electric";
            }
            lbCarDescription.Text += currentCar.getVehicle() + "has " + currentCar.fuel + " out of " + currentCar.maxFuel + " fuel.";

            // Display all information as a sentence
        }

        private void btnCreateCar_Click(object sender, EventArgs e)
        {
            if (tbNameInput.Text.Length == 0) return;// If nothing is inputted in the name textbox, stop

            if (currentCar != null)
            {// If has car already, remove the car
                RemoveCar(false);
            }

            switch (selectedCarType)
            {
                case 0:
                    currentCar = new Car(tbNameInput.Text, colors[selectedColor], cbIsElectric.Checked);
                    break;
                case 1:
                    Random r = new Random();
                    currentCar = new Truck(tbNameInput.Text, colors[selectedColor], cbIsElectric.Checked, 
                        placeNames[r.Next() % placeTypes.Length]);
                    break;
                case 2:
                    currentCar = new Bus(tbNameInput.Text, colors[selectedColor], cbIsElectric.Checked);
                    break;
            }
            // Make new car (based off of which car type is selected)

            ResetCarSelection();// Makes car settings back to default

            DisplayDescription();
        }

        void ResetCarSelection()
        {// Default car settings
            tbNameInput.Text = "";
            selectedColor = 0;
            btnColor.Text = colors[0];
            cbIsElectric.Checked = false;
        }

        void RemoveCar(bool wasCrashed)
        {// Adds log of removed car and what happened to it
            string log = currentCar.carOwnerName + "'s " + currentCar.carColor;
            if (currentCar.isElectric)
                log += " electric";
            log += currentCar.getVehicle();
            if (wasCrashed)
            {
                log += currentCar.getCrashDescription();
            }
            else
            {
                log += currentCar.getPutAwayDescription();
            }
            lbLogs.Items.Add(log);
            currentCar = null;

            MessageBox.Show("The Current Car got Removed!");// Shows message about car being removed

            DisplayDescription();// Update description to show there is no car
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            // Toggle through colors
            selectedColor++;
            selectedColor %= colors.Length;

            btnColor.Text = colors[selectedColor];
        }

        private void btnDrive_Click(object sender, EventArgs e)
        {
            if (currentCar == null) return;// If no car, stop


            Random rand = new Random();

            place = rand.Next() % placeTypes.Length;// Pick new place to be

            btnRefuel.Enabled = placeTypes[place] > 0;// Enable refuel if place is gas station

            MessageBox.Show(currentCar.carOwnerName + " has arrived at " + placeNames[place]);
            // Say where car has arrived
            currentCar.ArrivalFunction(placeNames[place]);

            if (!currentCar.didDriveSafe())
            {// Check if car drove safely, crash car if didn't
                RemoveCar(true);
                return;
            }

            DisplayDescription();// Update description
        }

        private void btnRefuel_Click(object sender, EventArgs e)
        {
            if (currentCar == null) return;// If no car, stop

            // Does place have gas
            if (placeTypes[place] > 0)
            {
                currentCar.Refuel(placeTypes[place] == 2);
            }

            DisplayDescription();// Update description
        }

        private void btnCarType_Click(object sender, EventArgs e)
        {
            selectedCarType++;
            selectedCarType %= 3;
            switch (selectedCarType)
            {
                case 0:
                    btnCarType.Text = "CAR";
                    break;
                case 1:
                    btnCarType.Text = "TRUCK";
                    break;
                case 2:
                    btnCarType.Text = "BUS";
                    break;
            }
        }
    }
}
