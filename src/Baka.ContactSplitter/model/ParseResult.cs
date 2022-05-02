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
        public TM Model { get; set; }

        /// <summary>
        /// True, iff no error message is present.
        /// </summary>
        public bool Successful => ErrorMessages.Count == 0;

        private IList<string> _ErrorMessages;
        public IList<string> ErrorMessages => _ErrorMessages ??= new List<string>();
    }
}