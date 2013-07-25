using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class BaseSchemaFluent : IBaseSchemaFluent
    {

        private readonly Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement _baseElement;
        public Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement GetBaseElement()
        {
            return _baseElement;
        }

        public BaseSchemaFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement baseElement)
        {
            _baseElement = baseElement;
        }

        #region Base Schema Element Fluent
        
        public BaseSchemaFluent ParentElement(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement parentElement)
        {
            var baseSchemeElement = _baseElement as Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement;
            baseSchemeElement.ParentElement = parentElement.ParentElement;
            return this;
        }
        public BaseSchemaFluent ParentElement(IBaseSchemaFluent parentElementFluent)
        {
            var baseSchemeElement = _baseElement as Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement;
            baseSchemeElement.ParentElement = parentElementFluent.GetBaseElement().ParentElement;
            return this;
        }
        #endregion
        
        #region Base Create Children Fluent

        public BaseSchemaFluent CreateChild(String childName)
        {
            var createChildrenElement = _baseElement as Microsoft.Tools.WindowsInstallerXml.Serialize.ICreateChildren;
            createChildrenElement.CreateChild(childName);
            return this;
        }
        #endregion

        #region Base Parent Element Fluent

        public BaseSchemaFluent AddChild(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement child)
        {
            var parentElement = _baseElement as Microsoft.Tools.WindowsInstallerXml.Serialize.IParentElement;
            parentElement.AddChild(child);
            return this;
        }

        public BaseSchemaFluent AddChild(IBaseSchemaFluent childFluent)
        {
            var parentElement = _baseElement as Microsoft.Tools.WindowsInstallerXml.Serialize.IParentElement;
            parentElement.AddChild(childFluent.GetBaseElement());
            return this;
        }


        public BaseSchemaFluent RemoveChild(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement child)
        {
            var parentElement = _baseElement as Microsoft.Tools.WindowsInstallerXml.Serialize.IParentElement;
            parentElement.RemoveChild(child);
            return this;
        }

        public BaseSchemaFluent RemoveChild(IBaseSchemaFluent childFluent)
        {
            var parentElement = _baseElement as Microsoft.Tools.WindowsInstallerXml.Serialize.IParentElement;
            parentElement.RemoveChild(childFluent.GetBaseElement());
            return this;
        }
        
        #endregion


        #region Base Set Attribute Fluent

        public BaseSchemaFluent SetAttribute(String name, String value)
        {
            var parentElement = _baseElement as Microsoft.Tools.WindowsInstallerXml.Serialize.ISetAttributes;
            parentElement.SetAttribute(name, value);
            return this;
        }

        #endregion


    }
}
