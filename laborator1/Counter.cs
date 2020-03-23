using System;

namespace dotNet
{
    class Counter
    {

        private int thres;
        private int totalthr;
        public event EventHandler ThresholdReached;

        public Counter(int passedThreshold)
        {
            this.thres = passedThreshold;
        }

        public void Add(int x)
        {
            totalthr += x;
        }

        protected virtual void OnThresholdReached(EventArgs e)
        {
            EventHandler eventh = ThresholdReached;
            if (eventh != null)
            {
                eventh(this, e);
            }
        }

        
    }
}
