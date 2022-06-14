# Chapter 4-> Console Input and Output
- There is 3 important thing about Console class. Console.In for input, Console.Out for output and Console.Error for errors!
- Console is good for succint and fast interaction with program without bothering with GUI and such.
- When we writing small and simple programs using Console can be really good instead of GUI stuff!
- Operating system shells are two type :\
    CLI : Command Line interface, is console for commands(such as cmd.exe in Windows and bash in Linux)\
    GUI : Graphical User Interface, is graphical work environment (such as Windows Explorer)

![Some Command Line Commands on Windows](https://github.com/mrsahin101/Fundamentals_of_Programming_Csharp/blob/main/Chapter4_Console_Input_Output/Images/CommandLine_commands.png)

- The standart Standart-I/O is created since UNIX operating system was created.
- Standart Input stream -> in C# Console.In
- Standart Output stream -> in C# Console.Out
- Standart Error stream -> in C# Console.Error

- We usually work with System.Console class. But if we want we can modify those streams at run time.
- Console.WriteLine() -> print content then add new line to it.
- Console.Write() -> Just writes the content of input. no new line.

- When a string is involved in concatenation with any other type the result is always string.

- String concatenation is happening from left to right. Keep it in mind!

- When you concatenate strings and also sum numbers, use parentheses to specify correct order of operations. Otherwise they are executed from left to right!
- New line on Windiws : \r\n New line on Unix-based Operating Systems : \n
- This doesn't matter writing on console. The console will understand we meant \r\n. But if we trying to write to file we should use \r\n.(For Windows OS)
