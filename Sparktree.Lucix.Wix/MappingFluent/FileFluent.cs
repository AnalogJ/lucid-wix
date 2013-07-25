using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;
using File = Sparktree.Lucid.Wix.MappingModel.File;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class FileFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private File _file;

        public FileFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement file)
            : base(file)
        {
            _file = file as File;
        }
        public FileFluent Assembly(Microsoft.Tools.WindowsInstallerXml.Serialize.File.AssemblyType assemblyType)
        {
            _file.Assembly = assemblyType;
            return this;
        }
        public FileFluent AssemblyApplication(String assemblyApp)
        {
            _file.AssemblyApplication = assemblyApp;
            return this;
        }
        public FileFluent AssemblyManifest(String assemblyManifest)
        {
            _file.AssemblyManifest = assemblyManifest;
            return this;
        }
        public FileFluent BindPath(String bindPath)
        {
            _file.BindPath = bindPath;
            return this;
        }
        public FileFluent Checksum(Boolean checksum)
        {
            _file.Checksum = Utilities.YesNoTypeConvert<YesNoType>(checksum);
            return this;
        }
        public FileFluent CompanionFile(String compFile)
        {
            _file.CompanionFile = compFile;
            return this;
        }
        public FileFluent Compressed(Boolean? comp)
        {
            _file.Compressed = Utilities.YesNoDefaultTypeConvert<YesNoDefaultType>(comp);
            return this;
        }
        public FileFluent DefaultLanguage(String lang)
        {
            _file.DefaultLanguage = lang;
            return this;
        }
        public FileFluent DiskId(String diskId)
        {
            _file.DiskId = diskId;
            return this;
        }
        public FileFluent FontTitle(String font)
        {
            _file.FontTitle = font;
            return this;
        }
        public FileFluent Hidden(Boolean hidden)
        {
            _file.Hidden = Utilities.YesNoTypeConvert<YesNoType>(hidden);
            return this;
        }
        public FileFluent Id(String id)
        {
            _file.Id = id;
            return this;
        }
        public FileFluent KeyPath(Boolean keyPath)
        {
            _file.KeyPath = Utilities.YesNoTypeConvert<YesNoType>(keyPath);
            return this;
        }
        public FileFluent LongName(String longName)
        {
            _file.LongName = longName;
            return this;
        }
        public FileFluent Name(String name)
        {
            _file.Name = name;
            return this;
        }
        public FileFluent PatchAllowIgnoreOnError(Boolean patch)
        {
            _file.PatchAllowIgnoreOnError = Utilities.YesNoTypeConvert<YesNoType>(patch);
            return this;
        }
        public FileFluent PatchGroup(Int32 patch)
        {
            _file.PatchGroup = patch;
            return this;
        }
        public FileFluent PatchIgnore(Boolean patch)
        {
            _file.PatchIgnore = Utilities.YesNoTypeConvert<YesNoType>(patch);
            return this;
        }
        public FileFluent PatchWholeFile(Boolean patch)
        {
            _file.PatchWholeFile = Utilities.YesNoTypeConvert<YesNoType>(patch);
            return this;
        }
        public FileFluent ProcessorArchitecture(Microsoft.Tools.WindowsInstallerXml.Serialize.File.ProcessorArchitectureType patch)
        {
            _file.ProcessorArchitecture = patch;
            return this;
        }
        public FileFluent ReadOnly(Boolean readOnly)
        {
            _file.ReadOnly = Utilities.YesNoTypeConvert<YesNoType>(readOnly);
            return this;
        }
        public FileFluent SelfRegCost(Int32 selfreg)
        {
            _file.SelfRegCost = selfreg;
            return this;
        }
        public FileFluent Shortname(String shortName)
        {
            _file.ShortName = shortName;
            return this;
        }
        public FileFluent Source(String source)
        {
            _file.Source = source;
            return this;
        }
        public FileFluent System(Boolean system)
        {
            _file.System = Utilities.YesNoTypeConvert<YesNoType>(system);
            return this;
        }
        public FileFluent TrueType(Boolean trueType)
        {
            _file.TrueType = Utilities.YesNoTypeConvert<YesNoType>(trueType);
            return this;
        }
        public FileFluent Vital(Boolean vital)
        {
            _file.Vital = Utilities.YesNoTypeConvert<YesNoType>(vital);
            return this;
        }
    }
}
