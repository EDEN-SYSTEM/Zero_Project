using Zero_Project.ViewModels.Base;
using System;

namespace Zero_Project.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _title = "Hello, World!";

        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }
    }
}
