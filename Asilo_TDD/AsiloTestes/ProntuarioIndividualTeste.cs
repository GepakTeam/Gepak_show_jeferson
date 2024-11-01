using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AsiloTestes
{
    
    public class ProntuarioIndividualTeste
    {
        [Fact]
        public void Check_Gender_Masculino_Ok() 
        {



            //Arrange (Instancia)

            //var prontIndividual = new ProntuarioIndividual();
            bool gender = false;


            //Act (Valor)



            //Asset (Resultado)
            Assert.False(gender);

        }
    }
}
