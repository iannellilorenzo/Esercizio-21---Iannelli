class Program
{
    static void Main()
    {
        // Dichiarazione 
        string risposta = "";
        int lungh = 0;
        int[] array = new int[100];
        int index = 0, numUsati = 0, numero = 0, elemento = 0, indice = 0;

        // User input
        Console.Write("Inserie quanti valori si vogliono usare: ");
        numUsati = Convert.ToInt32(Console.ReadLine());

        // Carica array
        for (int i = 0; i < numUsati; i++)
        {
            Console.Write("Inserire elemento: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Aggiunta(array, numero, ref lungh);
            index++;
        }

        for (int i = 0; i < lungh; i++)
        {
            Console.WriteLine(array[i]);
        }

        Aggiunta(array, numero, ref lungh);

        // User input
        //Console.Write("Vuoi aggiungere un elemento? (Y/N) ");
        //risposta = Console.ReadLine();

        //if (risposta.ToUpper() == "Y")
        //{
        //    Console.Write("Aggiungi elemento: ");
        //    elemento = Convert.ToInt32(Console.ReadLine());
        //}
        //else if (risposta.ToUpper() == "N") 
        //{
        //    Console.Write("");
        //}
        //else
        //{
        //    Console.WriteLine("Carattere non accettato");
        //}


    }

    // Aggiungere all'array il valore inserito dall'utente (nel main)
    static void Aggiunta(int[] array, int numero, ref int index)
    {
        if (index < array.Length)
        {
            array[index] = numero;
            index++;
        }
    }
}