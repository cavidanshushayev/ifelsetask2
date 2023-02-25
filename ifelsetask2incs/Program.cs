namespace homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zehmet olmasa parklanma saatin qeyd edin");

            double saat = Convert.ToDouble(Console.ReadLine());
            if (saat < 3)
            {
                Console.WriteLine("odenilecek mebleg  " + saat + "azn");
            }else if(saat >3 && saat <= 5)
            {
                double endrimsizmebleg = 3;
                double endrimlimebleg = (saat - endrimsizmebleg) * 80 / 100;
                double tammebleg = endrimsizmebleg + endrimlimebleg;
                Console.WriteLine("odenilecek mebleg   " + tammebleg + "azn");
            }else if(saat > 5 && saat <= 8)
            {
                double endrimsizmebleg = 4.6f;

                double secondendrimlimebleg = (saat - 5) * 50 / 100;
                double  tammebleg = endrimsizmebleg +secondendrimlimebleg;
                Console.WriteLine("odenilecek mebleg " + tammebleg + "azn");
            }else
            {
                double endrimsizmebleg = 6.1f;
                double endrimlimebleg = (saat - 8) * 75 / 100;
                double tammebleg = endrimlimebleg + endrimsizmebleg;
                Console.WriteLine("odenilecek mebleg " + tammebleg + "azn");

            }
        }
    }
}