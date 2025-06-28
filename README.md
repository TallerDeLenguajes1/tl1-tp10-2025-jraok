# Trabajo Práctico N°10 – Taller de Lenguajes I (2025)

Este proyecto desarrolla los contenidos del **TP10** de la materia Taller de Lenguajes I, donde se aplican conocimientos sobre el uso de **archivos JSON**, **consumo de APIs REST** y la manipulación de datos en C# utilizando la biblioteca `System.Text.Json`.

El trabajo se divide en tres ejercicios, cada uno orientado a un objetivo concreto de aprendizaje.

---

## 🧩 Ejercicio 1: Análisis de tareas (ToDos)

En este ejercicio se realiza una solicitud HTTP a la API pública: https://jsonplaceholder.typicode.com/todos

markdown
Copiar
Editar

Se obtiene una colección de tareas en formato JSON, la cual se deserializa en objetos `Tarea` que contienen los siguientes campos:

- `userId`: ID del usuario asignado
- `id`: identificador único de la tarea
- `title`: descripción de la tarea
- `completed`: indica si fue completada o no

El programa:

- Clasifica las tareas en **pendientes** y **completadas**
- Muestra ambas listas por consola en orden
- Guarda el conjunto completo de tareas como archivo JSON (`tareas.json`) para persistencia local

---

## 🧩 Ejercicio 2: Visualización de usuarios

Este ejercicio se basa en el consumo de la siguiente API: https://jsonplaceholder.typicode.com/users

yaml
Copiar
Editar

Se trabaja con una colección de usuarios, y se extrae la siguiente información de los **primeros cinco** elementos:

- Nombre completo (`name`)
- Correo electrónico (`email`)
- Dirección (`address.street`, `address.city`, `address.zipcode`)

Además de mostrarlos por consola de forma legible, se guarda la estructura completa en un archivo local (`usuarios.json`).

---

## 🧩 Ejercicio 3: Consulta a API externa (libre)

Este ejercicio propone que el estudiante seleccione una **API pública externa** de su interés (como clima, criptomonedas, países, entre otras).

El programa:

- Realiza una consulta a dicha API (usando `HttpClient`)
- Muestra por consola los datos más relevantes
- Guarda la respuesta original en formato JSON en un archivo (`respuesta.json`)

La lógica y la API utilizada pueden variar según el enfoque del estudiante.

---

## 🧠 Objetivos del trabajo

- Utilizar objetos JSON como fuente de datos externa
- Aprender a deserializar estructuras complejas en objetos C#
- Desarrollar lógica para clasificar, filtrar y presentar datos
- Persistir datos en disco en formato JSON
- Comprender el flujo básico de una consulta HTTP: solicitud → respuesta → procesamiento → almacenamiento

---