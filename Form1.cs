using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string LoggR = "inspector";
            string PassR = "inspector";
            if (login.Text != LoggR || pass.Text != PassR)
            {
                MessageBox.Show("ошибка входа!");
            }
            else
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.Table_1". При необходимости она может быть перемещена или удалена.
            this.table_1TableAdapter.Fill(this.baseDataSet.Table_1);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
