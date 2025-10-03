#Tabla de multiplicar del 1 al 12

print("Escriba un numero, escribiremos su tabla de multiplicar")
num = int(input())

for i in range(1,13):
    print(f"{num} x {i} = {num * i}")

print("Se mostro sus 12 multiplicaciones")

input()
