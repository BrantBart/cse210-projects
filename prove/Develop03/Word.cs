using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Word
{
    public string Text { get; set; }
    public bool IsHidden { get; set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }
}
