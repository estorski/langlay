﻿using System.Collections.Generic;
using Product.Common;

namespace Product
{
    public interface IConfigService
    {
        IList<KeyCode> LanguageSwitchKeyArray { get; }
        KeyCode LanguageSwitchNonModifiers { get; }
        KeyCode LanguageSwitchModifiers { get; }
        IList<KeyCode> LayoutSwitchKeyArray { get; }
        KeyCode LayoutSwitchNonModifiers { get; }
        KeyCode LayoutSwitchModifiers { get; }

        bool DoShowOverlay { get; }
        bool DoShowOverlayOnMainDisplayOnly { get; }
        bool DoShowOverlayRoundCorners { get; }
        uint OverlayDuration { get; }
        uint OverlayOpacity { get; }
        uint OverlayScale { get; }
        OverlayLocation OverlayLocation { get; }
        bool DoRunAtWindowsStartup { get; }
        bool DoSwitchLanguage { get; }
        bool GetLanguageSwitchConfigured();
        bool DoSwitchLayout { get; }
        bool GetLayoutSwitchConfigured();
        bool DoShowSettingsOnce { get; }
        bool DoShowCursorTooltip { get; }
    }
}
