using System;
using static System.Console;
using System.Linq;

             //classe
              public class mensagem{

            /* propriedade da classe -> textoMensagem
            public -> modificador de acesso, torna a propriedade utilizavel/acessavel 
            se nao colocar o public significa que o recurso é privado e logo não consegue interagir com outro, apenas com ele msmo, importante colocar na classe tbm */
            private string textoMensagem;

            /* função/método usado para executar uma ação 
            no caso a função de exibir a mensagem do objeto
            */
            public void exibirMensagem(){
                /* o - this. - é usado para interagir com coisas que pertencem ao objeto, quando colocado o ponto depois do this eu posso ver tudo que o objeto possui */ 
                WriteLine(this.textoMensagem);
                                 }
            //método de acesso para podermos utilizar a propriedade privada
            // get -> "pega" o valor da propriedade
            public string gettextoMensagem(){
                //this interage com objeto
                //return devolve para quem utilizar o método "gettextoMensagem"
                return this.textoMensagem;
            }

            //set -> "armazena" um valor a propriedade
            // o método receberá como parametro o valor que eu vou adicionar dentro da propriedade
            public void settextoMensagem(String valor){
                   // a propriedade recebe o valor recebido atraves do parametro 
                   // assim pode-se realizar ações que o usuario nem ficará sabendo!
                    this.textoMensagem = valor;
            }
        }
