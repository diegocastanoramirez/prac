using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clase29
{
    public partial class punto10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            string veca= "", vecb="",vecc="";
            int var;
            var = 20;
            Random aleatora = new Random(); 
            int[] vectorA = new int[20];
            int[] vectorB = new int[20];
            int[] vectorC = new int[20];
            for (int i=0;i<20;i++)
            {
                
                vectorA[i] = aleatora.Next(0,50)+1;
                vectorB[i] = aleatora.Next(0, 50) + 1;

                veca = veca + "," + vectorA[i];
                vecb = vecb + "," + vectorB[i];
            }
          
            for (int i = 0; i < 20; i++)
            {
                var = var - 1;
                vectorC[i] = vectorA[i] * vectorB[var];

               
                vecc = vecc + "," + vectorC[i];
            }
            lblresultado1.Text =Convert.ToString(veca);
            lblresultado2.Text = Convert.ToString(vecb);
            lblresultado3.Text = Convert.ToString(vecc);





        }
    }
}