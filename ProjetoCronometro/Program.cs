﻿StartCronometro();

static void StartCronometro()
{
    Console.WriteLine("Cronometro Iniciado");
    int tempo = 10;
    int currentTime = 0;

    while (true)
    {
        Console.Clear();
        Console.WriteLine($"{currentTime} s");
        Thread.Sleep(1000);

        currentTime++;

        if (currentTime == tempo)
        {
            Console.Clear();
            Console.WriteLine($"{currentTime} segundos");
            break;
        }
    }
}