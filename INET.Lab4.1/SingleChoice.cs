using System.Collections.Generic;

namespace INET.Lab4._1
{ 
    public class BankTerminalFactory
    {
        private Dictionary<BankTerminalType, BaseBankTerminal> _payments = new ();

        public BankTerminalFactory()
        {
            _payments.Add(BankTerminalType.Brp,BankTerminalBrp.create());
            _payments.Add(BankTerminalType.Dcp,BankTerminalDcp.create());
        }
    }
}