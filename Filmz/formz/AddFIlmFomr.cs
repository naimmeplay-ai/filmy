using Filmz.bd;
using Filmz.service;
namespace Filmz.formz
{
    public partial class AddFIlmFomr : Form
    {
        public AddFIlmFomr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addFilm = new Film
            {
                Name = textBox1.Text,
                Author = textBox3.Text,
                Type = textBox2.Text,
                DateRel = dateTimePicker1.Value.Date
            };
            if (Add.AddFilm(addFilm) == true)
            {

                this.Close();
            }
        }
        private void KeyPresse(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsLetter(ch) && ch != 8 && ch != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
