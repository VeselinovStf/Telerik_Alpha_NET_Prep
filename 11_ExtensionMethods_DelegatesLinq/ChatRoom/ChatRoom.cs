using System;
using System.Collections.Generic;
using System.Text;

namespace ChatRoom
{
    public class ChatRoom
    {
        public event EventHandler<ChatMessageEventArgs> ChatRoomEventHandler;

        public ChatRoom(string name)
        {
            Name = name;
        }

        

        public string Name { get; private set; }

        public  void PublishMessage(string username, string content)
        {
            var msgArgs = new ChatMessageEventArgs(content, username);
            this.ChatRoomEventHandler(this, msgArgs);
        }

      
    }
}
