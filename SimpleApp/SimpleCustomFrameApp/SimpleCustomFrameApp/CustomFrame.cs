using Xamarin.Forms;

namespace SimpleCustomFrameApp
{
    public class CustomFrame : Frame
    {
        public CustomFrame()
        {
            base.CornerRadius = 0;
        }

        public new static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create(nameof(CustomFrame), typeof(CornerRadius), typeof(CustomFrame));

        public new CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }
    }
}
