internal class Program
{
    private static void Main(string[] args)
    {
        int luaChon;

        do
        {
            InMenu();
            System.Console.WriteLine("Enter choice: ");
            luaChon = int.Parse(Console.ReadLine());

            intHinh(luaChon);
        } while (luaChon != 7);
    }

    static void InMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Print the rectangle");
        Console.WriteLine("2. Print the square triangle (botton-left)");
        Console.WriteLine("3. Print the square triangle (top-left)");
        Console.WriteLine("4. Print the square triangle (botton-right)");
        Console.WriteLine("5. Print the square triangle (top-right)");
        Console.WriteLine("6. Print isosceles triangle");
        Console.WriteLine("7. Exit");
    }
    static void intHinh(int luaChon)
    {
        switch (luaChon)
        {
            case 1:
                InHinhChuNhat();
                break;
            case 2:
                InTamGiacVuongGocTraiDuoi();
                break;
            case 3:
                InTamGiacVuongGocTraiTren();
                break;
            case 4:
                InTamGiacVuongGocPhaiDuoi();
                break;
            case 5:
                InTamGiacVuongGocPhaiTren();
                break;
            case 6:
                InTamGiacCan();
                break;
            case 7:
                Console.WriteLine("Exit!");
                break;
            default:
                Console.WriteLine("Not sutable choice!");
                break;
        }
    }

    static void InHinhChuNhat()
    {
        System.Console.WriteLine("Enter Length: ");
        int chieuDai = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter Height: ");
        int chieuRong = int.Parse(Console.ReadLine());

        for (int i = 1; i <= chieuDai; i++)
        {
            for (int j = 1; j <= chieuRong; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void InTamGiacVuongGocTraiDuoi()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void InTamGiacVuongGocTraiTren()
    {
        for (int i = 5; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void InTamGiacVuongGocPhaiDuoi()
{
    for (int i = 1; i <= 5; i++)
    {
        for (int j = 0; j < 5 - i; j++)
        {
            Console.Write(" "); // khoảng trống trước các dấu *
        }
        for (int j = 0; j < i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

static void InTamGiacVuongGocPhaiTren()
{
    for (int i = 5; i >= 1; i--)
    {
        for (int j = 0; j < 5 - i; j++)
        {
            Console.Write(" "); // khoảng trống trước các dấu *
        }
        for (int j = 0; j < i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

    static void InTamGiacCan()
    {
        Console.Write("Enter Height: ");
        int chieuCao = int.Parse(Console.ReadLine());

        for (int i = 1; i <= chieuCao; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}