namespace aluguelDeQuartos {
    class Program {
        static void Main(string[] args) {


            string name, email;
            int room;
            Estudante[] estudante = new Estudante[10];

            Console.Write("How many rooms will be rented? ");
            int quantityRooms = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < quantityRooms; i++) {
                int validator = 0;
                while (validator != 1) {

                    Console.WriteLine($"Rent #{i + 1}");

                    Console.Write("Name: ");
                    name = Console.ReadLine();

                    Console.Write("Email: ");
                    email = Console.ReadLine();

                    Console.Write("Room: ");
                    room = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    if (room < 0 || room > 9) {
                        Console.WriteLine("Não temos essa numeração de quarto");
                        continue;
                    }
                    else {
                        estudante[room] = new Estudante(name, email, room);
                        validator = 1;

                    }
                }
            }

            Console.WriteLine("Busy Rooms: ");


            for(int i = 0; i < estudante.Length; i++) {
                Estudante currentRoom = estudante[i];
                if(currentRoom == null) {
                    continue;
                }
                Console.WriteLine(currentRoom);
            }

        }
    }
}