using System.Globalization;
namespace dateTimeTest {
    class Program {
        static void Main(string[] args) {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);

            Console.WriteLine();

            DateTime d2 = new DateTime(2003, 03, 10); // ANO: 2003, MÊS: MARÇO(03), DIA: 10;
            Console.WriteLine(d2);

            Console.WriteLine();

            DateTime d3 = new DateTime(2003, 03, 10, 12, 35, 12); // ANO: 2003, MÊS: MARÇO(03), DIA: 10, HORA: 12, MINUTO: 35, SEGUNDO: 12
            Console.WriteLine(d3);

            Console.WriteLine();

            Console.WriteLine(d1 < d3); // A DATA D1 É MENOR QUE A DATA D3? OBS. ELE COMPARA OS TICKS.


            Console.WriteLine();

            DateTime d4 = DateTime.Parse("2008-09-27"); // Conervete uma string para data.
            DateTime d5 = DateTime.Parse("2008-09-27 16:09:29"); // Agora com horario. OBS. Ele tambem aceita o formato com /. 20/06/1999
            Console.WriteLine(d4);
            Console.WriteLine();
            Console.WriteLine(d5);
            Console.WriteLine();

            DateTime d6 = DateTime.ParseExact("2012-09-29", "yyyy-MM-dd", CultureInfo.InvariantCulture); // Aqui você formata da maneira que quer
            DateTime d7 = DateTime.ParseExact("20-05-18", "yy-MM-dd", CultureInfo.InvariantCulture); // yy(ano 2020) - MM(mês 05) - dd(Dia 18)
            Console.WriteLine(d6);
            Console.WriteLine(d7);
        }
    }
}