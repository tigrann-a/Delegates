namespace Delegates_20260304;

internal class WorkPerformetEventArgs : EventArgs
{
    public int Hours {  get; set; }
    public WorkType WorkType {  get; set; }

    public WorkPerformetEventArgs(int hours, WorkType workType)
    {
        Hours = hours;
        WorkType = workType;
    }
}
