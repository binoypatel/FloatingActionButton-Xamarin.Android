using System;
using Android.Content.Res;
using Android.Support.V7.Widget;
using Android.Widget;
using Clans.Fab;

namespace FloatingActionButtonXamarin
{
    public static class ListExtensions
    {
        private static int scrollThreshold = 4;

        public static void AttachToListView(this FloatingActionButton fab, 
                                            AbsListView listView, 
                                            IScrollDirectorListener scrollDirectionListener = null, 
                                            AbsListView.IOnScrollListener onScrollListener = null)
        {
            var scrollDetector = new AbsListViewScrollDetectorImpl(fab);
            scrollDetector.ScrollDirectionListener = scrollDirectionListener;
            scrollDetector.OnScrollListener = onScrollListener;
            scrollDetector.ListView = listView;
            scrollDetector.ScrollThreshold = scrollThreshold;
            listView.SetOnScrollListener(scrollDetector);
        }

        public static void AttachToRecyclerView(this FloatingActionButton fab,
                                            RecyclerView recyclerView,
                                            IScrollDirectorListener scrollDirectionListener = null,
                                            RecyclerView.OnScrollListener onScrollListener = null)
        {
            var scrollDetector = new RecyclerViewScrollDetectorImpl(fab);
            scrollDetector.ScrollDirectionListener = scrollDirectionListener;
            scrollDetector.OnScrollListener = onScrollListener;
            scrollDetector.ScrollThreshold = scrollThreshold;
            recyclerView.AddOnScrollListener(scrollDetector);
        }

        public static void AttachToScrollView(this FloatingActionButton fab,
                                       ObservableScrollView scrollView, 
                                       IScrollDirectorListener scrollDirectionListener = null, 
                                       IOnScrollChangedListener onScrollChangedListener = null)
        {
            var scrollDetector = new ScrollViewScrollDetectorImpl(fab);
            scrollDetector.ScrollDirectionListener = scrollDirectionListener;
            scrollDetector.OnScrollChangedListener = onScrollChangedListener;
            scrollDetector.ScrollThreshold = scrollThreshold;
            scrollView.OnScrollChangedListener = scrollDetector;
        }

    }


}
