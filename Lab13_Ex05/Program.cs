var circle = new Circle();
var rectangle = new Rectangle();
var triangle = new Triangle();

class Shape
{
    private int? NumOfSide;

    // Constructor ที่ไม่มีพารามิเตอร์
    protected Shape() 
    {
    }

    // Constructor ที่รับพารามิเตอร์ NumOfSide
    public Shape(int NumOfSide) : this() 
    {
        this.NumOfSide = NumOfSide;
        System.Console.WriteLine($"This is some shape with {NumOfSide} sides");
    }
}

class Circle : Shape
{
    public Circle() : base(0) // ระบุจำนวนขอบเป็น 0 สำหรับวงกลม
    {
        System.Console.WriteLine("This is a circle");
    }
}

class Rectangle : Shape
{
    public Rectangle() : base(4) // ระบุจำนวนขอบเป็น 4 สำหรับสี่เหลี่ยม
    {
        System.Console.WriteLine("This is a rectangle");
    }
}

class Triangle : Shape
{
    public Triangle() : base(3) // ระบุจำนวนขอบเป็น 3 สำหรับสามเหลี่ยม
    {
        System.Console.WriteLine("This is a triangle");
    }
}
