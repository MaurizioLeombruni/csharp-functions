//Chiedere all'utente la grandezza dell'array, compilare l'array, ed eseguire poi varie funzioni sull'array creato.

int inputLength;
int numSquare;
int numSum;

static void stampaArrayInteri(int[] array)
{
    Console.Write("[");
    for(int i=0; i<array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

static int Quadrato(int val)
{
    int squaredVal = val * val;
    return squaredVal;
}

static int[] elevaArrayAlQuadrato(int[] array)
{
    int[] tempArray = (int[])array.Clone();
    for(int i=0; i<tempArray.Length; i++)
    {
        tempArray[i] = tempArray[i] * tempArray[i];
    }

    return tempArray;
}

static int sommaElementiArray(int[] array)
{
    int tempSum = 0;
    for(int i=0; i<array.Length; i++)
    {
        tempSum = tempSum + array[i];
    }
    return tempSum;
}

static void compileArray(int[] array)
{
    int tempNum;
    for(int i=0; i<array.Length; i++)
    {
        do
        {
            Console.WriteLine("Inserisci il valore (diverso da 0) da mettere nell'array");
            int.TryParse(Console.ReadLine(), out tempNum);
        } while (tempNum == 0);

        array[i] = tempNum;
    }
}

do
{
    Console.WriteLine("Inserisci la lunghezza dell'array da creare");
    int.TryParse(Console.ReadLine(), out inputLength);

} while (inputLength == 0);

int[] userArray = new int[inputLength];

compileArray(userArray);

int[] userArraySquare = elevaArrayAlQuadrato(userArray);

Console.WriteLine("Array originale: ");
stampaArrayInteri(userArray);
Console.WriteLine("Array con elementi al quadrato: ");
stampaArrayInteri(userArraySquare);
Console.WriteLine("La somma degli elementi dell'array originale: ");
numSum = sommaElementiArray(userArray);
Console.WriteLine(numSum);
Console.WriteLine("Il quadrato del primo elemento dell'array originale è: ");
numSquare = Quadrato(userArray[0]);
Console.WriteLine(numSquare);