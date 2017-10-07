/* Prova de Linguagem de Programação P1
 * Professor Mestre José Carlos Bortot
 * No momento da entrega renomear o diretório do projeto para FATEC_LP_P1_SeuNome
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FATEC_Ita_ProvaP1LP_SegSem2017
{
    class Program
    {
        /// <summary>
        /// Dimensionamento do hotel 
        /// </summary>
        public const int QTDE_ANDARES = 30, // quantidade de andares do Hotel
            QTDE_QUARTOS_POR_ANDAR = 20,    // quantidade de quartos por andar
            QTDE_TOTAL_QUARTOS = QTDE_ANDARES *
                    QTDE_QUARTOS_POR_ANDAR; // quantidade total de quartos do Hotel
        /// <summary>
        /// Andares sendo reformados, portanto todos os seus quartos não podem
        /// ser alugados. Na inicialização do programa todos os quartos desses
        /// andares estarão com ocupados.
        /// </summary>
        public const int SETIMO = 7,        // andar em reforma
            OITAVO = 8;                     // idem
        /// <summary>
        /// Struct para conter os dados de cada quarto
        /// </summary>
        public struct stHOTEL
        {
            public bool flgLivreOcupado;    // true indica que o quarto está ocupado
            public int nAndar,              // andar 1, 2, 3, .....até a quantidade de andares
                nQuarto;                    // quarto dentro do andar 1, 2, 3,... até qtde quartos por andar 
            public string szNomeHospede;    // nome do hóspede que ocupa o quarto
            public double dVlrDiaria;       // valor da diária conforme tabela de diárias abaixo
        }
        /// <summary>
        /// Tabela de Diárias dos quartos nos andares
        /// Valor das diárias para os andares do hotel
        /// O valor da diária do quarto é função do andar onde o mesmo
        /// estiver
        /// </summary>
        public const double
            VLR_DIARIA_PRIM_TERCEIRO = 120.00,  // valor da diária do primeiro andar ao terceiro
            VLR_DIARIA_QUAR_SEXTO = 140.00,     // valor da diária do quarto andar ao sexto
            VLR_DIARIA_SETIMO_DECIMO = 170.00,  // valor da diária do sétimo andar ao décimo
            VLR_DIARIA_ACIMA_DO_DECIMO = 200.00; // valor da diária acima do décimo andar
        /// <summary>
        /// Tabela de andares sem considerar os em reforma
        /// </summary>
        public const int PRIMEIRO = 1,
            SEGUNDO = 2,
            TERCEIRO = 3,
            QUARTO = 4,
            QUINTO = 5,
            SEXTO = 6,
            NONO = 9,
            DECIMO = 10;
        /// <summary>
        /// Opções do menu do operador
        /// </summary>
        public const string EXIBIR_DADOS_QUARTO = "E",  // exibir dados do quarto
            FAZER_CHECK_IN = "C",                       // fazer o check-in de um hospede
            SAIR_DO_PROGRAMA = "S";                     // sair do programa
        /// <summary>
        /// Hotel dimensionado através do vetor de 
        /// </summary>
        private static stHOTEL[] vetQuartos = new stHOTEL[QTDE_TOTAL_QUARTOS];
        /// <summary>
        /// Entry point do programa
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int nAndar = 0,                 // para receber o andar desejado 
                                            // (1 a QTDE_ANDARES)
                nQuarto = 0,                // para receber o quarto dentro do andar
                                            // (1 a QTDE_QUARTOS_POR_ANDAR)
                iIndice = 0,                // indice do quarto no vetor
                i, j , k;                   // indices genéricos
            DateTime dtHoje;                // para receber a data e hora de hoje
            // <<<< 0 >>>> - codificar no string abaixo o seu nome
            string szMeuNome = "Rafael Luis Barbosa", // substituir por seu nome com letras maiúscula e 
                // minúsculas
                szOpcaoOperador,            // para receber a opção de escolha do operador
                szWork;                     // para as opções de string.Format
            //
            // <<<<< 1 >>>>> - fazer um único loop inicializando o vetor vetQuartos informando 
            //                  que todos os quartos estão livres exceto os andares que estão em
            //                  reforma (SETIMO e OITAVO ficarão ocupados) e indicar o valor da diária de cada
            //                  quarto que está sujeita a Tabela de diárias 
            //                  codificada nas constantes.
            //                  Esta cofidificação tem que ser feita em um único loop
            //
            //      loop infinito
            for (i = 0; i < vetQuartos.Length; i++)
            {
                vetQuartos[i].flgLivreOcupado = false;
                if (i < 60)
                    vetQuartos[i].dVlrDiaria = VLR_DIARIA_PRIM_TERCEIRO;
                if (i > 60 && i < 120)
                    vetQuartos[i].dVlrDiaria = VLR_DIARIA_QUAR_SEXTO;
                if (i > 120 && i < 200)
                    vetQuartos[i].dVlrDiaria = VLR_DIARIA_SETIMO_DECIMO;
                if (i > 200)
                    vetQuartos[i].dVlrDiaria = VLR_DIARIA_ACIMA_DO_DECIMO;
            }
            //
            while (true)
            {
                dtHoje = DateTime.Now;
                szWork = string.Format("FATEC - Itaquá - SisHotel || {0:00}/{1:00}/{2}",
                    dtHoje.Day, dtHoje.Month, dtHoje.Year);
                Console.Title = szWork;
                Console.Clear();                 // limpar a tela
                szWork = string.Format("\n\tFATEC-Itaquaquecetuba - Sistema de Hotel " + 
                                "{0:00}/{1:00}/{2} {3:00}:{4:00}:{5:00}",
                    dtHoje.Day, dtHoje.Month, dtHoje.Year,
                    dtHoje.Hour, dtHoje.Minute, dtHoje.Second);
                Console.WriteLine(szWork +
                    Environment.NewLine + "\tOperador: " + szMeuNome);
                Console.WriteLine(EXIBIR_DADOS_QUARTO + " - Exibir dados do quarto");
                Console.WriteLine(FAZER_CHECK_IN + " - Check-in de um hóspede");
                Console.WriteLine(SAIR_DO_PROGRAMA + " - Sair do programa");
                Console.Write("\n\tSelecione: ");
                szOpcaoOperador = Console.ReadLine().ToUpper();     // opção de escolha do operador
                switch (szOpcaoOperador)                             // avaliar a opção do operador
                {
                    case EXIBIR_DADOS_QUARTO:
                        // <<<< 2 >>>> - Invocar o método PedirAndarQuarto, a ser codificado,
                        //               informando o endereço do nAndar, nQuarto e iIndice
                        //               para receber os dados digitados pelo operador
                        //               Informar também a ação a ser executada que é:
                        //                 "Exibir dados do quarto".
                        //               A chamada deste método está codificado abaixo:

                        if (!PedirAndarQuarto(ref nAndar, ref nQuarto, ref iIndice,
                            "Exibir dados do quarto"))          // operador cancelou?
                        {
                            Console.Write("Voltando ao Menu,aperte qualquer tecla para continuar....");
                            Console.ReadKey();
                            break;                              // volta ao menu
                        }
                        else
                        {
                            if (vetQuartos[iIndice].flgLivreOcupado == false)
                            {
                                Console.WriteLine("Quarto vazio, aperte qualquer tecla para voltar ao menu...");
                                Console.ReadKey();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Numero do Quarto: " + vetQuartos[iIndice].nQuarto);
                                Console.WriteLine("Andar: " + vetQuartos[iIndice].nAndar);
                                Console.WriteLine("Hospede: " + vetQuartos[iIndice].szNomeHospede);
                                Console.WriteLine("Valor da Diária: " + vetQuartos[iIndice].dVlrDiaria);
                                Console.WriteLine("\n\n\tDigite qualquer tecla para voltar ao menu...");
                                Console.ReadKey();
                            }
                        }
                        // <<<< 3 >>>> - verificar se o quarto está ocupado e 
                        //               se não estiver avisar ao operador e
                        //               voltar ao menu.

                        
                        // <<<< 4 >>>> - Se estiver ocupado exibir os seus dados indicando
                        //               quarto, andar, hóspede e valor da diária 
                        //               dar uma pausa e voltar ao menu
                        break;                  // sai do switch e volta ao menu
                    case FAZER_CHECK_IN:

                        if (!PedirAndarQuarto(ref nAndar, ref nQuarto, ref iIndice,
                            "Fazer check-in de hóspede"))          // operador cancelou?
                        {
                            Console.Write("Voltando ao Menu,aperte qualquer tecla para continuar....");
                            Console.ReadKey();
                            break;
                        }
                        if (vetQuartos[iIndice].flgLivreOcupado)
                        {
                            Console.WriteLine("QUARTO JÁ OCUPADO!");
                            Console.WriteLine("Numero do Quarto: " + vetQuartos[iIndice].nQuarto);
                            Console.WriteLine("Andar: " + vetQuartos[iIndice].nAndar);
                            Console.WriteLine("Hospede: " + vetQuartos[iIndice].szNomeHospede);
                            Console.WriteLine("Valor da Diária: " + vetQuartos[iIndice].dVlrDiaria);
                            Console.WriteLine("\n\n\tDigite qualquer tecla para voltar ao menu...");
                            Console.ReadKey();
                        }

                        Console.Write("Informe o nome do hóspede: ");
                        vetQuartos[iIndice].szNomeHospede = Console.ReadLine();
                        vetQuartos[iIndice].nAndar = nAndar;
                        vetQuartos[iIndice].nQuarto = nQuarto;
                        vetQuartos[iIndice].flgLivreOcupado = true;
                        Console.WriteLine("Cadastro Feito com Sucesso! Pressione qualquer tecla para voltar para o menu...");
                        Console.ReadKey();
                        // <<<< 5 >>>> - Invocar o método PedirAndarQuarto, a ser codificado,
                        //               informando o endereço do nAndar, nQuarto e iIndice
                        //               para receber os dados digitados pelo operador
                        //               Informar também a ação a ser executada que é:
                        //                 "Fazer check-in de hóspede".

                        // <<<< 6 >>>> - Verificar se o quarto está ocupado e se estiver
                        //                  ocupado, exibir os seus dados e
                        //                  avisar o operador e voltar ao menu

                        // <<<< 7 >>>> - Se estiver livre pedir o nome do hóspede, 
                        //               indicar que o quarto está ocupado, 
                        //               exibir andar, quarto no andar nome do hóspede e
                        //               valor da diária, dar uma pausa e voltar ao menu

                        break;
                    case SAIR_DO_PROGRAMA:
                        Console.Write("\n\tDeseja sair realmente? ( S ou N): ");
                        szOpcaoOperador = Console.ReadLine().ToUpper();         // opção do operador
                        if (szOpcaoOperador == "S")                             // sair mesmo?
                            return;                                             // sai do programa
                        break;                                                  // sai do switch e volta ao menu
                    default:
                        Console.Write("\n\tOpção válida!" + Environment.NewLine +
                            "\n\tDigite qualquer tecla para continuar...... ");
                        Console.ReadKey();                             // pausa
                        break;
                } // switch
            } // loop infinito
        } // main
        /// <summary>
        /// Método que recebe endereços de váriaveis e o operador irá digitar 
        /// as informações solicitadas
        /// </summary>
        /// <param name="nAndar">número do andar válido ou zero para indicar que
        ///                     cancelou a transação. Se o operador digitou um 
        ///                     andar que está em reforma, informar ao operador tal
        ///                     fato e pedir que digite outro andar</param>
        /// <param name="nQuarto">número do quarto dentro do andar válido ou
        ///                     zero para indicar que cancelou a transação</param>
        /// <param name="iIndice">se o operador digitou andar e quarto dentro do
        ///                         andar válidos, informar nesta variável o 
        ///                         índice do quarto levando-se em consideração
        ///                         o andar e o quarto dentro do andar</param>
        /// <param name="szAcao">ação a ser executada</param>
        /// <returns></returns>
        private static bool PedirAndarQuarto(ref int nAndar, ref int nQuarto,
            ref int iIndice, string szAcao)
        {
            // <<<< 8 >>>> - Exibir a ação a ser executada para tutelar o operador 
            Console.WriteLine("\n\t" + szAcao);
           
            do
            {
                try
                {
                    Console.Write("Informe um Andar entre 1 a "+ QTDE_ANDARES + " ou 0 para cancelar: ");
                    nAndar = Convert.ToInt32(Console.ReadLine());
                    if (nAndar == 0)
                        return false;
                    if (nAndar == SETIMO)
                    {
                        Console.WriteLine("Andar em Reforma, digite outro válido");
                        nAndar = 31;
                    }
                    if (nAndar == OITAVO)
                    {
                        Console.WriteLine("Andar em Reforma,digite outro válido");
                        nAndar = 31;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Digite algo válido !");
                    nAndar = 31;
                }
            } while (nAndar < 1 || nAndar > QTDE_ANDARES);

            do
            {
                try
                {
                    Console.Write("Informe um quarto entre 1 e " + QTDE_QUARTOS_POR_ANDAR + " ou 0 para cancelar: ");
                    nQuarto = Convert.ToInt32(Console.ReadLine());
                    if (nQuarto == 0)
                        return false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Digite algo válido!");
                    nQuarto = 21;
                }
            } while (nQuarto < 1 || nQuarto > QTDE_QUARTOS_POR_ANDAR);

            iIndice = ((nAndar - 1) * 20) + nQuarto - 1;
            // <<<< 9 >>>> - Ficar em loop pedindo um andar válido ou zero para
            //                  cancelar a transação sendo executada. Se o operador
            //                  informou um andar que está sendo reformado, informar
            //                  ao operador e pedir nova digitação. Um andar válido
            //                  é 1, 2, 3, ..........QTDE_ANDARES. Dentro do loop
            //                  fazer o try....catch para impedir que o operador aborte o programa
            //                  por uma digitação com caracteres inválidos.
            //                  Se o operador informou zero retornar com false;
            // <<<< 10 >>>> - Ficar em loop pedindo um quarto válido dentro do andar
            //                  desejado ou zero para cancelar a transação sendo
            //                  executada. Um quarto válido é 1, 2, 3, ....QTDE_QUARTOS_POR_ANDAR.
            //                  Dentro do loop fazer o try....catch para impedir 
            //                  que o operador aborte o programa
            //                  por uma digitação com caracteres inválidos.
            //                  Se o operador informou zero retornar com false.
            // <<<< 11 >>>> - Se o operador informou andar e quarto dentro do andar
            //                  válidos, calcular o indice correspondente e informar este
            //                  valor no endereço de iIndice.
            //                  Retornar informando true.

            return true;                            // para não dar erro na compilação
        }
    }
}
