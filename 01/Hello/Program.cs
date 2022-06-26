Math m = new Math();
int total = 0;
int x = (new Random()).Next(10, 20);
int y = (new Random()).Next(10, 20);
total = m.add(x, y);

Console.WriteLine($"The sum of {x} and {y} is {total}");
Console.WriteLine($"The concat of {x} and {y} is {m.add(x.ToString(), y.ToString())}");

public class Math {
    public int add(int x, int y) => x + y;
    public string add(string x, string y) => x + y;
    public float add(float x, float y) => x + y;
}
