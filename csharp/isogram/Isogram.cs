using System;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        bool result = true;

        if (word.Length <= 0)
        {
            return true;
        }

        /* This will keep the frequency of letters in order from
        a-z.*/
        int[] letterFrequencies = new int[26];

        // Fill the letterFrequencies with zeroes.
        Array.Clear(letterFrequencies, 0, letterFrequencies.Length);
        // Convert all letters to lowercase.
        word = word.ToLower();

        /* Go through each ascii character and get
        the frequencies of each letter from Aa-zZ. We
        will ignore all other ascii characters. */
        for (int i = 0; i < word.Length; i++)
        {
            int asciiCode = (int)word[i];

            // We will deal with a-z only.
            if (asciiCode >= 97 && asciiCode <= 122)
            {
                /* The letter a has an ascii code of 97,
                thus we need to offset by 97. */
                letterFrequencies[asciiCode - 97] += 1;

            }
        }

        /* To determine if the input is a pangram,
        the frequencies of all letters a-z needs to
        be at least one. */
        foreach (int letterFrequency in letterFrequencies)
        {
            if (letterFrequency > 1)
            {
                result = false;
                break;
            }
        }

        return result;
    }
}