using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Йоанна Милкова Гичева, F090350
/// </summary>
namespace PlanetResearch.Forms
{
    /// <summary>
    /// F090350, Йоанна Милкова Гичева
    /// Частичен клас на <see cref="AddPlanetForm"/>, съдържащ визуалните контроли и тяхната инициализация.
    /// </summary>
    partial class AddPlanetForm
    {
        /// <summary>
        /// Контейнер за компонентите на формата.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Текстово поле за въвеждане на името на планетата.
        /// </summary>
        private TextBox txtName;

        /// <summary>
        /// Текстово поле за въвеждане на звездната система на планетата.
        /// </summary>
        private TextBox txtStarSystem;

        /// <summary>
        /// Поле за въвеждане на разстоянието от Земята в светлинни години.
        /// </summary>
        private NumericUpDown numericDistance;

        /// <summary>
        /// Поле за въвеждане на масата на планетата в еквивалент на Земята.
        /// </summary>
        private NumericUpDown numericMass;

        /// <summary>
        /// Комбиниран списък за избор на типа на планетата.
        /// </summary>
        private ComboBox comboBoxType;

        /// <summary>
        /// Чекбокс, указващ дали планетата има атмосфера.
        /// </summary>
        private CheckBox checkBoxAtmosphere;

        /// <summary>
        /// Бутон за запис на новата планета.
        /// </summary>
        private Button btnSave;

        /// <summary>
        /// Етикет за името на планетата.
        /// </summary>
        private Label lblName;

        /// <summary>
        /// Етикет за звездната система.
        /// </summary>
        private Label lblStarSystem;

        /// <summary>
        /// Етикет за разстоянието от Земята.
        /// </summary>
        private Label lblDistance;

        /// <summary>
        /// Етикет за масата на планетата.
        /// </summary>
        private Label lblMass;

        /// <summary>
        /// Етикет за типа на планетата.
        /// </summary>
        private Label lblType;

        /// <summary>
        /// Освобождава ресурсите, използвани от формата.
        /// </summary>
        /// <param name="disposing">Ако е <c>true</c>, се освобождават и управляемите ресурси.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Инициализира визуалните компоненти на формата, задава техните свойства и събития.
        /// </summary>
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

            // --- Настройка на контролите (етикети, текстови полета, numericUpDown, comboBox, checkbox, бутон) ---
            // Пример: lblName
            this.lblName.Text = "Planet Name:";
            this.lblName.Location = new System.Drawing.Point(20, 0);
            this.lblName.Size = new System.Drawing.Size(100, 20);

            // txtName
            this.txtName.Location = new System.Drawing.Point(20, 20);
            this.txtName.Size = new System.Drawing.Size(200, 22);

            // lblStarSystem
            this.lblStarSystem.Text = "Star System:";
            this.lblStarSystem.Location = new System.Drawing.Point(20, 40);
            this.lblStarSystem.Size = new System.Drawing.Size(100, 20);

            // txtStarSystem
            this.txtStarSystem.Location = new System.Drawing.Point(20, 60);
            this.txtStarSystem.Size = new System.Drawing.Size(200, 22);

            // lblDistance
            this.lblDistance.Text = "Distance (light years):";
            this.lblDistance.Location = new System.Drawing.Point(20, 80);
            this.lblDistance.Size = new System.Drawing.Size(100, 20);

            // numericDistance
            this.numericDistance.Location = new System.Drawing.Point(20, 100);
            this.numericDistance.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numericDistance.DecimalPlaces = 2;

            // lblMass
            this.lblMass.Text = "Mass (Earth masses):";
            this.lblMass.Location = new System.Drawing.Point(20, 120);
            this.lblMass.Size = new System.Drawing.Size(100, 20);

            // numericMass
            this.numericMass.Location = new System.Drawing.Point(20, 140);
            this.numericMass.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numericMass.DecimalPlaces = 2;

            // lblType
            this.lblType.Text = "Type:";
            this.lblType.Location = new System.Drawing.Point(20, 160);
            this.lblType.Size = new System.Drawing.Size(100, 20);

            // comboBoxType
            this.comboBoxType.Location = new System.Drawing.Point(20, 180);
            this.comboBoxType.Size = new System.Drawing.Size(200, 24);

            // checkBoxAtmosphere
            this.checkBoxAtmosphere.Location = new System.Drawing.Poin
