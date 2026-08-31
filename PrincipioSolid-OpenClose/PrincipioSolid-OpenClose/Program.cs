
using PrincipioSolid_OpenClose;

AreaCalculator calculator = new AreaCalculator();

Circle circle1 = new Circle();
circle1.Radius = 2;

Circle circle2 = new Circle();
circle2.Radius = 3;

Circle circle3 = new Circle();
circle3.Radius = 4;


Square square1 = new Square();
square1.Size = 5;

Square square2 = new Square();
square2.Size = 4;

Square square3 = new Square();
square3.Size = 7;

Triangulo triangulo1 = new Triangulo();
triangulo1.Base = 5;
triangulo1.Altura = 2;

Triangulo triangulo2 = new Triangulo();
triangulo2.Base = 4;
triangulo2.Altura = 3;

Triangulo triangulo3 = new Triangulo();
triangulo3.Base = 8;
triangulo3.Altura = 8;

Hexagono Hexagono1 = new Hexagono();
Hexagono1.Perimetro = 6;
Hexagono1.Apotema = 5;

Hexagono Hexagono2 = new Hexagono();
Hexagono2.Perimetro = 8;
Hexagono2.Apotema = 7;

Hexagono Hexagono3 = new Hexagono();
Hexagono3.Perimetro = 10;
Hexagono3.Apotema = 9;

Trapecio Trapecio1 = new Trapecio();
Trapecio1.Basemayor = 14;
Trapecio1.Basemenor = 8;
Trapecio1.Altura = 6;


Trapecio Trapecio2 = new Trapecio();
Trapecio2.Basemayor = 17;
Trapecio2.Basemenor = 9;
Trapecio2.Altura = 5;

Trapecio Trapecio3 = new Trapecio();
Trapecio3.Basemayor = 20;
Trapecio3.Basemenor = 12;
Trapecio3.Altura = 8;





List<Shape> shapes = new List<Shape>();
shapes.Add(circle1);
shapes.Add(circle2);
shapes.Add(circle3);
shapes.Add(square1);
shapes.Add(square2);
shapes.Add(square3);
shapes.Add(triangulo1);
shapes.Add(triangulo2);
shapes.Add(triangulo3);

shapes.Add(Hexagono1);
shapes.Add(Hexagono2);
shapes.Add(Hexagono3);
shapes.Add(Trapecio1);
shapes.Add(Trapecio2);
shapes.Add(Trapecio3);



var resultTotalArea = calculator.TotalArea(shapes);

Console.WriteLine($"El área total es {resultTotalArea}");