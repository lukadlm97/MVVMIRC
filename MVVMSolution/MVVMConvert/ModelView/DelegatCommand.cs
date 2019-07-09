﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMMinimal.ModelView
{
    class DelegatCommand : ICommand
    {
        private readonly Action _action;

        public DelegatCommand(Action action)
        {
            _action = action;
        }


        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action();
        }
    }
}
