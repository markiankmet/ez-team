using FontAwesome.Sharp;
using FullApp.Model;
using FullApp.Repositories;
using FullApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace FullApp.ViewModel
{
    public class StudyingViewModel : ViewModelBase
    {
        private Window _currentChildView;
        private string _caption;
        private IconChar _icon;
        public ICommand ShowLevel_1_ViewCommand { get; }

        public Window CurrentChildView
        {
            get
            {
                return _currentChildView;
            }
            set
            {
                _currentChildView = value;
                OnPropertyChanged(nameof(CurrentChildView));
            }
        }
        public string Caption
        {
            get
            {
                return _caption;
            }
            set
            {
                _caption = value;
                OnPropertyChanged(nameof(Caption));
            }
        }
        public IconChar Icon
        {
            get
            {
                return _icon;
            }
            set
            {
                _icon = value;
                OnPropertyChanged(nameof(Icon));
            }
        }
        public StudyingViewModel()
        {
            ShowLevel_1_ViewCommand = new ViewModelCommand(ExecuteShowLevel_1_ViewCommand);
        }
        private void ExecuteShowLevel_1_ViewCommand(object obj)
        {
            CurrentChildView = new YourWindow();
            Caption = "Level_1";
            Icon = IconChar.ChalkboardTeacher;
            CurrentChildView.Visibility= Visibility.Visible;
        
        }
    }
}
    

