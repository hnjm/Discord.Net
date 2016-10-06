﻿using Discord.API;

namespace Discord
{
    public struct Emoji
    {
        public ulong Id { get; }
        public string Name { get; }
        public int Index { get; }

        public string Url => CDN.GetEmojiUrl(Id);

        internal Emoji(ulong id, string name, int index)
        {
            Id = id;
            Name = name;
            Index = index;
        }
    }
}
