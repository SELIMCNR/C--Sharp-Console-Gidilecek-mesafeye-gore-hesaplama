internal class Program
{
    private static void Main(string[] args)
    {
        double mesafe = 0;
        int zaman = 0;
        double hiz = 0;
        Console.WriteLine("Gidilecek mesafeye göre hız hesaplayan program ");

        Console.WriteLine("\n Gidilecek mesafe (m) : ");
        mesafe= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Mesafeniz : ",mesafe);

        Console.WriteLine("\n Varis zamani (sn): ");
        zaman = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Varis zamaniniz : ", zaman);

        hiz = (double) mesafe / zaman;

        Console.WriteLine("\n Hiziniz : {0} m/s olmalidir.", hiz);

    }
}