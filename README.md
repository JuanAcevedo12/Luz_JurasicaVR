# Luz Jurásica VR

![Unity Version](https://img.shields.io/badge/Unity-6.3_LTS-black?style=flat-square&logo=unity)
![Target](https://img.shields.io/badge/Target-Meta_Quest_3-blue?style=flat-square)
![Render Pipeline](https://img.shields.io/badge/Pipeline-URP_(Manual)-green?style=flat-square)
![Code License](https://img.shields.io/badge/Code_License-GNU_GPL_v3.0-orange?style=flat-square)
![Assets License](https://img.shields.io/badge/Assets_License-CC_BY_NC_SA_%204.0-red?style=flat-square)

![Vista previa del proyecto](Resources\LJVR_01.png)

## Descripción

**Luz Jurásica VR** es un prototipo inmersivo de Realidad Virtual para Meta Quest 3 que fusiona la exploración interactiva con la divulgación paleontológica. 

Este proyecto nació como un reto dual: crear una experiencia educativa atractiva que permita a los usuarios visualizar la anatomía de especies prehistóricas, y al mismo tiempo, resolver un problema técnico de optimización gráfica para hardware móvil (standalone). En lugar de depender de costosas simulaciones de iluminación dinámica, el proyecto utiliza matemáticas a nivel de shader para lograr un efecto visual complejo con un alto rendimiento.

**Características Principales:**
* **Linterna de Revelado Anatómico:** El corazón del proyecto. Un shader URP personalizado que calcula la distancia de la luz de la linterna en tiempo real para enmascarar mallas 3D, revelando la carne y la piel sobre los modelos óseos fósiles de forma fluida.
* **Optimización Standalone:** Arquitectura gráfica construida y ajustada manualmente para mantener una tasa de refresco estable de 72 a 90 FPS nativos en Meta Quest 3.
* **Interacción Intuitiva:** Físicas e interacciones inmersivas (agarre, apuntado y manipulación espacial) gestionadas íntegramente a través del estándar XR Interaction Toolkit.

---

## Tecnologías

* **Motor:** Unity 6.3 LTS
* **Render Pipeline:** Universal Render Pipeline (URP)
* **Lenguaje:** C#
* **Plataforma XR:** Meta Quest 3 (Standalone) / OpenXR
* **Assets/Librerías Clave:** Meta XR SDK, Shader Graph

---

## Autor

* **[Juan Pablo Acevedo Aponte]** - [@JuanAcevedo12](https://github.com/JuanAcevedo12) - [LinkedIn](www.linkedin.com/in/juan-pablo-acevedo-aponte-b8b6833b0) - [Behance](https://www.behance.net/juanacevedo06)

---

## Cómo Bajarlo y Empezar

Sigue estos pasos para obtener una copia local y ejecutar el proyecto en tu propio entorno de Unity.

1. Abre tu terminal o consola de Git.
2. Clona el repositorio usando el siguiente comando:
   ```sh
   git clone [https://github.com/tu_usuario/nombre-del-repositorio.git](https://github.com/tu_usuario/nombre-del-repositorio.git)
   
3. Abre Unity Hub y haz clic en "Add project from disk" (Añadir proyecto desde el disco).
4. **Importante**: Navega dentro de la carpeta clonada y selecciona la subcarpeta *Unity Project Files* (aquí es donde residen los archivos de configuración y Assets de Unity, separados de la raíz del repositorio).
5. Deja que Unity importe los paquetes e inicialice la librería. Una vez abierto, asegúrate de cambiar la plataforma de construcción a Android en *File > Build Settings* para la correcta previsualización de URP en Quest.

---

## ⚖️ Licencia

Este proyecto utiliza un modelo de **Licencia Dual** para proteger diferentes aspectos del desarrollo:

1. **Código Fuente:** Protegido bajo la [GNU GPL v3.0](./LICENSE). Se fomenta la transparencia y el desarrollo colaborativo de software libre.
2. **Activos Digitales y Reconstrucciones:** Los modelos 3D y texturas están protegidos bajo [CC BY-NC-SA 4.0](./ASSETS_LICENSE). Queda prohibida su explotación comercial sin autorización expresa de los autores.