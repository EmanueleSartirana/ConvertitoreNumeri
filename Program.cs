using System; // Importa le librerie di base (Console, Convert, ecc.)

namespace ConvertitoreNumeri
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true; // Variabile booleana per controllare se il programma continua a girare

            // Ciclo principale: si ripete finché l'utente non sceglie di uscire
            while (running)
            {
                Console.Clear(); // Pulisce lo schermo della console ad ogni ciclo
                Console.WriteLine("MENU CONVERSIONI"); // Titolo menu
                Console.WriteLine("1. Da binario a decimale"); // Opzione 1
                Console.WriteLine("2. Da ottale a decimale");  // Opzione 2
                Console.WriteLine("3. Da esadecimale a decimale"); // Opzione 3
                Console.WriteLine("4. Fine programma"); // Opzione 4 (uscita)
                Console.Write("Scegli un'opzione: "); // Messaggio all'utente

                string scelta = Console.ReadLine(); // Legge la scelta dell'utente come stringa

                // Controlla quale opzione ha scelto l'utente
                switch (scelta)
                {
                    case "1": // Conversione da binario a decimale
                        Console.Write("Inserisci numero binario: "); // Chiede input
                        string bin = Console.ReadLine(); // Legge il numero binario
                        try
                        {
                            // Converte la stringa "bin" da base 2 a intero decimale
                            int decBin = Convert.ToInt32(bin, 2);
                            Console.WriteLine($"Binario {bin} = Decimale {decBin}");
                        }
                        catch
                        {
                            // Se l'input non è valido, mostra un messaggio di errore
                            Console.WriteLine("Numero binario non valido!");
                        }
                        break;

                    case "2": // Conversione da ottale a decimale

                    case "3": // Conversione da esadecimale a decimale

                    case "4": // Uscita dal programma
                        running = false; // Imposta la variabile a false e termina il ciclo while
                        Console.WriteLine("Programma terminato."); // Messaggio di chiusura
                        break;

                    default: // Se l'utente scrive qualcosa di non valido
                        Console.WriteLine("Scelta non valida, riprova.");
                        break;
                }

                // Se il programma è ancora in esecuzione, aspetta un tasto prima di tornare al menu
                if (running)
                {
                    Console.WriteLine("\nPremi un tasto per continuare...");
                    Console.ReadKey(); // Attende un input da tastiera (qualunque tasto)
                }
            }
        }
    }
}
