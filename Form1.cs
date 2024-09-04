using System;
using System.Windows.Forms;

namespace SobrecargaMetodos_2025_I
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private float Suma(float sumando1,float sumando2)
        {
            return sumando1 + sumando2;
        }

        private float Suma(float sumando1, 
            float sumando2, 
            float sumando3)
        {
            return sumando1 + sumando2 + sumando3;

        }


        private void btnSum1_Click(object sender, EventArgs e)
        {
          float suma=Suma( float.Parse(  txtbSumando1.Text)
              , float.Parse(txtbSumando2.Text) );

            lbResult1.Text = suma.ToString();

        }

        private void btnSum2_Click(object sender, EventArgs e)
        {
            float suma = Suma(float.Parse(txtbSumando21.Text)
                , float.Parse(txtbSumando22.Text), float.Parse(txtbSumando23.Text));

            lbResult2.Text = suma.ToString();

        }
    }
}
