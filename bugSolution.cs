public class MyClass {
    public int MyProperty { get; set; }

    public void MyMethod() {
        int x = 5;
        // Increment x after checking condition
        if (x == 5) { 
            Console.WriteLine("x is 5");
            x++;
        }
    }
}