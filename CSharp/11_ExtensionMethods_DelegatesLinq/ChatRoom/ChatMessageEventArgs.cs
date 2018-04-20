using System;

namespace ChatRoom
{
    public class ChatMessageEventArgs : EventArgs
    {
        public ChatMessageEventArgs(string content, string author)
        {
            this.Content = content;
            this.Author = author;
            this.SendOn = DateTime.Now;
        }

        public string Content { get; private set; }
        public string Author { get; private set; }
        public DateTime SendOn { get; private set; }
    }
}