using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosCriacao
{
    public class CriadorForcasEspeciais : CriadorDeSoldado
    {
        public CriadorForcasEspeciais()
        {
            _soldado = new SoldadoDeForcasEspeciais();
        }

        public override void Arma()
        {
            _soldado.EscolherArma("Fuzil");
        }

        public override void Foco()
        {
            _soldado.DefinirFoco("combate em solo");
        }

        public override void Transporte()
        {
            _soldado.EscolherTransporte("Carro de operações especiais");
        }
    }
}
