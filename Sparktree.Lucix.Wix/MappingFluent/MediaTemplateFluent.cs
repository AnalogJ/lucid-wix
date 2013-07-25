using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;
using MediaTemplate = Sparktree.Lucid.Wix.MappingModel.MediaTemplate;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class MediaTemplateFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private MediaTemplate _mediaTemp;

        public MediaTemplateFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement mediaTemp)
            : base(mediaTemp)
        {
            _mediaTemp = mediaTemp as MediaTemplate;
        }
        public MediaTemplateFluent CabinetTemplate(String field)
        {
            _mediaTemp.CabinetTemplate = field;
            return this;
        }
        public MediaTemplateFluent CompressionLevel(Microsoft.Tools.WindowsInstallerXml.Serialize.MediaTemplate.CompressionLevelType field)
        {
            _mediaTemp.CompressionLevel = field;
            return this;
        }
        public MediaTemplateFluent DiskPrompt(String field)
        {
            _mediaTemp.DiskPrompt = field;
            return this;
        }
        public MediaTemplateFluent EmbedCab(Boolean field)
        {
            _mediaTemp.EmbedCab = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public MediaTemplateFluent MaximumUncompressedMediaSize(Int32 field)
        {
            _mediaTemp.MaximumUncompressedMediaSize = field;
            return this;
        }
        public MediaTemplateFluent VolumeLabel(String field)
        {
            _mediaTemp.VolumeLabel = field;
            return this;
        }
    }
}
