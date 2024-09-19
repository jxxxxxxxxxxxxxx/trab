using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace trab.banco
{
    internal class Clientes
    {
        [PrimaryKey]
    public string CPF { get; set; }
    public string Nome { get; set; }
    public string Ende { get; set; }
    public string Fone { get; set; }
    public int Idade { get; set; }

    }
}
