﻿using DADOMI.View.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DADOMI.ViewModel.Command
{
    public class HelpButtonCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            HelpWindow Win = new HelpWindow();
            Win.ShowDialog();
        }
    }
}