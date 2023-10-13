using Poster.Enums;
using Poster.Models;
using Poster.Services.HTTP;
using Poster.Services.View_Services;

namespace Poster;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        UILabelParameterController.MoveLabelParameters(ref LabelKey, ref LabelValue, TextBoxParameterKey, TextBoxParameterValue);

        ComboBoxMethodSelection.SelectedIndex = 0;

        this.parameter_rows.Add(new(CheckBoxIsParameterEnabled, TextBoxParameterKey, TextBoxParameterValue, ButtonDeleteParameter));
    }

    private void OnTextBoxParameterKeyChanged(object sender, EventArgs e)
    {
        TextBox textbox = (TextBox)sender;
        List<TextBox> all_parameter_key_textboxes = this.parameter_rows.Select(parameter_row => parameter_row.Key).ToList();
        int parameter_key_textbox_index = 0;

        foreach (TextBox parameter_key_textbox in all_parameter_key_textboxes)
            if (parameter_key_textbox == textbox)
                parameter_key_textbox_index = all_parameter_key_textboxes.IndexOf(textbox);

        if (string.IsNullOrWhiteSpace(textbox.Text) == false)
        {
            this.parameter_rows[parameter_key_textbox_index].Enabled.Checked = true;
            this.parameter_rows[parameter_key_textbox_index].Value.Enabled = true;
        }
        else
        {
            this.parameter_rows[parameter_key_textbox_index].Enabled.Checked = false;
            this.parameter_rows[parameter_key_textbox_index].Value.Enabled = false;
        }

        if (string.IsNullOrEmpty(textbox.Text) == false && parameter_key_textbox_index == this.parameter_rows.Count - 1)
        {
            UIParameterController.CreateUIParameterRow(ref this.parameter_rows, ref PanelParameters);

            this.parameter_rows.Last().Key.TextChanged += OnTextBoxParameterKeyChanged;
            this.parameter_rows.Last().Delete.Click += OnButtonDeleteParameter;
        }
    }

    private void OnButtonDeleteParameter(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        List<Button> all_delete_buttons = this.parameter_rows.Select(parameter_row => parameter_row.Delete).ToList();
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

    private async void OnButtonSendRequest(object sender, EventArgs e)
    {
        Dictionary<string, string> parameter_keys_values = new();
        HttpResponseMessage response = new();

        foreach (ParameterRow parameter_row in parameter_rows)
            if (parameter_row.Enabled.Checked)
                parameter_keys_values.Add(parameter_row.Key.Text, parameter_row.Value.Text);

        try
        {
            switch (Enum.Parse<RequestEnum>(ComboBoxMethodSelection.Text))
            {
                case RequestEnum.POST:
                    response = await HTTPMethodCaller.POST(TextBoxUrl.Text, parameter_keys_values);
                    break;

                case RequestEnum.GET:
                    response = await HTTPMethodCaller.GET(TextBoxUrl.Text, parameter_keys_values);
                    break;

                case RequestEnum.PUT:
                    response = await HTTPMethodCaller.PUT(TextBoxUrl.Text, parameter_keys_values);
                    break;

                case RequestEnum.PATCH:
                    response = await HTTPMethodCaller.PATCH(TextBoxUrl.Text, parameter_keys_values);
                    break;

                case RequestEnum.DELETE:
                    response = await HTTPMethodCaller.DELETE(TextBoxUrl.Text, parameter_keys_values);
                    break;
            }
        } catch (Exception) { }

        this.request_calls.Add(new
        (
            Enum.Parse<RequestEnum>(ComboBoxMethodSelection.Text),
            TextBoxUrl.Text.Split('?').First(),
            parameter_keys_values,
            response
        ));
    }

    private void OnListBoxResponseHistoryDoubleClick(object sender, EventArgs e)
    {
        if (ListBoxResponseHistory.SelectedItems.Count != 1)
            return;

        // TODO
    }

    private List<ParameterRow> parameter_rows = new();
    private List<HTTPRequestCall> request_calls = new();
}