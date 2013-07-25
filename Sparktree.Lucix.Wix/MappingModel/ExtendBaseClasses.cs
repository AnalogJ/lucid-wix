using Sparktree.Lucid.Wix.MappingFluent;

namespace Sparktree.Lucid.Wix.MappingModel
{
   
    public class Wix : Microsoft.Tools.WindowsInstallerXml.Serialize.Wix
    {
        private WixFluent _set;
        public Wix()
        {
            _set = new WixFluent(this);
        }
        public WixFluent Set
        {
            get { return _set; }
        }

    }

    public class AdminExecuteSequence : Microsoft.Tools.WindowsInstallerXml.Serialize.AdminExecuteSequence
    {
        private BaseSchemaFluent _set;
        public AdminExecuteSequence()
        {
            _set = new BaseSchemaFluent(this);
        }
        public BaseSchemaFluent Set
        {
            get { return _set; }
        }

    }

    public class AdminUISequence : Microsoft.Tools.WindowsInstallerXml.Serialize.AdminUISequence
    {
        private BaseSchemaFluent _set;
        public AdminUISequence()
        {
            _set = new BaseSchemaFluent(this);
        }
        public BaseSchemaFluent Set
        {
            get { return _set; }
        }

    }

    public class Binary : Microsoft.Tools.WindowsInstallerXml.Serialize.Binary
    {
        private BinaryFluent _set;
        public Binary()
        {
            _set = new BinaryFluent(this);
        }
        public BinaryFluent Set
        {
            get { return _set; }
        }

    }

    public class BinaryRef : Microsoft.Tools.WindowsInstallerXml.Serialize.BinaryRef
    {
        private BinaryRefFluent _set;
        public BinaryRef()
        {
            _set = new BinaryRefFluent(this);
        }
        public BinaryRefFluent Set
        {
            get { return _set; }
        }

    }

    public class BootstrapperApplication : Microsoft.Tools.WindowsInstallerXml.Serialize.BootstrapperApplication
    {
        private BootstrapperApplicationFluent _set;
        public BootstrapperApplication()
        {
            _set = new BootstrapperApplicationFluent(this);
        }
        public BootstrapperApplicationFluent Set
        {
            get { return _set; }
        }

    }

    public class BootstrapperApplicationRef : Microsoft.Tools.WindowsInstallerXml.Serialize.BootstrapperApplicationRef
    {
        private BootstrapperApplicationRefFluent _set;
        public BootstrapperApplicationRef()
        {
            _set = new BootstrapperApplicationRefFluent(this);
        }
        public BootstrapperApplicationRefFluent Set
        {
            get { return _set; }
        }

    }

    public class Bundle : Microsoft.Tools.WindowsInstallerXml.Serialize.Bundle
    {
        private BundleFluent _set;
        public Bundle()
        {
            _set = new BundleFluent(this);
        }
        public BundleFluent Set
        {
            get { return _set; }
        }

    }

    public class Catalog : Microsoft.Tools.WindowsInstallerXml.Serialize.Catalog
    {
        private CatalogFluent _set;
        public Catalog()
        {
            _set = new CatalogFluent(this);
        }
        public CatalogFluent Set
        {
            get { return _set; }
        }

    }

    public class Category : Microsoft.Tools.WindowsInstallerXml.Serialize.Category
    {
        private CategoryFluent _set;
        public Category()
        {
            _set = new CategoryFluent(this);
        }
        public CategoryFluent Set
        {
            get { return _set; }
        }

    }

    public class Chain : Microsoft.Tools.WindowsInstallerXml.Serialize.Chain
    {
        private ChainFluent _set;
        public Chain()
        {
            _set = new ChainFluent(this);
        }
        public ChainFluent Set
        {
            get { return _set; }
        }

    }

    public class ComboBox : Microsoft.Tools.WindowsInstallerXml.Serialize.ComboBox
    {
        private ComboBoxFluent _set;
        public ComboBox()
        {
            _set = new ComboBoxFluent(this);
        }
        public ComboBoxFluent Set
        {
            get { return _set; }
        }

    }
    public class Component : Microsoft.Tools.WindowsInstallerXml.Serialize.Component
    {
        private ComponentFluent _set;
        public Component()
        {
            _set = new ComponentFluent(this);
        }
        public ComponentFluent Set
        {
            get { return _set; }
        }

    }
    public class ComponentGroup : Microsoft.Tools.WindowsInstallerXml.Serialize.ComponentGroup
    {
        private ComponentGroupFluent _set;
        public ComponentGroup()
        {
            _set = new ComponentGroupFluent(this);
        }
        public ComponentGroupFluent Set
        {
            get { return _set; }
        }
    }
    public class ComponentGroupRef : Microsoft.Tools.WindowsInstallerXml.Serialize.ComponentGroupRef
    {
        private ComponentGroupRefFluent _set;
        public ComponentGroupRef()
        {
            _set = new ComponentGroupRefFluent(this);
        }
        public ComponentGroupRefFluent Set
        {
            get { return _set; }
        }
    }

    public class ComponentRef : Microsoft.Tools.WindowsInstallerXml.Serialize.ComponentRef
    {
        private ComponentRefFluent _set;
        public ComponentRef()
        {
            _set = new ComponentRefFluent(this);
        }
        public ComponentRefFluent Set
        {
            get { return _set; }
        }
    }
    public class Condition : Microsoft.Tools.WindowsInstallerXml.Serialize.Condition
    {
        private ConditionFluent _set;
        public Condition()
        {
            _set = new ConditionFluent(this);
        }
        public ConditionFluent Set
        {
            get { return _set; }
        }
    }

    public class Configuration : Microsoft.Tools.WindowsInstallerXml.Serialize.Configuration
    {
        private ConfigurationFluent _set;
        public Configuration()
        {
            _set = new ConfigurationFluent(this);
        }
        public ConfigurationFluent Set
        {
            get { return _set; }
        }
    }

    public class Control : Microsoft.Tools.WindowsInstallerXml.Serialize.Control
    {
        private ControlFluent _set;
        public Control()
        {
            _set = new ControlFluent(this);
        }
        public ControlFluent Set
        {
            get { return _set; }
        }
    }

    public class CostFinalize : Microsoft.Tools.WindowsInstallerXml.Serialize.CostFinalize
    {
        private BaseSchemaFluent _set;
        public CostFinalize()
        {
            _set = new BaseSchemaFluent(this);
        }
        public BaseSchemaFluent Set
        {
            get { return _set; }
        }
    }
    public class CostInitialize : Microsoft.Tools.WindowsInstallerXml.Serialize.CostInitialize
    {
        private BaseSchemaFluent _set;
        public CostInitialize()
        {
            _set = new BaseSchemaFluent(this);
        }
        public BaseSchemaFluent Set
        {
            get { return _set; }
        }
    }

    public class CreateFolder : Microsoft.Tools.WindowsInstallerXml.Serialize.CreateFolder
    {
        private CreateFolderFluent _set;
        public CreateFolder()
        {
            _set = new CreateFolderFluent(this);
        }
        public CreateFolderFluent Set
        {
            get { return _set; }
        }
    }

    public class Custom : Microsoft.Tools.WindowsInstallerXml.Serialize.Custom
    {
        private CustomFluent _set;
        public Custom()
        {
            _set = new CustomFluent(this);
        }
        public CustomFluent Set
        {
            get { return _set; }
        }
    }
    public class CustomAction : Microsoft.Tools.WindowsInstallerXml.Serialize.CustomAction
    {
        private CustomActionFluent _set;
        public CustomAction()
        {
            _set = new CustomActionFluent(this);
        }
        public CustomActionFluent Set
        {
            get { return _set; }
        }
    }
    public class CustomActionRef : Microsoft.Tools.WindowsInstallerXml.Serialize.CustomActionRef
    {
        private CustomActionRefFluent _set;
        public CustomActionRef()
        {
            _set = new CustomActionRefFluent(this);
        }
        public CustomActionRefFluent Set
        {
            get { return _set; }
        }
    }

    public class Dialog : Microsoft.Tools.WindowsInstallerXml.Serialize.Dialog
    {
        private DialogFluent _set;
        public Dialog()
        {
            _set = new DialogFluent(this);
        }
        public DialogFluent Set
        {
            get { return _set; }
        }
    }

    public class DialogRef : Microsoft.Tools.WindowsInstallerXml.Serialize.DialogRef
    {
        private DialogRefFluent _set;
        public DialogRef()
        {
            _set = new DialogRefFluent(this);
        }
        public DialogRefFluent Set
        {
            get { return _set; }
        }
    }

    public class Directory : Microsoft.Tools.WindowsInstallerXml.Serialize.Directory
    {
        private DirectoryFluent _set;
        public Directory()
        {
            _set = new DirectoryFluent(this);
        }
        public DirectoryFluent Set
        {
            get { return _set; }
        }
    }

    public class DirectoryRef : Microsoft.Tools.WindowsInstallerXml.Serialize.DirectoryRef
    {
        private DirectoryRefFluent _set;
        public DirectoryRef()
        {
            _set = new DirectoryRefFluent(this);
        }
        public DirectoryRefFluent Set
        {
            get { return _set; }
        }
    }
    public class DisableRollback : Microsoft.Tools.WindowsInstallerXml.Serialize.DisableRollback
    {
        private BaseSchemaFluent _set;
        public DisableRollback()
        {
            _set = new BaseSchemaFluent(this);
        }
        public BaseSchemaFluent Set
        {
            get { return _set; }
        }
    }

    public class ExePackage : Microsoft.Tools.WindowsInstallerXml.Serialize.ExePackage
    {
        private ExePackageFluent _set;
        public ExePackage()
        {
            _set = new ExePackageFluent(this);
        }
        public ExePackageFluent Set
        {
            get { return _set; }
        }
    }
    public class Feature : Microsoft.Tools.WindowsInstallerXml.Serialize.Feature
    {
        private FeatureFluent _set;
        public Feature()
        {
            _set = new FeatureFluent(this);
        }
        public FeatureFluent Set
        {
            get { return _set; }
        }
    }
    public class File : Microsoft.Tools.WindowsInstallerXml.Serialize.File
    {
        private FileFluent _set;
        public File()
        {
            _set = new FileFluent(this);
        }
        public FileFluent Set
        {
            get { return _set; }
        }
    }
    public class Fragment : Microsoft.Tools.WindowsInstallerXml.Serialize.Fragment
    {
        private FragmentFluent _set;
        public Fragment()
        {
            _set = new FragmentFluent(this);
        }
        public FragmentFluent Set
        {
            get { return _set; }
        }
    }

    public class Icon : Microsoft.Tools.WindowsInstallerXml.Serialize.Icon
    {
        private IconFluent _set;
        public Icon()
        {
            _set = new IconFluent(this);
        }
        public IconFluent Set
        {
            get { return _set; }
        }
    }
    public class Include : Microsoft.Tools.WindowsInstallerXml.Serialize.Include
    {
        private BaseSchemaFluent _set;
        public Include()
        {
            _set = new BaseSchemaFluent(this);
        }
        public BaseSchemaFluent Set
        {
            get { return _set; }
        }
    }

    public class InstallUISequence : Microsoft.Tools.WindowsInstallerXml.Serialize.InstallUISequence
    {
        private BaseSchemaFluent _set;
        public InstallUISequence()
        {
            _set = new BaseSchemaFluent(this);
        }
        public BaseSchemaFluent Set
        {
            get { return _set; }
        }
    }

    public class InstallExecuteSequence : Microsoft.Tools.WindowsInstallerXml.Serialize.InstallExecuteSequence
    {
        private BaseSchemaFluent _set;
        public InstallExecuteSequence()
        {
            _set = new BaseSchemaFluent(this);
        }
        public BaseSchemaFluent Set
        {
            get { return _set; }
        }
    }
    public class MajorUpgrade : Microsoft.Tools.WindowsInstallerXml.Serialize.MajorUpgrade
    {
        private MajorUpgradeFluent _set;
        public MajorUpgrade()
        {
            _set = new MajorUpgradeFluent(this);
        }
        public MajorUpgradeFluent Set
        {
            get { return _set; }
        }
    }
    public class MediaTemplate : Microsoft.Tools.WindowsInstallerXml.Serialize.MediaTemplate
    {
        private MediaTemplateFluent _set;
        public MediaTemplate()
        {
            _set = new MediaTemplateFluent(this);
        }
        public MediaTemplateFluent Set
        {
            get { return _set; }
        }
    }
    public class MsiPackage : Microsoft.Tools.WindowsInstallerXml.Serialize.MsiPackage
    {
        private MsiPackageFluent _set;
        public MsiPackage()
        {
            _set = new MsiPackageFluent(this);
        }
        public MsiPackageFluent Set
        {
            get { return _set; }
        }
    }
    public class MsiProperty: Microsoft.Tools.WindowsInstallerXml.Serialize.MsiProperty
    {
        private MsiPropertyFluent _set;
        public MsiProperty()
        {
            _set = new MsiPropertyFluent(this);
        }
        public MsiPropertyFluent Set
        {
            get { return _set; }
        }
    }
    public class Package : Microsoft.Tools.WindowsInstallerXml.Serialize.Package
    {
        private PackageFluent _set;
        public Package()
        {
            _set = new PackageFluent(this);
        }
        public PackageFluent Set
        {
            get { return _set; }
        }
    }
    public class PackageGroup : Microsoft.Tools.WindowsInstallerXml.Serialize.PackageGroup
    {
        private PackageGroupFluent _set;
        public PackageGroup()
        {
            _set = new PackageGroupFluent(this);
        }
        public PackageGroupFluent Set
        {
            get { return _set; }
        }
    }
    public class PackageGroupRef : Microsoft.Tools.WindowsInstallerXml.Serialize.PackageGroupRef
    {
        private PackageGroupRefFluent _set;
        public PackageGroupRef()
        {
            _set = new PackageGroupRefFluent(this);
        }
        public PackageGroupRefFluent Set
        {
            get { return _set; }
        }
    }
    public class Payload : Microsoft.Tools.WindowsInstallerXml.Serialize.Payload
    {
        private PayloadFluent _set;
        public Payload()
        {
            _set = new PayloadFluent(this);
        }
        public PayloadFluent Set
        {
            get { return _set; }
        }
    }

    public class Product : Microsoft.Tools.WindowsInstallerXml.Serialize.Product
    {
        private ProductFluent _set;
        public Product()
        {
            _set = new ProductFluent(this);
        }
        public ProductFluent Set
        {
            get { return _set; }
        }
    }
    public class Property : Microsoft.Tools.WindowsInstallerXml.Serialize.Property
    {
        private PropertyFluent _set;
        public Property()
        {
            _set = new PropertyFluent(this);
        }
        public PropertyFluent Set
        {
            get { return _set; }
        }
    }
    public class PropertyRef : Microsoft.Tools.WindowsInstallerXml.Serialize.PropertyRef
    {
        private PropertyRefFluent _set;
        public PropertyRef()
        {
            _set = new PropertyRefFluent(this);
        }
        public PropertyRefFluent Set
        {
            get { return _set; }
        }
    }

    public class Publish : Microsoft.Tools.WindowsInstallerXml.Serialize.Publish
    {
        private PublishFluent _set;
        public Publish()
        {
            _set = new PublishFluent(this);
        }
        public PublishFluent Set
        {
            get { return _set; }
        }
    }

    public class RegistrySearch : Microsoft.Tools.WindowsInstallerXml.Serialize.RegistrySearch
    {
        private RegistrySearchFluent _set;
        public RegistrySearch()
        {
            _set = new RegistrySearchFluent(this);
        }
        public RegistrySearchFluent Set
        {
            get { return _set; }
        }
    }
    public class RegistryValue : Microsoft.Tools.WindowsInstallerXml.Serialize.RegistryValue
    {
        private RegistryValueFluent _set;
        public RegistryValue()
        {
            _set = new RegistryValueFluent(this);
        }
        public RegistryValueFluent Set
        {
            get { return _set; }
        }
    }

    public class RollbackBoundary : Microsoft.Tools.WindowsInstallerXml.Serialize.RollbackBoundary
    {
        private RollbackBoundaryFluent _set;
        public RollbackBoundary()
        {
            _set = new RollbackBoundaryFluent(this);
        }
        public RollbackBoundaryFluent Set
        {
            get { return _set; }
        }
    }
    public class Shortcut : Microsoft.Tools.WindowsInstallerXml.Serialize.Shortcut
    {
        private ShortcutFluent _set;
        public Shortcut()
        {
            _set = new ShortcutFluent(this);
        }
        public ShortcutFluent Set
        {
            get { return _set; }
        }
    }
    public class UI : Microsoft.Tools.WindowsInstallerXml.Serialize.UI
    {
        private UIFluent _set;
        public UI()
        {
            _set = new UIFluent(this);
        }
        public UIFluent Set
        {
            get { return _set; }
        }
    }
    public class UIRef : Microsoft.Tools.WindowsInstallerXml.Serialize.UIRef
    {
        private UIRefFluent _set;
        public UIRef()
        {
            _set = new UIRefFluent(this);
        }
        public UIRefFluent Set
        {
            get { return _set; }
        }
    }
    public class WixVariable : Microsoft.Tools.WindowsInstallerXml.Serialize.WixVariable
    {
        private WixVariableFluent _set;
        public WixVariable()
        {
            _set = new WixVariableFluent(this);
        }
        public WixVariableFluent Set
        {
            get { return _set; }
        }
    }
}


