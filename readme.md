## Práctica: Introducción a los scripts de Unity

Nombre: Aram Pérez Dios  
Correo: alu0101244488@ull.edu.es  
Universidad: Universidad de La Laguna 
Asignatura: Interfaces Inteligentes
Grupo: PE102  



### Ejercicio 1

Se han implementado los tres objetos requeridos para la primera escena (Esfera, cubo y plano).
En los siguientes gif se pueden varias de las distintas ejecuciones con cada una de las restricciones.

![]()
![]()
![]()
![]()
![]()
![]()
![]()

### Ejercicio 2

Se ha implemenado al personaje utilizando los ejes horizontal y vertical utilizando las teclas wasd y eliminando
las entradas de las flechas desde el input manager. También se ha añadido la rotación en el eje y empleando el eje x
del ratón. Este movimiento se encuentra implementado en el script **characterController.cs**.

![]()


### Ejercicio 2

Por último nos encontramos con la implementación de distintos elementos. Estos se encuentran por orden de 
implementación en:

- Cilindros que aumentan de tamaño al colisionar en **objectCollision.cs** y aumentar la puntuación en **scoreCalculator.cs**
- Barra espaciadora para mover hacia fuera a varios cilindros **pusButton.cs**
- Cilindros que se alejan al acercarse a ellos **push.cs**
- Objeto que se mueva con las teclas imjl y que sea capaz de detectar colisiones **characterController2.cs**
- Cubo que reduce su tamaño cuando el jugador se acerca y aumenta cuando se acerca una esfera **sizeCollision.cs**

Aquí se muestra una ejecución al compleo del proyecto:

![]()

