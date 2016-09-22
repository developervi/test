using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button_test
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Web ss = new Web();
               ss.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fPPDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fPPDataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.fPPDataSet1.Table);

        }
    }
}
