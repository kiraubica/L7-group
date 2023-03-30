using L7_group;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        IDBItem_DataAccessLayer dbItem_DataAccessLayer = new DBItem_DataAccessLayer();
        IDispatcherPresentationLayer dispatcherPresentationLayer = new DispatcherPresentationLayer(dbItem_DataAccessLayer);
        MainMenu mainMenu = new MainMenu(dispatcherPresentationLayer);
        DispatcherMenu dispatcherMenu = new DispatcherMenu(dispatcherPresentationLayer);
        mainMenu.Show();
    }
}