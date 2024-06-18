import cv2
import numpy as np

img1 = cv2.imread('uno.jpg', cv2.IMREAD_GRAYSCALE)
img2 = cv2.imread('uno.jpg', cv2.IMREAD_GRAYSCALE)

img1 = cv2.resize(img1, (100, 100))
img2 = cv2.resize(img2, (100, 100))

if img1 is not None and img2 is not None:
    matriz = np.array(img1) + np.array(img2)

# Crear una representación dispersa de la matriz
    valores = []
    filas = []
    columnas = []

    for i in range(matriz.shape[0]):
        for j in range(matriz.shape[1]):
            if matriz[i, j] != 0:
                valores.append(matriz[i, j])
                filas.append(i)
                columnas.append(j)
    
    print("filas:", filas,"\n")
    print("columnas:", columnas,"\n")
    print("valores:", valores,"\n")

    matrizSparce=[
        filas, 
        columnas, 
        valores
    ]; 
else: 
    print("No se pueden procesar las imágenes porque una o ambas no se cargaron correctamente.")

