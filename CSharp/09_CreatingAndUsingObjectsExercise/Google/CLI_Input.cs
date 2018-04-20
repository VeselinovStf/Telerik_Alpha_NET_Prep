using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Google
{
    public static class CLI_Input
    {
        public static void FakeInput()
        {
            string input = @"JelioJelev pokemon Onyx Rock
JelioJelev parents JeleJelev 13/03/1933
GoshoGoshev pokemon Moltres Fire
JelioJelev company JeleInc Jelior 777.77
JelioJelev children PudingJelev 01/01/2001
StamatStamatov pokemon Blastoise Water
JelioJelev car AudiA4 180
JelioJelev pokemon Charizard Fire
End
JelioJelev";

            Console.SetIn(new StringReader(input));
        }
    }
}
