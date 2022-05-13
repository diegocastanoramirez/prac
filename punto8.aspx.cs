using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clase29
{
    public partial class punto8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnnum1_Click(object sender, EventArgs e)
        {
            string mostrar="";
            float numeros, o = 0;
            int tamano,contador=0;
            tamano = Convert.ToInt32(txtvector.Text);
            float[] vector = new Single[tamano];

            for (int i=0;i<vector.Length;i++) {
                numeros = Convert.ToSingle(Microsoft.VisualBasic.Interaction.InputBox("ingrese datos del vector"));
                vector[i] = numeros;
                mostrar = mostrar + "," + vector[i];

               
                if (vector[i] > o) {

                    contador = contador + 1;

                
                }

                o = vector[i]+o;
            }
            if (contador == tamano)
            {
                lblascendente.Text = ("es ascendente " + mostrar);
            }
            else
            {
                lblascendente.Text = ("no es ascendente"+mostrar);
            }


        }
    }
}