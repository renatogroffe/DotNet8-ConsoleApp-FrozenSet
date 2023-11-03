using System.Collections.Frozen;
using System.Runtime.InteropServices;
using System.Text.Json;

Console.WriteLine("***** Testes com .NET 8 | Colecoes imutaveis com FrozenSet  *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");

var campeoesMundiais = new HashSet<string>()
{
    "Brasil",
    "Italia",
    "Alemanha",
    "Argentina",
    "Uruguai",
    "Franca",
    "Inglaterra",
    "Espanha"
}.ToFrozenSet();

Console.WriteLine();
Console.WriteLine($"Quantidades de paises que ja venceram Copas: {campeoesMundiais.Count}");

Console.WriteLine();
Console.WriteLine("JSON com os campeoes da Copa do Mundo: ");
Console.WriteLine(JsonSerializer.Serialize(campeoesMundiais,
    new JsonSerializerOptions() { WriteIndented = true }));