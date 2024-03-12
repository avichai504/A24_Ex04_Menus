//using Ex04.Menus.Interfaces;

//namespace Ex04.Menus.Test.Tests
//{
//    public class InterfaceMenuTest
//    {
//        public void Show()
//        {
//            Menu mainMenu = new Menu("Interface Test Menu");
//            MenuItem dateTimeMenuItem = new MenuItem("Show Date/Time", new ShowDateOrTime());
//            MenuItem versionAndDigitsMenuItem = new MenuItem("Version and Digits", new VersionAndDigits());

//            mainMenu.AddMenuItem(dateTimeMenuItem);
//            mainMenu.AddMenuItem(versionAndDigitsMenuItem);

//            mainMenu.Show();
//        }

//        private class ShowDateOrTime : IMenuAction
//        {
//            public void Execute()
//            {
//                // Here you can implement the logic to show date or time
//                // For example:
//                // Console.WriteLine(DateTime.Now.ToString());
//            }
//        }

//        private class VersionAndDigits : IMenuAction
//        {
//            public void Execute()
//            {
//                // Here you can implement the logic to show version or count digits
//                // For example:
//                // Console.WriteLine("Version: 1.0");
//            }
//        }
//    }
//}
