using System;

public class Word
{
    // private stuffs
    private string _text;
    private bool _isHidden;


    // constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }


    // setters and getters
    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }


    // display or output
    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}