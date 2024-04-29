//using System.Globalization;

//class Menu
//{
//    Livro[] livros = new Livro[1]; // Armazenar até 10 livros
//    int contadorLivros = 0; // Contador de livros cadastrados

//    public void opcoes()

//    {
//        int opcao;

//        do
//        {
//            Console.WriteLine("\n**Escolha uma opção:**");
//            Console.WriteLine("1. Cadastrar novo livro");
//            Console.WriteLine("2. Exibir livro por número");
//            Console.WriteLine("3. Exibir todos os livros cadastrados");
//            Console.WriteLine("4. Sair");

//            opcao = int.Parse(Console.ReadLine());

//            switch (opcao)
//            {
//                case 1:
//                    CadastrarLivro();
//                    break;
//                case 2:
//                    ExibirLivroPorNumero();
//                    break;
//                case 3:
//                    ExibirTodosLivros();
//                    break;
//                case 4:
//                    Console.WriteLine("Saindo do programa...");
//                    break;
//                default:
//                    Console.WriteLine("Opção inválida. Tente novamente.");
//                    break;
//            }
//        } while (opcao != 4);
//    }

//    public void CadastrarLivro()
//    {
//        if (contadorLivros >= 10)
//        {
//            Console.WriteLine("Limite de livros atingido (10).");
//            return;
//        }

//        Console.WriteLine("\nDigite o título do livro: ");
//        string titulo = Console.ReadLine();

//        Console.WriteLine("Digite o(s) autor(es) do livro: ");
//        string autor = Console.ReadLine();

//        Console.WriteLine("Digite a data de lançamento: ");
//        DateOnly dataLancamentoString = DateOnly.Parse(Console.ReadLine());

//        Console.Write("Digite a Editora: ");
//        string editora = Console.ReadLine();

//        Console.Write("Digite a Edição: ");
//        int edicao = int.Parse(Console.ReadLine());

//        Console.Write("Digite o ISBN: ");
//        string isbn = (Console.ReadLine());

//        Console.Write("Digite a quantidade de Paginas: ");
//        int paginas = int.Parse(Console.ReadLine());

//        Livro novoLivro = new Livro(/*titulo, autor, lancamento*/);

//        // Armazenar o livro na coleção
//        livros[contadorLivros] = novoLivro;
//        contadorLivros++;

//        Console.WriteLine("Livro cadastrado com sucesso!");
//    }
//    //public string ObterString(string prompt)
//    //{
//    //    Console.WriteLine(prompt);
//    //    return Console.ReadLine();
//    //}

//    // Função para obter data válida do usuário
//    public DateOnly DataValida(string datavalida)
//    {
//        DateOnly data;
//        while (true)
//        {
//            Console.WriteLine("Data inválida. Tente novamente no formato AAAA-MM-DD.");
//        }
//        return data;
//    }
//    //while (!IsValidDate(dataLancamentoString))
//    //{
//    //    Console.WriteLine("Data inválida. Tente novamente no formato AAAA-MM-DD.");
//    //    dataLancamentoString = Console.ReadLine();
//    //}

//    //DateTime lancamento;
//    //Console.WriteLine("Livro cadastrado com sucesso!");
//    public void ExibirLivroPorNumero()
//    {
//        if (contadorLivros == 0)
//        {
//            Console.WriteLine("Ainda não há livros cadastrados.");
//            return;
//        }

//        int numero;

//        do
//        {
//            Console.WriteLine("\nDigite o número do livro que deseja exibir (1 a {0}): ", contadorLivros);
//            numero = int.Parse(Console.ReadLine());
//        } while (numero < 1 || numero > contadorLivros);

//        livros[numero - 1].ExibirDetalhes();
//    }

//    public void ExibirTodosLivros()
//    {
//        if (contadorLivros == 0)
//        {
//            Console.WriteLine("Ainda não há livros cadastrados.");
//            return;
//        }

//        for (int i = 0; i < contadorLivros; i++)
//        {
//            // Imprima as informações do livro na posição i aqui
//            Console.WriteLine($"Livro {i + 1}:");
//            Console.WriteLine($"Nome: {livros[i].titulo}");
//            Console.WriteLine($"Autor: {livros[i].autor}");
//            Console.WriteLine($"Ano de Publicação: {livros[i].lancamento}");
//            Console.WriteLine(); // Adiciona uma linha em branco entre os livros
//        }
//    }
//}