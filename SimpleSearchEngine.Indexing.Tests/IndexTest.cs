using System;
using System.Collections.Generic;
using Machine.Specifications;

namespace SimpleSearchEngine.Indexing.Tests
{
    // ReSharper disable InconsistentNaming
    // ReSharper disable UnusedMember.Local
    public class when_getting_a_word_that_is_in_the_index
    {
        static IIndex index;
        static readonly ISet<Guid> expectedOccurrences = new HashSet<Guid>
        {
            new Guid("b63241ca-97c8-4a61-a967-a4fcdb577657")
        };
        static ISet<Guid> actualOccurrences;

        Establish context = () =>
        {
            index = new Index();
            index.Add("word", new Guid("b63241ca-97c8-4a61-a967-a4fcdb577657"));
        };

        Because of = () => actualOccurrences = index.Get("word");

        It should_get_the_occurrences_of_that_word = () => actualOccurrences.SetEquals(expectedOccurrences);
    }
    // ReSharper restore UnusedMember.Local
    // ReSharper restore InconsistentNaming
}