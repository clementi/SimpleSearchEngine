using System;
using System.Collections.Generic;

namespace SimpleSearchEngine.Indexing
{
    public interface IIndex
    {
        ISet<Guid> Get(string word);
    }
}