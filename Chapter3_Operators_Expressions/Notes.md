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

### Logical Operators 
- Logical operators takes boolean values and return boolean results.(true or false) 
- Logical operators are **|| (OR), &&(AND), ^(Exclusive OR), !(logical negation)**.
- Laws of De Morgan applied when it comes to logical operators.
- De morgan Laws : 
1. !(a && b) = (!a || !b);
2. !(a || b) = (!a && !b);

![Logical Operators in C#](https://github.com/mrsahin101/Fundamentals_of_Programming_Csharp/blob/main/Chapter3_Operators_Expressions/Logical_Operators.png)

### Operators for Concatenation of Strings
- The operator + concatenation(joins) strings together. If at least one of operands is string, .NET run-time will convert if there are other operands which none string to string. But it is good practice to typecast each operands to have full control on our program flow.
- Concatenation(joining, gluing) is slow operation and carefully should be used. It shouldn't be used for iterative tasks. Rather we should use StringBuilder class for iterative(repetitive) operations.

### Bitwise Operators
- Bitwise operators acts on binary representation of numerical types. In fact we store all information in binary format in computers.
- Bitwise operators are : **&(AND), |(OR), ^(Exclusive OR), ~(negation)** 

![Bitwise Operators in C#](https://github.com/mrsahin101/Fundamentals_of_Programming_Csharp/blob/main/Chapter3_Operators_Expressions/Bitwise_Operators.png) 

- Also there are 2 more bitwise operators : **Bit-Shift to Right(>>), Bit-Shift to Left(<<)**
- They are used of numerical values. For example : 3 << 2 means shift to left 2 digit. So 3 in binary is (0000 0011). When we shift 2 digit it becomes (0000 1100) and thats equivalent to 6


### Comparison Operators
- Comparison operators are : **greater than(>), less than(<), greater than or equal to(>=), less than or equal to(<=), equality(==), difference(!=)**
- All comparison operators are binary(takes 2 operands) and return boolen. Either true or false.


### Assignment Operators
- Operator for assignment is **"="**. Syntax is : operand1 = literal, expression or operand2;
- The assignment operator is **"="** while comparison operator is **"=="**. The exchange of operation is common mistake in C#. Be carefull about that.
- Compound Assignment operators are pretty much same but express what we doing succintly. Syntax is : **operand1 operator = operand2;** This is also equals to **operand1 = operand1 operator operand2**