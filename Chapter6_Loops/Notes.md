# Chapter 6-> LOOPS

###  While Loop Syntax :
    while(condition)    
    {
        loop body;
    }
    // condition has to be boolean

- Break keyword when reached its breaking the loop instantly.

### DO-While Loop Syntax : (this also knows post-test loop)
    do
    {
        executable code;
    }while(condition);

- If you want to work with really big numbers you can work with BigInteger and its very large. (it could be using 100000 digits.) as long as you have enough memory big integers are good

### For Loop Syntax :

    for(initialization; condition; update)
    {
        loop's body;
    }

    // infinite loop
    for( ; ;)
    {
        loop body
    }
### Nested For Loop
    for(initialization; verification; update)
    {
        for(initialization; verification; update)
        {
            // Executable code...
        }
        ....
    }


### Foreach Loop Syntax : Also known as extended For Loop
    foreach(type variable in collection)
    {
        statements;
    }

* iterates over all elements of an array, list or other collection of elements(IEnumerable)

- CPU can make many computation so fast in really short period of time. But when it comes to printing out text to console this can be 10K to 20K lines per second. Printing text is slow.

- Foreach Loop is **read-only**, so we cannot modify the current loop item from the loop body.