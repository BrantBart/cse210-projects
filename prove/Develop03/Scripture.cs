using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


class Scripture
{
    private List<Word> words;
    private Reference reference;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        InitializeWords(text);
    }

    private void InitializeWords(string text)
    {
        string[] wordArray = text.Split(' ');
        words = wordArray.Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine($"{reference.ReferenceText}: {GetDisplayText()}");
    }

    private string GetDisplayText()
    {
        return string.Join(" ", words.Select(word => word.IsHidden ? "___" : word.Text));
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = random.Next(1, 4); // Hide 1 to 3 words

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(words.Count);
            words[index].IsHidden = true;
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.IsHidden);
    }
}
