﻿using System.IO;

namespace Discord.API
{
    public struct Image
    {
        public Stream Stream { get; }
        public string Hash { get; }

        public Image(Stream stream)
        {
            Stream = stream;
            Hash = null;
        }
        public Image(string hash)
        {
            Stream = null;
            Hash = hash;
        }

        public static Image Create(Discord.Image image)
        {
            return new Image(image.Stream);
        }
    }
}
