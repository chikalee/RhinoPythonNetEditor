﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using RhinoPythonNetEditor.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using RhinoPythonNetEditor.ViewModel.Messages;
using System.Diagnostics;
using System.Windows.Documents;
using System.IO;

namespace RhinoPythonNetEditor.ViewModel
{

    public class MenuBarViewModel : ObservableRecipient
    {
        public MenuBarViewModel(ViewModelLocator locator)
        {
            IsActive = true;
            Locator = locator;
        }

        private WeakReferenceMessenger Messenger => Locator?.Messenger;

        private ViewModelLocator Locator { get; set; }

    }
}
