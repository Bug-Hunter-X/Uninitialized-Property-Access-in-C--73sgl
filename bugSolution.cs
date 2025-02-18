public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize with a default value

    public ExampleClass() //Constructor to ensure correct value
    {
        MyProperty = 10; // or assign it properly
    }
    public void MyMethod()
    {
        int value = this.MyProperty * 2; 
        Console.WriteLine(value);
    }
}