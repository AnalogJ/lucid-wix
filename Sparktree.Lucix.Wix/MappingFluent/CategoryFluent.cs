using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Sparktree.Lucid.Wix.MappingModel;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class CategoryFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private Category _category;

        public CategoryFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement category)
            : base(category)
        {
            _category = category as Category;
        }
        public CategoryFluent AppData(String appData)
        {
            _category.AppData = appData;
            return this;
        }
        public CategoryFluent Feature(String feature)
        {
            _category.Feature = feature;
            return this;
        }
        public CategoryFluent Id(String id)
        {
            _category.Id = id;
            return this;
        }
        public CategoryFluent Qualifier(String qualifier)
        {
            _category.Qualifier = qualifier;
            return this;
        }
    }
}
