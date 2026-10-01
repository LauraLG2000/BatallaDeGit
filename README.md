# Ronda 1 -- Cambios sin conflicto
## ¿Ha aparecido algun conflicto? ¿Por qué Git ha podido integrar automáticamente ambos cambios.
Sí, porque Nerea no sabe leer y lo ha puesto en las mismas lineas que Laura.
En teoria si se ponía abajo el código de Nerea, Git los habría integrado sin problema ya que se trataría de información nueva en un lugar donde no existe solapamiento con la versión anterior.

## Ronda 6 -- Mi compañero ha avanzado y yo no lo sabía
### Paso 3 — Comparad las versiones
Antes de continuar, comprobad:

Qué código tiene el Alumno A.
Qué código tiene el Alumno B.
Qué código aparece actualmente en GitHub.
¿Son iguales las tres versiones?

¿Por qué?

El código del alumno A coincide con la rama develop de GitHub. El código del Alumno B coincide con la rama feature/Nerea de GitHub. Esto se debe a que el alumno A ha subido cambios nuevos a develop y el alumno B no los descargó antes de crear una nueva rama para crear las nuevas funcionalidades.

### ¿Por qué el Alumno B estaba trabajando con una versión antigua?
Porque no ha ejecutado el comando git pull origin develop, confirmando de esta forma que tenía la versión más actualizada de la rama antes de ponerse a trabajar.

### ¿Haber realizado un commit significa que tenemos la última versión del proyecto?
No, significa que estás preparando la subida de nuevos cambios de local a remoto.

### ¿Haber realizado un push significa que tenemos los cambios realizados por nuestro compañero?
No, significa subir los cambios del local al remoto.

### ¿Qué operación permite obtener los cambios del repositorio remoto?
La operación es git pull origin nombreRama

### ¿Qué habría sido recomendable hacer antes de comenzar la nueva funcionalidad?
Hacer un git pull de la rama develop, o de la rama con los cambios más actualizados, y con git switch -c nombreNuevaRama, empiezas a trabajar sobre esa última versión en una nueva.

## Preguntas finales

1. ¿Por qué dos personas pueden modificar el mismo archivo sin generar necesariamente un conflicto?
Porque se están trabajando diferentes funcionalidades que antes no existian en la versión anterior y que no generan solapamientos con versiones anteriores.

2. ¿Qué provoca que Git considere que existe un conflicto?
Cuando has editado los mismos elementos de la rama origen dentro de una o varias ramas distintas que parten del mismo inicio.

3. ¿Un conflicto significa que alguien ha hecho algo mal?
No, significa que se ha modificado el mismo trozo de código y que una versión de esas puede estar obsoleta o que se ha desarrollado de dos formas distintas y el equipo debe decidir con que versión quedarse.

4. ¿Quién debe decidir cuál debe ser el código definitivo?
Se debe acordar entre todas las personas involucradas en la creación de esa parte del código.

5. ¿Qué diferencia existe entre `commit`, `push` y `pull`?
Commit crea una versión instantanea de los cambios que se quieren subir de local a remoto. Push es la instrucción para subir los cambios de local a remoto. Pull es para traer los cambios de remoto a local.

6. ¿Por qué es importante actualizar nuestra copia antes de comenzar nuevo trabajo?
Para no tener que trabajar con versiones obsoletas.

7. ¿Actualizar antes de empezar garantiza que nunca tendremos conflictos?
No, no es una garantía de que luego a la hora de hacer el merge no haya conflictos. Eso depende de la parte del código que se haya modificado o añadido.

8. ¿Por qué debemos comprobar que el programa funciona después de resolver un conflicto?
Para garantizar que no hay problemas de compilación, errores de escritura en el código o que la nueva funcionalidad no genera problemas en el código ya creado anteriormente.