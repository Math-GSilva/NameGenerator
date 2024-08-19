using System;
using System.Xml.Linq;
using Bogus;
using Bogus.DataSets;
using NLog;

namespace NameGenerator
{
    class Program
    {
        private static readonly Logger Logger = LogManager.GetLogger("Name Generator Logger");

        static void Main(string[] args)
        {
            Logger.Info("Iniciando o programa de geração de nomes aleatórios.");

            try
            {
                // Configuração inicial
                bool continuar = true;
                while (continuar)
                {
                    Logger.Debug("Perguntando ao usuário pelas opções de geração de nome.");

                    Console.WriteLine("Bem-vindo ao Gerador de Nomes Aleatórios!");
                    Console.Write("Escolha a primeira letra do nome (deixe em branco para qualquer letra): ");
                    var firstLetter = Console.ReadLine()?.ToUpper();

                    Console.Write("Escolha o sexo do nome (M/F ou deixe em branco para aleatório): ");
                    var genderInput = Console.ReadLine()?.ToUpper();

                    Name.Gender? gender = Name.Gender.Male;
                    switch (genderInput)
                    {
                        case "M":
                            gender = Name.Gender.Male;
                            break;
                        case "F":
                            gender = Name.Gender.Female;
                            break;
                        default:
                            gender = null;
                            break;
                    }

                    Console.Write("Quantos nomes você deseja gerar? ");
                    if (!int.TryParse(Console.ReadLine(), out var count) || count <= 0)
                    {
                        Logger.Warn("Entrada inválida para quantidade de nomes. Gerando 1 nome por padrão.");
                        count = 1;
                    }

                    Logger.Info($"Gerando {count} nome(s) com a primeira letra '{firstLetter}' e gênero '{gender}'.");

                    // Gerar nomes
                    var faker = new Faker("pt_BR");
                    for (var i = 0; i < count; i++)
                    {
                        var name = faker.Name.FirstName(gender);

                        if (!string.IsNullOrEmpty(firstLetter) && name[0].ToString().ToUpper() == firstLetter)
                        {
                            Console.WriteLine($"Nome Gerado: {name}");
                            Logger.Debug($"Nome gerado: {name}");
                        }
                        else
                        {
                            i--;
                        }
                    }

                    Console.Write("Deseja gerar mais nomes? (S/N): ");
                    continuar = Console.ReadLine()?.Trim().ToUpper() == "S";
                }

                Logger.Info("Programa encerrado com sucesso.");
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Ocorreu um erro durante a execução do programa.");
            }
            finally
            {
                LogManager.Shutdown();
            }
        }
    }
}
