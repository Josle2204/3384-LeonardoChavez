# Usando condicional anidadas:
# Si la nota es mayor o igual a 18 → mostrar "Excelente"
# Si la nota está entre 14 y 17 → mostrar "Muy bueno"
# Si la nota está entre 11 y 13 → mostrar "Suficiente"
# Si la nota es menor a 11 → mostrar "Desaprobado"

#Declarar 'num' y solicitar valor al usuario
print("Ingrese su nota (1 - 20):")
num = float(input())

#Condicionales Anidadas
if num > 20:
    print("Nota invalida")
else:
    if num >= 18:
        print("Nota Excelente")
    else:
        if num  >= 14:
            print("Nota Muy Buena")
        else:
            if num >= 11:
                print("Nota Suficiente")
            else:
                if num >= 0:
                    print("Nota Desaprobatoria")
                else:
                    print("Nota invalida")

#Pausa para que no se cierre automaticamente
input()