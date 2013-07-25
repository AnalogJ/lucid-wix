using System;

namespace Sparktree.Lucid.Wix.MappingFluent.Abstract
{
    public interface IBaseSchemaFluent
    {
        Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement GetBaseElement();
        BaseSchemaFluent ParentElement(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement parentElement);
    }

    public interface IBaseCreateChildrenFluent
    {
        BaseSchemaFluent CreateChild(String childName);
    }

    public interface IBaseParentElementFluent
    {
        BaseSchemaFluent AddChild(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement child);
        BaseSchemaFluent RemoveChild(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement child);
    }

    public interface IBaseSetAttributesFluent
    {
        BaseSchemaFluent SetAttribute(String name, String value);
    }
}