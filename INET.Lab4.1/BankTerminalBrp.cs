namespace INET.Lab4._1
{
    public class BankTerminalBrp: BaseBankTerminal{
        public static BankTerminalBrp create() 
        {
            return new BankTerminalBrp();    
        }

        private BankTerminalBrp()
        {
            this.type = BankTerminalType.Brp;
        }
    }
}