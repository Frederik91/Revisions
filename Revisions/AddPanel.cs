using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;

namespace Revisions
{
    public class AddPanel : Autodesk.Revit.UI.IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            // add new ribbon panel
            RibbonPanel ribbonPanel = application.CreateRibbonPanel("Revisions");

            //Create a push button in the ribbon panel "NewRibbonPanel"
            //the add-in application "HelloWorld" will be triggered when button is pushed

            PushButton pushButton = ribbonPanel.AddItem(new PushButtonData("Create snapshot",
                "Create snapshot", @"C:\Users\frte\Source\Repos\Revisions\Revisions\bin\Debug\Revisions.dll", @"C:\Users\frte\Source\Repos\Revisions\Revisions\CreateSnapshot.cs")) as PushButton;

            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
    }
}
