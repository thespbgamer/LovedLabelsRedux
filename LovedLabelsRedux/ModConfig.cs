using StardewModdingAPI;
using StardewModdingAPI.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovedLabelsRedux
{
    internal class ModConfig
    {
        public KeybindList ToggleUIKey { get; set; } = KeybindList.Parse("LeftShift + OemPipe");

        public String AlreadyPettedMessage { get; set; } = "Already Petted";
        public String NeedsPettingMessage { get; set; } = "Needs Petting";

        public bool IsUIEnabled { get; set; } = true;
    }
}