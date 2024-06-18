import cv2
import numpy as np
from matplotlib import pyplot as plt

# Cargar las dos imágenes
imagen1 = cv2.imread('Telefono.png')
imagen2 = cv2.imread('Ubicacion.png')

imagen1 = cv2.resize(imagen1, (200, 200))
imagen2 = cv2.resize(imagen2, (200, 200))


suma = cv2.add(imagen1, imagen2)

resta = cv2.subtract(imagen1, imagen2)
  

# Mostrar las imágenes originales y los resultados
plt.figure(figsize=(10, 8))

plt.subplot(2, 2, 1)
plt.title('Imagen 1')
plt.imshow(cv2.cvtColor(imagen1, cv2.COLOR_BGR2RGB))

plt.subplot(2, 2, 2)
plt.title('Imagen 2')
plt.imshow(cv2.cvtColor(imagen2, cv2.COLOR_BGR2RGB))

plt.subplot(2, 2, 3)
plt.title('Suma de Imágenes')
plt.imshow(cv2.cvtColor(suma, cv2.COLOR_BGR2RGB))

plt.subplot(2, 2, 4)
plt.title('Resta de Imágenes')
plt.imshow(cv2.cvtColor(resta, cv2.COLOR_BGR2RGB))

plt.tight_layout()
plt.show()
