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

![requerimientos](<Imágenes de Análisis/Análisis De Requerimientos - Biblioteca.png>)

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
-   Encapsulamiento: Cuando estamos iniciando la programación del formulario 
    de ususarios tenemos la línea  private bool modoEdicion = false; aquí
    se encapsula la variable modoEdición para que otra clase no pueda acceder
    a ella y modificarla.
-   Colecciones: Para el caso de este concepto lo enlazamos con la creación 
    de objetos tipo tabla que almacenan información de manera ordenada, cuando
    creamos un objeto tipo DataTable podemos llenarlo con información traida 
    de la base de datos por medio de un mñetodo y los datos obtenidos se 
    muestran en el data grid view
-   Herencia: En este caso podemos identificar la herencia en la manera que 
    cada formulario creado es heredado de la clase principal por defecto de
    wiondows form ya que cada uno de los que creamos tienen métodos como la
    administración de la ventana,cambio de tamaño, se define cuando vemos
    en una parte del código frmUsuarios :  Form

------------------------------------------------------------------------

# 7. MODELO ENTIDAD-RELACIÓN

## 7.1 Descripción

Se diseña las posibles entidades en la base, podemos definir Autores, Usuarios
editoriales, libros y preñstamos cada una con los atributos necesarios para 
tener información relevante y también enlazar las llaves foráneas según sea el
caso, por ejemplo en la entidad libros exiten dos llaves foráneas la de idAutor
e idEditorial.

## 7.2 Diagrama entidad-relación

![Modelo E-R](<Modelo Entidad-Relación de Biblioteca.png>)


## 7.3 Relaciones principales


-   Un autor puede tener muchos libros.
-   Un usuario puede realizar muchos préstamos.
-   Un libro solo puede tener un autor.
-   Un libro pertenece a una editorial.
-   Un préstamo lo realiza un usuario.

------------------------------------------------------------------------

# 8. DICCIONARIO DE DATOS

![diccionario](<Imágenes de Análisis/Diccionario De Datos - Biblioteca .png>)

## 8.1 Convenciones

  Abreviatura   Significado
  ------------- -----------------------------
  - PK            Clave primaria
  - FK            Clave foránea
  - UQ            Campo con valor único
  - NULL          Campo que puede estar vacío
  - NOT NULL      Campo obligatorio

## 8.2 Tabla: Autor

  Campo             Tipo de dato   Clave   Nulo   Descripción
  ----------------- -------------- ------- ------ --------------------------------
  - idAutor           INT            PK      No     Identificador único del autor.
  - nombre            VARCHAR(100)   \-      No     Nombre del autor.
  - apellidos         VARCHAR(100)   \-      No     Apellidos del autor.

## 8.3 Tabla: Categoria

  Campo         Tipo de dato   Clave   Nulo   Descripción
  ------------- -------------- ------- ------ --------------------------------------


## 8.4 Tabla: Libro

  Campo             Tipo de dato   Clave   Nulo   Descripción
  ----------------- -------------- ------- ------ -----------------------------------
  - idLibro (ISBN)    INT            PK      No     Identificador único del libro.
  - titulo            VARCHAR(200)   \-      No     Título del libro.
  - anioPublicacion   INT            \-      Sí     Año de publicación.
  - idAutor           INT            FK      No     Autor asociado al libro.
  - idEditorial       INT            FK      No     Editorial asociada al libro.
  - categoría         VARCHAR(50)    \-       \-    Categoría asociada a libro.
  - existencias       INT            \-       \-    Cantidad de libros disponibles.

## 8.5 Tabla: Usuario

  Campo             Tipo de dato   Clave   Nulo   Descripción
  ----------------- -------------- ------- ------ ----------------------------------
  - idUsuario         INT            PK      No     Identificador único del usuario.
  - documento         VARCHAR(20)    UQ      No     Número de documento.
  - nombre            VARCHAR(100)   \-      No     Nombre del usuario.
  - apellidos         VARCHAR(100)   \-      No     Apellidos del usuario.
  - telefono          VARCHAR(20)    \-      Sí     Teléfono de contacto.
  - correo            VARCHAR(100)   \-      Sí     Correo electrónico.


## 8.6 Tabla: Prestamo

  Campo           Tipo de dato   Clave   Nulo   Descripción
  --------------- -------------- ------- ------ -----------------------------------
  - idPrestamo      INT            PK      No     Identificador único del préstamo.
  - idUsuario       INT            FK      No     Usuario que realiza el préstamo.
  - ISBN            INT            FK      No     IdLibro
  - fechaPrestamo   DATETIME       \-      No     Fecha del préstamo.
  - fechaDevolucion   DATETIME     \-      No     Fecha del préstamo.
  - estado          VARCHAR(20)    \-      No     Estado del préstamo.


------------------------------------------------------------------------

# 9. ARQUITECTURA DEL SISTEMA

## 9.1 Descripción general

El Sistema de Gestión de Biblioteca se desarrolla utilizando una
**arquitectura por capas**, con el propósito de separar las
responsabilidades del sistema y facilitar su mantenimiento, organización
y evolución.

La arquitectura está compuesta por:

1.  Capa de Presentación.
2.  Capa de Lógica de Negocio.
3.  Capa de Acceso a Datos.
4.  Capa de Base de Datos.

## 9.2 Diagrama de arquitectura

![Arquitectura](<Imágenes de Análisis/Arquitectura Del Sistema  - Biblioteca .png>)

## 9.3 Capa de Presentación

**Responsabilidad:**

Es la capa mediante la cual el usuario interactúa con el sistema.

**Componentes:**

-   \[FrmInicio\]
-   \[FrmPrincipal\]
-   \[FrmLibros\]
-   \[FrmAutores\]
-   \[FrmCategorias\]
-   \[FrmUsuarios\]
-   \[FrmPrestamos\]
-   \[FrmDevoluciones\]

**Tecnología utilizada:**

-   C#
-   Windows Forms
-   \[.NET 18.10.3\]

## 9.4 Capa de Lógica de Negocio

**Responsabilidad:**

Procesa las solicitudes provenientes de la interfaz, aplica las reglas
de negocio y coordina las operaciones.

**Componentes:**

-   \[LibroController\]
-   \[AutorController\]
-   \[EditorialController\]
-   \[UsuarioController\]
-   \[PrestamoController\]


-   Validar disponibilidad.
-   Validar existencia del usuario.
-   Validar existancia del autor.
-   Validar existencia del libro.
-   Calcular días de retraso.
-   Actualizar disponibilidad.

## 9.5 Capa de Acceso a Datos

**Responsabilidad:**

Gestiona la comunicación entre la aplicación y SQL Server.

**Componentes:**

-   \[Conexion\]
-   \[LibroDAO\]
-   \[AutorDAO\]
-   \[CategoriaDAO\]
-   \[UsuarioDAO\]
-   \[PrestamoDAO\]
-   \[DevolucionDAO\]

**Tecnologías utilizadas:**

-   SQL Server.
-   ADO.NET 
-   SQL CLIENT
-   Consultas parametrizadas.

## 9.6 Capa de Base de Datos

La información del sistema se almacena en:

**Base de datos:** `[AcaBiblioteca]`

**Tablas principales:**

-   Autor
-   Libro
-   Usuario
-   Prestamo
-   Editoriales


## 9.7 Flujo de información

``` text
Usuario
   ↓
Presentación
   ↓
Lógica de Negocio
   ↓
Acceso a Datos
   ↓
SQL Server
```

Las respuestas de la base de datos realizan el recorrido inverso hasta
llegar nuevamente a la interfaz.

------------------------------------------------------------------------

# 10. EXPLICACIÓN DE CADA MÓDULO DESARROLLADO

## 10.1 Módulo de libros

**Objetivo:** \[Tener un panel donde se puedan gestionar los libros
y a su vez se pueda visualizar información detallada en un data
grid view.\]

**Funcionalidades:** - Registrar. - Guardar. - Actualizar. -
Eliminar. - Buscar.

## 10.2 Módulo de autores

**Objetivo:** \[Visibilizar los autores y poder crear nuevos\]

**Funcionalidades:** - Registrar. - Consultar. - Guardar.- Actualizar. 
Eliminar.

## 10.3 Módulo de editoriales

**Objetivo:** \[Retornar el nombre de la editorial y poder validar
por megio de una tabla la editoriales creadas\]

**Funcionalidades:** - Registrar. - Consultar. - Actualizar. - Guardar.
Eliminar.

## 10.4 Módulo de usuarios

**Objetivo:** \[Gestionar los usuarios que van a hacer uso del servicio
de préstamos\]

**Funcionalidades:** - Registrar. - Consultar. - Actualizar. - Eliminar.
Guardar.
## 10.5 Módulo de préstamos

**Objetivo:** \[Tener a mano la información actualizada del estado de
los préstamos actuales y la fecha.\]

**Funcionalidades:** - Registrar préstamo. - Ver fecha devolución
. - Ver fecha préstamo. - Actualizar disponibilidad.

## 10.6 Módulo de reportes

**Objetivo:** \[Visibilizar los diferentes reportes de las
transacciones realizadas por el administrador.\]

**Funcionalidades:** - Generar Reporte - Consultar inventario de
libros. - Consultar libros devueltos. - Consultar libros prestados.

## 10.7 Módulo de acerca de...

**Objetivo:** \[Generar información del programa.\]

**Funcionalidades:** - Generar un mensaje con la información del 
desarrollo del programa, versión y otra información relevante.

## 10.8 Módulo de Inicio

**Objetivo:** \[Bienvenida al programa\]

**Funcionalidades:** - Generar una imagen de bienvenida al
programa de bibloteca interactiva.

------------------------------------------------------------------------

# 11. CAPTURAS DE PANTALLA DEL SISTEMA


## 11.1 Menú principal

![Menú principal](<Capturas Proyecto/Captura de pantalla Inicio.png>)

**Descripción:** \[Se aprecia imagen gif de inicio y mensaje de
bienvenida\]

## 11.2 Gestión de libros
![Gestión de libros](<Capturas Proyecto/Captura de pantalla Libros.png>)

**Descripción:** \[Gestionar los libros existentes en la biblioteca,
se pueden guardar registros, editar, eliminar, se puede ver el nombre 
del libro, Autor, Año y otras características.\]

## 11.3 Gestión de autores

![Gestión de autores](<Capturas Proyecto/Captura de pantalla Autores.png>)


**Descripción:** \[En este apartado se gestionan los autores, podemos crear
un nuevo autor, eliminarlo, el botón cancelar borra todos los registros,
también podemos ver infromación como nombre del autor y apellido.\]

## 11.4 Gestión de editoriales

![Gestión de editoriales](<Capturas Proyecto/Captura de pantalla Editoriales.png>)

**Descripción:** \[Se pueden crear nuevas editoriales y visibilizar el 
nombre también una tabla con las editoriales disponibles en el momento.\]

## 11.5 Gestión de usuarios

![Gestión de usuarios](<Capturas Proyecto/Captura de pantalla Usuarios.png>)


**Descripción:** \[En este panel se visibilizan los usuarios creados, tambien 
diferentes opciones de botones como crear nuevo usuario, eliminar, guardar  y 
aprecia información general del usuario si hacemos doble clic en el data grid
view\]

## 11.6 Registro de préstamos

![Registro de préstamos](<Capturas Proyecto/Captura de pantalla prestamos.png>)

**Descripción:** \[Aqui se pueden ingresar los diferentes registros de los
préstamos adquiridos por los usuarios, podemos editar un préstamo,
registrar una devolución de un libro y en la tabla visivilizar el estado
de los préstamos ingresados.\]


## 11.87 Reportes

![Reportes](<Capturas Proyecto/Captura de pantalla reportes.png>)

**Descripción:** \[Aqui en este panel podemos generar tres diferentes 
reportes que son 1. Préstamos activos. 2. Préstamos devueltos 3. 
inventario de libros y dos botones de generar reporte y limpiar que 
borra el registro\]

------------------------------------------------------------------------

# 12. PRUEBAS DE FUNCIONAMIENTO

## 12.1 Estrategia de pruebas

Describir cómo se verificó el funcionamiento del sistema.

## 12.2 Casos de prueba

  ---------------------------------------------------------------------------------------------------------------
  ID          Funcionalidad   Entrada / Acción Resultado        Resultado                           Estado
                                               esperado         obtenido        
  ----------- --------------- ---------------- ---------------- -------------------------------   ---------------
  CP01        Registrar libro Datos válidos    Libro registrado \[creación de libro\]               Aprobado
                                               correctamente                    

  CP02        Registrar libro Código repetido  Mostrar mensaje  \[ISBN duplicado\]                  Aprobado
                                               de validación                    

  CP03        Registrar       Datos válidos    Usuario          \[Se Ingresa nueavo usuario\]       Aprobado
              usuario                          registrado                       

  CP04        Registrar       Libro disponible Préstamo         \[Se presta el libro\]              Aprobado
              préstamo                         registrado y                     
                                               disponibilidad                   
                                               actualizada                      

  CP05        Registrar       Libro sin        No permitir el   \[Transsación Rechazada\]           Aprobado
              préstamo        disponibilidad   préstamo                         

  CP06        Registrar       Préstamo activo  Registrar        \[Devolución completada\]           Aprobado
              devolución                       devolución y                     
                                               actualizar                       
                                               disponibilidad                                         

  CP07        Consulta        Consultar libros Mostrar libros   \[Retorna inventario libros\]       Aprobado
                              disponibles      disponibles                      
                    
  --------------------------------------------------------------------------------------------------------------

## 12.3 Evidencias de pruebas


### Prueba CP01

![Evidencia CP01](<Pruebas Proyecto/Prueba CP_01.png>)

**Resultado:** \[Se crea el libro El coronel no tiene quién le escriba\]

### Prueba CP02

![Evidencia CP02](<Pruebas Proyecto/Prueba CP_02.png>)


**Resultado:** \[Se intenta crear un libro con un ISBN ya existente, el
programa rechaza la creación al ser una llave duplicada.\]

### Prueba CP03

![Evidencia CP03](<Pruebas Proyecto/Prueba CP_03.png>)


**Resultado:** \[Se crea un nuevo usuario Anibal Galindo, se observa que 
el usuario ha sido creado con éxito\]

### Prueba CP04

![Evidencia CP04](<Pruebas Proyecto/Prueba CP_04.png>)


**Resultado:** \[Se crea una nueva transacción de préstamo del libro
de la tierra a la luna, se observa mensaje de préstamo registrado 
con éxito.\]

### Prueba CP05

![Evidencia CP05](<Pruebas Proyecto/Prueba CP_05.png>)


**Resultado:** \[Se intenta hacer un préstamo a un libro sin existencias
el programa valida que no se puede completar la transacción por inventario
=0\]

### Prueba CP06

![Evidencia CP06](<Pruebas Proyecto/Prueba CP_06.png>)


**Resultado:** \[Se realiza una devolución del libro cien años de soledad
con el usuario Daniel Torres, se evidencia mensaje de devolución completada
y adicionalmente se suma uno a la exitencia del libro\]

### Prueba CP07

![Evidencia CP07](<Pruebas Proyecto/Prueba CP_07.png>)


**Resultado:** \[Se genera un reporte de la cantidad y los libros
disponibles se actualiza en el data grid view la información
solicitada.\]


------------------------------------------------------------------------

# 13. CONCLUSIONES

## Conclusión 1

Se logra resolver el problema descrito para poder automatizar y gestionar de
una manera intuitiva las operaciones  en una librería, se integran conocimientos
de programación avanzada y la importancia de las herramientas de desarollo como 
visual studio y git hub para publicar la solución en un entorno académico. Se 
amplían conocimientos para la realización de una solución con interfaz gráfica.

## Conclusión 2

Se amplian conocimientos de programación orientada a objetos como la herencia, 
abstracción, colecciones y manejo de excepciones con la palabra clave try catch
dando así opciones de retorno de funaciones como los mensajes de error o la
validación por condicionales.

## Conclusión 3

Se establece una conexión a una base de datos para generar persistencia a todas 
transacciones realizadas por el administrador de la biblioteca, se identifican 
también los comandos para establecer dicha conexión dentro de nuestro proyecto.


## Conclusión 4

Se apoya el conocimineto de palabras clavecon la documentación oficial de C#
y se usa el IDE de visual studio para tomar las sugerencias en cuanto a código
igualmente se asimilan conocimineot y oprtunidades de mejora en el apartado 
gráfico.

------------------------------------------------------------------------

# 14. RECOMENDACIONES

-   En nuestro panel de inicio se puede crear un apartado para inicio de
    sesión y mejorar la seguridad del programa.
-   Creación de otro autor para que tenga privilegios de consulta.
-   Creación de la entidad categoría para normalizar la base de datos.
-   Creación del microservicio de multas en el caso que los usuarios
    se pasen de la fecha límite de entrega.

------------------------------------------------------------------------

# 15. REFERENCIAS BIBLIOGRÁFICAS


Ejemplos de formato:

**Página web:**

W3Schools. (s. f.). C# tutorial. https://www.w3schools.com/cs/index.php

**LLM**

OpenAI. (2026). ChatGPT [Modelo de lenguaje grande]. https://chatgpt.com/



------------------------------------------------------------------------

# ANEXOS

## Anexo A. Repositorio GitHub

**Repositorio:** (https://github.com/anigaly-beep/AcaBiblioteca.git)

## Anexo B. Script de base de datos

**Archivo:**

[Script DB](SQLQueryAcaBiblioteca.txt)


## Anexo C. Evidencia de Git y GitHub

![commits](<Anexos_Evidencias/Captura de pantalla commits gitdesktop.png>)
![github](<Anexos_Evidencias/Captura de pantalla github.png>)

[creación](<Anexos_Evidencias/Evidencias ACA Programación avanzada.pdf>)



------------------------------------------------------------------------








