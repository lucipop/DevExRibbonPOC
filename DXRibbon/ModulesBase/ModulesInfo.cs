using DevExpress.XtraNavBar;
using DXRibbon.Helpers;
using System;

namespace DXRibbon.ModulesBase
{
    public class ModulesInfo
    {
        public event EventHandler CurrentModuleChanged;
        static ModulesInfo instance;
        ModuleInfoCollection collection;
        ModuleInfo currentModule;

        public ModuleInfoCollection Collection { get { return collection; } }
        public ModuleInfo CurrentModuleBase { get { return currentModule; } set { currentModule = value; } }

        public static void Add(string name, Type type, string description, string imageName, string group)
        {
            Add(name, type, description, imageName, group);
        }
      
        public static int Count { get { return instance.Collection.Count; } }
        public static ModuleInfo GetItem(int index) { return instance.Collection[index]; }
        public static ModuleInfo GetItem(string name) { return instance.Collection[name]; }
        public static void RemoveItem(string name)
        {
            ModuleInfo info = GetItem(name);
            if (info != null)
                instance.Collection.Remove(info);
        }
        public static ModulesInfo Instance { get { return instance; } }
        public static ModuleInfo CurrentModuleInfo { get { return instance.currentModule; } }
        //public static TutorialControlBase CurrentModule
        //{
        //    get
        //    {
        //        if (CurrentModuleInfo != null)
        //            return CurrentModuleInfo.TModule;
        //        return null;
        //    }
        //}
        static ModulesInfo()
        {
            instance = new ModulesInfo();
        }
        public ModulesInfo()
        {
            //this.collection = new ModuleInfoCollection();
            this.currentModule = null;
        }
        protected static void RaiseModuleChanged()
        {
            if (Instance.CurrentModuleChanged != null)
                Instance.CurrentModuleChanged(Instance, EventArgs.Empty);
        }
        public static void FillNavBar(NavBarControl navBar)
        {
            FillNavBar(navBar, NavBarGroupStyle.LargeIconsText, NavBarImage.Small);
        }
        public static void FillNavBar(NavBarControl navBar, NavBarGroupStyle groupStyle, NavBarImage groupCaptionImage)
        {
            if (navBar == null) return;
            navBar.BeginUpdate();
            for (int i = 0; i < Count; i++)
            {
                if (GetItem(i).Group == ConstStrings.Get("AboutGroup")) continue;
                NavBarItem item = new NavBarItem();
                navBar.Items.Add(item);
                item.Caption = GetItem(i).Name;
                item.Tag = GetItem(i);
                GetNavBarGroup(navBar, GetItem(i).Group, groupStyle, groupCaptionImage).ItemLinks.Add(new NavBarItemLink(item));
            }
            navBar.EndUpdate();
        }
        static NavBarGroup GetNavBarGroup(NavBarControl navBar, string groupName, NavBarGroupStyle groupStyle, NavBarImage groupCaptionImage)
        {
            foreach (NavBarGroup group in navBar.Groups)
                if (group.Caption == groupName) return group;
            NavBarGroup newGroup = navBar.Groups.Add();
            newGroup.Caption = groupName;
            newGroup.Name = groupName;
            newGroup.GroupStyle = groupStyle;
            newGroup.GroupCaptionUseImage = groupCaptionImage;
            return newGroup;
        }
    }
}
