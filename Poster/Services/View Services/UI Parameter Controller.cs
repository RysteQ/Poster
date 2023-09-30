namespace Poster.Services.View_Services;

internal static class UIParameterController
{
    public static void CreateUIParameterRow(ref List<(CheckBox, TextBox, TextBox, Button)> parameter_rows, ref Panel parent_panel)
    {
        CheckBox new_checkbox = new();
        TextBox new_textbox_key = new();
        TextBox new_textbox_parameter = new();
        Button new_button = new();

        new_checkbox.Location = new(parameter_rows.Last().Item1.Location.X, parameter_rows.Last().Item1.Location.Y + 29);
        new_textbox_key.Location = new(parameter_rows.Last().Item2.Location.X, parameter_rows.Last().Item2.Location.Y + 29);
        new_textbox_parameter.Location = new(parameter_rows.Last().Item3.Location.X, parameter_rows.Last().Item3.Location.Y + 29);
        new_button.Location = new(parameter_rows.Last().Item4.Location.X, parameter_rows.Last().Item4.Location.Y + 29);

        new_checkbox.Size = parameter_rows.First().Item1.Size;
        new_textbox_key.Size = parameter_rows.First().Item2.Size;
        new_textbox_parameter.Size = parameter_rows.First().Item3.Size;
        new_button.Size = parameter_rows.First().Item4.Size;

        new_checkbox.Anchor = parameter_rows.First().Item1.Anchor;
        new_textbox_key.Anchor = parameter_rows.First().Item2.Anchor;
        new_textbox_parameter.Anchor = parameter_rows.First().Item3.Anchor;
        new_button.Anchor = parameter_rows.First().Item4.Anchor;

        new_textbox_parameter.Enabled = false;

        parent_panel.Controls.Add(new_checkbox);
        parent_panel.Controls.Add(new_textbox_key);
        parent_panel.Controls.Add(new_textbox_parameter);
        parent_panel.Controls.Add(new_button);

        // when the vertical scrollbar appears it makes some UI elements slightly smaller but not the ones added by code,
        // this is a dirty but effective fix
        new_textbox_parameter.Size = parameter_rows.First().Item3.Size;
        new_button.Location = new(parameter_rows.Last().Item4.Location.X, parameter_rows.Last().Item4.Location.Y + 29);

        parameter_rows.Add((new_checkbox, new_textbox_key, new_textbox_parameter, new_button));
    }

    public static void DeleteUIParameterRow(ref List<(CheckBox, TextBox, TextBox, Button)> parameter_rows, int parameter_row, ref Panel parent_panel)
    {
        parameter_rows.Remove(parameter_rows[parameter_row]);

        for (int i = 0; i < 4; i++)
            parent_panel.Controls.Remove(parent_panel.Controls[(4 * (parameter_row + 1)) - i - 1]);
    }

    public static void MoveUIParametersRow(ref List<(CheckBox, TextBox, TextBox, Button)> parameter_rows, int parameter_row)
    {
        for (int i = parameter_row; i < parameter_rows.Count; i++)
        {
            parameter_rows[i].Item1.Location = new(parameter_rows[i].Item1.Location.X, parameter_rows[i].Item1.Location.Y - 29);
            parameter_rows[i].Item2.Location = new(parameter_rows[i].Item2.Location.X, parameter_rows[i].Item2.Location.Y - 29);
            parameter_rows[i].Item3.Location = new(parameter_rows[i].Item3.Location.X, parameter_rows[i].Item3.Location.Y - 29);
            parameter_rows[i].Item4.Location = new(parameter_rows[i].Item4.Location.X, parameter_rows[i].Item4.Location.Y - 29);
        }
    }
}