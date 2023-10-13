namespace Poster.Models;

internal class ParameterRow
{
    public ParameterRow(CheckBox Enabled, TextBox Key, TextBox Value, Button Delete)
    {
        this.Enabled = Enabled;
        this.Key = Key;
        this.Value = Value;
        this.Delete = Delete;
    }

    public CheckBox Enabled { get; set; }
    public TextBox Key { get; set; }
    public TextBox Value { get; set; }
    public Button Delete { get; set; }

    public KeyValuePair<string, string> KeyValuePair { get => new KeyValuePair<string, string>(Key.Text, Value.Text); }
}