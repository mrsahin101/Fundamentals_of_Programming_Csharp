# Chapter 7-> ARRAYS

- All elements of given array are of the same type, no matter whether they are **primitive** or **reference** types.

- One-dimensional arrays called **vectors** and Two-Dimensional arrays called **matrices**

- in C# arrays have fixed length. 
    int[] myArray;      -> this is saying: give me a pointer to int array type. but array didnt get the memory space allocated yet! This points to null right now!

    int[] myArray = new int[6]; this allocating new memory space for myArray pointer in dynamic memory(heap) with **new** keyword

- in C# the elements of array always stored in dynamic memory.(heap)

- Foreach Loop is **read-only**, so we cannot modify the current loop item from the loop body.

-   One-Dimensional Array : int[]
    Two-Dimensional Array : int[,]
    Three-Dimensional Array : int[,,]

    nDimensionalArray[index1,index2,..., indexN]

- In C# we can have arrays of arrays, which we call **jagged** arrays.
int[][] myJaggedArray : this is pointer pointing to other arrays in heap memory. this pointer is in stack memory. 
