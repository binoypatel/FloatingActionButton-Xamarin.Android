using System;
using Clans.Fab;

namespace FloatingActionButtonXamarin
{
    internal class ScrollViewScrollDetectorImpl : ScrollViewScrollDetector
    {
        public IScrollDirectorListener ScrollDirectionListener { get; set; }

        FloatingActionButton fab;

        public ScrollViewScrollDetectorImpl(FloatingActionButton fab)
        {
            this.fab = fab;
        }

        public override void OnScrollDown()
        {
            fab.Show(true);
            if (ScrollDirectionListener != null)
                ScrollDirectionListener.OnScrollDown();
        }


        public override void OnScrollUp()
        {
            fab.Hide(true);
            if (ScrollDirectionListener != null)
                ScrollDirectionListener.OnScrollUp();

        }

    }
}
