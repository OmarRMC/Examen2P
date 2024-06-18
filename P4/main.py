import cv2
import numpy as np
from scipy.sparse import csr_matrix

img1 = cv2.imread('uno.jpg', cv2.IMREAD_GRAYSCALE)
img2 = cv2.imread('dos.jpg', cv2.IMREAD_GRAYSCALE)

img1=cv2.resize(img1, (1000, 1000))
img2=cv2.resize(img2, (1000, 1000))

matriz_1 = np.array(img1)
matriz_2 = np.array(img2)

csr1 = csr_matrix(matriz_1)
csr2 = csr_matrix(matriz_2)

mul = csr1.dot(csr2)

print(mul)
print("Numero de elementos:", mul.nnz)
