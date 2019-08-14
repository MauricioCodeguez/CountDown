using System;
using System.Threading;
using System.Windows.Input;
using Xamarin.Forms;

namespace CountDown.ViewsModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private static CancellationTokenSource _cancellationTokenSource;
        //private CountDown.Classes.Timer _timer;

        private TimeSpan _totalSeconds;
        public TimeSpan TotalSeconds
        {
            get { return _totalSeconds; }
            set { SetProperty(ref _totalSeconds, value); }
        }

        public ICommand StartCommand { get; set; }
        public ICommand PauseCommand { get; set; }
        public ICommand StopCommand { get; set; }

        public MainPageViewModel()
        {
            StartCommand = new Command(Start);
            PauseCommand = new Command(Pause);
            StopCommand = new Command(Stop);

            _cancellationTokenSource = new CancellationTokenSource();
            //_timer = new Timer(TimeSpan.FromSeconds(1), CountDown);
            _totalSeconds = new TimeSpan(0, 5, 0);
        }

        private void CountDown()
        {
            CancellationTokenSource cts = _cancellationTokenSource;

            Device.StartTimer(new TimeSpan(0, 0, 1), () =>
              {
                  if (cts.IsCancellationRequested)
                      return false;

                  if (_totalSeconds.TotalSeconds == 0)
                      Stop();
                  else
                      TotalSeconds = _totalSeconds.Subtract(new TimeSpan(0, 0, 1));

                  return true;
              });

            //if (_totalSeconds.TotalSeconds == 0)
            //    Stop();
            //else
            //    TotalSeconds = _totalSeconds.Subtract(new TimeSpan(0, 0, 1));
        }

        //private void Start() => _timer.Start();

        private void Start() => CountDown();

        //private void Pause() => _timer.Stop();

        private void Pause() => Interlocked.Exchange(ref _cancellationTokenSource, new CancellationTokenSource()).Cancel();

        private void Stop()
        {
            TotalSeconds = new TimeSpan(0, 5, 0);

            Interlocked.Exchange(ref _cancellationTokenSource, new CancellationTokenSource()).Cancel();
            //_timer.Stop();
        }
    }
}
