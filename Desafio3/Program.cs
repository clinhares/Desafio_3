using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            var tabela = CriarTabela();

            ImprimirTabela(tabela);
            Console.WriteLine("\n\n\n" + "Iniciando a conversão de OBJETOS.");
            Thread.Sleep(4000);

            ConverterTabelaParaObjeto(tabela, out var quatidadeDeConversoes);
            Console.WriteLine("\n\n" + "Foram convertidos " + quatidadeDeConversoes + " OBJETOS com sucesso!");
            Console.Read();
        }

        private static void ImprimirTabela(DataTable tabela)
        {
            foreach (var coluna in tabela.Columns)
            {
                Console.Write("[ " + coluna.ToString().PadRight(18, ' ') + " ]");
            }

            foreach (DataRow dataRow in tabela.Rows)
            {
                Console.WriteLine();

                foreach (var item in dataRow.ItemArray)
                {
                    Console.Write("| " + item.ToString().PadRight(18, ' ') + " |");
                }
            }
        }

        private static void ConverterTabelaParaObjeto(DataTable tabela, out int quatidadeDeConversoes)
        {
            var pessoas = new List<Pessoa>();
            
            foreach (var item in tabela.AsEnumerable())
            {
                var pessoa = new Pessoa();

                pessoa.Id = int.Parse(item[0].ToString());
                pessoa.Nome = item[1].ToString();
                pessoa.Email = item[2].ToString();
                pessoa.Telefone = item[3].ToString();
                pessoa.Idade = int.Parse(item[4].ToString());

                pessoas.Add(pessoa);
            }

            quatidadeDeConversoes = pessoas.Count;
        }

        private static DataTable CriarTabela()
        {
            var table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("NOME", typeof(string));
            table.Columns.Add("EMAIL", typeof(string));
            table.Columns.Add("TELEFONE", typeof(string));
            table.Columns.Add("IDADE", typeof(int));

            table.Rows.Add(1, "José", "jose@yahoo.com", "44669922", 45);
            table.Rows.Add(null, "Maria", "maria@bol.com.br", "88669977", 23);
            table.Rows.Add(3, "Lula", "lula@uol.com.br", "96885522", 20);
            table.Rows.Add(4, "Jessica", "jessica@uol.com.br", "96885522", 25);
            table.Rows.Add(5, "Miriam", "miriam@uol.com.br", "96885522", null);

            return table;
        }
    }
}
