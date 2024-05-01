// See https://aka.ms/new-console-template for more information

        Console.WriteLine("Inserisci un numero intero:");
        int numeroInserito;

        // Ciclo per assicurarmi che l'input sia un numero intero 
        while (!int.TryParse(Console.ReadLine(), out numeroInserito))
        {
            Console.WriteLine("Input non valido. Inserisci un numero intero:");
        }

        // Ciclo per stampare la tabellina 
        for (int tab = 1; tab <= 10; tab++)
        {
            int risultato = numeroInserito * tab;
            Console.WriteLine($"{numeroInserito} x {tab} = {risultato}");
        }
