using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Sparktree.Lucid.Wix.MappingModel;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class ProductFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private Product _product;

        public ProductFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement product)
            : base(product)
        {
            _product = product as Product;
        }
        public ProductFluent Codepage(String field)
        {
            _product.Codepage = field;
            return this;
        }
        public ProductFluent Id(String id)
        {
            _product.Id = id;
            return this;
        }
        public ProductFluent Language(String field)
        {
            _product.Language = field;
            return this;
        }
        public ProductFluent Manufacturer(String field)
        {
            _product.Manufacturer = field;
            return this;
        }
        public ProductFluent Name(String field)
        {
            _product.Name = field;
            return this;
        }
        public ProductFluent UpgradeCode(String field)
        {
            _product.UpgradeCode = field;
            return this;
        }
        public ProductFluent Version(String field)
        {
            _product.Version = field;
            return this;
        }
    }
}
