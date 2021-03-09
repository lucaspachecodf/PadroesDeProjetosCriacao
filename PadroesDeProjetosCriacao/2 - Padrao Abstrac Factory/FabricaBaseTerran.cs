﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosCriacao
{
    public class FabricaBaseTerran : IFabricaBases
    {
        public FabricaBaseTerran()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            Console.WriteLine("Base	Terran criada com sucesso!");
            RevestimentoBaseTerran revestimento = new RevestimentoBaseTerran();
            revestimento.Composicao();
            EnergiaBaseTerran energia = new EnergiaBaseTerran();
            energia.Composicao();
        }
    }
}
