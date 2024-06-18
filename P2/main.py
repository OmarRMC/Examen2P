import cv2
import numpy as np

def convert_to_sparse(image):
    sparse_rep = {}
    rows, cols = image.shape
    for i in range(rows):
        for j in range(cols):
            if image[i, j] != 0:
                sparse_rep[(i, j)] = image[i, j]
    return sparse_rep

# Rutas a las imágenes
image_path1 = 'imagen1.jpg'
#image_path2 = 'imagen1.jpg'

# Leer las imágenes en escala de grises
img1 = cv2.imread(image_path1, cv2.IMREAD_GRAYSCALE)
#img2 = cv2.imread(image_path2, cv2.IMREAD_GRAYSCALE)

# Verificar que las imágenes se hayan leído correctamente
if img1 is None:
    raise ValueError("No se pudieron leer una o ambas imágenes.")

# Convertir las imágenes a representaciones dispersas
sparse_img1 = convert_to_sparse(img1)
#sparse_img2 = convert_to_sparse(img2)

# Imprimir las matrices dispersas
print("Matriz dispersa de la imagen 1:")
print(sparse_img1)
#print("\nMatriz dispersa de la imagen 2:")
#print(sparse_img2)
