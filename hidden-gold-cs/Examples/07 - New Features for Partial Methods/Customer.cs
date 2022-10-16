﻿namespace DotNetCoach.CSTricks.H;

partial class Customer
{
    private string? _name;

    public string? Name
    {
        get { return _name; }
        set
        {
            if( OnNameChanging(value) )
            {
                _name = value;
                OnNameChanged(out var old);
            }
        }
    }

    private partial bool OnNameChanging(string? newName);
    public partial void OnNameChanged(out string? oldName);
}
