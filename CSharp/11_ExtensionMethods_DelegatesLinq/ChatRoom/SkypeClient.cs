using System;
using System.Collections.Generic;
using System.Text;

namespace ChatRoom
{
    public class SkypeClient
    {
        public SkypeClient(string user)
        {
            User = user;
        }

        public string User { get; private set; }

        public void JoinChatRoom(ChatRoom room)
        {
            room.ChatRoomEventHandler += this.OnMessageRecieve;
        }

        public void SendMessage(ChatRoom room, string content)
        {
            room.PublishMessage(this.User, content);
        }

        protected void OnMessageRecieve(object sender, ChatMessageEventArgs args)
        {
            Console.WriteLine($"SK-> [{this.User}] | just recieved : [{args.Author}] : {args.Content}");
        }
    }
}
