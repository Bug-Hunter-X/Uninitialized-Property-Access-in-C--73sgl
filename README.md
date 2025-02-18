# Uninitialized Property Access in C#

This repository demonstrates a common error in C# where a class property is accessed before it has been properly initialized.  This can lead to unexpected behavior or runtime exceptions.

The `bug.cs` file contains the problematic code. The `bugSolution.cs` file provides a corrected version.

## Problem

The `ExampleClass` in `bug.cs` attempts to use the `MyProperty` before it has a value. If the property is not assigned a default value, it will cause an unexpected value to be used, possibly throwing exceptions.