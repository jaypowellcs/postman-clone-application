using PostmanClone.Library; 

namespace PostmanCloneUI;

public partial class Dashboard : Form
{

    private readonly IApiAccess api = new ApiAccess();

    public Dashboard()
    {
        InitializeComponent();
        httpVerbSelection.SelectedItem = "GET";
    }

    private async void callAPI_Click(object sender, EventArgs e)
    {

        systemStatus.Text = "Calling API....";
        resultstext.Text = "";



        //Validate the API URl
        if (api.IsValidUrl(apitext.Text) == false)
        {
            systemStatus.Text = "Invalid URL";
            return;
        }

        HttpAction action;
        if (Enum.TryParse(httpVerbSelection.SelectedItem!.ToString(), out action) == false)
        {
            systemStatus.Text = "Invalid HTTP Verb";
            return;
        }


        try
        {
            systemStatus.Text = "Calling API...";

            //Sample Code - replace with the actual API Call 
            resultstext.Text = await api.CallApiAsync(apitext.Text, bodytext.Text, action);
            callData.SelectedTab = outputTab;
            outputTab.Focus();

            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {

            resultstext.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }
    }
}
