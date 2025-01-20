using GarageManager.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace GarageManager.UI.Controls.Button
{
    public class LightupButton : System.Windows.Controls.Button
    {
        public LightupButton()
        {
            //Width = 100;
            //Foreground = Brushes.Blue;

            //AddHandler(ClickEvent, new RoutedEventHandler(GetClick));
        }

        private void GetClick(object sender, RoutedEventArgs e)
        {
            
        }

        private static Brush? _defaultForground;

        public bool IsLightup
        {
            get { return (bool)GetValue(LightupProperty); }
            set { SetValue(LightupProperty, value); }
        }

        public static readonly DependencyProperty LightupProperty =
            DependencyProperty.Register("IsLightup", typeof(bool), typeof(System.Windows.Controls.Button),
                new PropertyMetadata(false, LightupPropertyChanged));

        private static void LightupPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var btn = (System.Windows.Controls.Button)d;
            if (btn == null) return;

            if (_defaultForground == null) _defaultForground = btn.Foreground;

            var isLightup = (bool)d.GetValue(LightupProperty);
            //btn.Foreground = isLightup ? Brushes.Red : _defaultForground;

            try
            {
                btn.ApplyTemplate();
                var textbox = (TextBlock)btn.Template.FindName("btnTxtblck", btn);
                if (textbox != null) 
                {
                    textbox.Foreground = isLightup ? Brushes.Red : _defaultForground;
                }

                //var children = VisualTreeHelper.GetChildrenCount(btn);
                //var templateTextbox = (TextBox)VisualTreeHelper.GetChild(btn, 0);
                //var templateTextbox = XamlHelper.FindChild<TextBox>(btn, "btnTxtbx");
                //templateTextbox.Foreground = isLightup ? Brushes.Red : _defaultForground;
            }
            catch (Exception ex)
            {

            }


        }
    }
}



