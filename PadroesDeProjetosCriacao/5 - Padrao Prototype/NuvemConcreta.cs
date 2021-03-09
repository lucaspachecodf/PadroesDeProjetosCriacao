using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosCriacao._5___Padrao_Prototype
{
    public class NuvemConcreta : NuvemMolde
    {
        private string cor_preenchimento;
        private string cor_contorno;

        public NuvemConcreta(string preenchimento, string contorno)
        {
            this.cor_preenchimento = preenchimento;
            this.cor_contorno = contorno;
        }

        public override NuvemMolde Clone()
        {
            Console.WriteLine("A nuvem clonada tem contorno	" + cor_contorno + " e preenchimento " + cor_preenchimento);
            return MemberwiseClone() as NuvemMolde;
        }
    }
}
