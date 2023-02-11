namespace PruebaCodifico 
{
    // Declare the abstract class Figure
    public abstract class Figure
    {
        // Declare the abstract method CalculateArea
        public abstract double CalculateArea();
    }

    // Declare the class Circle which inherits from Figure
    public class Circle : Figure
    {
        // Declare the private field radius
        private double radius;

        // Declare the constructor which takes the radius
        public Circle(double radius)
        {
            // Initialize the private field radius.
            this.radius = radius;
        }

        // Override the abstract method CalculateArea to return the area of a circle
        public override double CalculateArea()
        {
            // Return the area of the circle
            return Math.PI * Math.Pow(radius, 2);
        }
    }

    // Declare the class Rectangle which inherits from Figure
    public class Rectangle : Figure
    {
        // Declare the private fields width and height.
        private double width;
        private double height;

        // Declare the constructor which takes the width and height
        public Rectangle(double width, double height)
        {
            // Initialize the private fields width and height.
            this.width = width;
            this.height = height;
        }

        // Override the abstract method CalculateArea to return the area of a rectangle
        public override double CalculateArea()
        {
            // Return the area of the rectangle
            return width * height;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Declare variable continueProccess for validate the cycle
            bool continueProccess = true;

            // Conditional for repeat the process or finish it 
            do
            {
                // Declare a Figure object and initialize it as a null
                Figure figure = null;

                // Display the options
                Console.WriteLine("Calculadora de Área del Círculo y Rectángulo");
                Console.WriteLine("1. Círculo");
                Console.WriteLine("2. Rectángulo");
                Console.WriteLine("Seleccione la figura para calcular su área: ");

                // Try to calculate the area
                try
                {
                    // Read the option (1 or 2)
                    int option = int.Parse(Console.ReadLine());

                    // Evaluate the option and do the process
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el radio del círculo: ");
                            double radius = double.Parse(Console.ReadLine());
                            figure = new Circle(radius);
                            break;
                        case 2:
                            Console.WriteLine("Ingrese el ancho del rectángulo: ");
                            double width = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la altura del rectángulo: ");
                            double height = double.Parse(Console.ReadLine());
                            figure = new Rectangle(width, height);
                            break;
                        default:
                            Console.WriteLine("La opción no es válida");
                            break;
                    }

                    if (figure != null)
                    {
                        // Validate the figure and display the result
                        if (option == 1)
                        {
                            Console.WriteLine("El área del círculo es: " + figure.CalculateArea());
                        }
                        else
                        {
                            Console.WriteLine("El área del rectángulo es: " + figure.CalculateArea());
                        }
                    }

                    Console.WriteLine("");
                    Console.WriteLine("¿Desea calcular otra área?");
                    Console.WriteLine("1. Si, continuar");
                    Console.WriteLine("2. No, salir");
                    int optionExit = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    continueProccess = optionExit == 1 ? true : false;
                }
                catch (FormatException ex)
                {
                    // Display the error message
                    Console.WriteLine("Entrada no válida: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // Display the error message
                    Console.WriteLine("Error: " + ex.Message);
                }

            } while (continueProccess);
        }
    }
}
