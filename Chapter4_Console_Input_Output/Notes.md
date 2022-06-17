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
- Composite Formatting strings can be so usefull. General Syntax for it : {index[,alignment][:format string] }
- Composite formatting basicly using 2 things. 
1. Composite formatting string
2. Series of arguments.


- The index component indicates the position of component.

- When formatting item refer to argument does not exist, an exception is thrown.

- The alignment component is optional and it indicates the string alignment.
Example : Console.WriteLine("{0,6}",123);
Console Output :   123;

- formatString component specifies formatting of the string. There are 3 types of it.
1. for numerical types of arguments
2. for arguments of type date (DateTime)
3. for arguments of type enumeration (listed types)

MSDN Documentation about formats : https://docs.microsoft.com/en-us/dotnet/standard/base-types/formatting-types

### Standart Formats for Numbers 

![Some Command Line Commands on Windows](https://github.com/mrsahin101/Fundamentals_of_Programming_Csharp/blob/main/Chapter4_Console_Input_Output/Images/StandartFormats_forNumbers.png)

- Part of formatting is determined by **the current "culture" settings** which taken by default ffrom your regional settings of Operating system.


### Custom Formats for Numbers 
- With custom formats we can build our custom representation of data. These ares building blocks for custom formats.

![Some Command Line Commands on Windows](https://github.com/mrsahin101/Fundamentals_of_Programming_Csharp/blob/main/Chapter4_Console_Input_Output/Images/CustomFormats_forNumbers.png)

- These are just examples. More details can be found on MSDN documentation.

### Standart Defined Date Formats

![Some Command Line Commands on Windows](https://github.com/mrsahin101/Fundamentals_of_Programming_Csharp/blob/main/Chapter4_Console_Input_Output/Images/StandartFormatsForDates.png)

### Custom Formats for Dates

![Some Command Line Commands on Windows](https://github.com/mrsahin101/Fundamentals_of_Programming_Csharp/blob/main/Chapter4_Console_Input_Output/Images/CustomFormatsForDates.png)

- When using the specifiers we can insert different separators between different parts of date, such as ".", "/".

### Format String Enumeration Components

![Some Command Line Commands on Windows](https://github.com/mrsahin101/Fundamentals_of_Programming_Csharp/blob/main/Chapter4_Console_Input_Output/Images/FormatStringsEnumerationComponents.png)

- When using format strings it is possible one and same program to print different values depending on the **localization settings** for the operating system.
- When launching console application its automatically retrives the operating system localization (culture settings ) and uses it for reading and writing formatted data.
- .NET framework culture settings can manually be changed via System.Globalization.CultureInfo

# CONSOLE INPUT 
