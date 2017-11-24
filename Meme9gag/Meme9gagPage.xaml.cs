using Xamarin.Forms;
using Plugin.Media;

namespace Meme9gag
{
    public partial class Meme9gagPage : ContentPage
    {
        public Meme9gagPage()
        {
            InitializeComponent();
        }

        async void TakePhoto_Clicked(object sender, System.EventArgs e)
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("오류", "카메라를 사용할 수 없습니다", "확인");
                return;
            }
            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "Sample",
                Name = "test.jpg"
            });
            if (file == null)
                return;

            image.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });
        }

        async void PickPhoto_Clicked(object sender, System.EventArgs e)
        {
            var file = await CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
            {
            });
            if (file == null)
                return;
            image.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });
        }
    }
}
