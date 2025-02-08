public class MyClass {
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public MyClass() {
        MyProperty = 0; // Initialize to a default value
    }

    public void MyMethod() {
        Console.WriteLine(MyProperty); // Now MyProperty is initialized
    }
}