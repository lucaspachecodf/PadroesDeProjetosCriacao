using PadroesDeProjetosCriacao._5___Padrao_Prototype;
using System;

namespace PadroesDeProjetosCriacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region Factory Method

            //FactoryMethod fm = new FactoryMethod();
            //Console.WriteLine("Liu Kang | SubZero | Scorpion");
            //Console.WriteLine();
            //Console.Write("Escolha seu Personagem: ");
            //string escolha = Console.ReadLine();
            //IPersonagem personagem = fm.EscolherPersonagem(escolha);
            //Console.WriteLine();
            //Console.Write("Você vai jogar com ");
            //personagem.Escolhido();
            //Console.ReadKey();

            //#endregion

            //#region Abstract Factory

            //IFabricaBases fabrica;
            //Console.Write("Escolha um dos personagens: 1-Protoss | 2 - Zergs | 3 - Terranos: ");
            //switch (Console.ReadLine())
            //{
            //    case "1":
            //        fabrica = new FabricaBaseProtoss();
            //        break;
            //    case "2":
            //        fabrica = new FabricaBaseZerg();
            //        break;
            //    case "3":
            //        fabrica = new FabricaBaseTerran();
            //        break;
            //}
            //Console.ReadLine();

            //#endregion

            //#region Singleton

            //Singleton jogador_1 = Singleton.GetInstancia;
            //jogador_1.Mensagem("Jogador	1: A bola está comigo no meio do campo.");

            //Singleton jogador_2 = Singleton.GetInstancia;
            //jogador_2.Mensagem("Jogador	2: recebeu a bola.");
            //Singleton jogador_3 = Singleton.GetInstancia;
            //jogador_3.Mensagem("Jogador	3: recebeu o lançamento	na linha de fundo.");

            //Console.ReadKey();

            //#endregion

            //#region Builder

            //var exercito = new Exercito();
            //CriadorDeSoldado criadorDeSoldado;
            //Soldado soldado;

            ////criando um soldado das Forças Especiais
            //criadorDeSoldado = new CriadorForcasEspeciais();
            //exercito.ConstruirSoldado(criadorDeSoldado);
            //soldado = criadorDeSoldado.ObterSoldado();
            //Console.WriteLine("Soldado com as características: {0}, {1}, {2}", soldado.Arma, soldado.Transporte, soldado.Foco);

            ////criando o soldado de Infantaria Leve
            //criadorDeSoldado = new CriadorDeInfantariaLeve();
            //exercito.ConstruirSoldado(criadorDeSoldado);
            //soldado = criadorDeSoldado.ObterSoldado();
            //Console.WriteLine("Soldado com as características: {0}, {1}, {2}", soldado.Arma, soldado.Transporte, soldado.Foco);
            //Console.ReadKey();

            //#endregion

            #region Prototype

            GerenciadorNuvens gerenciador_de_nuvens = new GerenciadorNuvens();
            gerenciador_de_nuvens["padrão"] = new NuvemConcreta("branco",	"azul");

            gerenciador_de_nuvens["personalizada"] = new NuvemConcreta("branco", "laranja");
            NuvemConcreta um = gerenciador_de_nuvens["padrão"].Clone() as NuvemConcreta;
            NuvemConcreta dois = gerenciador_de_nuvens["padrão"].Clone() as NuvemConcreta;
            NuvemConcreta tres = gerenciador_de_nuvens["personalizada"].Clone()	as	NuvemConcreta;

            Console.ReadKey();

            #endregion
        }
    }
}
