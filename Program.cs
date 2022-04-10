// See https://aka.ms/new-console-template for more information
using monitoramento_de_diretorio.Service;

Console.WriteLine("Inicio programa");

var path = @"C:\dev\monitorado";
MonitorarDiretorioService.Monitorar(path);

Console.WriteLine("Termino do programa");