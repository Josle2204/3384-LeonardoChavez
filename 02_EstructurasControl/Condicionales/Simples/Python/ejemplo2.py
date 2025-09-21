#Condicionales -- Simples // Ejemplo 2
#Saludar solo si el usuario ingresado es 'admin'

print("Ingrese el nombre de usuario:")      #Solicitando el usuario
user = input().lower()      #Declarando 'user'

#Condicional simple
if user == "admin":
    print("¡Tenga un bonito dia!")
    
#pausa para que no se cierre automaticamente
input()