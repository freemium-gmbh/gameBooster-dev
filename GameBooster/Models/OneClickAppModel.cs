/// <summary>
/// The <see cref="GameBooster.Models"/> namespace contains a set of model classes
/// of the <see cref="GameBooster"/> project
/// </summary>
namespace GameBooster.Models
{
    /// <summary>
    /// OneClickApp statuses collection
    /// </summary>
    public enum OneClickAppStatus
    {
        NotStarted,
        ScanStarted,
        ScanFinishedOK,
        ScanFinishedError,
        FixStarted,
        FixFinished
    };
}