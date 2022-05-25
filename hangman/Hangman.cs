using System.IO;
using System.Collections.Generic;

namespace Game
{
    public class Hangman
    {
        public Hangman(string file)
        {
            _words = new Dictionary<int, List<string>>();
            for (int i = 0; i < 30; ++i)
            {
                _words.Add(i, new List<string>());
            }

            foreach (string line in File.ReadLines(file))
            {
                _words[line.Length].Add(line);
            }
        }

        private Dictionary<int, List<string>> _words;
        public Dictionary<int, List<string>> Words
        {
            get
            {
                return this._words;
            }
        }
        private List<string> _currentWords;
        public List<string> CurrentWords
        {
            get
            {
                return this._currentWords;
            }
        }
        public int _numGuesses { get; set;}
        public int _wordLength { get; set;}
        private bool _isDebug;
    }
}