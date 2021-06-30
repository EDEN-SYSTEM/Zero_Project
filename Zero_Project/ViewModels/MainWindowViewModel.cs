﻿using Zero_Project.Infrastructure.Commands;
using Zero_Project.ViewModels.Base;
using System;
using System.Windows;
using System.Windows.Input;

namespace Zero_Project.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        public MainWindowViewModel()
        {
            #region Команды - инициализация

            CloseAplicationCommand = new LambdaCommand(OnCloseAplicationCommandExecuted, CanCloseAplicationCommandExecute);

            #endregion
        }

        #region Свойства - описание



        #endregion

        #region Команды - описание

        public ICommand CloseAplicationCommand { get; }

        private bool CanCloseAplicationCommandExecute(object p) => true;

        private void OnCloseAplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        #endregion
    }
}
