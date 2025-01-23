using BridgeSystemInterface;

var linux = new SystemLinux();
linux.userInterface = new ConsoleInterface();
linux.DisplayMenu();

var windows = new SystemWindows();
windows.userInterface = new GUIInterface();
windows.DisplayMenu();