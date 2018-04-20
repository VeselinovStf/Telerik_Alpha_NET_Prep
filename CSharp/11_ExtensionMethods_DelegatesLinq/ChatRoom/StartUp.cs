using System;

namespace ChatRoom
{
    public class StartUp
    {
        public static void Main()
        {
            var chatRoom = new ChatRoom("T1");

            var pesho = new SkypeClient("Pesho");
            var conka = new mRCaClient("Conka");

            pesho.JoinChatRoom(chatRoom);
            conka.JoinChatRoom(chatRoom);

            pesho.SendMessage(chatRoom, "Ko Staa Conke");
        }
    }
}
