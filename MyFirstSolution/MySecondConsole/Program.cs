using System;
using System.Text;
using static System.Console;


class Program
{
    static void Main(string[] args)
    {
        
        const double Pi = 3.141592653;
        const decimal E = 1.414213562373095048M;
        OutputEncoding = Encoding.UTF8;

        WriteLine("Hello! This program can help you execute a mathematical quest" +
                  "\nThis program contains the basic formulas where \u03c0 is used." +
                  $"\n\u03c0 = {Pi} \te = {E}");
        WriteLine("Enter \"help\" to see list of formulas" +
                  "\nIf you have chosen the wrong formula or want to end your work, " +
                  "enter <exit>");
        StartMenu:
        WriteLine("what the programm can you use?");
        string userChoice = ReadLine();
        switch (userChoice.ToLower())
        {
            case "help":
                Help();
                goto StartMenu;
            case "1":
                WriteLine("Length circumference in using of radius:");
                CircumferenceRadius();
                goto StartMenu;
            case "2":
                WriteLine("Circumference in terms of diameter");
                WriteLine("Please, enter diameter(D)");
                CircumferencePiValue();
                goto StartMenu;
            case "3":
                WriteLine("Circumference in terms of the area of a circle");
                CircumferenceAreaOfCircle();
                goto StartMenu;
            case "4":
                WriteLine("Circumference of a circle through the diagonal of an inscribed rectangle");
                WriteLine("Please, enter diagonal(d)");
                CircumferencePiValue();
                goto StartMenu;
            case "5":
                WriteLine("Circumference through the side of the circumscribed square");
                WriteLine("Please, enter side(a)");
                CircumferencePiValue();
                goto StartMenu;
            case "6":
                WriteLine("circumference in terms of sides and area of an inscribed triangle");
                CircumferenceSidesAndArea();
                goto StartMenu;
            case "7":
                WriteLine("circumference in terms of area and half-perimeter of an inscribed triangle");
                CircumferenceAreaAndHalfPerimeter();
                goto StartMenu;
            case "8":
                WriteLine("circumference through the side of an inscribed regular polygon");
                CircumferenceRegularPolygon();
                goto StartMenu;
            case "9":
                WriteLine("arc length through angle and radius");
                ArcLength();
                goto StartMenu;
            case "10":
                WriteLine("Circle area in terms of radius");
                CircleAreaOfRadius();
                goto StartMenu;
            case "11":
                WriteLine("Circle area in terms of diameter");
                CircleAreaOfDiameter();
                goto StartMenu;
            case "12":
                WriteLine("Circle diameter in terms of circumference");
                CircleDiameterOfLenght();
                goto StartMenu;
            case "13":
                WriteLine("Circle radius through area");
                CircleRadiusOfArea();
                goto StartMenu;
            case "14":
                WriteLine("Circle radius through lenght");
                CircleRadiusOfLength();
                goto StartMenu;
            case "15":
                WriteLine("the radius of the circle through the area of the sector and the central angle");
                CircleRadiusOfAreaAndCentralAngle();
                goto StartMenu;
            case "16":
                WriteLine("The area of a sector of a circle in terms of the radius and angle of the sector");
                SectorAreaOfRadiusAndAngle();
                goto StartMenu;
            case "17":
                WriteLine("Ring area in terms of inner and outer radius");
                RingAreaOfRadius();
                goto StartMenu;
            case "18":
                WriteLine("Volume of a circular cylinder in terms of height and radius");
                VolumeCylinderOfRadiusAndHeight();
                goto StartMenu;
            case "19":
                WriteLine("Side surface area of a right circular cylinder in terms of radius and height");
                AreaOfRightCylinder();
                goto StartMenu;
            case "20":
                WriteLine("Volume of a circular cone in terms of radius and height");
                VolumeOfCircularCone();
                goto StartMenu;
            case "21":
                WriteLine("The area of the lateral surface of a right circular cone through the generatrix and the radius");
                AreaOfRightCircularCone();
                goto StartMenu;
            case "22":
                WriteLine("Volume of a sphere in terms of radius");
                VolumeSphere();
                goto StartMenu;
            case "23":
                WriteLine("Area of a sphere in terms of radius");
                AreaSphere();
                goto StartMenu;
            case "exit":
                WriteLine("Goodbye!");
                break;
            default:
                NotCorrect();
                goto StartMenu;
        }
        void Help()
        {
            WriteLine("You can use the following formulas:" +
                "\n1) Find the circumference of a circle using the radius;" +
                "\n2) Find the circumference of a circle using the diameter;" +
                "\n3) Find the circumference of a circle using the area of a circle;" +
                "\n4) Find the circumference of a circle using the diagonal of an inscribed rectangle;" +
                "\n5) Find the circumference of a circle using the side of the circumscribed square;" +
                "\n6) Find the circumference of a circle using the sides and area of an inscribed triangle;" +
                "\n7) Find the circumference of a circle using the area and semiperimeter of the circumscribed triangle;" +
                "\n8) Find the circumference of a circle using the side of an inscribed regular polygon;" +
                "\n9) Find the length of a circular arc using radius and central angle;" +
                "\n10) Find the area of a circle using the radius;" +
                "\n11) Find the area of a circle using the diameter;" +
                "\n12) Find the diameter of a circle using the circumference of a circle;" +
                "\n13) Find the radius of a circle using the area of a circle;" +
                "\n14) Find the radius of a circle using the circumference of a circle;" +
                "\n15) Find the radius of a circle using the area of the sector of the circle and the central angle;" +
                "\n16) Find area of a sector using radius and angle;" +
                "\n17) Find the area of a ring using the inner and outer radius;" +
                "\n18) Find the volume of a circular cylinder using radius and height;" +
                "\n19) Find the lateral surface area of a right circular cone using radius and height;" +
                "\n20) Find the volume of a circular cone using radius and height;" +
                "\n21) Find the lateral surface area of a right circular cone using the generatrix and the radius;" +
                "\n22) Find the volume of a sphere using the radius;" +
                "\n23) Find the surface area of a sphere (area of a sphere) using the radius;");
        }
        void CircumferenceRadius()
        {
            WriteLine("Please, enter radius(R):");
            string userEnter = ReadLine();
            if (userEnter.ToLower() == "exit")
            {
                return;
            }
            try
            {
                double radius = Validation(userEnter);
                double length = 2.0 * Pi * radius;
                WriteLine($"Circumference is {length}");
            }
            catch (Exception)
            {
                NotCorrect();
                CircumferenceRadius();
            }
        }
        void CircumferencePiValue()
        {
            string userEnter = ReadLine();
            if (userEnter.ToLower() == "exit")
            {
                return;
            }
            try
            {
                double value = Validation(userEnter);
                double length = Pi * value;
                WriteLine($"Circumference is {length}");
            }
            catch (Exception)
            {
                NotCorrect();
                CircumferencePiValue();
            }
        }
        void CircumferenceAreaOfCircle()
        {
            WriteLine("Please, enter area of a circle(S):");
            string userEnter = ReadLine();
            if (userEnter.ToLower() == "exit")
            {
                return;
            }
            try
            {
                double areaOfCircle = Validation(userEnter);
                double length = Math.Sqrt((areaOfCircle * 4 * Pi));
                WriteLine($"Circumference is {length}");
            }
            catch (Exception)
            {
                NotCorrect();
                CircumferenceAreaOfCircle();
            }
        }
        void CircumferenceSidesAndArea()
        {
            WriteLine("Please, enter area of a triangle(S):");
            string userEnter = ReadLine();
            if (userEnter.ToLower() == "exit")
            {
                return;
            }
            try
            {
                double areaOfTriangle = Validation(userEnter);
                WriteLine("Please, enter side A:");
                double sideA = Validation(ReadLine());
                WriteLine("Please, enter side B:");
                double sideB = Validation(ReadLine());
                WriteLine("Please, enter side C:");
                double sideC = Validation(ReadLine());
                double length = Pi * ((sideA * sideB * sideC)/(2 * areaOfTriangle));
                WriteLine($"Circumference is {length}");
            }
            catch (Exception)
            {
                NotCorrect();
                CircumferenceSidesAndArea();
            }
        }
        void CircumferenceAreaAndHalfPerimeter()
        {
            WriteLine("Please, enter half-perimeter(p):");
            string userEnter = ReadLine();
            if (userEnter.ToLower() == "exit")
            {
                return;
            }
            try
            {
                double areaOfTriangle = Validation(userEnter);
                WriteLine("Please, enter area of an inscribed triangle:");
                double halfPerimeter = Validation(ReadLine());
                double length = (2 * Pi) * (areaOfTriangle / halfPerimeter);
                WriteLine($"Circumference is {length}");
            }
            catch (Exception)
            {
                NotCorrect();
                CircumferenceAreaAndHalfPerimeter();
            }
        }
        void CircumferenceRegularPolygon()
        {
            WriteLine("Please, enter number of sides of a polygon(N):");
            string userEnter = ReadLine();
            if (userEnter.ToLower() == "exit")
            {
                return;
            }
            try
            {
                double numberOfSides = Validation(userEnter);
                WriteLine("Please, enter side of the polygon:");
                double sideOfPolygon = Validation(ReadLine());
                double length = Pi * (sideOfPolygon / (Math.Sin(180/numberOfSides)));
                WriteLine($"Circumference is {length}");
            }
            catch (Exception)
            {
                NotCorrect();
                CircumferenceRegularPolygon();
            }
        }
        void ArcLength()
        {
            WriteLine("Please, enter circle radius(r):");
            string userEnter = ReadLine();
            if (userEnter.ToLower() == "exit")
            {
                return;
            }
            try
            {
                double radius = Validation(userEnter);
                WriteLine("Please, enter central angle in degrees:");
                double centralAngle = Validation(ReadLine());
                double length = (Pi * radius * centralAngle) / 180;
                WriteLine($"Arc length is {length}");
            }
            catch (Exception)
            {
                NotCorrect();
                ArcLength();
            }
        }
        void CircleAreaOfRadius()
        {
            WriteLine("Please, enter radius(R):");
            string userEnter = ReadLine();
            if (userEnter.ToLower() == "exit")
            {
                return;
            }
            try
            {
                double radius = Validation(userEnter);
                double area = Pi * Math.Pow(radius, 2);
                WriteLine($"Area of a circle is {area}");
            }
            catch (Exception)
            {
                NotCorrect();
                CircleAreaOfRadius();
            }
        }
        void CircleAreaOfDiameter()
        {
            WriteLine("Please, enter diameter(D):");
            string userEnter = ReadLine();
            if (userEnter.ToLower() == "exit")
            {
                return;
            }
            try
            {
                double diameter = Validation(userEnter);
                double area = (Pi * Math.Pow(diameter, 2)) / 4;
                WriteLine($"Area of a circle is {area}");
            }
            catch (Exception)
            {
                NotCorrect();
                CircleAreaOfDiameter();
            }
        }
        void CircleDiameterOfLenght()
        {
            WriteLine("Please, enter circumference(L):");
            string userEnter = ReadLine();
            if (userEnter.ToLower() == "exit")
            {
                return;
            }
            try
            {
                double circumference = Validation(userEnter);
                double diameter = circumference / Pi;
                WriteLine($"Circle diameter is {diameter}");
            }
            catch (Exception)
            {
                NotCorrect();
                CircleDiameterOfLenght();
            }
        }
        void CircleRadiusOfArea()
        {
            WriteLine("Please, enter area(S):");
            string userEnter = ReadLine();
            if (userEnter.ToLower() == "exit")
            {
                return;
            }
            try
            {
                double area = Validation(userEnter);
                double radius = Math.Sqrt(area/Pi);
                WriteLine($"Circle radius is {radius}");
            }
            catch (Exception)
            {
                NotCorrect();
                CircleRadiusOfArea();
            }
        }
        void CircleRadiusOfLength()
        {
            WriteLine("Please, enter lenght(P):");
            string userEnter = ReadLine();
            if (userEnter.ToLower() == "exit")
            {
                return;
            }
            try
            {
                double lenght = Validation(userEnter);
                double radius = lenght / (2 * Pi);
                WriteLine($"Circle radius is {radius}");
            }
            catch (Exception)
            {
                NotCorrect();
                CircleRadiusOfLength();
            }
        }
        void CircleRadiusOfAreaAndCentralAngle()
        {
            WriteLine("Please, enter area of a sector of a circle(S):");
            string userEnter = ReadLine();
            if (userEnter.ToLower() == "exit")
            {
                return;
            }
            try
            {
                double areaOfSector = Validation(userEnter);
                WriteLine("Please, enter central angle in degrees:");
                double centralAngle = Validation(ReadLine());
                double radius = Math.Sqrt((360 * areaOfSector)/(Pi * centralAngle));
                WriteLine($"Circle radius is {radius}");
            }
            catch (Exception)
            {
                NotCorrect();
                CircleRadiusOfAreaAndCentralAngle();
            }
        }
        void SectorAreaOfRadiusAndAngle()
        {
            WriteLine("Please, enter area of a sector of a circle(S):");
            string userEnter = ReadLine();
            if (userEnter.ToLower() == "exit")
            {
                return;
            }
            try
            {
                double radius = Validation(userEnter);
                WriteLine("Please, enter sector angle in degrees:");
                double sectorAngle = Validation(ReadLine());
                double area = Pi * Math.Pow(radius, 2) * (sectorAngle / 360);
                WriteLine($"Sector area of a circle is {area}");
            }
            catch (Exception)
            {
                NotCorrect();
                SectorAreaOfRadiusAndAngle();
            }
        }
        void RingAreaOfRadius()
        {
            WriteLine("Please, enter outer radius(R):");
            string userEnter = ReadLine();
            if (userEnter.ToLower() == "exit")
            {
                return;
            }
            try
            {
                double outerRadius = Validation(userEnter);
                WriteLine("Please, enter inner radius(r):");
                double innerRadius = Validation(ReadLine());
                double area = Pi * (Math.Pow(outerRadius,2) - Math.Pow(innerRadius,2));
                WriteLine($"Ring area is {area}");
            }
            catch (Exception)
            {
                NotCorrect();
                RingAreaOfRadius();
            }
        }
        void VolumeCylinderOfRadiusAndHeight()
        {
            WriteLine("Please, enter radius(R):");
            string userEnter = ReadLine();
            if (userEnter.ToLower() == "exit")
            {
                return;
            }
            try
            {
                double radius = Validation(userEnter);
                WriteLine("Please, enter height:");
                double height = Validation(ReadLine());
                double volume = Pi * height * Math.Pow(radius,2);
                WriteLine($"Volume of a circular cylinder is {volume}");
            }
            catch (Exception)
            {
                NotCorrect();
                VolumeCylinderOfRadiusAndHeight();
            }
        }
        void AreaOfRightCylinder()
        {
            WriteLine("Please, enter radius(R):");
            string userEnter = ReadLine();
            if (userEnter.ToLower() == "exit")
            {
                return;
            }
            try
            {
                double radius = Validation(userEnter);
                WriteLine("Please, enter height:");
                double height = Validation(ReadLine());
                double area = 2 * Pi * radius * height;
                WriteLine($"Lateral surface area of a right circular cylinder is {area}");
            }
            catch (Exception)
            {
                NotCorrect();
                AreaOfRightCylinder();
            }
        }
        void VolumeOfCircularCone()
        {
            WriteLine("Please, enter radius(R):");
            string userEnter = ReadLine();
            if (userEnter.ToLower() == "exit")
            {
                return;
            }
            try
            {
                double radius = Validation(userEnter);
                WriteLine("Please, enter height:");
                double height = Validation(ReadLine());
                double volume = (Pi * Math.Pow(radius,2) * height) / 3;
                WriteLine($"Volume of a circular cone is {volume}");
            }
            catch (Exception)
            {
                NotCorrect();
                VolumeOfCircularCone();
            }
        }
        void AreaOfRightCircularCone()
        {
            WriteLine("Please, enter radius(R):");
            string userEnter = ReadLine();
            if (userEnter.ToLower() == "exit")
            {
                return;
            }
            try
            {
                double radius = Validation(userEnter);
                WriteLine("Please, enter a generatrix:");
                double generatrix = Validation(ReadLine());
                double area = Pi * radius * generatrix;
                WriteLine($"Lateral surface area of a right circular cone is {area}");
            }
            catch (Exception)
            {
                NotCorrect();
                AreaOfRightCircularCone();
            }
        }
        void VolumeSphere()
        {
            WriteLine("Please, enter radius(R):");
            string userEnter = ReadLine();
            if (userEnter.ToLower() == "exit")
            {
                return;
            }
            try
            {
                double radius = Validation(userEnter);
                double volume = (4/3) * Pi * Math.Pow(radius,3);
                WriteLine($"Sphere volume is {volume}");
            }
            catch (Exception)
            {
                NotCorrect();
                VolumeSphere();
            }
        }
        void AreaSphere()
        {
            WriteLine("Please, enter radius(R):");
            string userEnter = ReadLine();
            if (userEnter.ToLower() == "exit")
            {
                return;
            }
            try
            {
                double radius = Validation(userEnter);
                double area = 4 * Pi * Math.Pow(radius,2);
                WriteLine($"Sphere area is {area}");
            }
            catch (Exception)
            {
                NotCorrect();
                VolumeSphere();
            }
        }

        void NotCorrect()
        {
            WriteLine("You have entered incorrect data! try again.");
        }
        double Validation(string x)
        {
            if (x.Contains('.'))
            {
                x = x.Replace('.', ',');
            }
            if (x == string.Empty)
            {
                x = "null";
            }
            double value = double.Parse(x);
            return value;
            
        }
    }
}