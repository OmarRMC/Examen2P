import cv2
import numpy as np

imagen1 = cv2.imread('uno.jpg', cv2.IMREAD_GRAYSCALE)
imagen2 = cv2.imread('dos.jpg', cv2.IMREAD_GRAYSCALE)

imagen1 = cv2.resize(imagen1, (100, 100))
imagen2 = cv2.resize(imagen2, (100, 100))

if imagen1 is not None and imagen2 is not None:
    matriz = np.array(imagen1) + np.array(imagen2)

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
    print("No se encuentra la imagen ")

