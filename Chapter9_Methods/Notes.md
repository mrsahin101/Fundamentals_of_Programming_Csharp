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

### Method Overloading
- When signature(parameter list or the way the arranged) of 2 method differs, we can declare 2 method with same name.This is called method (Draw in our case) is overloaded!

    For Example :   
    
                    static void Draw(string str)
                    {
                
                    }

                    or
                    static void Draw(int number)
                    {

                    }
- In C# method signature is specified with : parameter type and order of parameter listed. So if signature is different we can overload the method. If signature is same we cant do it!
    UN-Valid Example :  static void DoSomething(int param1, float param2){ }
                        static void DoSomething(int p1, float p2) { }
                    - This is unvalid, even if parameters name are different, signature is same!

    Valid Example :     static void DoSomething(int p1, float p2){ }
                        static void DoSomething(int param1, int param2) { }
                    - Since in first method second parameter is float and in second method is int type, we can say these methods signature is different and thats why we can overload this function! 

### Returning Result from Method
- Syntax for declaring such a method :

                    static <return_type> <method_name> (<parameters_list>)
                    {
                        return <method's_result>;   // method's_result must be same type 
                                                    // as return_type
                    }

- return type could be either primitive or reference type. Void means doesnt return anything!
    we use return keyword to return value from method!

- Returning value from method could be used in some expression, or passed as argument to another method or assigned to a variable

- When returning from function sometimes some implicit conversion could be done! Also when returning value from some method we can use some complex expression with return keyword. 

- return keyword when executed it stops execution on method and return immediately

- In same method body return could be called multiple times!

- Method return type is **not** part of method signature. so we cant declare exact same 2 or more methods with exact signature but different return type. This will give compilation error!


## Best Practices when using Methods
- Each method must resolve a **distinct, well defined task**. This is also known as **strong cohesion** . Each method only must resolve signal task. Not many!

- A method has to have a **good name**. It must be descriptive what method it does!

- Method names must **describe an action**, so they should contain **verb** or **verb + noun**

- In C# method naming follow PascalCase. Example : SendEmail(); GetPosition(); -> this are good method names!

- The method resolves the task it is created for, or returns an error!(throw exception!)

- A method must have **minimum dependency** on the class in which the method is declared and to other methods and classes! This is knowns as **loose coupling**.

- Method must do its job by using the data that passed to it as parameters, but not data that can be accesses from other places.(like global variables,etc)

- It is recommended that the methods must be **short**. Methods are longer than computer screen are avoided!

- Method should do what its name says or throw exception! Method should **never return wrong result**