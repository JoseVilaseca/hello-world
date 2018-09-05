using System;
using System.Linq;
namespace lol
{
    public  class Person {
        public string name;
        string id;

        string errormsg;

        public Person(string nick, string id){
            this.name = nick;
             
            if (validarFormatoCI(id, out errormsg)){
                this.id = id;
            }
            else
            {
                this.id = "";
            }
        }
        public void IntroduceYourself(){
            Console.WriteLine($"Mi nombre es: {this.name} y mi ID es: {this.id}.");
        } 
        public bool validarFormatoCI(string ci, out string errorMsg)
        {
		    
            errorMsg = "";

            long verificadorFormato;

            //Validar largo
            if (ci.Length == 8 && long.TryParse(ci, out verificadorFormato))
            {
                var vectorStrCI = ci.ToCharArray();
                var vectorCI = vectorStrCI.Select(c => int.Parse(c.ToString())).ToArray();
                var vectorReferencia = "2987634".ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();

                var verificadorIngresado = vectorCI[7];

                //Calcular número verificador
                int numeroVerificadorRaw = 0;

                for (int i = 0; i < vectorReferencia.Length; i++)
                {
                    numeroVerificadorRaw = numeroVerificadorRaw + (vectorCI[i] * vectorReferencia[i]);
                }

                int verificadorCalculado = 10 - (numeroVerificadorRaw % 10);

                if(verificadorCalculado != verificadorIngresado)
                {
                    errorMsg = "Número verificador ingresado inválido";
                    return false;
                }
            }
            else
            {
                errorMsg = "Formato de cédula de identidad inválido";
                return false;
            }

            return true;
        }
    }
}