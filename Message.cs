using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FifthLessonTasks
{
    class Message
    {
        public string MessageText
        {
            get
            {
                return messageText;
            }
            set
            {
                messageText = value;
                BuildWordsList(value);
            }
        }
        private string messageText { get; set; }
        private List<string> messageWords = new List<string>();

        public Message(string messageText)
        {
            MessageText = messageText;
        }

        private void BuildWordsList(string message)
        {
            messageWords.Clear();
            StringBuilder strB = new StringBuilder(message+" ");
            string word = "";
            for(var i = 0; i < strB.Length; i++)
            {
                if (strB[i] >= 'а' && strB[i] <= 'я' || strB[i] >= 'А' && strB[i] <= 'Я') 
                {
                    word += strB[i];
                }else
                {
                    if (!String.IsNullOrEmpty(word))
                    {
                        messageWords.Add(word);
                        word = "";
                    }
                }

            }

            Regex regExpEng = new Regex(@"\b[a-zA-Z]{1,}\b");
            foreach (Match mtchEng in regExpEng.Matches(message))
            {
                messageWords.Add(mtchEng.Value);
            }
        }

        public List<string> GetLesserThanMaxWords(int max)
        {
            List<string> result = new List<string>();
            foreach(string word in messageWords)
            {
                if(word.Length < max)
                {
                    result.Add(word);
                }
            }

            return result;
        }

        public List<string> RemoveWordsEndsOn(char endingSym)
        {
            List<string> result = new List<string>();
            string tempMessage = MessageText;
            StringBuilder strB = new StringBuilder(MessageText);
            foreach (string word in messageWords)
            {
                if (word.EndsWith(endingSym.ToString()))
                {
                    Regex regExp = new Regex(word);
                    Match mtch = regExp.Match(tempMessage);
                    while (mtch.Success)
                    {
                        strB = strB.Remove(mtch.Index, word.Length);
                        tempMessage = strB.ToString();
                        mtch = regExp.Match(tempMessage);
                    }

                    result.Add(word);
                }
            }
            MessageText = tempMessage;

            return result;
        }

        public string GetLongestWord()
        {
            string result = "";
            for(int i = 0; i < messageWords.Count; i++)
            {
                if (messageWords[i].Length > result.Length) result = messageWords[i];
            }

            return result;
        }

        public string GetStringWithLongestWords()
        {
            string longestWord = GetLongestWord();
            string result = "";
            for (int i = 0; i < messageWords.Count; i++)
            {
                if (messageWords[i].Length == longestWord.Length)
                {
                    result += " " + messageWords[i];
                }
            }
            return result;
        }

        public override string ToString()
        {
            return MessageText;
        }

    }
}
