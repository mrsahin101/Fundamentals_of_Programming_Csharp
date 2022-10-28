# CHAPTER 8 -> NUMERAL SYSTEMS

- Duodecimal : Base-12 numeral system
- Sexagesimal : Base-60 numeral system

- Every numeral system has **base**. Any number can be chosen as base, but it absolute value has to be different than 1 and 0. It can be real or complex number too.

- Mathematically it is proven that best way to represent number ( length and number of digit used for depiction) is by using Euler number ( e = 2.71828...)

- But working with base e is inconvenient and impractical. So because of that working with base 2 or 3 is most optimal way. Since it is easier to implement base 2 on computers we use base 2.

- Positional Numeral systems are basically the value of digit is decided by its position in the representation! They are used almost in every systems today.

![Common numeral Representation on Computers](https://github.com/mrsahin101/Fundamentals_of_Programming_Csharp/tree/main/Chapter8_Numeral_Systems/Images/Common_Representation.png)

- There is also Non-Positional Numeral Systems, which is numbers are represented by their size not place. Which is huge drawback when it comes to represent big numbers! This numbers systems are rarely used!

## Binary Numeral Systems!
- This is used in modern computing machines!
- Some naming for bit-wise operations :
    1. Logical Multiplication(Conjunction)
    2. Logical Addition(Disjunction)
    3. Sum of modulo two(Exclusive-Or)

- Bit-wise And in C#
    * int result = integer1 & integer2;

- Bit-wise OR in C#
    * int result = integer1 & integer2;

- Bit-wise Ex-Or in C#
    * int result = integer1 ^ integer2;

- Bit-wise Negation in C# -> (this is unary operator, it means applied to single operand)
    * int result = ~integer1;

- Machine word is concept could be change from machine to machine. For 16-bit machine the words represent 16-bit data, for 64-bit machine word represent 64-bit data!

- When represent signed number in computer, If MSB(Most-Significant-Bit) shows the sign. If 1 it means it is negative, when 0 it means it is positive!

### Signed Numbers :

![Signed Numbers](https://github.com/mrsahin101/Fundamentals_of_Programming_Csharp/tree/main/Chapter8_Numeral_Systems/Images/Signed_Numbers.png)

### UN-Signed Numbers :

![Un-Signed Numbers](https://github.com/mrsahin101/Fundamentals_of_Programming_Csharp/tree/main/Chapter8_Numeral_Systems/Images/Unsigned_Numbers.png)


## Integer Types in C#

![Integer Types](https://github.com/mrsahin101/Fundamentals_of_Programming_Csharp/tree/main/Chapter8_Numeral_Systems/Images/Integer_Typpes.png)

- When giving value to long type variable, we have to put 'l' or 'L' at the end of value. E.g. ->  long myLongVariable = 9223377623423l;
    long mySecondLongVar = 858238123123912L;
- This is done because all literals has int type by default in C#. But since small l could look like 1 its better to use L instead. This is good practice.

- For ulong available suffixes are : UL, ul, Ul, uL, Lu, lU

- When we are ordering bytes in memory there are 2 way we can do it!
    1. Little Endian : Bytes ordered left-to-right from lowest to highest
        Example for 0xA8B6EA72 : 0xA8 0xB6 0xEA 0x72
    
    2. Big Endian : Bytes ordered from left-to-right starting from highest order to lowest
        Example for 0xA8B6EA72 : 0x72 0xEA 0xB6 0xA8

- Most hardware units obey IEEE-754 standart for floating point arithmetic! 
    -> also IEEE-754-1985 is another document for doing arithmetic with floating point numbers!
- float : single precision floating-point
- double : double precision floating-point

- In C# we use f suffixes for float and d suffixes for double.
    -> In C#, floating-point literals are double by default!

- For financial calculation or alike calculation use decimal data type instead! Decimal type has 128-bit precision. For decimal type, use m or M suffixes
