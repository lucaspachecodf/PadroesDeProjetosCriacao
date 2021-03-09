﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosCriacao
{
    public abstract class CriadorDeSoldado
    {
        protected Soldado _soldado;
        public Soldado ObterSoldado()
        {
            return _soldado;
        }
        public abstract void Arma();
        public abstract void Transporte();
        public abstract void Foco();
    }
}
