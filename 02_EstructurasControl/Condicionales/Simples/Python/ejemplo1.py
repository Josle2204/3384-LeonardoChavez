#Condicionales -- Simples // Ejemplo 1
#Hacer descuento del 10% solo si la compra es >= a S/1000

print("Ingrese el valor de su compra")      #Ingresar valor
valor = float(input())      #Declarar 'valor' y que lo ingrese el ususario

#Usando el condicional Simple y formula
if valor >= 1000:
    valor = (0.9*valor)
    print(f"Tiene un descuento del 10% y deberá pagar S/{valor}")

#pausa para que no se cierre automaticamente
input()