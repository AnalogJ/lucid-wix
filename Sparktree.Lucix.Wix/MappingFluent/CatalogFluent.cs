using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Sparktree.Lucid.Wix.MappingModel;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class CatalogFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseSetAttributesFluent
    {
        private Catalog _catalog;

        public CatalogFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement catalog)
            : base(catalog)
        {
            _catalog = catalog as Catalog;
        }
        public CatalogFluent Id(String id)
        {
            _catalog.Id = id;
            return this;
        }
        public CatalogFluent SourceFile(String sourceFile)
        {
            _catalog.SourceFile = sourceFile;
            return this;
        }
    }
}
