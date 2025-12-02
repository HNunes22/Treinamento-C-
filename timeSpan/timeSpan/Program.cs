namespace timeSpanTest {
    class Program {
        static void Main(string[] args) {
            TimeSpan time1 = new TimeSpan(01, 30, 30); // Horas(01): Minuto(30): Segundo(30)
            TimeSpan time2 = new TimeSpan(); // Vai dar hora 00:00:00
            TimeSpan time3 = new TimeSpan(900000000L); // Ele vai converter os TICKS em horario normal
            TimeSpan time4 = new TimeSpan(5, 4, 42, 18);// Dia(05).  Horas(01): Minuto(30): Segundo(30)

            // Usando o From

            TimeSpan time5 = TimeSpan.FromDays(1.5); // Converta um dia e meio em TimeSpan:  que é 1 dia e 12h
            TimeSpan time6 = TimeSpan.FromHours(1.5); // Converta uma hora e meia em TimeSpan:  que é 1 hora e 30min



            Console.WriteLine(time1);
            Console.WriteLine(time2);
            Console.WriteLine(time3);
            Console.WriteLine(time4);
            Console.WriteLine(time5);
            Console.WriteLine(time6);
        }
    }
}