﻿namespace Greetings2;

class Program
{
    static void Main(string[] args)
    {
        if(args.Length == 0) {
            Console.WriteLine("Hello, World!");
            return;
        }
        ShowBot(String.Join(' ', args));
    }

    static void ShowBot(string message)
    {
        string bot = $"\n        {message}";
        bot += @"
        __________________
                        \
                        \
                            ....
                            ....'
                            ....
                            ..........
                        .............'..'..
                    ................'..'.....
                .......'..........'..'..'....
                ........'..........'..'..'.....
                .'....'..'..........'..'.......'.
                .'..................'...   ......
                .  ......'.........         .....
                .    _            __        ......
                ..    #            ##        ......
            ....       .                 .......
            ......  .......          ............
                ................  ......................
                ........................'................
            ......................'..'......    .......
            .........................'..'.....       .......
        ........    ..'.............'..'....      ..........
    ..'..'...      ...............'.......      ..........
    ...'......     ...... ..........  ......         .......
    ...........   .......              ........        ......
    .......        '...'.'.              '.'.'.'         ....
    .......       .....'..               ..'.....
    ..       ..........               ..'........
            ............               ..............
            .............               '..............
            ...........'..              .'.'............
        ...............              .'.'.............
        .............'..               ..'..'...........
        ...............                 .'..............
        .........                        ..............
            .....
    ";
        Console.WriteLine(bot);
    }
}
