using CountDown.Models;
using System;
using System.Collections.Generic;

namespace CountDown.Repositories
{
    public class PalavrasReservadasRepositorio : IPalavrasReservadasRepositorio
    {
        public IEnumerable<PalavrasReservadas> ObterPalavrasReservadas()
        {
            List<PalavrasReservadas> lista = new List<PalavrasReservadas>
            {
                new PalavrasReservadas { Palavra = "abstract" },
                new PalavrasReservadas { Palavra = "as" },
                new PalavrasReservadas { Palavra = "base" },
                new PalavrasReservadas { Palavra = "bool" },
                new PalavrasReservadas { Palavra = "break" },
                new PalavrasReservadas { Palavra = "byte" },
                new PalavrasReservadas { Palavra = "case" },
                new PalavrasReservadas { Palavra = "catch" },
                new PalavrasReservadas { Palavra = "char" },
                new PalavrasReservadas { Palavra = "checked" },
                new PalavrasReservadas { Palavra = "class" },
                new PalavrasReservadas { Palavra = "const" },
                new PalavrasReservadas { Palavra = "continue" },
                new PalavrasReservadas { Palavra = "decimal" },
                new PalavrasReservadas { Palavra = "default" },
                new PalavrasReservadas { Palavra = "delegate" },
                new PalavrasReservadas { Palavra = "do" },
                new PalavrasReservadas { Palavra = "double" },
                new PalavrasReservadas { Palavra = "else" },
                new PalavrasReservadas { Palavra = "enum" },
                new PalavrasReservadas { Palavra = "event" },
                new PalavrasReservadas { Palavra = "explicit" },
                new PalavrasReservadas { Palavra = "extern" },
                new PalavrasReservadas { Palavra = "false" },
                new PalavrasReservadas { Palavra = "finally" },
                new PalavrasReservadas { Palavra = "fixed" },
                new PalavrasReservadas { Palavra = "float" },
                new PalavrasReservadas { Palavra = "for" },
                new PalavrasReservadas { Palavra = "foreach" },
                new PalavrasReservadas { Palavra = "goto" },
                new PalavrasReservadas { Palavra = "if" },
                new PalavrasReservadas { Palavra = "implicit" },
                new PalavrasReservadas { Palavra = "in" },
                new PalavrasReservadas { Palavra = "int" },
                new PalavrasReservadas { Palavra = "interface" },
                new PalavrasReservadas { Palavra = "internal" },
                new PalavrasReservadas { Palavra = "is" },
                new PalavrasReservadas { Palavra = "lock" },
                new PalavrasReservadas { Palavra = "long" },
                new PalavrasReservadas { Palavra = "namespace" },
                new PalavrasReservadas { Palavra = "new" },
                new PalavrasReservadas { Palavra = "null" },
                new PalavrasReservadas { Palavra = "object" },
                new PalavrasReservadas { Palavra = "operator" },
                new PalavrasReservadas { Palavra = "out" },
                new PalavrasReservadas { Palavra = "override" },
                new PalavrasReservadas { Palavra = "params" },
                new PalavrasReservadas { Palavra = "private" },
                new PalavrasReservadas { Palavra = "protected" },
                new PalavrasReservadas { Palavra = "public" },
                new PalavrasReservadas { Palavra = "readonly" },
                new PalavrasReservadas { Palavra = "ref" },
                new PalavrasReservadas { Palavra = "return" },
                new PalavrasReservadas { Palavra = "sbyte" },
                new PalavrasReservadas { Palavra = "sealed" },
                new PalavrasReservadas { Palavra = "short" },
                new PalavrasReservadas { Palavra = "sizeof" },
                new PalavrasReservadas { Palavra = "stackalloc" },
                new PalavrasReservadas { Palavra = "static" },
                new PalavrasReservadas { Palavra = "string" },
                new PalavrasReservadas { Palavra = "struct" },
                new PalavrasReservadas { Palavra = "switch" },
                new PalavrasReservadas { Palavra = "this" },
                new PalavrasReservadas { Palavra = "throw" },
                new PalavrasReservadas { Palavra = "true" },
                new PalavrasReservadas { Palavra = "try" },
                new PalavrasReservadas { Palavra = "typeof" },
                new PalavrasReservadas { Palavra = "uint" },
                new PalavrasReservadas { Palavra = "ulong" },
                new PalavrasReservadas { Palavra = "unchecked" },
                new PalavrasReservadas { Palavra = "unsafe" },
                new PalavrasReservadas { Palavra = "ushort" },
                new PalavrasReservadas { Palavra = "using" },
                new PalavrasReservadas { Palavra = "virtual" },
                new PalavrasReservadas { Palavra = "volatile" },
                new PalavrasReservadas { Palavra = "void" },
                new PalavrasReservadas { Palavra = "while" }
            };

            return lista;
        }
    }
}
