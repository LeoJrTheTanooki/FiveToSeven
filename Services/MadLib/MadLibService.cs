namespace FiveToSeven.Services.MadLib;
public class MadLibService : IMadLibService
{
    public string MadLib(string name1, string name2, string show, string movie, string game, string timeOfDay)
    {
        return $"One day {name1} and {name2} wanted to do something together.\n{name1} wanted to watch {show}, while {name2} wanted to watch {movie}.\nThey couldn't decide, so they decided to settle it with {game}.\nIt took all {timeOfDay}, until it was time for {name1} and {name2} to go their seperate ways for the day, neither declared the true victor.\nIn the end, {name1} and {name2} got what they wanted after all, something to do, in the form of {game}.";
    }
}