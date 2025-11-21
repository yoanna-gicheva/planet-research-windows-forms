using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Йоанна Милкова Гичева, F090350
/// </summary>
namespace PlanetResearch.Forms
{
    /// <summary>
    /// Частичен клас на <see cref="EditPlanetForm"/>, съдържащ визуалните контроли и тяхната инициализация.
    /// </summary>
    partial class EditPlanetForm
    {
        /// <summary>
        /// Контейнер за управляеми ресурси на формата.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Текстово поле за въвеждане на името на планетата.
        /// </summary>
        private System.Windows.Forms.TextBox txtName;

        /// <summary>
        /// Текстово поле за въвеждане на звездната система на планетата.
        /// </summary>
        private System.Windows.Forms.TextBox txtStarSystem;

        /// <summary>
        /// Поле за въвеждане на разстоянието от Земята в светлинни години.
        /// </summary>
        private System.Windows.Forms.NumericUpDown numericDistance;

        /// <summary>
        /// Поле за въвеждане на масата на планетата в еквивалент на Земята.
        /// </summary>
        private System.Windows.Forms.NumericUpDown numericMass;

        /// <summary>
        /// Комбиниран списък за избор на типа на планетата.
        /// </summary>
        private System.Windows.Forms.ComboBox comboBoxType;

        /// <summary>
        /// Чекбокс, указващ дали планетата има атмосфера.
        /// </summary>
        private System.Windows.Forms.CheckBox checkBoxAtmosphere;

        /// <summary>
        /// Бутон за запис на направените промени.
        /// </summary>
        private System.Windows.Forms.Button btnSave;

        /// <summary>
        /// Освобождава ресурсите, използвани от формата.
        /// </summary>
        /// <param name="disposing">
        /// Ако е <c>true</c>, се освобождават и управляемите ресурси.
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Инициализира визуалните контроли на формата, задава тяхното разположение, размер и събития.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStarSystem = new System.Windows.Forms.TextBox();
            this.numericDistance = new System.Windows.Forms.NumericUpDown();
            this.numericMass = new System.Windows.Forms.NumericUpDown();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.checkBoxAtmosphere = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numericDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMass)).BeginInit();
            this.SuspendLayout();

            // Настройка на контролите (положение, размер, максимални стойности и събития)
            this.txtName.Location = new System.Drawing.Point(20, 20);
            this.txtName.Size = new System.Drawing.Size(220, 22);

            this.txtStarSystem.Location = new System.Drawing.Point(20, 60);
            this.txtStarSystem.Size = new System.Drawing.Size(220, 22);

            this.numericDistance.Location = new System.Drawing.Point(20, 100);
            this.numericDistance.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numericDistance.DecimalPlaces = 2;

            this.numericMass.Location = new System.Drawing.Point(20, 140);
            this.numericMass.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numericMass.DecimalPlaces = 2;

            this.comboBoxType.Location = new System.Drawing.Point(20, 180);
            this.comboBoxType.Size = new System.Drawing.Size(220, 24);

            this.checkBoxAtmosphere.Location = new System.Drawing.Point(20, 220);
            this.checkBoxAtmosphere.Text = "Has Atmosphere";

            this.btnSave.Location = new System.Drawing.Point(20, 260);
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // Настройка на формата
            this.ClientSize = new System.Drawing.Size(260, 310);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtStarSystem);
            this.Controls.Add(this.numericDistance);
            this.Controls.Add(this.numericMass);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.checkBoxAtmosphere);
            this.Controls.Add(this.btnSave);
            this.Text = "Edit Planet";

            ((System.ComponentModel.ISupportInitialize)(this.numericDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
