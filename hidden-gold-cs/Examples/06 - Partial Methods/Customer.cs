namespace DotNetCoach.CSTricks.H;

partial class Customer
{
    private string? _name;

    public string? Name
    {
        get { return _name; }
        set
        {
            OnNameChanging(value);
            _name = value;
            OnNameChanged();
        }
    }

    partial void OnNameChanging(string? newName);
    partial void OnNameChanged();
}
