﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosCriacao
{
    public class RevestimentoBaseProtoss : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Base revestida pela cor amarela");
        }
    }
}
