﻿using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;
using Wox.Infrastructure.Storage;

namespace Wox.Plugin.FileSearch
{
    public class Settings
    {
        public List<ContextMenu> ContextMenus = new List<ContextMenu>();

        public int MaxSearchCount { get; set; } = 100;

        public bool UseLocationAsWorkingDir { get; set; } = false;
    }

    public class ContextMenu
    {
        public string Name { get; set; }
        public string Command { get; set; }
        public string Argument { get; set; }
        public string ImagePath { get; set; }
    }
}