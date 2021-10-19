namespace INET.Lab4._1
{
    public class BankTerminalDcp: BaseBankTerminal {
        public static BankTerminalDcp create() 
        {
            return new BankTerminalDcp();    
        }

        private BankTerminalDcp()
        {
            this.type = BankTerminalType.Dcp;
        }
    } 
}