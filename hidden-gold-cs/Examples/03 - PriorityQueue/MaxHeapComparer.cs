namespace DotNetCoach.CSTricks.C;

class MaxHeapComparer : IComparer<TimeOnly>
{
    public int Compare(TimeOnly x, TimeOnly y) => x < y ? 1 : -1;
}