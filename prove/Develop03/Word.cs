using System;

public class Word
{
    // private stuffs
    private string _text;
    private bool _isHidden;

    /*
    Constructor acts like an example of how the template should work, but for the computer
    */
    // constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    /*
    best I understand setter and getters act like a magnifying glass for comunication between public and private
    */
    // setters and getters
    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    /*
    this part I was stuck & this is the solution Ai gave. What the world is even happening here
    what is the ? doing, looking at bool? 
    */
    // display or output
    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}