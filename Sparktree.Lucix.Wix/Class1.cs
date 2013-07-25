using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Sparktree.Lucid.Wix.Extensions.Bal.MappingModel;
using Sparktree.Lucid.Wix.MappingModel;


namespace Sparktree.Lucid.Wix
{
    public class Class1
    {
        public static void test()
        {


            //using (XmlWriter xmlWriter = XmlWriter.Create("testingoutput.xml"))
            //{
            //    XDocument xDoc = new XDocument(new XElement("BookmarkCollection"
            //                ));

            //    xDoc.Save(xmlWriter);
            //}
            MappingModel.Wix test = new MappingModel.Wix();
            test.Set.SetAttribute("ui", "http://schemas.microsoft.com/wix/UIExtension");
            test.Set
                .AddChild(
                (new Bundle()).Set.AboutUrl("testing").Copyright("test").AddChild(
                (new BootstrapperApplicationRef()).Set.Id("WixStandardBootstrapperApplciation.RtfLicense").AddChild((new WixStandardBootstrapperApplication()).Set.LicenseUrl("http://www.google.ca"))
                ).AddChild(
                (new Include())
                )

            );
            //MappingModel.Concrete.Bundle bin = new Bundle();
            //bin.Set.AboutUrl("test.com").Condition("true");



            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";
            settings.NewLineOnAttributes = true;
            XmlWriter writer = XmlWriter.Create("books.xml", settings);

            writer.WriteStartDocument();
            writer.WriteComment("testign");

            test.OutputXml(writer);
            writer.Close();

        }


    }
}
