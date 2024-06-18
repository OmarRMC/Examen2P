import numpy as np
from scipy.sparse import csr_matrix
from multiprocessing import Pool, cpu_count

def mul_fila(args):
    fila, otra_matriz = args
    return fila.dot(otra_matriz).toarray()

def mul_matriz(A, B):
    A = csr_matrix(A)
    B = csr_matrix(B)

    with Pool(cpu_count()) as pool:
        filas_resultado = pool.map(mul_fila, [(A.getrow(i), B) for i in range(A.shape[0])])
    
    return csr_matrix(np.vstack(filas_resultado))

if __name__ == "__main__":
    # Crear matrices dispersas de ejemplo
    np.random.seed(42)
    tamaño = 1000
    densidad = 0.1

    #A = csr_matrix(np.random.rand(tamaño, tamaño) *(np.random.rand(tamaño, tamaño)  < densidad), dtype=np.int8)
    #B = csr_matrix(np.random.rand(tamaño, tamaño)*(np.random.rand(tamaño, tamaño)  < densidad),dtype=np.int8)

    A = csr_matrix(np.random.rand(tamaño, tamaño)  < densidad,dtype=np.int8)
    B = csr_matrix(np.random.rand(tamaño, tamaño)  < densidad,dtype=np.int8)

    C = mul_matriz(A, B)
    print(C)
