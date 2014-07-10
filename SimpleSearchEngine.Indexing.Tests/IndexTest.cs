using System;
using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace SimpleSearchEngine.Indexing.Tests
{
    // ReSharper disable InconsistentNaming
    // ReSharper disable UnusedMember.Local
    [Subject("IIndex")]
    class when_getting_a_word_that_is_in_the_index
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

    [Subject("IIndex")]
    class when_getting_a_word_that_is_not_in_the_index
    {
        static IIndex index;
        static ISet<Guid> actualOccurrences; 

        Establish context = () => index = new Index();

        Because of = () => actualOccurrences = index.Get("word");

        It should_get_an_empty_set = () => actualOccurrences.Any().ShouldBeFalse();
    }
    // ReSharper restore UnusedMember.Local
    // ReSharper restore InconsistentNaming
}