﻿using ReactiveUI;
using ReactiveUI.Routing;

namespace Shimmer.DesktopDemo.ViewModels
{
    public class ForegroundUpdaterViewModel : ReactiveObject, IRoutableViewModel
    {
        public ForegroundUpdaterViewModel(IScreen screen)
        {
            HostScreen = screen;
        }

        public string UrlPathSegment { get { return "foreground"; }}
        public IScreen HostScreen { get; private set; }
    }
}