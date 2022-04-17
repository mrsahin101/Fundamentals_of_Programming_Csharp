# Chapter 2-> Primitive Types And Variables

# Data Types:
- Data types can be characterized by: Name(E.g. int), Size (4 Bytes), Default Value(0)

## Types in C#

- Integer Types : sbyte, byte, short, ushort, int, uint, long, ulong
- Real Floating-point Types : float, double
- Real Type with decimal Percision : decimal
- Boolean Type : bool
- Character Type : char
- String : string
- Object Type : object

These are built-in (primitives) data types in C#. They are embedded in C# lowest level.
![Primitive Data Types in C#](https://github.com/mrsahin101/Fundamentals_of_Programming_Csharp/blob/main/Chapter2_Primitive_Types_and_Variables/primitive_data_types_values.png)


## Information Snippets :
- 32-bit real floating-point float is also known as single precision real number. This type has accuracy up to seven decimal places.
- 64-bit real floating-point type is double. Also known as double precision real number.Has precision up to 15-16 significant decimal digits.
- Closest value to 0 is Double.Epsilon.
- Float and Double values can take special values. (negative/positive infinity or uncertainty)
- When using float values keep in mind that precision matters.


## Special Values of the Real Types
- Negative Infinity : (Single.NegativeInfinity) It's obtained when for instance dividing -1.0f by 0.0f
- Positive Infinity : (Single.PositiveInfinity) It's obtained when for instance dividing 1.0f by 0.0f
- Uncertainty: (Single.NaN) - means that invalid operation performed on real numbers. For example when we divide 0 by 0 or when we try to calculate square root of negative number.

## Errors in Calculations of Real Types
- Since there is countless number of real numbers between 2 real number (According to  Mathematics) and because we have only limited amount of memory we can only store real values with approximation.
- In calculations of floating-point data types its possible to observe strange behaviour, because during representation of real number often happens to lose accuracy.
- Rouding is done when we printing out the value. In fact double value in memory is just represented power of 2. So precision is okay until we convert it to string.
- Conclusion is that floating-point number arithmetic can produce mistakes, therefore not appropriate for fields when you need absolutly precise calculations like finance.

## Decimal Data Type 
