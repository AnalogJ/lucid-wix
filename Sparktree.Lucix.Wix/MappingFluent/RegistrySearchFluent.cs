using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;
using RegistrySearch = Sparktree.Lucid.Wix.MappingModel.RegistrySearch;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class RegistrySearchFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private RegistrySearch _registrySearch;

        public RegistrySearchFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement reg)
            : base(reg)
        {
            _registrySearch = reg as RegistrySearch;
        }
        public RegistrySearchFluent Id(String field)
        {
            _registrySearch.Id = field;
            return this;
        }
        public RegistrySearchFluent Key(String field)
        {
            _registrySearch.Key = field;
            return this;
        }
        public RegistrySearchFluent Name(String field)
        {
            _registrySearch.Name = field;
            return this;
        }
        public RegistrySearchFluent Root(Microsoft.Tools.WindowsInstallerXml.Serialize.RegistrySearch.RootType field)
        {
            _registrySearch.Root = field;
            return this;
        }
        public RegistrySearchFluent Type(Microsoft.Tools.WindowsInstallerXml.Serialize.RegistrySearch.TypeType field)
        {
            _registrySearch.Type = field;
            return this;
        }
        public RegistrySearchFluent Win64(Boolean field)
        {
            _registrySearch.Win64 = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
    }
}
