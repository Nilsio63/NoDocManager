using System.Runtime.CompilerServices;

namespace NoDocManager.Wpf.ViewModels;

public abstract class BaseViewModel
{
    private readonly Dictionary<string, object?> _propertyValues = new();

    protected T GetValue<T>([CallerMemberName] string propertyName = "")
    {
        if (_propertyValues.ContainsKey(propertyName))
        {
            return (T)_propertyValues[propertyName]!;
        }

        return default!;
    }

    protected void SetValue<T>(T value, [CallerMemberName] string propertyName = "")
    {
        _propertyValues[propertyName] = value;
    }
}
