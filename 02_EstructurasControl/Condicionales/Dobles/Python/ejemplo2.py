#Cada libro en una libreria sale a  S/13.
#Si compras más de 5 libros cada libro te sale a S/10.

#Definir y solicitar numero de libros comprados
print("Escriba la cantidad de libros a comprar:")
num = int(input())

#Usando condicional doble
if num >= 5:
    print("Obtuvo una oferta, ahora cada libro le cuesta S/10")
    print(f"El total a pagar es de S/{num*10}")
else:
    print("Cada libro le cuesta S/13")
    print(f"El total a pagar es de S/{num*13}")

#Pausa para que no se cierre automaticamente
print()