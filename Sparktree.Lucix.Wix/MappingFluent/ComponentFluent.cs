using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;
using Component = Sparktree.Lucid.Wix.MappingModel.Component;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class ComponentFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private Component _comp;

        public ComponentFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement comp)
            : base(comp)
        {
            _comp = comp as Component;
        }
        public ComponentFluent ComPlusFlags(int comPlusFlags)
        {
            _comp.ComPlusFlags = comPlusFlags;
            return this;
        }
        public ComponentFluent Directory(String directory)
        {
            _comp.Directory = directory;
            return this;
        }
        public ComponentFluent DisableRegistryReflection(Boolean disableReg)
        {
            _comp.DisableRegistryReflection = Utilities.YesNoTypeConvert<YesNoType>(disableReg);
            return this;
        }
        public ComponentFluent DiskId(String diskId)
        {
            _comp.DiskId = diskId;
            return this;
        }
        public ComponentFluent Feature(String feature)
        {
            _comp.Feature = feature;
            return this;
        }
        public ComponentFluent Guid(String guid)
        {
            _comp.Guid = guid;
            return this;
        }
        public ComponentFluent GenerateGuid()
        {
            _comp.Guid = Utilities.GenerateGuid();
            return this;
        }
        public ComponentFluent Id(String id)
        {
            _comp.Id = id;
            return this;
        }
        public ComponentFluent KeyPath(Boolean keyPath)
        {
            _comp.KeyPath = Utilities.YesNoTypeConvert<YesNoType>(keyPath);
            return this;
        }
        public ComponentFluent Location(Microsoft.Tools.WindowsInstallerXml.Serialize.Component.LocationType locType)
        {
            _comp.Location = locType;
            return this;
        }
        public ComponentFluent MultiInstance(Boolean multiInstance)
        {
            _comp.MultiInstance = Utilities.YesNoTypeConvert<YesNoType>(multiInstance);
            return this;
        }
        public ComponentFluent NeverOverwrite(Boolean neverOverwrite)
        {
            _comp.NeverOverwrite = Utilities.YesNoTypeConvert<YesNoType>(neverOverwrite);
            return this;
        }
        public ComponentFluent Permanent(Boolean permanent)
        {
            _comp.Permanent = Utilities.YesNoTypeConvert<YesNoType>(permanent);
            return this;
        }
        public ComponentFluent Shared(Boolean shared)
        {
            _comp.Shared = Utilities.YesNoTypeConvert<YesNoType>(shared);
            return this;
        }
        public ComponentFluent SharedDllRefCount(Boolean sharedDll)
        {
            _comp.SharedDllRefCount = Utilities.YesNoTypeConvert<YesNoType>(sharedDll);
            return this;
        }
        public ComponentFluent Transitive(Boolean trans)
        {
            _comp.Transitive = Utilities.YesNoTypeConvert<YesNoType>(trans);
            return this;
        }
        public ComponentFluent UninstallWhenSuperseded(Boolean uninstall)
        {
            _comp.UninstallWhenSuperseded = Utilities.YesNoTypeConvert<YesNoType>(uninstall);
            return this;
        }
        public ComponentFluent Win64(Boolean win64)
        {
            _comp.Win64 = Utilities.YesNoTypeConvert<YesNoType>(win64);
            return this;
        }
        
    }
}
