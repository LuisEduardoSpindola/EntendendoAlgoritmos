using System;

class EntendendoAlgoritmos
{

    static void Main()
    {
        // Lista usada
        int[] lista = { 5, 9, 3, 7, 2 };

        // Imprime a lista original
        Console.WriteLine("\n Lista original:");
        ImprimirArray(lista);

        // Busca pelo menor valor na lista
        int menor_indice = BuscaMenor(lista, 0); // Chamada para BuscaMenor
        Console.WriteLine($"\n Menor valor na lista: {lista[menor_indice]} na posição {menor_indice} \n");

        // Ordenação por Seleção
        Console.WriteLine("\n Ordenar por seleção: \n ");
        OrdenarPorSelecao(lista);

        // Imprime a lista ordenada
        Console.WriteLine("\nLista ordenada: \n ");
        ImprimirArray(lista);
    }

    static void ImprimirArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }


    // Algoritmos ----

    static void BuscaBinaria(int[] lista, int item)
    {
        int baixo = 0;
        int alto = lista.Length - 1;

        while (baixo <= alto)
        {
            int meio = (baixo + alto) / 2;
            int chute = lista[meio];
            if (chute == item)
            {
                Console.WriteLine($"O item {item} foi encontrado na posição {meio}.");
                return;
            }
            else if (chute > item)
            {
                alto = meio - 1;
            }
            else
            {
                baixo = meio + 1;
            }
        }

        Console.WriteLine($"O item {item} não foi encontrado na lista.");
    }

    static int BuscaMenor(int[] arr, int primeiro_indice)
    {
        int menor = arr[primeiro_indice];
        int menor_indice = primeiro_indice;

        for (int i = primeiro_indice + 1; i < arr.Length; i++)
        {
            if (arr[i] < menor)
            {
                menor = arr[i];
                menor_indice = i;
            }
        }
        Console.WriteLine(menor);
        return menor_indice;
    }


    static void OrdenarPorSelecao(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int menor_indice = BuscaMenor(arr, i); // Passando i para começar a busca a partir da posição i
            int temp = arr[i];
            arr[i] = arr[menor_indice];
            arr[menor_indice] = temp;
        }
    }
}
