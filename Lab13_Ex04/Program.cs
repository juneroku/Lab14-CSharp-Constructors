var circle = new Circle();
var rectangle = new Rectangle();
var triangle = new Triangle();

class Shape
{
    private int? NumOfSide;
    // เปลี่ยน constructor นี้เป็น protected หรือ public
    protected Shape()  // หรือ public
    {
        System.Console.WriteLine("This is some shape with unknown side");
    }
    
    public Shape(int NumOfSide)
    {
        System.Console.WriteLine($"This is some shape with {NumOfSide} sides");
    }
}

class Circle : Shape
{
    public Circle() : base() // เรียก constructor ของ Shape ที่ไม่มีพารามิเตอร์
    {
        System.Console.WriteLine("This is a circle");
    }
}

class Rectangle : Shape
{
    public Rectangle() : base(4) // เรียก constructor ของ Shape ที่มีพารามิเตอร์
    {
        System.Console.WriteLine("This is a rectangle");
    }
}

class Triangle : Shape
{
    public Triangle() : base(3) // เรียก constructor ของ Shape ที่มีพารามิเตอร์
    {
        System.Console.WriteLine("This is a triangle");
    }
}
