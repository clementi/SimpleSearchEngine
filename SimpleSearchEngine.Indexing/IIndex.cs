using System;
using System.Collections.Generic;

namespace SimpleSearchEngine.Indexing
{
    public interface IIndex
    {
        void Add(string word, Guid documentId);

        ISet<Guid> Get(string word);
    }
}