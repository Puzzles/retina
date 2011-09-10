using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Retina
{
    class Core
    {

        internal static void handleMessage(MainWindow mainWindow, string message)
        {
            if (message.StartsWith("/"))
            {
                // This catches any message determined to be (possibly) global in nature. Eg. Joining a new channel etc.
                mainWindow.messageList.Items.Add("DEBUG: Command specified.");
            }
            else
            {
                // Here we can pull off normal channel (or user) messages and process them.
                mainWindow.messageList.Items.Add("DEBUG: This is a channel message.");
            }
        }

        internal void init()
        {
            throw new NotImplementedException();
        }

    }
}
