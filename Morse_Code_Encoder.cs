using System;

    class Program
    {
        static void Main(string[] args)
        {
            char [] alphabet = new char [] {'a', 'b', 'c', 'd', 'e',
            'f', 'g','h','i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
            'r','s', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' '};

            string [] morse = new string [] {".-", "-...", ".-.-", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..",
            "--", "-.", "---", "-..-", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", "  " };

            Console.Write("Enter the string: ");
            string input = Console.ReadLine();

            char [] inputMes = input.ToCharArray();

            string [] newMes = new string [input.Length];

            for (int i = 0; i <input.Length; i++) {
                char letter = inputMes[i];
                int letterPos = Array.IndexOf(alphabet, letter);
                string morseCor = morse[letterPos];
                newMes[i] = morseCor;
            }

            string finalMes = String.Join(" ", newMes);
            Console.WriteLine("\n"+ finalMes);

            Console.ReadKey();
        }
    }

