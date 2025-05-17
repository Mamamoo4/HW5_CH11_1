using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH_11_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int intValue = 5;
            double doubleValue = 5.5;

            int intCube = Algebra.Cube(intValue);
            double doubleCube = Algebra.Cube(doubleValue);

            label1.Text = ($"整數立方 : {intValue} 的立方是 {intCube}\n" +
                            $"浮點數立方 : {doubleValue} 的立方是 {doubleCube}");
                      

            int min3 = Algebra.MinElement(10, 5, 8);
            int min4 = Algebra.MinElement(15, 9, 12, 7);

            label2.Text = ($"三個數中的最小值 : 10, 5, 8 中的最小值是 {min3}\n" +
                            $"四個數中的最小值 : 15, 9, 12, 7 中的最小值是 {min4}");
        }
    }
}
