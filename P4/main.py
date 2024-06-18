import cv2
import numpy as np
from scipy.sparse import csr_matrix

imagen1 = cv2.imread('uno.jpg', cv2.IMREAD_GRAYSCALE)
imagen2 = cv2.imread('dos.jpg', cv2.IMREAD_GRAYSCALE)

imagen1=cv2.resize(imagen1, (1000, 1000))
imagen2=cv2.resize(imagen2, (1000, 1000))

matriz_1 = np.array(imagen1)
matriz_2 = np.array(imagen2)

csr1 = csr_matrix(matriz_1)
csr2 = csr_matrix(matriz_2)

mul = csr1.dot(csr2)

print(mul)
print("Numero de elementos:", mul.nnz)
