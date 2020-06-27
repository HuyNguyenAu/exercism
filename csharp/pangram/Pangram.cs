using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        bool result = true;

        if (input.Length <= 0)
        {
            return false;
        }

        /* This will keep the frequency of letters in order from
        a-z.*/
        int[] letterFrequencies = new int[26];

        // Fill the letterFrequencies with zeroes.
        Array.Clear(letterFrequencies, 0, letterFrequencies.Length);
        // Convert all letters to lowercase.
        input = input.ToLower();

        /* Go through each ascii character and get
        the frequencies of each letter from Aa-zZ. We
        will ignore all other ascii characters. */
        for (int i = 0; i < input.Length; i++)
        {
            int asciiCode = (int)input[i];

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
        be one and one only. */
        foreach (int letterFrequency in letterFrequencies) {
            if (letterFrequency <= 0) {
                result = false;
                break;
            }
        }

        return result;
    }
}
