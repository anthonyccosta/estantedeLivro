
using System.Globalization;

class Menu
{
    Livro[] livros = new Livro[10]; // Armazenar até 10 livros
    int contadorLivros = 0; // Contador de livros cadastrados

    public void opcoes()

    {
        int opcao;

        do
        {
            Console.WriteLine("\n**Escolha uma opção:**");
            Console.WriteLine("1. Cadastrar novo livro");
            Console.WriteLine("2. Exibir livro por número");
            Console.WriteLine("3. Exibir todos os livros cadastrados");
            Console.WriteLine("4. Sair");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarLivro();
                    break;
                case 2:
                    ExibirLivroPorNumero();
                    break;
                case 3:
                    ExibirTodosLivros();
                    break;
                case 4:
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        } while (opcao != 4);
    }

    public void CadastrarLivro()
    {
        if (contadorLivros >= 10)
        {
            Console.WriteLine("Limite de livros atingido (10).");
            return;
        }

        Console.WriteLine("\nDigite o título do livro: ");
        string titulo = Console.ReadLine();

        Console.WriteLine("Digite o(s) autor(es) do livro: ");
        string autor = Console.ReadLine();

        Console.WriteLine("Digite a data de lançamento: ");
        DateOnly dataLancamentoString = DateOnly.Parse(Console.ReadLine());

        Console.Write("Digite a Editora: ");
        string editora = Console.ReadLine();

        Console.Write("Digite a Edição: ");
        int edicao = int.Parse(Console.ReadLine());

        Console.Write("Digite o ISBN: ");
        string isbn = (Console.ReadLine());

        Console.Write("Digite a quantidade de Paginas: ");
        int paginas = int.Parse(Console.ReadLine());

        Livro novoLivro = new Livro(/*titulo, autor, lancamento*/);

        // Armazenar o livro na coleção
        livros[contadorLivros] = novoLivro;
        contadorLivros++;

        Console.WriteLine("Livro cadastrado com sucesso!");
    }

    // Função  para obter data válida do usuário
    public DateOnly DataValida(string datavalida)
    {
        DateOnly data;
        while (true)
        {
            Console.WriteLine("Data inválida. Tente novamente.");
        }
        return data;
    }

    public void ExibirLivroPorNumero()
    {
        if (contadorLivros == 0)
        {
            Console.WriteLine("Ainda não há livros cadastrados.");
            return;
        }

        int numero;

        do
        {
            Console.WriteLine("\nDigite o número do livro que deseja exibir (1 a {0}): ", contadorLivros);
            numero = int.Parse(Console.ReadLine());
        } while (numero < 1 || numero > contadorLivros);

        livros[numero].ExibirDetalhes();
    }

    public void ExibirTodosLivros()
    {
        if (contadorLivros == 0)
        {
            Console.WriteLine("Ainda não há livros cadastrados.");
            return;
        }

        for (int i = 0; i < contadorLivros; i++)
        {
            if (livros[i] != null)
            {
                Console.WriteLine($"Livro {i + 1}:");
                Console.WriteLine($"Nome: {livros[i].titulo}");
                Console.WriteLine($"Autor: {livros[i].autor}");
                Console.WriteLine($"Ano de Publicação: {livros[i].lancamento}");
                Console.WriteLine(); // Adiciona uma linha em branco entre os livros
            }
            else
            {
                Console.WriteLine($"Erro: Livro na posição {i + 1} não encontrado.");
            }
        }
    }
}
public class Livro
{
    public string titulo;
    public string autor;
    public DateOnly lancamento;
    public string editora;
    public int edicao;
    public string isbn;
    public int paginas;

    //public Livro(string titulo, string autor, DateOnly lancamento, string editora, int edicao, string isbn, int paginas)
    //{
    //    this.titulo = titulo;
    //    this.autor = autor;
    //    this.lancamento = lancamento;
    //    this.editora = editora;
    //    this.edicao = edicao;
    //    this.isbn = isbn;
    //    this.paginas = paginas;
    //}

    public void DefinirTitulo(string titulo)
    {
        this.titulo = titulo;
    }
    public void DefinirAutor(string autor)
    {
        this.autor = autor;
    }
    public void DefinirdataLancamento(DateOnly lancamento)
    {
        this.lancamento = lancamento;
    }
    public void DefinirEditora(string editora)
    {
        this.editora = editora;
    }
    public void DefinirEdicao(int edicao)
    {
        this.edicao = edicao;
    }
    public void Definirisbn(string isbn)
    {
        this.isbn = isbn;
    }
    public void DefinirPaginas(int paginas)
    {
        this.paginas = paginas;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine(this.titulo);
        Console.WriteLine(this.autor);
        Console.WriteLine(this.lancamento);
        Console.WriteLine(this.editora);
        Console.WriteLine(this.edicao);
        Console.WriteLine(this.isbn);
        Console.WriteLine(this.paginas);
    }
}