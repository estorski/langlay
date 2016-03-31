﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Product
{
    public class TrayService
    {
        private IConfigService ConfigService { get; set; }
        private ContextMenu ContextMenu { get; set; }
        private NotifyIcon Icon { get; set; }
        private bool IsStarted { get; set; }

        public Action OnExit { get; set; }

        public TrayService(IConfigService configService)
        {
            ConfigService = configService;
        }

        public void Start()
        {
            if (!IsStarted)
            {
                IsStarted = true;
                ContextMenu = new ContextMenu(new[]
                {
                    new MenuItem("Quit", delegate { if (OnExit != null) OnExit(); })
                });
                Icon = new NotifyIcon()
                {
                    Text = Application.ProductName,
                    Icon = new Icon(typeof(Program), "Keyboard Filled-16.ico"),
                    Visible = true,
                    ContextMenu = ContextMenu
                };
            }
        }

        public void Stop()
        {
            if (IsStarted)
            {
                IsStarted = false;
                if (ContextMenu != null)
                    ContextMenu.Dispose();
                if (Icon != null)
                    Icon.Dispose();
            }
        }
    }
}
