﻿using System;
using Newtonsoft.Json;
using OmniSharp.Extensions.LanguageServer.Protocol.Serialization;
using OmniSharp.Extensions.LanguageServer.Protocol.Serialization.Converters;

namespace OmniSharp.Extensions.LanguageServer.Protocol.Models
{
    public class LocationLink
    {
        /// <summary>
        /// Span of the origin of this link.
        ///
        /// Used as the underlined span for mouse interaction. Defaults to the word range at
        /// the mouse position.
        /// </summary>
        [Optional]
        public Range OriginSelectionRange { get; set; }

        /// <summary>
        /// The target resource identifier of this link.
        /// </summary>
        [JsonConverter(typeof(AbsoluteUriConverter))]
        public Uri TargetUri { get; set; }

        /// <summary>
        /// The full target range of this link. If the target for example is a symbol then target range is the
        /// range enclosing this symbol not including leading/trailing whitespace but everything else
        /// like comments. This information is typically used to highlight the range in the editor.
        /// </summary>
        public Range TargetRange { get; set; }

        /// <summary>
        /// The range that should be selected and revealed when this link is being followed, e.g the name of a function.
        /// Must be contained by the the `targetRange`. See also `DocumentSymbol#range`
        /// </summary>
        public Range TargetSelectionRange { get; set; }
    }
}
