using Poster.Models;

namespace Poster.Services.View_Services;

internal static class UIParameterController
{
    public static void CreateUIParameterRow(ref List<ParameterRow> parameter_rows, ref Panel parent_panel)
    {
        CheckBox new_checkbox = new();
        TextBox new_textbox_key = new();
        TextBox new_textbox_parameter = new();
        Button new_button = new();

        new_checkbox.Location = new(parameter_rows.Last().Enabled.Location.X, parameter_rows.Last().Enabled.Location.Y + 29);
        new_textbox_key.Location = new(parameter_rows.Last().Key.Location.X, parameter_rows.Last().Key.Location.Y + 29);
        new_textbox_parameter.Location = new(parameter_rows.Last().Value.Location.X, parameter_rows.Last().Value.Location.Y + 29);
        new_button.Location = new(parameter_rows.Last().Delete.Location.X, parameter_rows.Last().Delete.Location.Y + 29);

        new_checkbox.Size = parameter_rows.First().Enabled.Size;
        new_textbox_key.Size = parameter_rows.First().Key.Size;
        new_textbox_parameter.Size = parameter_rows.First().Value.Size;
        new_button.Size = parameter_rows.First().Delete.Size;

        new_checkbox.Anchor = parameter_rows.First().Enabled.Anchor;
        new_textbox_key.Anchor = parameter_rows.First().Key.Anchor;
        new_textbox_parameter.Anchor = parameter_rows.First().Value.Anchor;
        new_button.Anchor = parameter_rows.First().Delete.Anchor;

        new_textbox_parameter.Enabled = false;

        parent_panel.Controls.Add(new_checkbox);
        parent_panel.Controls.Add(new_textbox_key);
        parent_panel.Controls.Add(new_textbox_parameter);
        parent_panel.Controls.Add(new_button);

        // when the vertical scrollbar appears it makes some UI elements slightly smaller but not the ones added by code,
        // this is a dirty but effective fix
        new_textbox_parameter.Size = parameter_rows.First().Value.Size;
        new_button.Location = new(parameter_rows.Last().Delete.Location.X, parameter_rows.Last().Delete.Location.Y + 29);

        parameter_rows.Add(new(new_checkbox, new_textbox_key, new_textbox_parameter, new_button));
    }

    public static void DeleteUIParameterRow(ref List<ParameterRow> parameter_rows, int parameter_row, ref Panel parent_panel)
    {
        parameter_rows.Remove(parameter_rows[parameter_row]);

        for (int i = 0; i < 4; i++)
            parent_panel.Controls.Remove(parent_panel.Controls[(4 * (parameter_row + 1)) - i - 1]);
    }

    public static void MoveUIParametersRow(ref List<ParameterRow> parameter_rows, int parameter_row)
    {
        for (int i = parameter_row; i < parameter_rows.Count; i++)
        {
            parameter_rows[i].Enabled.Location = new(parameter_rows[i].Enabled.Location.X, parameter_rows[i].Enabled.Location.Y - 29);
            parameter_rows[i].Key.Location = new(parameter_rows[i].Key.Location.X, parameter_rows[i].Key.Location.Y - 29);
            parameter_rows[i].Value.Location = new(parameter_rows[i].Value.Location.X, parameter_rows[i].Value.Location.Y - 29);
            parameter_rows[i].Delete.Location = new(parameter_rows[i].Delete.Location.X, parameter_rows[i].Delete.Location.Y - 29);
        }
    }
}