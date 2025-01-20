using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interactivity;
using System.Windows.Media;

namespace GarageManager.UI.Controls.Button
{
    internal class LightupBehavior : DependencyObject
    {
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
            btn.Foreground = isLightup ? Brushes.Red : _defaultForground;
        }

        public LightupBehavior()
        {
        }
    }
}
