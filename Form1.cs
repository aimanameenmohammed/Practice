using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        void ShowData(int PersonID)
        {
            textBox1.Text = PersonID.ToString();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            Form2 frm=new Form2();

            frm.DataBack += ShowData;

            frm.ShowDialog();
        }

        private void ctrlCalculateNumbers1_Load(object sender, EventArgs e)
        {




        }

        private void ctrlCalculateNumbers1_OnCalclulationSelected(object sender, ctrlCalculateNumbers.CalculationCompletedEventArgs e)
        {
            textBox1.Text = e.Value1.ToString()+" + "+e.Value2.ToString()+" = "+e.Result.ToString();
        }
    }
}
