Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("==Exame de diabetes gestacional==");
Console.ResetColor();
Thread.Sleep(1000);
Console.Write("Digite o valor de glicemia (em mg/dL): ");
decimal glicemia = Convert.ToDecimal(Console.ReadLine());
    if (glicemia < 92 )
    {

        Console.WriteLine($"{glicemia} mg/dL (reavaliar entre 24 e 28 semanas com TTOG 75g de glicose)");
       
    }
      
        if (glicemia >= 92 && glicemia < 126)
        {
            Console.WriteLine($"{glicemia} mg/dL; (Compatível com Diabetes Gestacional)");
        }

            if (glicemia >= 126)
            { 
                Console.WriteLine($"{glicemia} mg/dL: (Diabetes Mellitus na Gravidez)");
            }
            