using System;

class HelloWorld {

  static void Main() {

      int cont=1, cont_max = 0;

      ulong i=1, x=0, max_number = 1;

      while(i<1000001) {

          //poderia ser usado um if dessa forma abaixo para encurtar o tempo para o calculo

          //porem o exercicio menciona o range (1 <= numero <= 1000000), entao nao utilizei

          //if(i>837790) { 

        x = i;

        cont = 1;

        while(x != 1) {

        if(x%2==0) {

            x=x/2;

        }

        else {

            x = 3*x+1;

        }

        cont++;

    }

    

    if(cont_max<=cont) {

        max_number = i;

        cont_max = cont;

    }

          //}

    i++;

      }

      Console.WriteLine("Maior sequencia: " + cont_max);

      Console.WriteLine("Numero maximo: " + max_number);

  }

}


//Gabriel Hortmann