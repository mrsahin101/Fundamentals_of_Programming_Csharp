## Chapter 1-> Introduction to Programming

# Stages in Software Development

- Gathering Requirments for product and creating Task
- Planning and preparing the architecture design
- Implementation
- Product Trails(testing)
- Deployment and exploitation
- Support

# Usefull Information snippets in Chapter
- Every C# program starts from Main() method. It must be static void.
- C# is case sensitive. it means that we need to be carefull about upper-case or lower-case letters
- Code indentetion is not important to compiler.But improves code readability. Good format and identation is good practice.
- Writing each class in separate file helps for code readability and code modularity
- Programs written .NET frame-work languages can easly be changed to each other. For example from Visual Basic to C# or vice versa. or F# etc
- .NET has rich libraries can be used to speed-up development process.
- Each .NET library has API(Application Programming Interface) offering to our usage.
- API's has to be explained to user. The explanations and instructions are called documentation. Microfost Documentation -> https://docs.microsoft.com/en-us/documentation/
- To develop C# projects on Linux: There is called MONO-project open source software. Can experiment with it later.
- When we create files it's important to give meaningfull names

# Usefull Command-Line Commands
- md : make new directory
- cd : change to directory
- csc : C# compilier command

# Some Formatting Rules
- All class name must start with a capital letter
- Variable names must begin with a lower-case letter
- Methods name must start with a capital letter

# C# Language
- Modern, General-Purpose, Object-Oriented High Level Programming Language
- Syntax similiar to C and C++

# Keywords of C#
- abstract      -as             -base           -bool           -break      -byte
- case          -catch          -char           -checked        -class      -const
- continue      -decimal        -default        -delegate       -do         -double
- else          -enum           -event          -explicit       -extern     -false
- finally       -fixed          -float          -for            -foreach    -goto
- if            -implicit       -in             -int            -interface  -internal
- is            -lock           -long           -namespace      -new        -null
- object        -operator       -out            -override       -params     -private
- protected     -public         -readonly       -ref            -return     -sbyte
- sealed        -short          -sizeof         -stackalloc     -static     -string
- struct        -switch         -this           -throw          -true       -try
- typeof        -uint           -ulong          -unchecked      -unsafe     -ushort
- using         -virtual        -void           -volatile       -while

* There might be more keywords. This is kinda general list of it and some of them are not used. I just wanted to write it once to go through them. Future ME don't laugh at me :)

# Automatic Memory Managment
- C# has automatic garbage collector. This helps alot to write software and make development faster. CLR(Common Language Run-Time) has built in garbage collector.

# Common Language Run-Time(CLR)
- When we compile code we don't turn it to specific processor machine code. Rather We turn it into Microsoft Intermediate Language(MSIL).
Then it's executed in virtual envoirment called CLR(Common Language Run-Time)
- CLR is basicly virtual machine which has own registers and instruction. It ensures the execution of .NET programs on different hardware platforms and Operating Systems.

# .NET Platform
- .NET technology is collection of .NET classes, libraries, tools, standarts, and other programming means.
## Flavours
- .NET Framework -> General purpose
- .NET Compact Framework (CF) -> Light version of .NET framework. Usually for Mobile Apps etc
- Silverlight -> Light version of .NET framework. Usually for browsers, Rich Internet Applications etc
- .NET for Windows Store Apps -> Designed for programs that going to run on Windows machines

# Compiling Code And IDE's
- Integrated Development Envoirments( IDE's) can be really usefull to use when dealing with big projects. 
- IDE's can be used for debugging, coding, testing, acessing other libraries, designing UI, etc..
- When trying to compile a code and giving errors; checking error messages helping a lot to find where the problem is.
- There are few alternatives to Visual Studio but honestly none of them is good as Visual Studio.

# Debugging 

- Debugging is important part of software development.
- We can use breakpoints, Step-by-Step execution to find the bugs.
- Once we find the problem with debugging we can correct it easly.

# Decompiling
- Decompiling can be used to extract source file from .exe file. In some cases can be usefull.
- ILSpy or JustDecompile tools can be used.

# Other .NET Languages

## VB.NET 
- Successor of Visual Basic 6.0
- Not recommended
- Similiar to C#

## Managed C++ 
- Implementation of C++ to .NET framework.

## F#
- Functional programming for .NET

## JavaScript
- Javascript implementation for .NET