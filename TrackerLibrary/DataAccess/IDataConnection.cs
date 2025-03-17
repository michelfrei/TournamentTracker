using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        // essa interface cria os "contratos" e especificam quais metodos, propriedades e objetos devem ser disponibilizados de forma
        // publica para todos que queiram usar (dentro do software obvio)
        PrizeModel CreatePrize(PrizeModel model);

        PersonModel CreatePerson(PersonModel model);
    }
}
