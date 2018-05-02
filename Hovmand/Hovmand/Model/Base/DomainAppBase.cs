using Data.Transformed.Implementation;

namespace Hovmand.Model.Base
{
    public abstract class DomainAppBase : CopyableWithDefaultValuesBase
    {
        public int Id
        {
            get { return Key; }
            set { Key = value; }
        }
    }
}