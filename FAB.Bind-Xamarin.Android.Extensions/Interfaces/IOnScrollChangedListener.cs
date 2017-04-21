
using Android.Widget;

namespace FloatingActionButtonXamarin
{
    public interface IOnScrollChangedListener
    {
        void OnScrollChanged(ScrollView who, int l, int t, int oldl, int oldt);
    }
}
