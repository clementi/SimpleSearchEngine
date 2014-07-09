using System;
using System.Collections.Generic;

namespace SimpleSearchEngine.Indexing
{
    public class Index : IIndex
    {
        private readonly IDictionary<string, ISet<Guid>> index;

        public Index()
        {
            this.index = new Dictionary<string, ISet<Guid>>();
        }

        public void Add(string word, Guid documentId)
        {
            if (this.index.ContainsKey(word))
                this.index[word].Add(documentId);
            else
                this.index.Add(word, new HashSet<Guid> { documentId });
        }

        public ISet<Guid> Get(string word)
        {
            return this.index[word];
        }
    }
}