# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property that hasn't been initialized before using it.  Uninitialized properties of reference types will have a null value which can lead to `NullReferenceException` errors, while value types may have their default values, which may not be the expected value. 

**Problem:**
The `MyProperty` in `MyClass` is accessed in `MyMethod` without first assigning a value.  This can result in unpredictable behavior depending on the property type. 

**Solution:**
Initialize the property in the constructor, or before accessing it in the method.