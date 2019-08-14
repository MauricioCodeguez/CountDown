using System;
using System.Threading;
using Xamarin.Forms;

namespace CountDown.Classes
{
    public class Timer
    {
        private readonly TimeSpan _timeSpan;
        private readonly Action _callBack;

        private static CancellationTokenSource _cancellationTokenSource;

        public Timer(TimeSpan timeSpan, Action callBack)
        {
            _timeSpan = timeSpan;
            _callBack = callBack;
            _cancellationTokenSource = new CancellationTokenSource();
        }

        public void Start()
        {
            CancellationTokenSource cts = _cancellationTokenSource;

            Device.StartTimer(_timeSpan, () =>
            {
                if (cts.IsCancellationRequested)
                    return false;

                _callBack.Invoke();
                return true;
            });
        }

        public void Stop() => Interlocked.Exchange(ref _cancellationTokenSource, new CancellationTokenSource()).Cancel();
    }
}
