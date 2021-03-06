﻿using System.Diagnostics;
using Cake.Core.IO;

namespace Cake.Web.Core.Content.Documentation
{
    [DebuggerDisplay("{DebuggerDisplay(),nq}")]
    public sealed class Topic
    {
        public string Id { get; }
        public string Name { get; }
        public string Body { get; }
        public FilePath Path { get; }
        public bool Hidden { get; }

        public Topic Previous { get; set; }
        public Topic Next { get; set; }
        public TopicSection Section { get; internal set; }

        public bool HasPrevious => Previous != null && Previous.HasContent;
        public bool HasNext => Next != null && Next.HasContent;
        public bool HasContent => !string.IsNullOrWhiteSpace(Body);

        public Topic(string id, string name, string body, bool hidden, FilePath path)
        {
            Id = id;
            Name = name;
            Body = body;
            Hidden = hidden;
            Path = path;
        }

        // ReSharper disable once UnusedMethodReturnValue.Local
        private string DebuggerDisplay()
        {
            return $"Topic: {Name}";
        }
    }
}
