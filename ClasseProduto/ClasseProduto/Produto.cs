
namespace ClasseProduto {
    class Produto {

        private string _nome;
        public double Preco { get; private set; } // Auto Propities, ou seja, Get (pode obter o valor); private Set(mas não pode altera-lo);
        public int Quantidade { get; private set; } // Esse tipo de definição de atributo só é usado quando o atributo não tem uma lógica a ser implementada.

        public Produto(string name, double price, int quantity) {
            _nome = name;
            Preco = price;
            Quantidade = quantity;
        }

        public Produto(string name, double price) {
            _nome = name;
            Preco = price;
            Quantidade = 0; // Por padrão ele já fica 0, mas só para lembrar.
        }

        public string Nome {

            get { return _nome; } // E usando Get, você consegue vê o nome do atributo usando esse metodo em outra classe.

            set {
                if(value != null && value.Length > 1 && value != _nome) {
                    _nome = value; // Usando o Set, você pode alterar o nome usando este metodo na classe principal.
                }
                else {
                    Console.WriteLine("Nome incorreto!");
                }

            }
        }
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarEstoque(int nova_quantidade) {
            Quantidade += nova_quantidade;
        }

        public void RemoverEstoque(int nova_quantidade) {
            Quantidade -= nova_quantidade;
        }

        public override string ToString() {
            return $"Nome: {_nome} / Preço: U${Preco} / Quantidade: {Quantidade} / Preço total em estoque: U${ValorTotalEmEstoque().ToString("F2")}";
        }

    }
}
