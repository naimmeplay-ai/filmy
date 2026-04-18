using Filmz.service;
namespace Filmz.formz
{
    public partial class FoundInfoz : Form
    {
        public FoundInfoz()
        {
            InitializeComponent();
            UpdateInfoz();
        }
        private void UpdateInfoz()
        {
            dataGridView1.DataSource = Found.FoundInfo(textBox1.Text, textBox3.Text, textBox2.Text);
        }
        private void TextChangeds(object sender, EventArgs e)
        {
            UpdateInfoz();
        }
    }
}
