using Plugin.Firebase.CloudMessaging;

namespace MauiFirebasePush;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		await CrossFirebaseCloudMessaging.Current.CheckIfValidAsync();
		var token = await CrossFirebaseCloudMessaging.Current.GetTokenAsync();
		await DisplayAlert("FCM token", token, "OK");
	}
}

