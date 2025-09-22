#Mostrar si el numero ingresado es par o impar
        
#Definir y solicitar valor del numero entero:
print("Ingrese un numero entero: ")
num = int(input())

#Usando condicional doble:
if num % 2 == 0:
    print(f"Su numero {num} es par")
else:
    print(f"Su numero {num} es impar")

#Pausa para que no se cierre
input()