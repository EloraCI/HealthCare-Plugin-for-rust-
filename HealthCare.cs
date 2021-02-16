using UnityEngine;
using Rust;
using Oxide.Core.Plugins;
using System.Collections.Generic;
using System;
using System.Reflection;
using Oxide.Core;
using System.Linq;
using Oxide.Game.Rust.Cui;
using System.Media;

namespace Oxide.Plugins
{
    [Info("HealthCare", "NEKO_CATG", "0.0.1")]
    [Description("Our tested Plugin")]
    public class HealthCare : RustPlugin
    {

        void Loaded()
        {
            permission.RegisterPermission("HealthCare.Use", this);
        }


        [ChatCommand("care")]
        void TextToScreen(BasePlayer player, string cmd, string[] args)
        {
            if (!permission.UserHasPermission(player.userID.ToString(), "HealthCare.Use"))
            {
                SendReply(player, "You do not have permission to use this command!");
                return;
            }
            player.health = player._maxHealth;
            SendReply(player, "Your Health has been restored");

        }
    }
}