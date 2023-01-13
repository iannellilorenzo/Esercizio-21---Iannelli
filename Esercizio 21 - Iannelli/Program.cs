class Program
{
    static void Main()
    {
        // Dichiarazione 
        int scelta = 0;
        int dim = 0;
        int[] array = new int[100];
        int index = 0, numUsati = 0, numero = 0, elemento = 0, indice = 0;



        do
        {
            Console.WriteLine("1 - Aggiungi elemento");
            Console.WriteLine("2 - Stampa array");

            scelta = int.Parse(Console.ReadLine());
            switch (scelta)
            {
                case 1:
                    Console.Write("Inserire elemento: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                    if (Aggiunta(array, numero, ref dim))
                    {
                        Console.WriteLine("Elemento inserito correttamente");
                    }
                    else
                    {
                        Console.WriteLine("Array pieno. Elemento non inserito");
                    }
                    break;
                case 2:
                    for (int i = 0; i < dim; i++)
                    {
                        Console.WriteLine(array[i]);
                    }
                    break;
            }
        } while (scelta != 0);

        // Carica array
        for (int i = 0; i < numUsati; i++)
        {
            Console.Write("Inserire elemento: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Aggiunta(array, numero, ref dim);
            index++;
        }

        for (int i = 0; i < dim; i++)
        {
            Console.WriteLine(array[i]);
        }

        Aggiunta(array, numero, ref dim);

    }

    // Aggiungere all'array il valore inserito dall'utente (nel main)
    static bool Aggiunta(int[] array, int numero, ref int index)
    {
        bool inserito = true;
        if (index < array.Length)
        {
            array[index] = numero;
            index++;
        }
        else
        {
            inserito = false;
        }
        return inserito;
    }
}