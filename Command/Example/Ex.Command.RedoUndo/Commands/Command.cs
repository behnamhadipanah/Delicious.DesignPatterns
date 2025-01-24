using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Command.RedoUndo.Commands
{
    public abstract class Command
    {
        protected ReceiverEditText _receiverEditText;

        protected Command(ReceiverEditText receiverEditText)
        {
            _receiverEditText = receiverEditText;
        }

        public string CurrentInput{ get; set; }
        public abstract string Execute(string input);
        public abstract string UnExecute(string input);

    }
}