﻿using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoPythonNetEditor.ViewModel.Messages
{
    public class PipMessage : RequestMessage<object>
    {
        public MenuBarViewModel DataContext { get; set; }
    }
}
