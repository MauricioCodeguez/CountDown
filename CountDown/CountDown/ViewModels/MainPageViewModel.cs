using CountDown.Extensions;
using CountDown.Models;
using CountDown.Repositories;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace CountDown.ViewsModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IPalavrasReservadasRepositorio _palavrasReservadasRepositorio;
        private readonly Classes.Timer _timer;

        public ObservableCollection<PalavrasReservadas> Itens { get; set; }

        private TimeSpan _totalSeconds;
        public TimeSpan TotalSeconds
        {
            get { return _totalSeconds; }
            set { SetProperty(ref _totalSeconds, value); }
        }

        private bool _startVisivel;
        public bool StartVisivel
        {
            get { return _startVisivel; }
            set { SetProperty(ref _startVisivel, value); }
        }

        public ICommand StartCommand { get; set; }
        public ICommand PauseCommand { get; set; }
        public ICommand StopCommand { get; set; }

        public MainPageViewModel()
        {
            _palavrasReservadasRepositorio = DependencyService.Get<IPalavrasReservadasRepositorio>();
            Itens = _palavrasReservadasRepositorio.ObterPalavrasReservadas().ToObservableCollection();

            StartCommand = new Command(Start);
            PauseCommand = new Command(Pause);
            StopCommand = new Command(Stop);

            _timer = new Classes.Timer(TimeSpan.FromSeconds(1), CountDown);
            _totalSeconds = new TimeSpan(0, 5, 0);
            _startVisivel = true;
        }

        private void CountDown()
        {
            if (_totalSeconds.TotalSeconds == 0)
                Stop();
            else
                TotalSeconds = _totalSeconds.Subtract(new TimeSpan(0, 0, 1));
        }

        private void Start()
        {
            StartVisivel = false;
            _timer.Start();
        }

        private void Pause()
        {
            StartVisivel = true;
            _timer.Stop();
        }

        private void Stop()
        {
            StartVisivel = true;
            TotalSeconds = new TimeSpan(0, 5, 0);
            _timer.Stop();
        }
    }
}