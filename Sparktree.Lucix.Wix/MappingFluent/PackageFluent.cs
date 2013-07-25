using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;
using Package = Sparktree.Lucid.Wix.MappingModel.Package;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class PackageFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseSetAttributesFluent
    {
        private Package _package;

        public PackageFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement package)
            : base(package)
        {
            _package = package as Package;
        }
        public PackageFluent AdminImage(Boolean field)
        {
            _package.AdminImage = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public PackageFluent Comments(String field)
        {
            _package.Comments = field;
            return this;
        }
        public PackageFluent Compressed(Boolean field)
        {
            _package.Compressed = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public PackageFluent Description(String field)
        {
            _package.Description = field;
            return this;
        }
        public PackageFluent Id(String field)
        {
            _package.Id = field;
            return this;
        }

        public PackageFluent InstallerVersion(Int32 field)
        {
            _package.InstallerVersion = field;
            return this;
        }
        public PackageFluent InstallPrivileges(Microsoft.Tools.WindowsInstallerXml.Serialize.Package.InstallPrivilegesType field)
        {
            _package.InstallPrivileges = field;
            return this;
        }
        public PackageFluent InstallScope(Microsoft.Tools.WindowsInstallerXml.Serialize.Package.InstallScopeType field)
        {
            _package.InstallScope = field;
            return this;
        }
        public PackageFluent Keywords(String field)
        {
            _package.Keywords = field;
            return this;
        }
        public PackageFluent Languages(String field)
        {
            _package.Languages = field;
            return this;
        }
        public PackageFluent Manufacturer(String field)
        {
            _package.Manufacturer = field;
            return this;
        }
        public PackageFluent Platform(Microsoft.Tools.WindowsInstallerXml.Serialize.Package.PlatformType field)
        {
            _package.Platform = field;
            return this;
        }
        public PackageFluent Platforms(String field)
        {
            _package.Platforms = field;
            return this;
        }
        public PackageFluent ReadOnly(Boolean? field)
        {
            _package.ReadOnly = Utilities.YesNoDefaultTypeConvert<YesNoDefaultType>(field);
            return this;
        }
        public PackageFluent ShortNames(Boolean field)
        {
            _package.ShortNames = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public PackageFluent SummaryCodepage(String field)
        {
            _package.SummaryCodepage = field;
            return this;
        }
    }
}
