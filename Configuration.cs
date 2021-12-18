﻿using System.Collections.Generic;
using Dalamud.Configuration;

namespace ReAction
{
    public class Configuration : IPluginConfiguration
    {
        public class Action
        {
            public uint ID = 0;
            public bool UseAdjustedID = false;
        }

        public class ActionStackItem
        {
            public uint ID = 0;
            public ActionStackManager.TargetType Target = ActionStackManager.TargetType.Target;
        }

        public class ActionStack
        {
            public string Name = string.Empty;
            public List<Action> Actions = new();
            public List<ActionStackItem> Items = new();
            public bool BlockOriginal = false;
        }

        public int Version { get; set; }

        public List<ActionStack> ActionStacks = new();
        public bool EnhancedAutoFaceTarget = false;
        public bool EnableGroundTargetQueuing = false;
        public bool EnableInstantGroundTarget = false;

        public void Initialize() { }

        public void Save() => DalamudApi.PluginInterface.SavePluginConfig(this);
    }
}