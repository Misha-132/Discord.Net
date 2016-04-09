﻿/*using System;
using Model = Discord.API.MemberVoiceState;

namespace Discord
{
    public class VoiceState
    {
        [Flags]
        private enum VoiceStates : byte
        {
            None = 0x0,
            Muted = 0x01,
            Deafened = 0x02,
            Suppressed = 0x4,
            SelfMuted = 0x10,
            SelfDeafened = 0x20,
        }
        
        private VoiceStates _voiceStates;

        public Guild Guild { get; }
        public ulong UserId { get; }

        /// <summary> Gets this user's current voice channel. </summary>
        public VoiceChannel VoiceChannel { get; internal set; }
        
        /// <summary> Returns true if this user has marked themselves as muted. </summary>
        public bool IsSelfMuted => (_voiceStates & VoiceStates.SelfMuted) != 0;
        /// <summary> Returns true if this user has marked themselves as deafened. </summary>
        public bool IsSelfDeafened => (_voiceStates & VoiceStates.SelfDeafened) != 0;
        /// <summary> Returns true if the guild is blocking audio from this user. </summary>
        public bool IsMuted => (_voiceStates & VoiceStates.Muted) != 0;
        /// <summary> Returns true if the guild is blocking audio to this user. </summary>
        public bool IsDeafened => (_voiceStates & VoiceStates.Deafened) != 0;
        /// <summary> Returns true if the guild is temporarily blocking audio to/from this user. </summary>
        public bool IsSuppressed => (_voiceStates & VoiceStates.Suppressed) != 0;

        internal VoiceState(ulong userId, Guild guild)
        {
            UserId = userId;
            Guild = guild;
        }

        internal void Update(Model model)
        {
            if (model.IsMuted == true)
                _voiceStates |= VoiceStates.Muted;
            else if (model.IsMuted == false)
                _voiceStates &= ~VoiceStates.Muted;

            if (model.IsDeafened == true)
                _voiceStates |= VoiceStates.Deafened;
            else if (model.IsDeafened == false)
                _voiceStates &= ~VoiceStates.Deafened;

            if (model.IsSuppressed == true)
                _voiceStates |= VoiceStates.Suppressed;
            else if (model.IsSuppressed == false)
                _voiceStates &= ~VoiceStates.Suppressed;
        }
    }
}*/