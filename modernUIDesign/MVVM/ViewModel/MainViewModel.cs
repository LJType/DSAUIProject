using modernUIDesign.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace modernUIDesign.MVVM.ViewModel
{
    internal class MainViewModel: ObservableOjects
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand JobPostingCommand { get; set; }
        public RelayCommand NotifCommand { get; set; }
        public RelayCommand ApplicationsCommand { get; set; }
        public RelayCommand MessagesCommand { get; set; }
        public RelayCommand WorkspaceCommand { get; set; }


        public HomeViewModel HomeVM { get; set; }
        public JobPostingViewModel JobPostingVM { get; set; }
        public NotifViewModel NotifVM { get; set; }
        public ApplicationsViewModel ApplicationsVM { get; set; }
        public MessagesViewModel MessagesVM { get; set; }

        public WorkspaceViewModel WorkspaceVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { 
                _currentView = value;
                OnPropertyChanged();
            }

        }

        public MainViewModel()
        {
            HomeVM= new HomeViewModel();
            JobPostingVM = new JobPostingViewModel();
            NotifVM = new NotifViewModel();
            ApplicationsVM = new ApplicationsViewModel();
            MessagesVM = new MessagesViewModel();
            WorkspaceVM = new WorkspaceViewModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            JobPostingCommand= new RelayCommand(o =>
            {
                CurrentView = JobPostingVM;
            });

            NotifCommand = new RelayCommand(o =>
            {
                CurrentView = NotifVM;
            });

            ApplicationsCommand = new RelayCommand(o =>
            {
                CurrentView = ApplicationsVM;
            });

            MessagesCommand = new RelayCommand(o =>
            {
                CurrentView = MessagesVM;
            });

            WorkspaceCommand = new RelayCommand(o =>
            {
                CurrentView = WorkspaceVM;
            });
        }
    }
}
