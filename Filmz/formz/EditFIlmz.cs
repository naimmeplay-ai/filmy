using Filmz.bd;
using Filmz.service;
namespace Filmz.formz
{
    public partial class EditFIlmz : Form
    {
        public Film filmz;
        public EditFIlmz(Film filmInfo)
        {
            InitializeComponent();
            filmz = filmInfo;
            LoadData();
        }
        private void LoadData()
        {
            textBox1.Text = filmz.Name;
            textBox3.Text = filmz.Author;
            textBox2.Text = filmz.Type;
            dateTimePicker1.Value = filmz.DateRel;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var updateFilmz = new Film
            {
                Id = filmz.Id,
                Name = textBox1.Text,
                Author = textBox3.Text,
                Type = filmz.Type,
                DateRel = dateTimePicker1.Value
            };
            if (Editz.EditFilmz(updateFilmz) == true)
            {
                this.Close();
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsLetter(ch) && ch != 8 && ch != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
