using ScreenSound.Banco;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus;

internal class MenuTodasMusicasPorAno : Menu
{
    public override void Executar(DAL<Artista> artistaDAL)
    {
        base.Executar(artistaDAL);
        ExibirTituloDaOpcao("Exibindo todas as músicas registradas, ordenadas por ano de lançamento:");
        foreach (var musica in artistaDAL.ListarPorAno())
        {
            Console.WriteLine($"Musica: {musica.Nome} - Ano: {musica.AnoLancamento} - Artista: {musica.Artista.Nome}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}