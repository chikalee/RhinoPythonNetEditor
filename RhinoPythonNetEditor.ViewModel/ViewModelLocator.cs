﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoPythonNetEditor.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            Services = ConfigureServices();
        }

        public IServiceProvider Services { get; set; }

        public MenuBarViewModel MenuBarViewModel =>Services.GetService<MenuBarViewModel>();

        public IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<MenuBarViewModel>();
            return services.BuildServiceProvider();
        }
    }
}
