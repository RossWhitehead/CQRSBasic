namespace CQRSBasic.CommandStack
{
    // Simple result class for command handlers to return 
    public class CommandResult
    {
        public bool Success { get; set; }

        public string Message { get; set; }
    }
}
