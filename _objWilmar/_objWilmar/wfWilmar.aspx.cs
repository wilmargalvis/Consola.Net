using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades_Negocio;

namespace _objWilmar
{
    public partial class wfWilmar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack) {


                clsPersona wilmar = new clsPersona();

                wilmar.Nombre = "Wilmar Galvis";
                wilmar.Edad = 15;
                wilmar.habilidades = new[] { "desarrollo", "musica", "liderazgo", "etc" };
                wilmar.ToString();
                Response.Write("Nombre" + wilmar.Nombre + "<br>" + "Edad" + wilmar.Edad + "<br>" + "Habilidades" + wilmar.habilidades.ToString());

                List<clsPersona> lista = new List<clsPersona>();
                clsPersona Persona = new clsPersona();
                Persona.Nombre = "maria";
                Persona.Edad = 28;

                lista.Add(Persona);
                lista.Add(new clsPersona());
                lista.Add(new clsPersona() { Nombre = "nelson ", Edad = 17 });

                // Usando inicializadores de colecciones :

                List<clsPersona> Persona2 = new List<clsPersona>
                {
                    new clsPersona(){ Nombre = "Title", Edad=15 },
                    new clsPersona(){ Nombre = "Title", Edad=17},
                    new clsPersona(){ Nombre = "Title", Edad=20 }
                };

                //foreach (clsWilmar yo in wilmar)
                //{

                //}
                //-------------------------------------------

            }
        }

        clsPersona[] persona = new clsPersona[]
        {
                new clsPersona {Nombre="norbey",Edad=15, habilidades= new string [] {"piano","bate","guita"} },
                new clsPersona {Nombre="angie",Edad=15, habilidades= new string [] {"bate","congas","violin"} },
                new clsPersona {Nombre="sebas",Edad=15, habilidades= new string [] {"congas","ss","dd"} }
         };

        public IEnumerable<clsPersona> obtenerRegistrosPersona()
        {
            return persona;
        }

        protected void Press_Click(object sender, EventArgs e)
        {
            foreach (clsPersona persona in obtenerRegistrosPersona())
            {
                Response.Write("Nombre: " + persona.Nombre + "<br> " + "Edad: " + persona.Edad + " <br> "
                          + "habilidades " + persona.habilidades + "<br> " + "<br>" + "-----" + "<br>");
            }
        }

    }
}