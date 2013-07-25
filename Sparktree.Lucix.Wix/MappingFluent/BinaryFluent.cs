using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;
using Binary = Sparktree.Lucid.Wix.MappingModel.Binary;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class BinaryFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private Binary _binary;

        public BinaryFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement binary)
            : base(binary)
        {
            _binary = binary as Binary;
        }
        public BinaryFluent Id(String id)
        {
            _binary.Id = id;
            return this;
        }
        public BinaryFluent IdByName(String binaryFileName)
        {
            _binary.Id = Utilities.GenerateBinaryId(binaryFileName);
            return this;
        }

        public BinaryFluent SourceFile(String sourceFile)
        {
            _binary.SourceFile = sourceFile;
            return this;
        }

        public BinaryFluent Src(String src)
        {
            _binary.src = src;
            return this;
        }

        public BinaryFluent SuppressModularization(Boolean suppressModularization)
        {
            _binary.SuppressModularization = Utilities.YesNoTypeConvert<YesNoType>(suppressModularization);
            return this;
        }
    }
}
