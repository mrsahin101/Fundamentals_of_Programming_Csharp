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
- When we assign values to function parameters, those values called **arguments**

- Primitive Types : When we pass argument to method, its getting copied to local variable in method body and used from there. Original argument value where is called doesn't change!

- Reference Types : Whenever an argument of reference types passed to method, the method's parameter receives the reference itself. It access original variable. So any change to that reference type variable will result change outside body of method aswell.

- The way we pass arguments to parameters must be same order. first variable must get first argument.. etc..

### How to declare Method with Variable Number of Arguments
- Syntax : 
    static void <return_type> <method_name> (<parameters_lsit>)
    {
        // Method Body
    }
- params keyword allow us to pass variable numbers of argument to function! Variable type could be primitive or reference type!

- params keyword actualy its like array but we dont have to declare array and then pass it reference. with params we can just write values and bum its passed to the function!

- static void DoSomething(string strParam, params int[] x) -> this is also valid but must be carefull where we put params. We always have to put params at the end of parameters list!

- Another limitation of params keyword is that, we can not declare more than 1 variable numbers of variables.
    For example : static void DoSomething(params int[] x, params string[] z) -> This is not valid!
- Also if we didnt pass anything to params int array[], (calling function without passing any value), this is also valid! Basically it passed to function empty array! Main function in C# is good example for this!
    : static void Main(params string[] args)
    {
        // Method body comes here!
    }

### Optional Parameters and Named Arguments
- We can create method with optional parameters and nameed arguments!
    1. Optional parameters allows us to skip some values as default when method invoked. If value for some variable didnt pass to method it will use its default value!
    2. Named Arguments allows us method parameters to be set by their name, instead of their exact posiiton!

    Example : 
        static void SomeMethod(int x, int y = 5, int z = 7) // y and z are optional
        {
            // Method Body!
        }
        Can invoke this method this way :
            SomeMethod(1,2,3);      -> This is Equivalent to : SomeMethod(1,2,3);
            SomeMethod(1,2);        -> This is Equivalent to : SomeMethod(1,2,7);
            SomeMethod(1);          -> This is Equivalent to : SomeMethod(1,5,7);

            SomeMethod(1, z:3);     -> This is Equivalent to : SomeMethod(1,5,3);
            SomeMethod(z:3, x:1)    -> This is Equivalent to : SomeMethod(1,5,3);