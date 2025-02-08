namespace BridgeSystemInterface
{
    internal class SystemWindows
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
