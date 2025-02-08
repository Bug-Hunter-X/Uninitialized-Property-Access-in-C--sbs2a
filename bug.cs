public class MyClass {
    public int MyProperty { get; set; }

    public void MyMethod() {
        // Accessing a property that hasn't been initialized can lead to unexpected behavior.
        Console.WriteLine(MyProperty); // Uninitialized property
    }
}