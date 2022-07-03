# Chapter 5-> Conditional Statements

### Comparison Operators 

![Some Command Line Commands on Windows](https://github.com/mrsahin101/Fundamentals_of_Programming_Csharp/blob/main/Chapter5_Conditional_Statements/Images/Comparison_Operators.png)

- Char type **behaves like number** and can be subtracted, added and compared to numbers freely. But this should be used cautiously because it makes code harder to read and room for errors!
- In C# several types can be compared:
1. Numbers (int, long, float, double, ushort, decimal, ...);
2. Characters(char)
3. Booleans(bool)
4. Reference to objects, also known as object pointers(string, object, arrays and others)

- We cannot compare different data types directly.
- When we compare integers and characters, we directly compare their binary representation in memory.

##### Comparison of Reference Types 
- We can compare addresses of Reference types. If they point to same thing it will return true, else it will return false

- == has **special behavior when comparing string** but for rest of reference types(arrays or classes) it applies comparison by address.

- The && operator called **short-circuit** because it doesn't lose time to additional unnecessary conditional check. Lets say you compare a expression like operandOne && operandTwo.If operandOne is false, it doesn't bother checking operandTwo. That's why it's called **short- circuit logical operator and** 

- Similarly with operator ||, if first operand is true, it doesn't bother check second operand. That's why it's called **short-circuit logical operator or**

- Logical operators for comparison & and | are similiar to && and || respectively. They do same job as && and || but difference lies in the fact that they check both operands no matter what. That's why they are called **full-circuit loglcal operators** and they are used very rarely.
- We must **NOT** confese Boolean operator & and | with bitwise operators & and |. 

- Logical operator ^ also known as **exclusive OR(XOR)** belong to full-circuit operators. This operator returns true if one of operand is true and other is not!

- Logical operator ! is return reversed of boolean value. if it's true it will return false, or if it's false will convert it to true.

### If-Else Conditional Statements
- If Format : 
    if( Boolean Expression)
    {
        Body of conditional statement;
    }
- In C# boolean variable can **NOT** be integer. Unlike languages like C,C++.
- If we have only one statement in body of the conditional statement we can ommit curly brackets. But it is good practice to use them even we have only one statement.
- If- Else format :
    if(Boolean Expression)
    {
        Body of conditional Statement;
    }
    else
    {
        Body of else statement;
    }

- If we need to do additional checks, we can use nested **IF** statements. But it's recommended that we don't use more than three conditional statements in each other. This makes code readability harder. In such case we should use methods. 

### Good Practices when Writing Conditional "If" Statements
- Use blocks, surrounded by curly brackets {} after if and else in order to avoid ambiguity

- Always format the code correctly by offsetting it with one tab inwards after if and else, for readability and avoid ambiguity.

- Prefer switch-case structure to of a series of if-else-if-else... structures or nested if else statement, if possible.

### Swich-Case Statements
- switch-case format :
    switch(integer_selector)
    {
        case integer_value_1 :
            statements;
            break;
        case integer_value_2 :
            statements;
            break;
        // ...
        default :
            statements;
            break;
    }
- selector is returning value can be compared. Like string or number. Then this value will be compared against case labels. If match found statement under label will executed until it hits break point. If no match found then it will execute default statements.
- The labels(those values front of case) must be unique. 
- If we dont use break, once we hit some label it will keep execute following cases aswell until it hits break.
- **switch** statement is clear way to implement selection among many options.
- selector  type could be integer number, char, string or enum.If we want to use array or float as selector it wont work. For non integer data types we should use if statements.

### Good Practices when using "switch-case"
- put **default statement at the end**, in order to have easier read code.

- It's good to place first the **cases**, which handle **the most common situations**. Case statements, which handle situations occuring rarely can be placed at the end of the structure.

- if the values in **case** labels are integer, it's recommended that they be arranged in **ascending order**.

- If the values in the case labels are of character type, it's recommended that the **case** labels are **sorted alphabetically**.

- It's advisable  to always use a **default** block to handle situations that cannot be processed in the normal operation of the program. If in the normal operation of the program the **default** block should not be reachable, you could put in it a **code reporting an error**