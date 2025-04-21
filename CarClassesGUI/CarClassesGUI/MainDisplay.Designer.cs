
namespace CarClassesGUI
{
    partial class MainDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbNameInput = new System.Windows.Forms.TextBox();
            this.cbIsElectric = new System.Windows.Forms.CheckBox();
            this.btnCreateCar = new System.Windows.Forms.Button();
            this.lbCarDescription = new System.Windows.Forms.Label();
            this.btnDrive = new System.Windows.Forms.Button();
            this.btnRefuel = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.lbLogs = new System.Windows.Forms.ListBox();
            this.btnCarType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNameInput
            // 
            this.tbNameInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameInput.Location = new System.Drawing.Point(357, 23);
            this.tbNameInput.Name = "tbNameInput";
            this.tbNameInput.Size = new System.Drawing.Size(247, 38);
            this.tbNameInput.TabIndex = 0;
            // 
            // cbIsElectric
            // 
            this.cbIsElectric.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbIsElectric.AutoSize = true;
            this.cbIsElectric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsElectric.Location = new System.Drawing.Point(478, 73);
            this.cbIsElectric.Name = "cbIsElectric";
            this.cbIsElectric.Size = new System.Drawing.Size(126, 24);
            this.cbIsElectric.TabIndex = 1;
            this.cbIsElectric.Text = "Is Electric Car";
            this.cbIsElectric.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbIsElectric.UseVisualStyleBackColor = true;
            // 
            // btnCreateCar
            // 
            this.btnCreateCar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCreateCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCar.Location = new System.Drawing.Point(400, 108);
            this.btnCreateCar.Name = "btnCreateCar";
            this.btnCreateCar.Size = new System.Drawing.Size(157, 50);
            this.btnCreateCar.TabIndex = 2;
            this.btnCreateCar.Text = "Create New Car";
            this.btnCreateCar.UseVisualStyleBackColor = true;
            this.btnCreateCar.Click += new System.EventHandler(this.btnCreateCar_Click);
            // 
            // lbCarDescription
            // 
            this.lbCarDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCarDescription.AutoSize = true;
            this.lbCarDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCarDescription.Location = new System.Drawing.Point(325, 174);
            this.lbCarDescription.Name = "lbCarDescription";
            this.lbCarDescription.Size = new System.Drawing.Size(317, 17);
            this.lbCarDescription.TabIndex = 3;
            this.lbCarDescription.Text = "Bob\'s blue electric car has 5 fuel out of 10";
            this.lbCarDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDrive
            // 
            this.btnDrive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrive.Location = new System.Drawing.Point(401, 208);
            this.btnDrive.Name = "btnDrive";
            this.btnDrive.Size = new System.Drawing.Size(157, 50);
            this.btnDrive.TabIndex = 4;
            this.btnDrive.Text = "DRIVE";
            this.btnDrive.UseVisualStyleBackColor = true;
            this.btnDrive.Click += new System.EventHandler(this.btnDrive_Click);
            // 
            // btnRefuel
            // 
            this.btnRefuel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefuel.Location = new System.Drawing.Point(401, 264);
            this.btnRefuel.Name = "btnRefuel";
            this.btnRefuel.Size = new System.Drawing.Size(157, 33);
            this.btnRefuel.TabIndex = 5;
            this.btnRefuel.Text = "refuel";
            this.btnRefuel.UseVisualStyleBackColor = true;
            this.btnRefuel.Click += new System.EventHandler(this.btnRefuel_Click);
            // 
            // btnColor
            // 
            this.btnColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(357, 67);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(110, 35);
            this.btnColor.TabIndex = 6;
            this.btnColor.Text = "red";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lbLogs
            // 
            this.lbLogs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogs.FormattingEnabled = true;
            this.lbLogs.ItemHeight = 16;
            this.lbLogs.Location = new System.Drawing.Point(199, 323);
            this.lbLogs.Name = "lbLogs";
            this.lbLogs.Size = new System.Drawing.Size(571, 148);
            this.lbLogs.TabIndex = 7;
            // 
            // btnCarType
            // 
            this.btnCarType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarType.Location = new System.Drawing.Point(610, 26);
            this.btnCarType.Name = "btnCarType";
            this.btnCarType.Size = new System.Drawing.Size(110, 35);
            this.btnCarType.TabIndex = 8;
            this.btnCarType.Text = "CAR";
            this.btnCarType.UseVisualStyleBackColor = true;
            this.btnCarType.Click += new System.EventHandler(this.btnCarType_Click);
            // 
            // MainDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 527);
            this.Controls.Add(this.btnCarType);
            this.Controls.Add(this.lbLogs);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnRefuel);
            this.Controls.Add(this.btnDrive);
            this.Controls.Add(this.lbCarDescription);
            this.Controls.Add(this.btnCreateCar);
            this.Controls.Add(this.cbIsElectric);
            this.Controls.Add(this.tbNameInput);
            this.Name = "MainDisplay";
            this.Text = "Main Display";
            this.Load += new System.EventHandler(this.MainDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbNameInput;
        private System.Windows.Forms.CheckBox cbIsElectric;
        private System.Windows.Forms.Button btnCreateCar;
        private System.Windows.Forms.Label lbCarDescription;
        private System.Windows.Forms.Button btnDrive;
        private System.Windows.Forms.Button btnRefuel;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ListBox lbLogs;
        private System.Windows.Forms.Button btnCarType;
    }
}

