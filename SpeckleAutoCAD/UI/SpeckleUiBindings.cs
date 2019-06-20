extern alias SpeckleNewtonsoft;
using SNJ = SpeckleNewtonsoft.Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.Civil.ApplicationServices;
using SpeckleUiBase;

namespace SpeckleAutoCAD.UI
{
  public partial class SpeckleUIBindingsAutoCAD : SpeckleUIBindings
    {

    public SpeckleUIBindingsAutoCAD(CivilDocument _doc) : base()
    {
      SpeckleCore.SpeckleInitializer.Initialize();
      SpeckleCore.LocalContext.Init();
    }

    /// <summary>
    /// Sends an event to the UI, bound to the global EventBus.
    /// </summary>
    /// <param name="eventName">The event's name.</param>
    /// <param name="eventInfo">The event args, which will be serialised to a string.</param>
    public void NotifyUi( string eventName, dynamic eventInfo )
    {
      var script = string.Format( "window.EventBus.$emit('{0}', {1})", eventName, SNJ.JsonConvert.SerializeObject( eventInfo ) );

    }

    /// <summary>
    /// Dispatches a store action directly. Please note, this will not work for any action.
    /// </summary>
    /// <param name="storeActionName"></param>
    /// <param name="args"></param>
    public void DispatchStoreActionUi( string storeActionName, string args = null )
    {
      var script = string.Format( "window.Store.dispatch('{0}', '{1}')", storeActionName, args );

    }

    /// <summary>
    /// Pops open the dev tools.
    /// </summary>
    public void ShowDev()
    {
 //     Browser.ShowDevTools();
    }

    /// <summary>
    /// Gets the current accounts.
    /// </summary>
    /// <returns></returns>
    public string GetAccounts()
    {
      return SNJ.JsonConvert.SerializeObject( SpeckleCore.LocalContext.GetAllAccounts() );
    }

        #region Client Actions

        public override string GetApplicationHostName()
        {
            throw new NotImplementedException();
        }

        public override string GetFileName()
        {
            throw new NotImplementedException();
        }

        public override string GetDocumentId()
        {
            throw new NotImplementedException();
        }

        public override string GetDocumentLocation()
        {
            throw new NotImplementedException();
        }

        public override string GetFileClients()
        {
            throw new NotImplementedException();
        }

        public override void AddSender(string args)
        {
            throw new NotImplementedException();
        }

        public override void AddSelectionToSender(string args)
        {
            throw new NotImplementedException();
        }

        public override void RemoveSelectionFromSender(string args)
        {
            throw new NotImplementedException();
        }

        public override void AddReceiver(string args)
        {
            throw new NotImplementedException();
        }

        public override void RemoveClient(string args)
        {
            throw new NotImplementedException();
        }

        public override void BakeReceiver(string args)
        {
            throw new NotImplementedException();
        }

        public override void UpdateSender(string args)
        {
            throw new NotImplementedException();
        }

        public override void AddObjectsToSender(string args)
        {
            throw new NotImplementedException();
        }

        public override void RemoveObjectsFromSender(string args)
        {
            throw new NotImplementedException();
        }

        public override void SelectClientObjects(string args)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
