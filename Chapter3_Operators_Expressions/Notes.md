# Chapter 3-> Operators and Expressions

## OPERATORS 
- Operators allow processing of primitive data types and objects. Operators are special characters and they perform transformations on the operands.
### Operators in C#
1. Arithmethic Operators : Used to perform simple mathematics operations.
2. Assignment Operators : Allow assigning values to variables.
3. Comparision Operatos : Allow comparison of two literals and/or variables.
4. Logical Operators : Operators that works on Boolean data types and expressions.
5. Binary Operators : Used to perform operations on binary representation of numerical data.
6. Type conversion Operators : Allow conversion of one data type to another.

![Operator Categories in C#](https://github.com/mrsahin101/Fundamentals_of_Programming_Csharp/blob/main/Chapter3_Operators_Expressions/Operators.png)

### Type of Operators by Numbers of Arguments 
1. unary : takes one operand. Not associative.
2. binary : takes two operands. Left-associative
3. ternary : takes three operands.
- Expressions calculated from left to right.Except assignment operators. All assignment operatos and conditional operators ?: and ?? are Right associative.
- Some operators takes different operations on different data types. For example + operator while doing aritmethic addition on numeric data types, on string data types it does concatenates(joins) together the content of 2 or more strings.

### Operator Precedence in C#
- Some operators have precedence(priority) over others. The operator () used to change precedence.
- When we write expressions that are more complex or have many operators, it is recommended to use parantesis to avoid difficulties in reading the code. For example : x + y /100; this is ambiguous. Better version is like this : x + (y / 100);

![Operator Precedence in C#](https://github.com/mrsahin101/Fundamentals_of_Programming_Csharp/blob/main/Chapter3_Operators_Expressions/Precedence.png)

### Arithmetical Operators 
- The arithmetical operators in C# "+", "-", "*", are same like ones in math. They perform operations on numerical values and give result in numerical values.

- Division operator has different on integer and real numbers. when we divide integer by integer (like int, sbyte, long) the returned value is integer.(no rouding, fractional part is cut). For example 7/3 = 2; This is known as integer division. Integer division by 0 is not allowed and causes run-time exception **DivideByZeroException** . The remainder of integer division can be obtained by % (modulo operator). For example : 7/3 = 1 or -10/2 = 0; 

- When dividing two real numbers or two numbers which one is real number **Real division** is done. And result is real number with whole and fractional part. For example 5.0 / 2 = 2.5;
In division of real numbers it is **allowed to divide by 0** and respectively the result is + ∞(positive infinity )and -∞(negative infinity) or NaN(invalid value).

- The operator for increasing by one(increment) **++** increase one unit value of variable by one and respectively the operator **--** (decrement) substratcs one unit  value of variable. When this operators used as **prefix(when placed immediately before variable)**  the new value calculated first then value returned. When used as **post-fix(when placed immediately after variable)** original value returned first then increment or decrement performed.