# Parlem Backend

Prueba técnica consistente en hacer una api que devuelva los datos de 1 cliente y los productos que ha comprado en diferente end-points

## Stack

* Api Rest 
* .Net 6 (LTS)
* Arquitectura N-capas (mi preferida). Logica de negocio en Services y persistencia en SQLiteDatabase.
* SqLite
* Entity Framework Core
* Contenerizado en docker
* Inyeccion de dependencias
* Tests de Integración con NUnit
* TO-DO: Test unitarios (ver otros repositorios)
* TO-DO: Pasar SonarQube
* No Aplica: Test de UI con Selenium (ver otros repositorios)

## Setup

Requiere tener Docker Desktop instalado y en ejecución para lanzar el contenedor

## Ejecución

Clonar el proyecto, abrirlo y pulsar F5.
Si la base de datos no existe la crea, en SQL con SQLiteConnection y SQLiteCommand (no me gusta Code First, aunque podría haber insertado los datos con EF)