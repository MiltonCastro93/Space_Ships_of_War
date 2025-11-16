# Space Ships of War – Prototipo (Unity 2021)

**Space Ships of War** es un prototipo rápido desarrollado con **Unity 2021**, utilizando modelos del paquete **"Star Sparrow Modular Spaceship"**.  
Es un proyecto antiguo y actualmente discontinuado, pero funciona como base técnica para pruebas de control de naves, límites de escenario y selección de vehículos.

---

## 🚀 Características Principales

### Control de la Nave
- Control de la Nave **W**, **S**, **A**, **D**.  {Avanzar, Retroceder, Lateral Izquierdo, Lateral Derecho}
- Inclinación en el eje X con interpolación **Lerp** para un efecto de **0** a **45°** al girar.  
- Disparo con **clic izquierdo**.  
- Corrección suave de posición cuando se supera el límite lógico del escenario.

### Selector de Naves
Incluye **tres naves diferentes**, todas funcionales y seleccionables antes de iniciar.

### Límites del Mapa
Se probaron dos sistemas:
1. **Límite lógico (por código)**  
   - Detecta cuando la nave sale del área y la devuelve suavemente al centro.
2. **Límite físico con BoxColliders**  
   - Alternativa rápida para pruebas.

### Estado Actual
- No posee enemigos ni sistema de respawn.  
- Proyecto detenido por falta de tiempo, pero funcional como prototipo jugable.

---

## 🖼️ Capturas del Proyecto

> Imagenes del Prototipo

<p align="center">
  <img src="https://github.com/MiltonCastro93/Space_Ships_of_War/blob/main/Captura%20de%20pantalla%202025-11-16%20132005.png" width="500"/>
</p>

<p align="center">
  <img src="https://github.com/MiltonCastro93/Space_Ships_of_War/blob/main/Captura%20de%20pantalla%202025-11-16%20132122.png" width="500"/>
</p>

---

## 📦 Tecnologías Utilizadas
- **Unity 2021**
- C# para lógica de movimiento y límites
- Asset pack: **Star Sparrow Modular Spaceship**
<p align="left">
  <img src="https://github.com/MiltonCastro93/Space_Ships_of_War/blob/main/icon.jpg" width="500"/>
</p>

---

## 📌 Nota Final
Este prototipo queda como una referencia técnica de control de naves y experimentación con límites.  
Si más adelante decido retomarlo, podría expandirse con IA enemiga, oleadas y escenarios adicionales.
