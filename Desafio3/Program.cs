using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            var tabela = CriarDataTable();
            ImprimirTabela(tabela);
            Console.Read();
        }

        private static DataTable CriarDataTable()
        {
            var table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("NOME", typeof(string));
            table.Columns.Add("EMAIL", typeof(string));
            table.Columns.Add("TELEFONE", typeof(string));
            table.Columns.Add("IDADE", typeof(int));

            table.Rows.Add(1, "José", "jose@yahoo.com", "44669922", 45);
            table.Rows.Add(2, "Maria", "maria@bol.com.br", "88669977", 23);
            table.Rows.Add(3, "Lula", "lula@uol.com.br", "96885522", 20);
            table.Rows.Add(4, "Jessica", "jessica@uol.com.br", "96885522", 25);
            table.Rows.Add(5, "Miriam", "miriam@uol.com.br", "96885522", 48);

            return table;
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
                    Console.Write("| " + item.ToString().PadRight(18,' ') + " |");
                }
            }
        }
    }
}
