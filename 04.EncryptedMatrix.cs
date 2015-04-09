using System;
using System.Globalization;
using System.Threading;

class EncryptedMatrix
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string message = Console.ReadLine();
        string direction = Console.ReadLine();
        string messageValue = string.Empty;
        foreach (char ch in message)
        {
            int vallue = ch % 10;
            messageValue += vallue;
        }
        int n = messageValue.Length;
        string encryptedMessage = string.Empty;
        for (int i = 0; i < n; i++)
        {
            int value = messageValue[i] - '0';
            if ((value & 1) == 1)
            {
                if (i > 0)
                {
                    value += (messageValue[i - 1] - '0');
                }
                if (i < n - 1)
                {
                    value += (messageValue[i + 1] - '0');
                }
            }
            else
            {
                value *= value;
            }
            encryptedMessage += value;
        }
        n = encryptedMessage.Length;
        char[,] matrix = new char[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = '0';
            }
        }
        if (direction == "\\")
        {
            EncryptMessage(encryptedMessage, matrix, 0, +1);
        }
        else
        {
            EncryptMessage(encryptedMessage, matrix, (encryptedMessage.Length - 1), -1);
        }
        PrintMatrix(matrix);
    }

    private static void PrintMatrix(char[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }

    private static void EncryptMessage(string encryptedMessage, char[,] matrix, int iStart, int iChange)
    {
        for (int i = iStart, j=0; j < encryptedMessage.Length; i+=iChange,j++)
        {
            matrix[i, j] = encryptedMessage[j];
        }
    }
}
