﻿using System.Collections.Generic;

namespace Baka.ContactSplitter.model
{
    /// <summary>
    /// Represents a result from IParserService.
    /// </summary>
    public class ParseResult<TM>
    {
        /// <summary>
        /// The model which was generated by the parser.
        /// </summary>
        public TM Model { get; init; }

        /// <summary>
        /// True, iff no error message is present.
        /// </summary>
        public bool Successful => ErrorMessages is null || ErrorMessages.Count == 0;

        public List<string> ErrorMessages { get; init; }
    }
}