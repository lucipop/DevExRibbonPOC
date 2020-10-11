using DevExpress.Utils.Design;
using DevExpress.XtraBars.Docking2010.DragEngine;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using DXRibbon.Helpers;

namespace DXRibbon.ModulesBase
{

    public class ModuleInfo
    {
        string name;
        string description;
        string group;
        Type type;
        string imageName;
        bool wasShown;
        //TutorialControlBase module;
        //DemoProducts products = DemoProducts.None;

        public ModuleInfo(string name, Type type, string description, string imageName, string group)
        {
            if (!type.IsSubclassOf(typeof(UserControl)))
                throw new ArgumentException(ConstStrings.Get("SubclassError"));
            this.name = name;
            this.type = type;
            this.imageName = imageName;
            this.description = description;
            this.group = group;
            //this.module = null;
            //this.products = products;
        }
        public string Name { get { return this.name; } }
        //public Image SmallImage { get { return ElementHelper.GetImage(imageName, ImageSize.Small16); } }
        //public Image LargeImage { get { return ElementHelper.GetImage(imageName, ImageSize.Large32); } }
        public string Description { get { return this.description; } }
        public string Group { get { return this.group; } }
        //public bool Created { get { return this.module != null; } }
        public bool WasShown { get { return wasShown; } set { wasShown = value; } }
        //public DemoProducts Products { get { return products; } }
        //public string TypeName
        //{
        //    get
        //    {
        //        if (Created)
        //            return TModule.GetType().Name;
        //        return string.Empty;
        //    }
        //}
        //public void ModuleDispose()
        //{
        //    if (this.module != null && this.module.AllowDispose)
        //    {
        //        this.module.ResetPibbonPage();
        //        this.module.Dispose();
        //        this.module = null;
        //    }
        //}
        //public TutorialControlBase TModule
        //{
        //    get
        //    {
        //        if (this.module == null)
        //        {
        //            ConstructorInfo constructorInfoObj = type.GetConstructor(Type.EmptyTypes);
        //            if (constructorInfoObj == null)
        //                throw new ApplicationException(string.Format(ConstStrings.Get("PublicConstructorError"), type.FullName));
        //            this.module = constructorInfoObj.Invoke(null) as TutorialControlBase;
        //        }
        //        return this.module;
        //    }
        //}
    }

}
