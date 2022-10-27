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

![Common numeral Representation on Computers](https://github.com/mrsahin101/Fundamentals_of_Programming_Csharp/tree/main/Chapter8_Numeral_Systems/Images/Signed_Numbers.png)

### UN-Signed Numbers :

![Common numeral Representation on Computers](https://github.com/mrsahin101/Fundamentals_of_Programming_Csharp/tree/main/Chapter8_Numeral_Systems/Images/Unsigned_Numbers.png)