namespace aluguelDeQuartos {
    internal class Estudante {

        
        public string StudentName {  get; set; }
        public string StudentEmail { get; set; }
        public int StudentRoom {  get; set; }

        public Estudante(string studentName, string studentEmail, int studentRoom) {
            StudentName = studentName;
            StudentEmail = studentEmail;
            StudentRoom = studentRoom;
        }

        public override string ToString() {
            return $"{StudentRoom}: {StudentName}, {StudentEmail}";
        }
    }
}
