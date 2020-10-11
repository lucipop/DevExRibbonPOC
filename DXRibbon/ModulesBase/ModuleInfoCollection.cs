using System.Collections;

namespace DXRibbon.ModulesBase
{
    public class ModuleInfoCollection : CollectionBase
    {
        public ModuleInfo this[int index]
        {
            get
            {
                if (List.Count > index)
                    return List[index] as ModuleInfo;
                return null;
            }
        }
        public ModuleInfo this[string name]
        {
            get
            {
                foreach (ModuleInfo info in this)
                    if (info.Name.Equals(name))
                        return info;
                return null;
            }
        }
        public void Add(ModuleInfo value)
        {
            if (!List.Contains(value))
                List.Add(value);
        }
        public void Remove(ModuleInfo value)
        {
            if (List.Contains(value))
                List.Remove(value);
        }
    }
}
