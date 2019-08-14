using CountDown.Models;
using System.Collections.Generic;

namespace CountDown.Repositories
{
    public interface IPalavrasReservadasRepositorio
    {
        IEnumerable<PalavrasReservadas> ObterPalavrasReservadas();
    }
}
