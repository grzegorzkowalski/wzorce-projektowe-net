namespace BridgeSystemInterface
{
    internal class SystemLinux
    {
        internal IUserInterface userInterface { get; set; }
        internal void DisplayMenu()
        {
            if (userInterface != null)
            {
                userInterface.DisplayMenu();
            }
        }
    }
}
