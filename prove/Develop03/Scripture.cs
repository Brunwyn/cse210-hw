public class Scripture
{
    // private stuffs
    private Reference _reference;
    private List<Word> _words;


    // constructors
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // iterating while pain
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsHidden = 0;

        while (wordsHidden < numberToHide && !IsCompletelyHidden())
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                wordsHidden++;
            }
        }
    }

    
    // return display
    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {scriptureText}";
    }

    // almost works results in 2 words still showing at the end
    // maybe add a delay?
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }



}