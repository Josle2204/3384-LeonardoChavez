print("Menu de opciones:")
print("1. Sumar")
print("2. Restar")
print("3. Multiplicar")
print("4. Dividir")


menu = int(input("Escriba su opción: "))

if 1 <= menu <= 4:

    num1 = int(input("Ingrese el 1er numero: "))
    num2 = int(input("Ingrese el 2do numero: "))

    if menu == 1:
        print(f"Resultado: {num1 + num2}")

    elif menu == 2:
        print(f"Resultado: {num1 - num2}")

    elif menu == 3:
        print(f"Resultado: {num1 * num2}")

    elif menu == 4:
        if num2 != 0:
            print(f"Resultado: {num1 / num2}")
        else:
            print("No se puede dividir entre 0")

else:
    print("Opcion no valida")

input()