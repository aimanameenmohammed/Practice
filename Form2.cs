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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        public delegate void DataBackEventHandler(int PersonID);

        public event DataBackEventHandler DataBack;

        private void Form2_Load(object sender, EventArgs e)
        {






        }

        private void SendData_Click(object sender, EventArgs e)
        {
            int PersonID = -1;

            if (int.TryParse(textBox1.Text, out  PersonID))
            {

                DataBack?.Invoke(PersonID);

                this.Close();

            }
            else
            {

            }

        }
    }
}
