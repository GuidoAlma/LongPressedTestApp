using LongPressedTestApp.Droid;
using LongPressedTestApp;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("LongPressedTestApp")]
[assembly: ExportEffect(typeof(AndroidLongPressedEffect), "LongPressedEffect")]
namespace LongPressedTestApp.Droid
{
    public class AndroidLongPressedEffect : PlatformEffect
    {
        private bool _attached;

        public static void Initialize() { }

        //public AndroidLongPressedEffect() { }

        protected override void OnAttached()
        {
            if (!_attached)
            {
                if (Control != null)
                {
                    Control.LongClickable = true;
                    Control.LongClick += Control_LongClick;
                }
                else
                {
                    Container.LongClickable = true;
                    Container.LongClick += Control_LongClick;
                }
                _attached = true;
            }
        }

        private void Control_LongClick(object sender, Android.Views.View.LongClickEventArgs e)
        {
            var command = LongPressedEffect.GetCommand(Element);
            command?.Execute(LongPressedEffect.GetCommandParameter(Element));
        }

        protected override void OnDetached()
        {
            if (_attached)
            {
                if (Control != null)
                {
                    Control.LongClickable = false;
                    Control.LongClick -= Control_LongClick;
                }
                else
                {
                    Container.LongClickable = false;
                    Container.LongClick -= Control_LongClick;
                }
                _attached = false;
            }
        }
    }
}