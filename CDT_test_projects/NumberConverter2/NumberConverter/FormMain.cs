using System;
using System.Windows.Forms;

namespace NumberConverter
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            long number = 0;

            if (long.TryParse(textBoxNumber.Text, out number))
            {
                Converter con = new Converter();
                MessageBox.Show(con.Convert(number));
            }
            else
            {
                MessageBox.Show(string.Format("{0} is not a valid number", textBoxNumber.Text));
            }
        }
    }
}
