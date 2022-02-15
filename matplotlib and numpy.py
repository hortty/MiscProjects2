import matplotlib.pyplot as p
import numpy as n

x = n.arange(0,2.1,0.1)
y = n.sin(n.pi*x)      #funcao seno e pi=3.14159

p.plot(x,y)

p.grid()
p.xlabel('Eixo x')
p.ylabel('Eixo y')
p.show()                #mostrar grafico
