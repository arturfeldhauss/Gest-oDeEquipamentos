using System;

namespace GestãoDeEquipamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] nomedoequipamento = new string[1000];
            string[] quantidade1 = new string[1000];
            string[] serie1 = new string[1000];
            string[] data1 = new string[1000];
            string[] fabricante1 = new string[1000];
            string[] titulochamado1 = new string[1000];
            string[] descricao1 = new string[1000];
            string[] equipamento1 = new string[1000];
            string[] datachamado1 = new string[1000];

            menu:
            //Menu
            Console.WriteLine("Estamos aqui para te ajudar com o inventário!!");
            Console.WriteLine("Para registrar um equipamento digite 1!!");
            Console.WriteLine("Para abrir a lista de equipamentos registrados digite 2!!!");
            Console.WriteLine("Para modificar um equipamento ja registrado digite 3!!!");
            Console.WriteLine("Para excluir um item digite 4!!!");
            Console.WriteLine("Para registrar um chamado digite 5!!!");
            Console.WriteLine("Para ver os chamados digite '6'!!");
            Console.WriteLine("Para editar um chamado digite '7'!!");
            Console.WriteLine("Para excluir um chamado digite '8'!!");
            Console.WriteLine("Para fechar o programad digite 'S'");
            string opcao = Console.ReadLine();

            //Requisito 1.1: Como funcionário, Junior quer ter a possibilidade de registrar equipamentos 
            if (opcao == "1")
            {
                registro:
                Console.WriteLine("Digite quantos equipamentos quer registrar!!");
                string quantidaderegisto = Console.ReadLine();
                int quantidaderegistro1 = Convert.ToInt32(quantidaderegisto);

                for (int i = 0; i < quantidaderegistro1; i++)
                {
                    Console.WriteLine("Agora as informações do equipamento numero{0}"  ,  i );
                    Console.WriteLine("Digite o Nome do equipamento que deseja registrar");
                    string nome = Console.ReadLine();
                    nomedoequipamento[i] = nome;

                    Console.WriteLine("Agora digite o preço de aquisição do equipamento!!");
                    string qntd = Console.ReadLine();
                    quantidade1[i] = qntd;

                    Console.WriteLine("Agora digite o numero de serie nesse formato:[1234-5]");
                    string serie = Console.ReadLine();
                    serie1[i] = serie;

                    Console.WriteLine("Agora digite a data de fabricação nesse formato: dd/mm/aaaa");
                    string data = Console.ReadLine();
                    data1[i] = data;

                    Console.WriteLine("Agora digite qual o fabricante do produto!");
                    string fabricante = Console.ReadLine();
                    fabricante1[i] = fabricante;

                    
                    Console.ReadKey();
                    Console.Clear();
                }

                Console.WriteLine("Se deseja adicionar outro produto digite '1'");
                Console.WriteLine("Se deseja encerrar o programa digite '2'");
                Console.WriteLine("Se deseja voltar ao menu digite '3'");
                string opcao3 = Console.ReadLine();
                if (opcao3 == "1")
                {
                    goto registro;
                }
                if(opcao3 == "2")
                {
                    Console.Clear();
                    Console.ReadLine();
                }
                if(opcao3 == "3")
                {
                    goto menu;
                }

            }
            //Requisito 1.2: Como funcionário, Junior quer ter a possibilidade de visualizar todos os equipamentos  registrados em seu inventário.  
            else if (opcao == "2")
            {
                
                Console.WriteLine("Digite o numero do item que deseja ver!!");
                string opcaover = Console.ReadLine();
                int opcaoverint = Convert.ToInt32(opcaover);
                Console.Write("O nome do equipamento é: ");
                Console.WriteLine(nomedoequipamento[opcaoverint]);

               

                Console.Write("O numero de serie é:");
                Console.WriteLine(serie1[opcaoverint]);

                

                Console.Write("A empresa que fabricou o produto é: ");
                Console.WriteLine(fabricante1[opcaoverint]);
                Console.ReadKey();
                Console.Clear();
                
                goto menu;
            }
            //Requisito 1.3: Como funcionário, Junior quer ter a possibilidade de editar um equipamento, sendo  que ele possa editar todos os campos.  
            else if (opcao == "3")
            {
                editar:
                Console.WriteLine("Digite o nuemro do item deseja editar!!!");
                string editar = Console.ReadLine();
                int editar1 = Convert.ToInt32(editar);
                Console.WriteLine("Vamos te mostrar as informações atuais!");
                Console.Write("O nome do equipamento é: ");
                Console.WriteLine(nomedoequipamento[editar1]);
                Console.Write("O preço do equipemaneto é: ");
                Console.WriteLine(quantidade1[editar1]);
                Console.Write("O numero de serie é: ");
                Console.WriteLine(serie1[editar1]);
                Console.Write("A data de fabricação é: ");
                Console.WriteLine(data1[editar1]);
                Console.Write("O fabricante é: ");
                Console.WriteLine(fabricante1[editar1]);
                Console.WriteLine("---------------------");
                Console.WriteLine("Agora escolha qual informação deseja editar!!");
                Console.WriteLine("Para editar o nome digite N");
                Console.WriteLine("Para editar o preço digite P");
                Console.WriteLine("Para editar o numero de serie digite S");
                Console.WriteLine("Para digitar a data de fabricação digite D");
                Console.WriteLine("E para editar o fabricante digite F");
                string opcaoeditar = Console.ReadLine();
                if (opcaoeditar == "N")
                {
                    Console.WriteLine("Digite o novo nome!");
                    string nome = Console.ReadLine();
                    nomedoequipamento[editar1] = nome;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("ITEM EDITADO COM SUCESSO!!!");
                    Console.ResetColor();
                }
                if(opcaoeditar == "P")
                {
                    Console.WriteLine("Digite o novo preço!");
                    string qntd = Console.ReadLine();
                    quantidade1[editar1] = qntd;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("ITEM EDITADO COM SUCESSO!!!");
                    Console.ResetColor();

                }
                if(opcaoeditar == "S")
                {
                    Console.WriteLine("Digite o novo numero de serie!");
                    string serie = Console.ReadLine();
                    serie1[editar1] = serie;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("ITEM EDITADO COM SUCESSO!!!");
                    Console.ResetColor();
                }
                if(opcaoeditar == "D")
                {
                    Console.WriteLine("Digite a nova data!");
                    string data = Console.ReadLine();
                    data1[editar1] = data;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("ITEM EDITADO COM SUCESSO!!!");
                    Console.ResetColor();
                }
                if (opcaoeditar == "F") 
                {
                    Console.WriteLine("Digite o novo fabricante!");
                    string fabricante = Console.ReadLine();
                    fabricante1[editar1] = fabricante;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("ITEM EDITADO COM SUCESSO!!!");
                    Console.ResetColor();
                }
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Se deseja editar mais itens digite 'E'");
                Console.WriteLine("Se deseja volta para o menu digite 'M'");
                string opcao10 = Console.ReadLine();
                if(opcao10 == "E")
                {
                    Console.ReadKey();
                    Console.Clear();
                    goto editar;
                }
                if (opcao10 == "M")
                {
                    Console.ReadKey();
                    Console.Clear();
                    goto menu;
                    
                }   
            }
            //Requisito 1.4: Como funcionário, Junior quer ter a possibilidade de excluir um equipamento que esteja  registrado.  
            else if (opcao == "4")
            {
                Console.WriteLine("Digite qual numero deseja excluir!!!");
                string excluir = Console.ReadLine();
                int excluir1 = Convert.ToInt32(excluir);

                nomedoequipamento[excluir1] = "Esse item foi excluido!!";
                quantidade1[excluir1] = "Esse item foi excluido!!";
                serie1[excluir1] = "Esse item foi excluido!!";
                data1[excluir1] = "Esse item foi excluido!!";
                fabricante1[excluir1] = "Esse item foi excluido!!";
                Console.ReadKey();
                Console.Clear();
                goto menu;
            }
            //Requisito 2.1: Como funcionário Junior quer ter a possibilidade de registrar os chamados de  manutenções que são efetuadas nos equipamentos registrados
            else if (opcao == "5")
            {
                Console.WriteLine("Digite quantos chamados deseja registrar!");
                string numerochamados = Console.ReadLine();
                int numerochamados1 = Convert.ToInt32(numerochamados);
                for (int i = 0; i < numerochamados1; i++)
                {
                    Console.WriteLine("Digite o titulo do chamado!!");
                    string titulochamado = Console.ReadLine();
                    titulochamado1[i] = titulochamado;
                    Console.WriteLine("Digite a descrição do chamado!");
                    string descricao = Console.ReadLine();
                    descricao1[i] = descricao;
                    Console.WriteLine("Digite o equipamento a qual o chamado se refere!");
                    string equipamento = Console.ReadLine();
                    equipamento1[i] = equipamento;
                    Console.WriteLine("Digite a data de abertura do chamado!");
                    string datachamado = Console.ReadLine();
                    datachamado1[i] = datachamado;
                    Console.WriteLine("O chamado foi registrado, obrigado!!!");
                    Console.WriteLine("========================================");
                    Console.ReadKey();
                    Console.Clear();
                    goto menu;
                
                }
            }
            //Requisito 2.2: Como funcionário Junior quer ter a possibilidade de visualizar todos os chamados  registrados para controle.  
            else if (opcao == "6")
            {
                Console.WriteLine("Digite qual chamado deseja ver");
                string verchamado = Console.ReadLine();
                int verchamado1 = Convert.ToInt32(verchamado);

                Console.Write("O Titulo do chamado é ");
                Console.WriteLine(titulochamado1[verchamado1]);
                Console.Write("Essa é a descriçao do chamado: ");
                Console.WriteLine(descricao1[verchamado1]);
                Console.Write("Referente ao equipamento: ");
                Console.WriteLine(nomedoequipamento[verchamado1]);
                Console.Write("A data do registro do chamado é: ");
                Console.WriteLine(datachamado1[verchamado1]);
                Console.WriteLine("========================================");
                Console.ReadKey();
                Console.Clear();
                goto menu;
            }
            //Requisito 2.3: Como funcionário Junior quer ter a possibilidade de editar um chamado que esteja registrado, sendo que ele possa editar todos os campos.
            else if (opcao == "7")
            {
                editarchamado:;
                Console.WriteLine("Qual chamado deseja editar??");
                string chamadoeditar = Console.ReadLine();
                int chamadoeditar1 = Convert.ToInt32(chamadoeditar);

                Console.Write("O titulo do chamado é!!");
                Console.WriteLine(titulochamado1[chamadoeditar1]);
                Console.Write("A descrição do chamado é!!");
                Console.WriteLine(descricao1[chamadoeditar1]);
                Console.Write("Referente ao equipamento: ");
                Console.WriteLine(nomedoequipamento[chamadoeditar1]);
                Console.Write("A data do registro do chamado é: ");
                Console.WriteLine(datachamado1[chamadoeditar1]);
                Console.WriteLine("Agora escolha o que deseja editar!");
                Console.WriteLine("Para digitar o nome do chamado digite 'N'!");
                Console.WriteLine("Para editar a descrição digite 'D'!");
                Console.WriteLine("Para editar o equipamento referente digite 'E'!");
                Console.WriteLine("Para editar a data digite 'A'");
                string opcao5 = Console.ReadLine();
                if (opcao5 == "N") 
                {
                    Console.WriteLine("Digite o novo TITULO!!");
                    string titulochamado = Console.ReadLine();
                    titulochamado1[chamadoeditar1] = titulochamado;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("ITEM EDITADO COM SUCESSO!!!");
                    Console.ResetColor();

                }
                else if (opcao5 == "D")
                {
                    Console.WriteLine("Digite a nova DESCRIÇÃO!");
                    string descricao = Console.ReadLine();
                    descricao1[chamadoeditar1] = descricao;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("ITEM EDITADO COM SUCESSO!!!");
                    Console.ResetColor();
                }
                else if (opcao5 == "E")
                {
                    Console.WriteLine("Digite o novo equipamento!");
                    string equipamento = Console.ReadLine();
                    equipamento1[chamadoeditar1] = equipamento;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("ITEM EDITADO COM SUCESSO!");
                    Console.ResetColor();
                }
                else if(opcao5 == "A")
                {
                    Console.WriteLine("Digite a nova DATA DE REGISTRO!");
                    string datachamado = Console.ReadLine();
                    datachamado1[chamadoeditar1] = datachamado;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("ITEM EDITADO COM SUCESSO!!!");
                    Console.ResetColor();
                }
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Se deseja editar outro item digite 'E'");
                Console.WriteLine("Se deseja ir para o mano digite 'M'");
                string opcao8 = Console.ReadLine();
                if (opcao8 == "E")
                {
                    goto editarchamado;
                }
                if(opcao8 == "M")
                {
                    goto menu;
                }
                
                
                Console.ReadKey();
                Console.Clear();
                goto menu;
            }
            //equisito 2.4: Como funcionário Junior quer ter a possibilidade de excluir um chamado.  
            if (opcao == "8")
            {
                Console.WriteLine("Qual chamada deseja excluir?");
                string chamadoexcluir = Console.ReadLine();
                int chamadoexcluir1 = Convert.ToInt32(chamadoexcluir);

                titulochamado1[chamadoexcluir1] = "Esse chamado foi excluido";
                descricao1[chamadoexcluir1] = "Esse chamado foi excluido";
                equipamento1[chamadoexcluir1] = "Esse chamado foi excluido";
                datachamado1[chamadoexcluir1] = "Esse chamado foi excluido";
                Console.ReadKey();
                Console.Clear();
                goto menu;           
            }
            else if (opcao == "S")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("OBRIGADO POR USAR O PROGRAMA!");
                Console.ResetColor();
                Console.ReadLine();


            }
         Console.ReadLine();
        }
    }
}
