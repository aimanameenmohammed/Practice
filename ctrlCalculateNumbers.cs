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
    public partial class ctrlCalculateNumbers : UserControl
    {
        public ctrlCalculateNumbers()
        {
            InitializeComponent();
        }


        public class CalculationCompletedEventArgs:EventArgs
        {

            public float Result {  get; set; }
            public float Value1 { get; set; }
            public float Value2 { get; set; }
            public float Value3 { get; set; }


           public CalculationCompletedEventArgs(float Result,float Value1,float Value2)
            {

                this.Result = Result;
                this.Value1 = Value1;   
                this.Value2 = Value2;   

            }

        }

        public event EventHandler<CalculationCompletedEventArgs>OnCalclulationSelected;


        protected virtual void RaiseOnCalculationCompleted(CalculationCompletedEventArgs e)
        {

            OnCalclulationSelected?.Invoke(this, e);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float Result = (Convert.ToSingle(textBox1.Text) + Convert.ToSingle(textBox2.Text));

            textBox3.Text= Result.ToString();

            RaiseOnCalculationCompleted(new CalculationCompletedEventArgs(Result, Convert.ToSingle(textBox1.Text), Convert.ToSingle(textBox2.Text)));


        }
    }
}
