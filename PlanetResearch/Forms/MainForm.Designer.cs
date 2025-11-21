using System;
using System.Windows.Forms;

namespace PlanetResearch.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private DataGridView dataGridViewPlanets;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSort;
        private Button btnSearch;
        private TextBox txtSearch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewPlanets = new DataGridView();
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            this.btnDelete = new Button();
            this.btnSort = new Button();
            this.txtSearch = new TextBox();
            this.btnSearch = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanets)).BeginInit();
            this.SuspendLayout();

            this.dataGridViewPlanets.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPlanets.Size = new System.Drawing.Size(600, 250);
            this.dataGridViewPlanets.ReadOnly = true;
            this.dataGridViewPlanets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPlanets.MultiSelect = false;
            this.dataGridViewPlanets.AllowUserToAddRows = false; 
            this.Controls.Add(this.dataGridViewPlanets);

            this.dataGridViewPlanets.CellMouseDown += (s, e) =>
            {
                if (e.RowIndex >= 0 &&
                    e.RowIndex < dataGridViewPlanets.Rows.Count &&
                    !dataGridViewPlanets.Rows[e.RowIndex].IsNewRow)
                {
                    dataGridViewPlanets.ClearSelection();
                    dataGridViewPlanets.Rows[e.RowIndex].Selected = true;
                }
                else
                {
                    dataGridViewPlanets.ClearSelection();
                }
            };

            this.btnAdd.Location = new System.Drawing.Point(630, 12);
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);

            this.btnEdit.Location = new System.Drawing.Point(630, 60);
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new EventHandler(this.btnEdit_Click);

            this.btnDelete.Location = new System.Drawing.Point(630, 108);
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);

            this.btnSort.Location = new System.Drawing.Point(630, 156);
            this.btnSort.Size = new System.Drawing.Size(100, 30);
            this.btnSort.Text = "Sort by Distance";
            this.btnSort.Click += new EventHandler(this.btnSort_Click);

            this.txtSearch.Location = new System.Drawing.Point(12, 280);
            this.txtSearch.Size = new System.Drawing.Size(350, 22);

            this.btnSearch.Location = new System.Drawing.Point(380, 278);
            this.btnSearch.Size = new System.Drawing.Size(120, 26);
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new EventHandler(this.btnSearch_Click);

            this.ClientSize = new System.Drawing.Size(750, 320);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Text = "Planet Research Database";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
