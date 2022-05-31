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

- Division operator has different on integer and real numbers. when we divide integer by integer (like int, sbyte, long) the returned value is integer.(no rouding, fractional part is cut). For example 7/3 = 2; This is known as integer division. Integer division by 0 is not allowed and causes run-time exception **DivideByZeroException** . The remainder of integer division can be obtained by % (modulo operator). For example : 7%3 = 1 or -10%2 = 0; 

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
- Operator for assignment is **=**. Syntax is : operand1 = literal, expression or operand2;
- The assignment operator is **=** while comparison operator is **==**. The exchange of operation is common mistake in C#. Be carefull about that.
- Compound Assignment operators are pretty much same but express what we doing succintly. Syntax is : **operand1 operator = operand2;** This is also equals to **operand1 = operand1 operator operand2**

### Conditional Operator 
- Conditional operator(?:) uses boolean value of expression to determine which of two expression must be calculated and returned. It's called ternary operator. Because it works on 3 operands. Syntax : **operand1 ? operand2 : operand3** This means : if operand1 is true return as result operand2. Otherwise(if operand1 is false) return as result operand3.
- Operand1 always has to be boolean. Operand2 and operand3 has to be same type. 

### Other Operators

##### The "." Operator
- The access operator "." (dot) is used to access member fields or methods of class object.

#### Square Brackets [] Operator
- Square brackets [] are used for accessing elements of arrays by index. They are so called indexer.

#### Brackets Operator
- Brackets () are used to override the priority of the execution of expressions and operators.

#### Type Conversion Operator
- Type conversion operator **(type)** is used to convert a variable to another type.

#### Operator "as"
- The operator **as** used for type conversion but if invalid conversions returns null instead of exception.

#### Operator "new"
- The new operator is used to **create and initialize new objects**.

#### Operator "is"
- The "is" operator is used to check whether object is compatible with given type. Basicly **checking object type**


#### Operator "??"
- This operator is similiar to conditional operator **?:**. The difference is that it is placed between two operands and returns the left operand only if it is value not null, otherwise it returns the right operand.

### Type Conversion and Casting
- When we want to do operation in C# we need to make sure all arguments are same data type. To do this we perform **type conversion(type casting)**. This can be explicit or implicit.
- If we try to perform or assign wrong data type to another we get compilation error. But sometimes when types are similiar to each other we might get away with it and in this case program performs **hidden type conversion**.
- Specific conversion of lets say Type A to Type B allows expression Type A to be treated as expression of Type B during the execution.
- Lets say if we have object type and we wanna convert it to string. In this case we have to do verification during run-time to make sure the value is really instance of string.
- But when it comes to string type to casted as object type verification is not required. Because string type is inheritor of object type. Basicly string type will be converted to object type without a risk of error or losing data.
- Conversion from Int to Long type can be made without verification needed. Because int type is subset of Long type
- Conversion from double to long requires verification. Depending on value data lose might happen. So because of this we have to do conversion explicitly.
- In C# not all types can be converted to others. We can group some of possible conversions under this 3 categories.
1. Implicit Conversion.
2. Explicit Conversion.
3. Conversion to or from **string**

#### Implicit Type Conversion
- Implicit(hidden) type convesrion is possible only when there is no risk of losing data during conversion. To make implicit conversion don't have to use any operator. Conversion done automatically by compiler.

![Possible Implicit Conversions in C#](https://github.com/mrsahin101/Fundamentals_of_Programming_Csharp/blob/main/Chapter3_Operators_Expressions/Implicit_Conversions.png) 

#### Explicit Type Conversion
- Explicit type conversion is used whenever there is possibility of data lose during conversion.In this case (e.g. double to long conversion) **explicit conversion** is necessary.
- This happens because the myDouble variable value is bigger than int range so it gets minimum value of integer. It's not always possible to predict what value of a variable will be after scope overflow! Therefore use sufficent large types and be careful to switching smaller types.


#### Data Loss During Type Conversion
- When we doing type convesrion data might get lost. Have to be carefull.
- When we doing implicit type conversion, it's still good practice to use type conversion keyword intentionally to make code more readable and reducing chance of errors.
- checked keyword can be used during conversion to detect overflow. e.g : int i = checked((int)d);
- Note that conversion form or to string is not possible through typecasting.


### Conversion to String
- If necessary we can convert any value to string. Including null. Conversion done automatically whether you are using concatenation operator (+) or calling ToString() method.

### Expressions 
- When dealing with expressions dividing by zero is important. if its integer divided by zero it will cause error in run-time. But if its some floating number then its either 0, NaN or infinity.
- When working with expressions it is always good practice to use brackets to make code more readable
