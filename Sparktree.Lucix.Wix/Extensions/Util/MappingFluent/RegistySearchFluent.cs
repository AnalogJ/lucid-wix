using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sparktree.Lucid.Wix.MappingFluent;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Extensions.Serialize.Util;
using UtilRegistrySearch = Sparktree.Lucid.Wix.Extensions.Util.MappingModel.RegistySearch;
namespace Sparktree.Lucid.Wix.Extensions.Util.MappingFluent
{
    public class RegistySearchFluent : BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private UtilRegistrySearch _regSearch;

        public RegistySearchFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement regSearch)
            : base(regSearch)
        {
            _regSearch = regSearch as UtilRegistrySearch;
        }

        public RegistySearchFluent After(String field)
        {
            _regSearch.After = field;
            return this;
        }
        public RegistySearchFluent Condition(String field)
        {
            _regSearch.Condition = field;
            return this;
        }
        public RegistySearchFluent ExpandEnvVariables(Boolean field)
        {
            _regSearch.ExpandEnvironmentVariables = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public RegistySearchFluent Format(RegistrySearch.FormatType field)
        {
            _regSearch.Format = field;
            return this;
        }
        public RegistySearchFluent Id(String field)
        {
            _regSearch.Id = field;
            return this;
        }
        public RegistySearchFluent Key(String field)
        {
            _regSearch.Key = field;
            return this;
        }
        public RegistySearchFluent Result(RegistrySearch.ResultType field)
        {
            _regSearch.Result = field;
            return this;
        }
        public RegistySearchFluent Root(RegistrySearch.RootType field)
        {
            _regSearch.Root = field;
            return this;
        }
        public RegistySearchFluent Value(String field)
        {
            _regSearch.Value = field;
            return this;
        }
        public RegistySearchFluent Variable(String field)
        {
            _regSearch.Variable = field;
            return this;
        }
        public RegistySearchFluent Win64(Boolean field)
        {
            _regSearch.Win64 = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
    }
}
