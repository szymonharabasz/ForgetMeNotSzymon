namespace ForgetMeNotSzymon;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        string timeOrTimes = count == 1 ? "time" : "times";

        CounterBtn.Text = $"Clicked {count} {timeOrTimes}";
        CounterLabel.Text = $"Button was clicked {count} {timeOrTimes}";
        
        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}