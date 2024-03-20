# AR Application - Byodoin Temple

AR aplikacija koja prikazuje 3D model Byodoin budističkog hrama u Japanu.

Slika korištena za image recognition se može naći na sljedećem linku:
[Byodoin image recognition](https://upload.wikimedia.org/wikipedia/commons/thumb/6/69/Phoenix_Hall%2C_Byodo-in%2C_November_2016_-01.jpg/1199px-Phoenix_Hall%2C_Byodo-in%2C_November_2016_-01.jpg).

##### POINTS OF INTEREST

Ispred modela hrama se nalaze 3 points of interest:
* Feniks u letu - simbolizira drugo ime hrama - Dvorana Feniksa, kojeg je dobio zbog svog oblika i statua feniksa na krovu.
    * klikom na feniksa prikazat će se kratki dron video hrama 
* Šolja čaja- simbolizuje salon čaja koji se nalazi u kompleksu hrama i u kojem se može probati autentični čaj.
    * klikom na šolju prikat će se tekst sa osnovnim informacijama o salonu čaja.
* Statua Bude - simbolizuje poznatu statuu Amida Bude koju se kreirao Jocho.
    * klikom na statuu prikazat će se slika stvarne statue Amida Bude koja se nalazi unutar hrama.

##### UI

* Klikom na dugme _i_ prikazat će se osnovne informacije o hramu, te informacije o programeru.
* Klikom na dugme poveznice odlazi se na stranicu predmeta Računarska grafika na Elektrotehničkom fakultetu u okviru kojeg je pravljen projekat.
* Klikom na dugme x izlazi se iz aplikacije.


## Linear algebra

Codon-NumPy fully supports the NumPy `linear algebra` module which provides a comprehensive set of functions for linear algebra operations. Linear algebra is a branch of mathematics that deals with linear equations, vector spaces, and matrices. This module is a critical component for scientific computing, machine learning, and data analysis tasks. It uses an optimized BLAS library when possible to optimize a variety of fundamental linear algebra operations.

### Examples:

### Getting started:

Importing `numpy linear algebra` module:

``` python
import numpy.linalg as LA
```

``` python
eigenvalues, eigenvectors = LA.eig(np.diag((1, 2, 3)))
print(eigenvalues)
# 1.+0.j 2.+0.j 3.+0.j

print(eigenvectors)
# [[1.+0.j 0.+0.j 0.+0.j]
#  [0.+0.j 1.+0.j 0.+0.j]
#  [0.+0.j 0.+0.j 1.+0.j]]
```

The `multi_dot()` function computes the dot product of two or more arrays in a single function call, while automatically selecting the fastest evaluation order:

``` python
result = LA.multi_dot([
    np.array([[1, 2], [4, 5]]),
    np.array([[5, 6], [7, 9]]),
    np.array([[6, 1], [3, 4]])])

print(result)
# [[186 115]
#  [537 331]]
```

Several of the linear algebra routines are able to compute results for several matrices at once, if they are stacked into the same array:

``` python
A = np.array([
    [[1, 2],
     [3, 4]],
    
    [[5, 6],
     [7, 8]]
])

U, S, Vh = LA.svd(A)
print(U)
# [[[-0.40455358 -0.9145143 ]
#   [-0.9145143   0.40455358]]

#  [[-0.59206014 -0.80589378]
#   [-0.80589378  0.59206014]]]

print(S)
# [[ 5.4649857   0.36596619]
#  [13.19003444  0.15162963]]

print(Vh)
# [[[-0.57604844 -0.81741556]
#   [ 0.81741556 -0.57604844]]

#  [[-0.65212545 -0.75811107]
#   [ 0.75811107 -0.65212545]]]
```

Because Codon supports full multithreading, meaning NumPy code can be parallelized, we can use parallelism to multiply several matrices:

**

### Additional Resources:

[Detailed descriptions of NumPy linear algebra module]([https://openai.com](https://numpy.org/doc/stable/reference/routines.linalg.html)) 

## Reductions

Codon-NumPy uses reduction operations to implement the majority of the functions available in the NumPy `statistics` module. This enables efficient, consistent, and flexible ways to analyze and summarize data along one or more axes. This approach ensures both performance and functionality in handling a variety of statistical computations. This module includes functions for order statistics, averaging, and variances.

### Examples

``` python
a = np.array([[2, 3],
              [0, 1],
              [6, 7],
              [4, 5]])
m = np.median(a, axis=1)
print(m)
# 2.5 0.5 6.5 4.5
```

``` python
A = np.array([[10, 7, 4],
              [3, 2, 1]])
q = [42.11, 74.21, 1.2, 55.98]
percentile = np.percentile(A, q)
print(percentile)
# 3.1055 6.1315 1.06 3.799
``` 

## Statistics

The Codon-NumPy `statistics` module alongside the `reductions` module provides a wide array of functions for statistical analysis. This module can be used in scientific computing, data analysis, and machine learning applications. This module includes functions for averaging, correlation and histograms.

### Examples

``` python
a = np.arange(6).reshape((3, 2))
avg = np.average(a, axis=1, weights=[1./4, 3./4])
print(avg)
# 0.75 2.75 4.75
```

``` python
hist, bin_edges = np.histogram(np.arange(4), bins=np.arange(5), density=True)
print(hist)
# 0.25 0.25 0.25 0.25

print(bin_edges)
# 0 1 2 3 4
```

### Not-yet-implemented:

- histogram2d
- histogramdd

### Additional Resources:

[Detailed descriptions of NumPy statistics module](https://numpy.org/doc/stable/reference/routines.statistics.html)

## Frequently Asked Questions:
