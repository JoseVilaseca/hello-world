// Ignacio Martínez //
using System;
using System.Linq;

namespace lol
{
    
    class Program{
       static void Main2(){
           string error;
           Person john = new Person("John Doe","Hola");
           Person jane = new Person("Jane Doe", "8.765.432-1");
           john.IntroduceYourself();
           jane.IntroduceYourself();
           Console.WriteLine(john.validarFormatoCI("52466137",out error));
       }

        
    }
}
        

    
    

    

