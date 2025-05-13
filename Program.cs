char opçao = '\0';

Console.WriteLine("--- Fluxograma da Engenharia ---");

Console.Write("Está se movendo? (S/N): ");
opçao = Convert.ToChar(Console.ReadLine()!);

if (opçao == 'S' || opçao == 's'){
        Console.Write("Deveria? (S/N): ");
        opçao = Convert.ToChar(Console.ReadLine()!);
        
        if (opçao == 'S' || opçao == 's'){
            Console.WriteLine("Otimo");
        }
        else if (opçao == 'N' || opçao == 'n'){
            Console.WriteLine("Use Silver Tape.");
        }

}
else if (opçao == 'N' || opçao == 'n'){
        Console.Write("Deveria? (S/N): ");
        opçao = Convert.ToChar(Console.ReadLine()!);

        if (opçao == 'N' || opçao == 'n'){
            Console.WriteLine("Otimo");
        }
        else if (opçao == 'S' || opçao == 's'){
            Console.WriteLine("Use WD-40.");
        }
}
