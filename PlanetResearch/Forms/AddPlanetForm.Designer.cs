using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetResearch.Forms
{
    partial class AddPlanetForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtName;
        private TextBox txtStarSystem;
        private NumericUpDown numericDistance;
        private NumericUpDown numericMass;
        private ComboBox comboBoxType;
        private CheckBox checkBoxAtmosphere;
        private Button btnSave;

        private Label lblName;
        private Label lblStarSystem;
        private Label lblDistance;
        private Label lblMass;
        private Label lblType;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtName = new TextBox();
            this.txtStarSystem = new TextBox();
            this.numericDistance = new NumericUpDown();
            this.numericMass = new NumericUpDown();
            this.comboBoxType = new ComboBox();
            this.checkBoxAtmosphere = new CheckBox();
            this.btnSave = new Button();

            this.lblName = new Label();
            this.lblStarSystem = new Label();
            this.lblDistance = new Label();
            this.lblMass = new Label();
            this.lblType = new Label();

            ((System.ComponentModel.ISupportInitialize)(this.numericDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMass)).BeginInit();
            this.SuspendLayout();

            this.lblName.Text = "Planet Name:";
            this.lblName.Location = new System.Drawing.Point(20, 0);
            this.lblName.Size = new System.Drawing.Size(100, 20);

            this.txtName.Location = new System.Drawing.Point(20, 20);
            this.txtName.Size = new System.Drawing.Size(200, 22);

            this.lblStarSystem.Text = "Star System:";
            this.lblStarSystem.Location = new System.Drawing.Point(20, 40);
            this.lblStarSystem.Size = new System.Drawing.Size(100, 20);

            this.txtStarSystem.Location = new System.Drawing.Point(20, 60);
            this.txtStarSystem.Size = new System.Drawing.Size(200, 22);

            this.lblDistance.Text = "Distance (light years):";
            this.lblDistance.Location = new System.Drawing.Point(20, 80);
            this.lblDistance.Size = new System.Drawing.Size(100, 20);

            this.numericDistance.Location = new System.Drawing.Point(20, 100);
            this.numericDistance.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numericDistance.DecimalPlaces = 2;

            this.lblMass.Text = "Mass (Earth masses):";
            this.lblMass.Location = new System.Drawing.Point(20, 120);
            this.lblMass.Size = new System.Drawing.Size(100, 20);

            this.numericMass.Location = new System.Drawing.Point(20, 140);
            this.numericMass.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numericMass.DecimalPlaces = 2;

            this.lblType.Text = "Type:";
            this.lblType.Location = new System.Drawing.Point(20, 160);
            this.lblType.Size = new System.Drawing.Size(100, 20);

            this.comboBoxType.Location = new System.Drawing.Point(20, 180);
            this.comboBoxType.Size = new System.Drawing.Size(200, 24);

            this.checkBoxAtmosphere.Location = new System.Drawing.Point(20, 220);
            this.checkBoxAtmosphere.Text = "Has Atmosphere";

            this.btnSave.Location = new System.Drawing.Point(20, 260);
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            this.ClientSize = new System.Drawing.Size(250, 310);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblStarSystem);
            this.Controls.Add(this.txtStarSystem);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.numericDistance);
            this.Controls.Add(this.lblMass);
            this.Controls.Add(this.numericMass);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.checkBoxAtmosphere);
            this.Controls.Add(this.btnSave);

            this.Text = "Add Planet";

            ((System.ComponentModel.ISupportInitialize)(this.numericDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
