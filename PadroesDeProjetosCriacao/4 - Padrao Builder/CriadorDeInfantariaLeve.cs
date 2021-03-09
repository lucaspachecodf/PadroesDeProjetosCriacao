using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosCriacao
{
    public class CriadorDeInfantariaLeve : CriadorDeSoldado
    {
        public CriadorDeInfantariaLeve()
        {
            _soldado = new SoldadeDeInfantariaLeve();
        }

        public override void Arma()
        {
            _soldado.EscolherArma("Ataque aéreo");
        }

        public override void Foco()
        {
            _soldado.DefinirFoco("resposta rápida aérea");
        }

        public override void Transporte()
        {
            _soldado.EscolherTransporte("Helicóptero de ataque do Exército");
        }
    }
}
