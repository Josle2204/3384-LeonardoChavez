#Ejemplo 2 C# -- Secuenciales
#Calcular area de un terrero rectangular

print("Ingrese su ancho del terreno en m:")
ancho = float(input())        #'ancho' declarado como float -- Solicitando el valor

print("Ingrese su largo del terreno en m:")
largo = float(input())      #'largo' declarado como float -- Solicitando el valor

#Formula
area = ancho * largo

#impresion
print(f"Su area del terreno es de {area} m2")

input()     #pausa para que no se cierre automaticamente