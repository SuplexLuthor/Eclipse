﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eclipse.Models
{
    public enum TitleMatchType
    {
        FullTitleMatch = 100,
        MainTitleMatch = 95,
        SubtitleMatch = 90,
        FullTitleContains = 60,
        None = 0
    }

    public enum BezelType
    {
        Game,
        PlatformDefault,
        Default
    }

    public enum BezelOrientation
    {
        Horizontal,
        Vertical
    }

    public enum FeatureGameOption
    {
        PlayGame,
        MoreInfo
    }
}
