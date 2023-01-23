namespace Calculator
{
    public class Tools
    {
        /// <summary>
        ///     Demande et renvoie un entier de type INT compris dans un intervalle optionnel  
        /// </summary>
        /// <param name="question">Question posée au moment de la demande</param>
        /// <param name="min">Valeur plancher de l'intervalle incluse (optionnelle)</param>
        /// <param name="max">Valeur plafond de l'intervalle incluse (optionnelle)</param>
        /// <returns></returns>
        public static int AskInteger(string question, int min = int.MinValue, int max = int.MaxValue)
        {
            int res = 0;
            while (true)
            {
                Console.Write(question);
                string res_str = Console.ReadLine();
                try
                {
                    res = int.Parse(res_str);
                    if ((res >= min) && (res <= max))
                        break;
                    else
                        Console.WriteLine("\n\tErreur : Seuls les nombres entiers compris entre " + min + " et " + max + " sont admis ! \n");
                }
                catch
                {
                    Console.WriteLine("\n\tErreur : Ceci n'est pas un nombre ! \n");
                }
            }
            Console.WriteLine("\n");
            return res;
        }
        /// <summary>
        ///     Demande et renvoie un caractère de type CHAR appartenant à un string  
        /// </summary>
        /// <param name="question">Question posée au moment de la demande</param>
        /// <param name="alphabet">Valeur plancher de l'intervalle incluse (optionnelle)</param>
        /// <returns></returns>
        public static char AskChar(string question, string alphabet)
        {
            string res_str = "";
            while (true)
            {
                Console.Write(question);
                res_str = Console.ReadLine();
                if (res_str.Length > 1)
                {
                    Console.WriteLine("\n\tErreur : Veuillez Entrer un seul caractère !\n");
                }
                else
                {
                    try
                    {
                        if (alphabet.Contains(res_str[0]))
                            break;
                        else
                        {
                            string msg = "";
                            foreach (char c in alphabet)
                                msg += c + " ";
                            Console.WriteLine("\n\tErreur : le caractère proposé doit être contenu dans cette liste : " + msg + "\n");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("\n\tErreur : Veuillez Entrer un caractère !\n");
                    }
                }
            }
            Console.WriteLine();
            return res_str[0];
        }
        /// <summary>
        ///     Renvoie un caractère de type CHAR aléatoirement extrait d'un string
        /// </summary>
        /// <param name="alphabet">String contenant les caractères potentiellement renvoyés </param>
        /// <returns></returns>
        public static char Take_Random_Char_From_Alphabet(string alphabet)
        {
            Random r = new Random();
            return alphabet[r.Next(0, alphabet.Length)];
        }
        /// <summary>
        ///     Détermine si une lettre de l'alphabet est accentuée ou combinée (æ)
        ///     limitation à "ÀàÁáÂâÃãÄäÅåÆæÇçÐðÈèÉéÊêËëÌìÍíÎîÏïÑñÒòÓóÔôÕõÖöœŒØøßÙùÚúÛûÜüÝýÞþŸÿ"
        /// </summary>
        static bool isSpecialLetter(char letter)
        {
            bool specialLetter = false;
            int i = 0;
            string specialLetterList = "ÀàÁáÂâÃãÄäÅåÆæÇçÐðÈèÉéÊêËëÌìÍíÎîÏïÑñÒòÓóÔôÕõÖöœŒØøßÙùÚúÛûÜüÝýÞþŸÿ";
            do
            {
                specialLetter = (specialLetterList[i] == letter);
                i++;
            }
            while ((!specialLetter) && (i < specialLetterList.Length));
            return specialLetter;
        }
        /// <summary>
        ///     Valide qu'un string ne contient aucun espace, ponctuation,
        ///     caractère spécial, accentué, OU est vide
        /// </summary>
        static bool IsStringOfLetter(string word)
        {
            bool isStringOK = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsLetter(word[i]) && !isSpecialLetter(word[i]))
                {
                    isStringOK = true;
                }
                else
                {
                    isStringOK = false;
                    break;
                }
            }
            return isStringOK;
        }
        /// <summary>
        ///     Demande un mot ne peut être vide, contenir Espace, Ponctuations, caractères Spéciaux Accentués ou Chiffres
        ///     Necessite bool isSpecialLetter(char ) & bool IsStringOfLetter(string)
        /// </summary>
        /// <param name="question">Question posée au moment de la demande</param>
        /// <returns></returns>
        static string Ask_a_Word(string question)
        {
            string inputUser = "";
            bool inputOK = false;
            do
            {
                Console.Write(question);
                inputUser = Console.ReadLine()!;
                inputOK = IsStringOfLetter(inputUser);

                if (!inputOK)
                {
                    Console.WriteLine("\nERREUR : votre mot ne peut être vide, contenir Espace, Ponctuations, caractères Spéciaux Accentués ou Chiffres !!!\n");
                }
            }
            while (!inputOK);
            return inputUser;
        }
    }
}
