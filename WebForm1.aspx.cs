using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clase29
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnnum1_Click(object sender, EventArgs e)
        {
            int numero,val=0;
            string todos="" ,valores="";
            Random llenar = new Random();
            numero = Convert.ToInt32(txtnum1.Text);

            int[] vector = new int[100];
            for (int i = 0; i <= 99; i++)
            {
                
                vector[i] = llenar.Next(1,100)+1;
                todos = todos +","+ vector[i];
                if (numero == vector[i])
                {
                    val = val + i;
                    valores = valores + "," + i;
                    lblresultado.Text =System.Convert.ToString(valores);
                }
                else if(val==0)
                {
                    lblresultado.Text ="el numero no esta en ninguna posicion";
                }



             }

            lblresultado2.Text =System.Convert.ToString(todos) ;
           




        }
    }
}