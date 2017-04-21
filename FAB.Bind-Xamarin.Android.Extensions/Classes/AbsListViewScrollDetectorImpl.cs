using Clans.Fab;

namespace FloatingActionButtonXamarin
{
    internal class AbsListViewScrollDetectorImpl : AbsListViewScrollDetector
    {
        public IScrollDirectorListener ScrollDirectionListener { get; set; }


        FloatingActionButton fab;

        public AbsListViewScrollDetectorImpl(FloatingActionButton fab)
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
