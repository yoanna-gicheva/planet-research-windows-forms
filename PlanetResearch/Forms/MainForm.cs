using PlanetResearch.Interfaces;
using PlanetResearch.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// Йоанна Милкова Гичева, F090350
/// </summary>
namespace PlanetResearch.Forms
{
    /// <summary>
    /// Основна форма за управление на колекция от планети.
    /// Позволява добавяне, редактиране, изтриване, сортиране и търсене на планети чрез визуален интерфейс.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Репозитори за съхранение на планетите.
        /// </summary>
        private PlanetRepository repo = new PlanetRepository();

        /// <summary>
        /// Инициализира нова инстанция на <see cref="MainForm"/>.
        /// Настройва визуалния фон, колоните на DataGridView и зарежда данните.
        /// </summary>
        public MainForm()
        {
            this.BackgroundImage = Image.FromFile("8021306cc8a902b61ffd9103ad880118.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            InitializeComponent();
            dataGridViewPlanets.AutoGenerateColumns = false;
            SetupDataGridView();
            RefreshGrid();
        }

        /// <summary>
        /// Конфигурира колоните на <see cref="dataGridViewPlanets"/> за показване на свойства на планетите.
        /// </summary>
        private void SetupDataGridView()
        {
            dataGridViewPlanets.Columns.Clear();

            dataGridViewPlanets.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Name", DataPropertyName = "Name" });
            dataGridViewPlanets.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Star System", DataPropertyName = "StarSystem" });
            dataGridViewPlanets.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Distance", DataPropertyName = "DistanceFromEarth" });
            dataGridViewPlanets.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Type", DataPropertyName = "Type" });
            dataGridViewPlanets.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mass", DataPropertyName = "Mass" });
            dataGridViewPlanets.Columns.Add(new DataGridViewCheckBoxColumn { HeaderText = "Atmosphere", DataPropertyName = "HasAtmosphere" });
        }

        /// <summary>
        /// Презарежда DataGridView с текущия списък от планети.
        /// </summary>
        private void RefreshGrid()
        {
            var planets = repo.GetAll() ?? new List<Interfaces.IPlanet>();
            dataGridViewPlanets.DataSource = null;

            if (planets.Count > 0)
            {
                dataGridViewPlanets.DataSource = planets;
                dataGridViewPlanets.ClearSelection();
            }
            else
            {
                dataGridViewPlanets.ClearSelection();
            }
        }

        /// <summary>
        /// Връща планетата, която е избрана в DataGridView.
        /// </summary>
        /// <returns>Избраният обект <see cref="IPlanet"/> или <c>null</c>, ако няма избрана планета.</returns>
        private Interfaces.IPlanet GetSelectedPlanet()
        {
            if (dataGridViewPlanets.SelectedRows.Count > 0 &&
                dataGridViewPlanets.SelectedRows[0].Index >= 0 &&
                dataGridViewPlanets.SelectedRows[0].DataBoundItem != null)
            {
                return (Interfaces.IPlanet)dataGridViewPlanets.SelectedRows[0].DataBoundItem;
            }
            return null;
        }

        /// <summary>
        /// Обработва натискането на бутона за добавяне на нова планета.
        /// Отваря <see cref="AddPlanetForm"/> и, ако потребителят потвърди, добавя планетата в репозитория и обновява DataGridView.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPlanetForm addForm = new AddPlanetForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                repo.AddPlanet(addForm.NewPlanet);
                RefreshGrid();
            }
        }

        /// <summary>
        /// Обработва натискането на бутона за редактиране на избрана планета.
        /// Отваря <see cref="EditPlanetForm"/> и обновява DataGridView при потвърждение.
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Interfaces.IPlanet selected = GetSelectedPlanet();
            if (selected != null)
            {
                EditPlanetForm editForm = new EditPlanetForm(selected);
                if (editForm.ShowDialog() == DialogResult.OK)
                    RefreshGrid();
            }
            else
            {
                MessageBox.Show("Choose a row for edit.", "Attention");
            }
        }

        /// <summary>
        /// Обработва натискането на бутона за изтриване на избрана планета.
        /// Потвърждава действието и премахва планетата от репозитория при потвърждение.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Interfaces.IPlanet selected = GetSelectedPlanet();
            if (selected != null)
            {
                var result = MessageBox.Show($"Are you sure you want to delete {selected.Name}?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    repo.RemovePlanet(selected);
                    RefreshGrid();
                }
            }
            else
            {
                MessageBox.Show("Please, choose a row for deletion.", "Attention");
            }
        }

        /// <summary>
        /// Обработва натискането на бутона за сортиране на планетите по разстояние от Земята.
        /// </summary>
        private void btnSort_Click(object sender, EventArgs e)
        {
            repo.Sort((a, b) => a.DistanceFromEarth.CompareTo(b.DistanceFromEarth));
            RefreshGrid();
        }

        /// <summary>
        /// Обработва натискането на бутона за търсене на планета по име.
        /// Показва информация за планетата чрез <see cref="IPrintable.GetPrintableInfo"/>.
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Input a name for search.", "Attention");
                return;
            }

            Interfaces.IPlanet found = repo.FindByName(name);
            if (found != null)
                MessageBox.Show((found as IPrintable).GetPrintableInfo(), "Planet found");
            else
                MessageBox.Show("A planet with this name was not found.", "Result");
        }
    }
}
