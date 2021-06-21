using System;
using System.Threading;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            classe obj = new classe();
            obj.func();
        }
    }
    class classe {
        private int[,] var = new int[1000,1000];
        private int i=0,j=0,i1=0, j1=0, i2=0, j2=0,aux=0, val=1, v=1;
        public classe() {
            for(i=0;i<100;i++) {
            for(j=0;j<100;j++) {
                var[i,j]=0;
                }
            }
        }
        
        public void func() {
        for(i1=0;i1<7;i1++) {     //define o valor de contagem, recomendado valores entre 3 e 10
            for(j1=0;j1<=0;j1++) {
                while(aux<10) {
                    aux++;
                    for(i=0;i<v;i++) {
                        for(j=0;j<=i;j++) {
                            if(v<4) {
                                print(v);
                                Thread.Sleep(80);
                                Console.Clear();
                            }
                    var[i,j]++;
                    if(var[i,j]>9) {
                        var[i,j] = 0;
                    }
                        }
                        if(v>=3) {
                                print(v);
                                Thread.Sleep(30);
                                Console.Clear();
                            }
                    }
                }
                aux=0;
            }
            v++;
            Thread.Sleep(300);
        }
    }
        public void print(int val) {
            for(i2=0;i2<val;i2++) {
                for(j2=0;j2<=i2;j2++) {
                    if(val<4) {
                        Thread.Sleep(((200)/(val*val*val*val*val*val*val*val*val))); 
                    } 
                Console.Write(var[i2,j2] + " ");      
        }
        Console.WriteLine("");
    }
    val=val*30;
}
    }
}


