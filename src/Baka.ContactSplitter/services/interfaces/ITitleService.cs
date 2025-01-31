﻿using System.Collections.Generic;

namespace Baka.ContactSplitter.Services.Interfaces
{
    public interface ITitleService
    {
        /// <summary>
        /// Saves or updates the given title with the given titleSalutation.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="titleSalutation"></param>
        /// <returns>True, iff the title with the titleSalutation could be saved or updated.</returns>
        bool SaveOrUpdateTitle(string title, string titleSalutation);

        /// <param name="title"></param>
        /// <returns>True, iff the title could be removed.</returns>
        bool DeleteTitle(string title);
        
        /// <returns>All titles stored.</returns>
        IEnumerable<string> GetTitles();

        /// <param name="title">The title to get the titleSalutation for.</param>
        /// <returns>The titleSalutation corresponding to the title.</returns>
        string GetTitleSalutation(string title);
    }
}