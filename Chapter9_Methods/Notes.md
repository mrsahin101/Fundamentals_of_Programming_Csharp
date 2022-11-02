# CHAPTER 9 -> Methods
- In programming always use "divide and conquer" method! Thats make it easy to solve big and complex problems!

- Why Use Methods?
    1. For better structured code and more readable code
    2. Avoiding duplicated code
    3. Code Reuse(Using same code snippet repeatly in code!)

- In the C# Language, a method can be declared only between the opening "{" and the closing "}" brackets of class!

- Method Decleration Syntax :
    [static] <return_type> <method_name>([<param_list>])

- in C# methods are distinguised from each other by **method signature**! Signature of method consist of method name and list of parameters! Return type of method **it's not** part of signature!

- Rules for Name a Method (Practical suggestions. Not mandatory)
    1. The name of method must start with **capital letter**
    2. The **PascalCase** rule must be applied! Each word in method name must start with capital letter!
    3. Method name must describe the method's purpose!
    

### Modifiers 

- There are few types of modifiers.For example 
    1. Access Modifiers : 
        - Public : Can be accessed from any class!
        - Private : It can be called by the class it created!
- If method declared without modifier, it is accessible from all classes in the current assembly but not from other assemblies!
- Static keyword allowing us to use method without needing instance of its class!

- **Method can NOT be declared inside the body of another method**

- Whenever we declare variable inside the body of method, we call that variable **local variable**. Scope of local variables are limited to inside of that method body!

- When method invoked(called) it takes control of the program. After it finished its execution it passes control back to caller.
- A method can be invoked from its own body. Such a call is refered as **recursion**
- In C# order of method doesnt matter. Not like C. Where you have to declare functionfirst to use it. 
