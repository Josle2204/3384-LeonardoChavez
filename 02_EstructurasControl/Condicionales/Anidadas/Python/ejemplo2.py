# Un sistema de transporte cobra pasajes según la edad de la persona y el tipo de viaje
# Si la edad es menor a 0 o mayor a 120 → mostrar "Edad inválida"

# Si la persona es menor de 18 años:
# Si el viaje es urbano, el pasaje cuesta S/ 2
# Si el viaje es rural, el pasaje cuesta S/ 5

# Si la persona es 18 años o más:
# Si el viaje es urbano, el pasaje cuesta S/ 3
# Si el viaje es rural, el pasaje cuesta S/ 7



# Definir edad, viaje y solicitar los datos
print("Ingrese su edad")
edad = int(input())

#Usando Condicional anidada:
if edad > 120 or edad < 0:
    print("Edad Invalida")
    