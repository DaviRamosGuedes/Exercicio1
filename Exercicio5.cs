using System;

class Exercicio5
{
    static void Main(string[] args)
    {
        // Principal String
        string stringprincipal = "hellow world";

        // String invertido
        string stringreversa = Reverterstring(stringprincipal);

        // Exibir as duas strings
        Console.WriteLine("String original: " + stringprincipal);
        Console.WriteLine("String invertida: " + stringreversa);
    }

    static string Reverterstring(string input)
    {
        // Convertendo a string em um array de caracteres
        char[] charArray = input.ToCharArray();

        // Obtendo o índice do último caractere
        int ultimaletra = charArray.Length - 1;

        // Invertendo os caracteres no array
        for (int i = 0; i < ultimaletra; i++, ultimaletra--)
        {
            // Trocando os caracteres de posição
            char temp = charArray[i];
            charArray[i] = charArray[ultimaletra];
            charArray[ultimaletra] = temp;
        }

        // Convertendo o array de caracteres de volta para uma string
        return new string(charArray);
    }
}
