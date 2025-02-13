public class MyClass {
    public int MyProperty { get; set; }

    public void MyMethod() {
        int x = 5;
        // Forgot to increment x
        if (x == 5) { 
            Console.WriteLine("x is 5");
        }
    }
}