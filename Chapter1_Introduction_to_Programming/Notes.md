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
- API's has to be explained to user. The explanations and instructions are called documentation.

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

## Flavours
- .NET Framework -> General purpose
- .NET Compact Framework (CF) -> Light version of .NET framework. Usually for Mobile Apps etc
- Silverlight -> Light version of .NET framework. Usually for browsers, Rich Internet Applications etc
- .NET for Windows Store Apps -> Designed for programs that going to run on Windows machines

# Compiling Code And IDE's
