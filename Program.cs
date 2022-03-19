using System;
using static System.Console;
using System.Linq;

namespace poo_cs
{
    class Program
    {
        static void Main(string[] args)
        {
           // objeto msg1 esta dentro da classe mensagem
            mensagem msg1, msg2;
            
            // dei "vida" ao objeto msg usando um construtor na classe em que ele esta inserido
            //construtor -> new + nomedaclasse()
    
            msg1 = new mensagem();
            
            /* usei a propriedade para dar uma caracteristica ao objeto msg1
            no caso o objeto terá a propriedade(textoMensagem) de mostrar a mensagem: "alo mundo" */
             // msg1.textoMensagem = "alo mundo"; //

            // como nao pode-se mais ter acesso direto a propriedade usa-se o metodo criado (settextoMensagem) para dar a caracteristica a msg1
             msg1.settextoMensagem("alo mundo");

           // a função/método exibirMensagem fez com que o objeto msg1 mostrasse a mensagem que estava inserida nele atraves da propriedade textoMensagem
            
            msg1.exibirMensagem();

            msg2 = new mensagem();
            msg2.settextoMensagem("segundo objeto");
            msg2.exibirMensagem();

                
              }
    }
}
