namespace Poster.Services.View_Services;

internal static class UILabelParameterController
{
    public static void MoveLabelParameters(ref Label key_label, ref Label value_label, TextBox key_textbox, TextBox value_textbox)
    {
        key_label.Location = new(key_textbox.Location.X + key_textbox.Size.Width / 2 - key_label.Width / 2, key_label.Location.Y);
        value_label.Location = new(value_textbox.Location.X + value_textbox.Size.Width / 2 - value_label.Width / 2, value_label.Location.Y);
    }
}