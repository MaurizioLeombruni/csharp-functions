//Chiedere all'utente la grandezza dell'array, compilare l'array, ed eseguire poi varie funzioni sull'array creato.

int inputLength;
int numSquare;
int numSum;
int numSumSquare;

//Stampiamo i numeri di un array, utilizzando la funzione Write() per ordinarli sulla console.
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

//Elevare un numero al quadrato (a.k.a. moltiplicarlo per sé stesso).
static int Quadrato(int val)
{
    int squaredVal = val * val;
    return squaredVal;
}

//Elevare gli elementi di un array al quadrato, con la funzione creata in precedenza.
//Le operazioni vengono fatte all'interno di un array di supporto per lasciare immutato l'array originale.
static int[] elevaArrayAlQuadrato(int[] array)
{
    int[] tempArray = (int[])array.Clone();
    for(int i=0; i<tempArray.Length; i++)
    {
        tempArray[i] = Quadrato(tempArray[i]);
    }

    return tempArray;
}

//Somma degli elementi di un array.

static int sommaElementiArray(int[] array)
{
    int tempSum = 0;
    for(int i=0; i<array.Length; i++)
    {
        tempSum = tempSum + array[i];
    }
    return tempSum;
}

//Utilizza una variabile di supporto per compilare l'array specificato dall'utente.
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

//Chiediamo all'utente di creare un'array, poi ne si crea una copia per elevare gli elementi del secondo array al quadrato.
do
{
    Console.WriteLine("Inserisci la lunghezza dell'array da creare");
    int.TryParse(Console.ReadLine(), out inputLength);

} while (inputLength == 0);

int[] userArray = new int[inputLength];

compileArray(userArray);

int[] userArraySquare = elevaArrayAlQuadrato(userArray);

//Stampiamo su console tutti i risultati delle funzioni.

Console.WriteLine("Array originale: ");
stampaArrayInteri(userArray);
Console.WriteLine("Array con elementi al quadrato: ");
stampaArrayInteri(userArraySquare);
Console.WriteLine("La somma degli elementi dell'array originale: ");
numSum = sommaElementiArray(userArray);
Console.WriteLine(numSum);
Console.WriteLine("La somma degli elementi dell'array quadratico:");
numSumSquare = sommaElementiArray(userArraySquare);
Console.WriteLine(numSumSquare);
Console.WriteLine("Il quadrato del primo elemento dell'array originale è: ");
numSquare = Quadrato(userArray[0]);
Console.WriteLine(numSquare);

//Birb.