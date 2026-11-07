# ACA -- Programación Avanzada

# Sistema de Gestión de Biblioteca

------------------------------------------------------------------------

## PORTADA

**\[CUN CORPORACIÓN UNIFICADA NACIONAL DE EDUCACIÓN SUPERIOR\]**

**\[INGENIERÍA DE SISTEMAS / PROGRAMACIÓN AVANZADA\]**

### ACA -- Programación Avanzada

### Sistema de Gestión de Biblioteca

**Presentado por:**\
\[ANIBAL GALINDO AGUILERA\]

**Docente:**\
\[VERONICA CASTRO MUNAR\]

**Fecha:**\
\[CAQUEZA, 8 NOVIEMBRE 2026\]


# CONTRAPORTADA

**Sistema de Gestión de Biblioteca**

Proyecto desarrollado como evidencia del curso de **Programación
Avanzada**, aplicando Programación Orientada a Objetos, base de datos
relacional, arquitectura por capas, operaciones CRUD, validaciones,
manejo de excepciones y conexión con SQL Server.

**Estudiante(s):** \[ANIBAL GALINDO AGUILERA\]\
**Programa:** \[INGENIERÍA DE SISTEMAS\]\
**Grupo:** \[54463\]\
**Docente:** \[VERONICA CASTRO MUNAR\]\
**Institución:** \[CUN CORPORACION UNIFICADA NACIONAL DE EDUCACIÓN SUPERIOR\]\
**Año:** \[2026\]

------------------------------------------------------------------------

# TABLA DE CONTENIDO


1.  Introducción
2.  Objetivos
    -   2.1 Objetivo general
    -   2.2 Objetivos específicos
3.  Planteamiento del problema
4.  Análisis de requerimientos
5.  Casos de uso
6.  Diagrama de clases
7.  Modelo entidad-relación
8.  Diccionario de datos
9.  Arquitectura del sistema
10. Explicación de los módulos desarrollados
11. Capturas de pantalla del sistema
12. Pruebas de funcionamiento
13. Conclusiones
14. Recomendaciones
15. Referencias bibliográficas

------------------------------------------------------------------------

# 1. INTRODUCCIÓN



El objetivo del presente proyecto es integrar los fundamentos básicos 
de la programación orientada a objetos y los diferentes paradigmas del 
desarrollo de software, estableciendo principios de responsabilidad única
para cada función del programa, Es un sistema de gestión de una librería
donde se pueden realizar diferentes acciones como consultar, borrar, crear 
e insertar datos llevando esto a enlazar el proyecto a una base de datos
creada en SQL Server para poder generar persistencia.

Se abordan conceptos importantes como el modelo entidad-relación, 
diagramas de clases y casos de uso para entender la importancia del 
modelado previo y el análisis óptimo de requisitos tanto funcionales 
como no funcionales para entregar un producto intuitivo para el usuario, 
También se utiliza Windows Forms para crear el entorno gráfico y C# para 
la programación.


------------------------------------------------------------------------

# 2. OBJETIVOS

## 2.1 Objetivo general

Desarrollar un Sistema de Gestión de Biblioteca que permita realizar
consultas, editar registros, agregar o eliminar usuarios, utilizando 
Programación Orientada a Objetos, una base de datos relacional y una 
arquitectura por capas, combinando conceptos avanzados como abstracción,
herencia y polimorfismo, y señalar la importancia del DevOps en la nueva
forma de implementar soluciones en el diseño de software.

## 2.2 Objetivos específicos

-   Diseñar e implementar una aplicación de escritorio para la gestión
    de libros, autores, usuarios y demás registros.
-   Aplicar principios de Programación Orientada a Objetos.
-   Diseñar e implementar una base de datos relacional en SQL Server.
-   Implementar operaciones CRUD para las entidades principales.
-   Implementar validaciones de datos.
-   Implementar manejo de excepciones.
-   Aplicar una arquitectura por capas.
-   Implementar consultas que faciliten la administración de la
    biblioteca.
-   Utilizar Git y GitHub para el control de versiones.
-   Documentar técnica y funcionalmente el proyecto.
-   Entender el modelo de Sprints para la genereación de proyectos.
-   Relacionar la funcinalidad del programa con la base de datos.
-   Modelar los diagramas para un mejor entendimiento de la funcionalidad.

------------------------------------------------------------------------

# 3. PLANTEAMIENTO DEL PROBLEMA

## 3.1 Descripción del problema

La institución educativa requiere un programa interactivo e intuitivo
que pueda gestionar y administrar las transacciones generadas dentro
de nuestra biblioteca entre ellas la de registrar nuevos usuarios,
nuevos libros y nuevos autores de manera organizada, también que se 
pueda visualizar de una manera confiable.

También se requiere que los datos ingresados tengan cierta seguiridad 
e integridad.


## 3.2 Justificación

La organización y la fácil administración de los datos son 
indispensables para cualquier organización por lo cual proponemos 
un sistema sencillo pero totalmente funcional segmentando las 
responsabilidades funcionales de cada clase y combinando modelos
y paradigmas de POO para optimizar y generar optimización de
recursos.

## 3.3 Alcance

El sistema permitirá:

-   Gestionar libros.
-   Gestionar autores.
-   Gestionar editoriales.
-   Gestionar usuarios.
-   Registrar préstamos.
-   Registrar devoluciones.
-   Consultar disponibilidad.
-   Consultar historial de préstamos.
-   Integrar todos los cambios de manera persistente en una base de datos.

## 3.4 Fuera Del Alcance

-   Poner Multas y calcular el valor de las mismas.
-   Registrar y crear categorías.

------------------------------------------------------------------------


# 4. ANÁLISIS DE REQUERIMIENTOS

## 4.1 Descripción general

El Sistema de Gestión de Biblioteca permitirá administrar la información
relacionada con libros, autores, editoriales y controlar los procesos de
préstamos, devoluciones y consultas.

## 4.2 Actores del sistema

  -----------------------------------------------------------------------
  Actor                               Descripción
  ----------------------------------- -----------------------------------
  Bibliotecario / Administrador       Administrar inventario de libros, 
                                      crear usuarios, actualizar autores
                                      y editoriales, consultar devoluciones.
  -----------------------------------------------------------------------


## 4.3 Requerimientos funcionales

  -----------------------------------------------------------------------
  Código                  Requerimiento           Descripción
  ----------------------- ----------------------- -----------------------
  RF01                    Gestionar libros        Registrar, consultar,
                                                  actualizar, eliminar y
                                                  buscar libros.

  RF02                    Gestionar autores       Registrar, consultar,
                                                  actualizar y eliminar
                                                  autores.

  RF03                    Gestionar usuarios      Registrar, consultar,
                                                  actualizar y eliminar
                                                  usuarios.

  RF04                    Registrar préstamos     Registrar préstamos y
                                                  actualizar la
                                                  disponibilidad de los
                                                  libros.

  RF05                    Registrar devoluciones  Registrar devoluciones,
                                                  calcular retrasos y
                                                  multa cuando aplique.

  RF06                    Realizar consultas      Consultar libros
                                                  disponibles, libros
                                                  prestados, historial y
                                                  usuarios con préstamos
                                                  activos.

  RF08                    Actualizar fechas       Realizar actualización 
                                                  de fechas de antrega.
  -----------------------------------------------------------------------


## 4.4 Requerimientos no funcionales

  -----------------------------------------------------------------------
  Código                  Requerimiento           Descripción
  ----------------------- ----------------------- -----------------------
  RNF01                   Usabilidad              La interfaz debe ser
                                                  clara, sencilla y fácil
                                                  de utilizar.

  RNF02                   Validación              El sistema debe validar
                                                  la información
                                                  ingresada por el
                                                  usuario.

  RNF03                   Mantenibilidad          El código debe estar
                                                  organizado y
                                                  documentado.

  RNF04                   Arquitectura            El sistema debe
                                                  utilizar una
                                                  arquitectura por capas.

  RNF05                   Manejo de excepciones   Las operaciones deben
                                                  manejar errores de
                                                  forma controlada.

  RNF06                   Integridad de datos     La información debe
                                                  mantenerse consistente
                                                  en la base de datos.

  RNF07                   Consultas               Las consultas a la base
                          parametrizadas          de datos deben utilizar
                                                  parámetros.
  -----------------------------------------------------------------------

## 4.5 Reglas de negocio

### RN01 -- Código único del libro

No se permitirá registrar dos libros con el mismo código.

### RN02 -- Datos obligatorios

No se permitirá almacenar registros con campos obligatorios vacíos.

### RN03 -- Usuario existente

No se podrá registrar un préstamo para un usuario inexistente.

### RN04 -- Libro existente

No se podrá registrar un préstamo para un libro inexistente.

### RN05 -- Disponibilidad

No se podrá prestar un libro cuando no existan ejemplares disponibles.

### RN06 -- Actualización de disponibilidad

Al registrar un préstamo, la disponibilidad del libro deberá
actualizarse.

### RN07 -- Devolución

Al registrar una devolución, la disponibilidad deberá actualizarse
nuevamente.

------------------------------------------------------------------------

# 5. CASOS DE USO

## 5.1 Descripción

El administrador o bibliotecario podrá realizar diferentes acciones como gestionar cada uno de los libros, usuarios y autores igualmente que realizar
consultas en las diferentes opciones de préstamo.

## 5.2 Diagrama de casos de uso


![Casos De Uso](<Imágenes de Análisis/Diagrama De Casos De Uso - Biblioteca .png>)


## 5.3 Descripción de casos de uso

### CU01 -- Gestionar libros

**Actor principal:** Bibliotecario / Administrador

**Descripción:** Permite registrar, consultar, actualizar, eliminar y
buscar libros.

**Precondiciones:** - El usuario debe tener acceso al sistema. - \[Otra
precondición.\]

**Flujo principal:** 1. El actor ingresa al módulo de libros. 2. El
sistema muestra los libros registrados. 3. El actor selecciona la
operación que desea realizar. 4. El sistema procesa la solicitud. 5. El
sistema muestra el resultado.

**Flujos alternativos:** - \[Describir errores o situaciones
alternativas.\]

**Postcondiciones:** - \[Indicar el resultado de la operación.\]

------------------------------------------------------------------------

### CU02 -- Registrar préstamo

**Actor principal:** Bibliotecario / Administrador

**Descripción:** Permite registrar el préstamo de uno o varios libros a
un usuario.

**Precondiciones:** - El usuario debe existir. - El libro debe
existir. - Debe existir disponibilidad.

**Flujo principal:** 1. Seleccionar usuario. 2. Seleccionar libro. 3.
Verificar disponibilidad. 4. Registrar préstamo. 5. Actualizar
disponibilidad. 6. Mostrar confirmación.

**Flujos alternativos:** - Usuario inexistente. - Libro inexistente. -
Libro sin disponibilidad. 

**Postcondiciones:** - El préstamo queda registrado. - La disponibilidad
del libro queda actualizada.

------------------------------------------------------------------------

### CU03 -- Registrar devolución

**Actor principal:** Bibliotecario / Administrador

**Descripción:** Permite registrar la devolución de un libro prestado.

**Precondiciones:** - Debe existir un préstamo activo.

**Flujo principal:** 1. Seleccionar el préstamo. 2. Registrar la
devolución. 3. Calcular días de retraso. 5. Actualizar disponibilidad.
 6. Actualizar el estado del préstamo. 7. Mostrar confirmación.

**Flujos alternativos:** - Devolución ya registrada.

**Postcondiciones:** - La devolución queda registrada. - El libro vuelve
a estar disponible según corresponda.

-----------------------------------------------------------------------

# 6. DIAGRAMA DE CLASES

## 6.1 Descripción

Describir las principales clases utilizadas en el sistema y su
responsabilidad.

## 6.2 Diagrama de clases

![Diagrama Clases](<Imágenes de Análisis/Diagrama De Clases - Biblioteca.png>)

## 6.3 Principales clases

  Clase             Responsabilidad
  ----------------- --------------------------------------------------------

  - Libro             Representar y gestionar la información de los libros.
  - Autor             Representar y gestionar los autores.
  - Usuario           Representar los usuarios de la biblioteca.
  - Prestamo          Gestionar la información de los préstamos.
  - DetallePrestamo   Relacionar los libros incluidos en un préstamo.
  - Devolucion        Gestionar las devoluciones y calcular retrasos/multas.

## 6.4 Aplicación de POO

-   Clases: En este proyecto las diferentes clases implementadas fueron 
    del formulario principal clase parcial publica por defecto, en cada
    formulario también se define la clase tanto para la parte funcional
    como para la parte de front-end. También se crea la clase conexión 
    la cual genera la conexión a la base de datos.
-   Objetos: También a partir de cada clase creada se crean objetos para 
    los llamados a la base de datos con new conexion()
-   Constructores: En todo el desarrollo del código se usan constructores
    por ejemplo el contrcutor público de la clase frmAutores donde hace el
    llamado a los métodos creados de incicialización del componente y
    el del método CargarAutores().
-   Métodos: Cada clase en si utiliza métodos creados dentro del código,
    tomando el ejemplo anterior CargarAutores() es un método del formulario
    autores que permite por medio de un try-catch establecer una conexión a 
    la base de datos y traer la información a nuestro data grid view por
    medio de una tabla haciendo una consulta SQL.
-   Propiedades: A cada elemento funcional del proyecto se le dan uso de 
    sus propiedades ejemplo al data grid view dgvAutores cuando le hacemos
    .DataSoruce= 'variable' define la fuente de datos a usar.
-   Encapsulamiento: Cuando estamos iniciando el 
-   Colecciones.
-   Herencia, si aplica.
-   Polimorfismo, si aplica.
-   Sobrecarga, si aplica.

------------------------------------------------------------------------




