using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


           bool respuesta= Imprimir("()[]{}");

        }

        private bool Imprimir(string sequence)
        {
            bool valido = true;

            if (sequence.Length == 0)
            { 
            
            
            
            }
            string[] characters = { "(", ")", "[", "]", "{", "}" };

            if (sequence.Length == characters.Length)
            {
                for (int i = 0; i < sequence.Length; i++)
                {

                    
                   
                        if (sequence.Substring(i, 1) != characters[i])
                        {
                            

                        valido = false;
                            break;

                        }
                    
                   
                    


                }
            }
            else {
                valido = false;
            }

            return valido;
            
        }
    }
}