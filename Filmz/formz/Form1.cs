using Filmz.bd;
using Filmz.formz;
using Filmz.service;
using Microsoft.EntityFrameworkCore;
namespace Filmz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadInfo();
        }
        private void LoadInfo()
        {
            dataGridView1.DataSource = Getz.GetFilmz();
        }
        private void AddBase()
        {
            using var db = new Serivce();
            db.Database.EnsureCreated();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddFIlmFomr addF = new AddFIlmFomr();
            addF.FormClosing += FormsClosing;
            addF.ShowDialog();
        }

        private void FormsClosing(object? sender, FormClosingEventArgs e)
        {
            switch (sender)
            {
                case AddFIlmFomr or EditFIlmz:
                    LoadInfo();
                    break;
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    Rowz(sender as DataGridView, 0);
                    break;
            }
        }
        private void Rowz(DataGridView dataGrid, int typeData)
        {
            int rowIndx = dataGrid.SelectedCells[0].RowIndex;
            var row = dataGrid.Rows[rowIndx];
            var data = row.DataBoundItem;
            if (typeData == 0)
            {
                if (data is Film filmz)
                {
                    Delete.DeteleFilmz(filmz.Id);
                    LoadInfo();
                }
            }
            if (typeData == 1)
            {
                if (data is Film filmz)
                {
                    EditFIlmz editF = new EditFIlmz(filmz);
                    editF.FormClosing += FormsClosing;
                    editF.ShowDialog();
                }
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Rowz(sender as DataGridView, 1);
        }

        private void foundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoundInfoz fi = new FoundInfoz();
            fi.ShowDialog();
        }
    }
}
