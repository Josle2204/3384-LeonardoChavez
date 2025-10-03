print("Ingrese la cantidad de numeros a contar N")

n = int(input())

par = 0
impar = 0

for i in range (1, n + 1):

    if (i % 2 == 0):
        par = par + 1
    else:
        impar = impar + 1

print(f"Hay {par} numeros pares")
print(f"Hay {impar} numeros impares")

input()