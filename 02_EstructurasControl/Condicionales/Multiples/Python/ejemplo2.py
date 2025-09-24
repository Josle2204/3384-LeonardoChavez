print("Calificaciones:")
print("A > Excelente")
print("B > Notable")
print("C > Aprobado")
print("D > Insuficiente")
print("F > Reprobatorio")

nota = input("Ingrese una letra de calificación: ").upper()

if nota == "A":
    print("Su nota es Excelente")
elif nota == "B":
    print("Su nota es Notable")
elif nota == "C":
    print("Su nota es Aprobado")
elif nota == "D":
    print("Su nota es Insuficiente")
elif nota == "F":
    print("Su nota es Reprobatorio")
else:
    print("Opcion no valida")

input()