using Poster.Services.View_Services;

namespace Poster;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        UILabelParameterController.MoveLabelParameters(ref LabelKey, ref LabelValue, TextBoxParameterKey, TextBoxParameterValue);

        ComboBoxMethodSelection.SelectedIndex = 0;

        this.parameter_rows.Add((CheckBoxIsParameterEnabled, TextBoxParameterKey, TextBoxParameterValue, ButtonDeleteParameter));
    }

    private void OnTextBoxParameterKeyChanged(object sender, EventArgs e)
    {
        TextBox textbox = (TextBox)sender;
        List<TextBox> all_parameter_key_textboxes = this.parameter_rows.Select(parameter_row => parameter_row.Item2).ToList();
        int parameter_key_textbox_index = 0;

        foreach (TextBox parameter_key_textbox in all_parameter_key_textboxes)
            if (parameter_key_textbox == textbox)
                parameter_key_textbox_index = all_parameter_key_textboxes.IndexOf(textbox);

        if (string.IsNullOrWhiteSpace(textbox.Text) == false)
        {
            this.parameter_rows[parameter_key_textbox_index].Item1.Checked = true;
            this.parameter_rows[parameter_key_textbox_index].Item3.Enabled = true;
        }
        else
        {
            this.parameter_rows[parameter_key_textbox_index].Item1.Checked = false;
            this.parameter_rows[parameter_key_textbox_index].Item3.Enabled = false;
        }

        if (string.IsNullOrEmpty(textbox.Text) == false && parameter_key_textbox_index == this.parameter_rows.Count - 1)
        {
            UIParameterController.CreateUIParameterRow(ref this.parameter_rows, ref PanelParameters);

            this.parameter_rows.Last().Item2.TextChanged += OnTextBoxParameterKeyChanged;
            this.parameter_rows.Last().Item4.Click += OnButtonDeleteParameter;
        }
    }

    private void OnButtonDeleteParameter(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        List<Button> all_delete_buttons = this.parameter_rows.Select(parameter_row => parameter_row.Item4).ToList();
        int delete_button_index = 0;

        foreach (Button delete_button in all_delete_buttons)
            if (delete_button == button)
                delete_button_index = all_delete_buttons.IndexOf(delete_button);

        UIParameterController.DeleteUIParameterRow(ref this.parameter_rows, delete_button_index, ref PanelParameters);

        if (delete_button_index != this.parameter_rows.Count)
            UIParameterController.MoveUIParametersRow(ref this.parameter_rows, delete_button_index);
    }

    private void OnFormResized(object sender, EventArgs e)
    {
        UILabelParameterController.MoveLabelParameters(ref LabelKey, ref LabelValue, TextBoxParameterKey, TextBoxParameterValue);
    }

    private List<(CheckBox, TextBox, TextBox, Button)> parameter_rows = new();
}