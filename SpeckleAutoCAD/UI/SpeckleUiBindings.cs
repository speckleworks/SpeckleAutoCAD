﻿//extern alias SpeckleNewtonsoft;
//using SNJ = SpeckleNewtonsoft.Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.Civil.ApplicationServices;
using SpeckleCore;
using SpeckleUiBase;

namespace SpeckleAutoCAD.UI
{
    public partial class SpeckleUIBindingsAutoCAD : SpeckleUIBindings
    {
        public List<SpeckleStream> LocalState;
        public CivilDocument ActiveDocCivil { get => Autodesk.Civil.ApplicationServices.CivilApplication.ActiveDocument; }
        public Document doc { get => Application.DocumentManager.MdiActiveDocument; }
        public Document AcadDoc { get => Application.DocumentManager.CurrentDocument; }

        public SpeckleUIBindingsAutoCAD(CivilDocument _doc) : base()
        {

        }

        #region Client Actions

        public override string GetApplicationHostName()
        {
            return "Civil3D";
        }

        public override string GetFileName()
        {
            return doc.Name;
        }

        public override string GetDocumentId()
        {

            return Application.InfoCenter.Host.Handle.ToString();
        }

        public override string GetDocumentLocation()
        {
            return doc.Database.Filename;
        }

        public override string GetFileClients()
        {
            // This one is for getting the clients for a particular Civil3D file/document (retrieving streamids/filters etc into the file)
            throw new NotImplementedException();
        }

        public override void AddSender(string args)
        {
            // this also sets the stream ids into the Civil3D file new and existing
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
            // this also sets the stream ids into the Civil3D file new and existing
            throw new NotImplementedException();
        }

        public override void RemoveClient(string args)
        {
            throw new NotImplementedException();
        }

        public override void BakeReceiver(string args)
        {
            // bake button brings geometry into Civil3D
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
            // select elements
            throw new NotImplementedException();
        }

        public override void PushSender(string args)
        {
            // manual send
            throw new NotImplementedException();
        }

        public override List<ISelectionFilter> GetSelectionFilters()
        {
            // get filters from client
            throw new NotImplementedException();
        }

        #endregion
    }
}
