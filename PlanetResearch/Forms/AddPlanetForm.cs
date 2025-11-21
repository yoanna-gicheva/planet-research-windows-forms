using PlanetResearch.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PlanetResearch.Forms
{
    /// <summary>
    /// Форма за добавяне на нова планета в системата.
    /// Позволява на потребителя да въведе основни свойства на планетата и да я създаде.
    /// </summary>
    public partial class AddPlanetForm : Form
    {
        /// <summary>
        /// Връща новосъздадената планета след потвърждение от потребителя.
        /// </summary>
        public Interfaces.IPlanet NewPlanet { get; private set; }

        /// <summary>
        /// Инициализира нова инстанция на <see cref="AddPlanetForm"/>.
        /// Настройва визуалния фон и запълва комбинирания списък с наличните типове планети.
        /// </summary>
        public AddPlanetForm()
        {
            this.BackgroundImage = Image.FromFile("8021306cc8a902b61ffd9103ad880118.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            InitializeComponent();
            comboBoxType.DataSource = Enum.GetValues(typeof(PlanetType));
        }

        /// <summary>
        /// Обработва натискането на бутона за запис на планетата.
        /// Събира всички данни от формата, създава нов <see cref="IPlanet"/> и затваря формата с <see cref="DialogResult.OK"/>.
        /// </summary>
        /// <param name="sender">Обектът, който е изпратил събитието.</param>
        /// <param name="e">Аргументи на събитието.</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string star = txtStarSystem.Text.Trim();
            double distance = (double)numericDistance.Value;
            PlanetType type = (PlanetType)comboBoxType.SelectedItem;
            double mass = (double)numericMass.Value;
            bool atmosphere = checkBoxAtmosphere.Checked;

            NewPlanet = new IPlanet(name, star, distance, type, mass, atmosphere);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
