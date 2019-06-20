using System;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.Civil.ApplicationServices;
using SpeckleUiBase;
using SpeckleAutoCAD.UI;

namespace SpeckleAutoCAD
{
    public class Program : IExtensionApplication
    {
        public static bool Launched = false;
        public static SpeckleUiWindow SpeckleWindow;

        #region IExtensionApplication Members



        public void Initialize()
        {
 //           throw new System.Exception("The method or operation is not implemented.");
        }

        public void Terminate()
        {
 //           throw new System.Exception("The method or operation is not implemented.");
        }

        #endregion  

        [CommandMethod("Speckle")]
        public void Speckle()
        {
            // Gets the current document, and prints some basic information about it
            // to the command editor window.

            

            CivilDocument doc = Autodesk.Civil.ApplicationServices.CivilApplication.ActiveDocument;

            var bindings = new SpeckleUIBindingsAutoCAD(doc);

            ObjectIdCollection alignments = doc.GetAlignmentIds();
            ObjectIdCollection sites = doc.GetSiteIds();
            String docInfo = String.Format("\nHello Speckle!");
            Application.DocumentManager.MdiActiveDocument.Editor.WriteMessage(docInfo);

            SpeckleWindow = new SpeckleUiWindow(bindings);

            var helper = new System.Windows.Interop.WindowInteropHelper(SpeckleWindow);
            helper.Owner = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;

            SpeckleWindow.Show();
            Launched = true;

        }
    }
}
