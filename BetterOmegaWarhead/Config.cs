﻿namespace BetterOmegaWarhead
{
    using System.ComponentModel;
    using Exiled.API.Interfaces;

    public sealed class Config : IConfig
    {
        [Description("Plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Chance that the Alpha Warhead will be replaced with Omega Warhead")]
        public int ReplaceAlphaChance { get; private set; } = 15;

        [Description("Time to the Omega Warhead detonation in seconds.")]
        public float TimeToDetonation { get; private set; } = 300f;

        [Description("Time to the open and lock checkpoint doors after Omega activation.")]
        public float OpenAndLockCheckpointDoorsDelay { get; private set; } = 235f;

        [Description("Time to the helicopter after Omega activation.")]
        public float HelicopterBroadcastDelay { get; private set; } = 255f;

        [Description("Indicates that the player can stop OmegaWarhead after activation.")]
        public bool isStopAllowed { get; private set; } = false;

        [Description("Red channel of the lights color in the rooms during OmegaWarhead event")]
        public float LightsColorR { get; private set; } = 0.05f;

        [Description("Green channel of the lights color in the rooms during OmegaWarhead event")]
        public float LightsColorG { get; private set; } = 0.85f;

        [Description("Blue channel of the lights color in the rooms during OmegaWarhead event")]
        public float LightsColorB { get; private set; } = 0.35f;

        [Description("Broadcast that will appear when the player escapes in the helicopter.")]
        public string HelicopterEscape { get; set; } = "You escaped in the helicopter.";

        [Description("Broadcast that will appear when the Omega Warhead is activated.")]
        public string ActivatedMessage { get; set; } = "<b><color=red>OMEGA WARHEAD ACTIVATED.</color></b>\nPLEASE EVACUATE IN BREACH SHELTER.";

        [Description("Cassie message when Omega Warhead is stopped")]
        public string StoppingOmegaCassie { get; set; } = "pitch_0.9 Omega Warhead detonation has been stopped";

        [Description("Cassie message of Omega Warhead activation")]
        public string StartingOmegaCassie { get; set; } = "pitch_0.2 .g3 .g3 .g3 pitch_0.9 attention . attention . activating omega warhead . Please evacuate in the . breach shelter or in the helicopter . please evacuate immediately .";

        [Description("Cassie message of Omega Warhead detonation")]
        public string DetonatingOmegaCassie { get; set; } = "pitch_0.65 Detonating pitch_0.5 Warhead";

        [Description("Cassie message regarding the incoming Helicopter")]
        public string HeliIncomingCassie { get; set; } = "pitch_0.25 .g3 .g3 .g3 pitch_0.9 attention . attention . the helicopter is in comeing . Please evacuate . Attention . the helicopter is in comeing . Please evacuate immediately";
        [Description("Cassie message regarding the checkpoints unlock")]
        public string CheckpointUnlockCassie { get; set; } = "pitch_0.25 .g3 .g3 .g3 pitch_0.9 attention . attention . the checkpoint doors are open . Attention . the checkpoint doors are open . Please evacuate immediately";
        [Description("Permissions of the plugin.")]
        public string Permissions { get; set; } = "omegawarhead";


        [Description("Debug enabled?")]
        public bool Debug { get; set; } = false;
    }
}