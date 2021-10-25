## Práctica: Introducción a los scripts de Unity

Nombre: Aram Pérez Dios  
Correo: alu0101244488@ull.edu.es  
Universidad: Universidad de La Laguna 
Asignatura: Interfaces Inteligentes
Grupo: PE102  



### Ejercicio 1

Se han implementado los tres objetos requeridos para la primera escena (Esfera, cubo y plano).
En los siguientes gif se pueden varias de las distintas ejecuciones con cada una de las restricciones.

![](https://github.com/alu0101244488/Interfaces-Inteligentes-introduccion-a-los-scripts-de-unity/blob/master/img/1.%20sin%20fisicas.png?raw=true)
![](https://github.com/alu0101244488/Interfaces-Inteligentes-introduccion-a-los-scripts-de-unity/blob/master/img/2.%20esfera%20con%20fisicas.gif?raw=true)
![](https://github.com/alu0101244488/Interfaces-Inteligentes-introduccion-a-los-scripts-de-unity/blob/master/img/3.%20esfera%20y%20cubo%20con%20fisicas.gif?raw=true)
![](https://github.com/alu0101244488/Interfaces-Inteligentes-introduccion-a-los-scripts-de-unity/blob/master/img/4.%20la%20masa%20de%20la%20esfera%20es%2010%20veces%20la%20del%20cubo.gif?raw=true)
![](https://github.com/alu0101244488/Interfaces-Inteligentes-introduccion-a-los-scripts-de-unity/blob/master/img/5.%20esfera%20con%20fisicas%20y%20cubo%20isTrigger.gif?raw=true)
![](https://github.com/alu0101244488/Interfaces-Inteligentes-introduccion-a-los-scripts-de-unity/blob/master/img/6.%20esfera%20con%20fisicas%20y%20cubo%20isTrigger%20con%20fisicas.gif?raw=true)

### Ejercicio 2

Se ha implemenado al personaje utilizando los ejes horizontal y vertical utilizando las teclas wasd y eliminando
las entradas de las flechas desde el input manager. También se ha añadido la rotación en el eje y empleando el eje x
del ratón. Este movimiento se encuentra implementado en el script **characterController.cs**.

![](https://github.com/alu0101244488/Interfaces-Inteligentes-introduccion-a-los-scripts-de-unity/blob/master/img/input%20manager.png?raw=true)

![](https://github.com/alu0101244488/Interfaces-Inteligentes-introduccion-a-los-scripts-de-unity/blob/master/img/7.%20Personaje%20que%20se%20mueve%20con%20las%20teclas%20wasd%20y%20con%20el%20eje%20x%20del%20raton.gif?raw=true)


### Ejercicio 2

Por último nos encontramos con la implementación de distintos elementos. Estos se encuentran por orden de 
implementación en:

- Cilindros que aumentan de tamaño al colisionar en **objectCollision.cs** y aumentar la puntuación en **scoreCalculator.cs**
- Barra espaciadora para mover hacia fuera a varios cilindros **pusButton.cs**
- Cilindros que se alejan al acercarse a ellos **push.cs**
- Objeto que se mueva con las teclas imjl y que sea capaz de detectar colisiones **characterController2.cs**
- Cubo que reduce su tamaño cuando el jugador se acerca y aumenta cuando se acerca una esfera **sizeCollision.cs**

Aquí se muestra una ejecución al compleo del proyecto:

![](https://github.com/alu0101244488/Interfaces-Inteligentes-introduccion-a-los-scripts-de-unity/blob/master/img/8.%20implementacion%20de%20las%20acciones.gif?raw=true)

