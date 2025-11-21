using PlanetResearch.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PlanetResearch.Forms
{
    public partial class MainForm : Form
    {
        private PlanetRepository repo = new PlanetRepository();

        public MainForm()
        {
            this.BackgroundImage = Image.FromFile("8021306cc8a902b61ffd9103ad880118.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            InitializeComponent();
            dataGridViewPlanets.AutoGenerateColumns = false;
            SetupDataGridView();
            RefreshGrid();
        }

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

        private void RefreshGrid()
        {
            var planets = repo.GetAll() ?? new List<Planet>();
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

        private Planet GetSelectedPlanet()
        {
            if (dataGridViewPlanets.SelectedRows.Count > 0 &&
                dataGridViewPlanets.SelectedRows[0].Index >= 0 &&
                dataGridViewPlanets.SelectedRows[0].DataBoundItem != null)
            {
                return (Planet)dataGridViewPlanets.SelectedRows[0].DataBoundItem;
            }
            return null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPlanetForm addForm = new AddPlanetForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                repo.AddPlanet(addForm.NewPlanet);
                RefreshGrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Planet selected = GetSelectedPlanet();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Planet selected = GetSelectedPlanet();
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

        private void btnSort_Click(object sender, EventArgs e)
        {
            repo.Sort((a, b) => a.DistanceFromEarth.CompareTo(b.DistanceFromEarth));
            RefreshGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Input a name for search.", "Attention");
                return;
            }

            Planet found = repo.FindByName(name);
            if (found != null)
                MessageBox.Show(found.GetPrintableInfo(), "Planet found");
            else
                MessageBox.Show("A planet with this name was not found.", "Result");
        }
    }
}
