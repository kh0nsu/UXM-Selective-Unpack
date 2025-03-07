﻿using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace UXM
{
    class ArchiveDictionary
    {
        private const uint PRIME = 37;
        private const ulong PRIME64 = 0x85ul;

        private Dictionary<ulong, string> hashes;

        public ArchiveDictionary(string dictionary, Util.Game game)
        {
            hashes = new Dictionary<ulong, string>();
            foreach (string line in Regex.Split(dictionary, "[\r\n]+"))
            {
                if (line.StartsWith("#"))
                    continue;

                string trimmed = line.Trim();
                if (trimmed.Length > 0)
                {
                    ulong hash = ComputeHash(trimmed, game);
                    hashes[hash] = trimmed;
                }
            }
        }

        private static ulong ComputeHash(string path, Util.Game game)
        {
            string hashable = path.Trim().Replace('\\', '/').ToLowerInvariant();
            if (!hashable.StartsWith("/"))
                hashable = '/' + hashable;

            return game == Util.Game.EldenRing ? hashable.Aggregate(0ul, (i,c) => i * PRIME64 + c) : hashable.Aggregate(0u, (i,c) => i * PRIME + c);
        }

        public bool GetPath(ulong hash, out string path)
        {
            return hashes.TryGetValue(hash, out path);
        }
    }
}
