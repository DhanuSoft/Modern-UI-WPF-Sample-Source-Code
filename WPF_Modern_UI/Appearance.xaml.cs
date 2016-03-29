using FirstFloor.ModernUI.Windows.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using FirstFloor.ModernUI.Presentation;
using System.ComponentModel;

namespace WPF_Modern_UI
{
    /// <summary>
    /// Interaction logic for $safeitemrootname$.xaml
    /// </summary>
    public partial class Appearance : UserControl
    {
        public Appearance()
        {
            InitializeComponent();

            this.DataContext = new SettingsAppearanceViewModel();

            IconBitmapDecoder ibd = new IconBitmapDecoder(new Uri(@"C:\Users\7903296\Downloads\Munchee Tikiri Marie\Emp Att\App.ico", UriKind.RelativeOrAbsolute), BitmapCreateOptions.None, BitmapCacheOption.Default);
            //Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(@"C:\Users\7903296\Downloads\Munchee Tikiri Marie\Emp Att\App.ico");
            ModernDialog Dialog = new ModernDialog();
            Dialog.Title = "DIALOG EXAMPLE";
            Dialog.Buttons = new Button[] { Dialog.OkButton, Dialog.CancelButton };
            Dialog.Content = "Testing a new DialogResult";
            Dialog.Icon = ibd.Frames[0];
            Dialog.ShowDialog();



            var msg = new ModernDialogMessage();
            //msg.Title = "DIALOG EXAMPLEsdsdsdfsdfsdfsdfsdfs";
            //msg.Buttons = new Button[] { msg.OkButton, msg.CancelButton };
            //msg.Content = "Testing a new DialogResultsdsdsdsddfsdfsdfsdfsdfsdf";
            //msg.Icon = new BitmapImage(new Uri(@"C:\Users\7903296\Downloads\the-dark-knight-rises-hd-wallpaper-3-139724-2880x1800.jpg"));
            msg.ShowDialog();
        }
        //private void BlankWindow_Click(object sender, RoutedEventArgs e)
        //{
        //    // create a blank modern window with lorem content
        //    // the BlankWindow ModernWindow styles is found in the mui assembly at Assets/ModernWindowEx.xaml

        //    var wnd = new ModernWindow
        //    {
        //        Style = (Style)App.Current.Resources["BlankWindow"],
        //        Title = "ModernWindow",
        //        IsTitleVisible = true == this.title.IsChecked,
        //       // Content = new LoremIpsum(),
        //        Width = 480,
        //        Height = 480
        //    };

        //    if (true == this.logo.IsChecked)
        //    {
        //        wnd.LogoData = PathGeometry.Parse("F1 M 24.9015,43.0378L 25.0963,43.4298C 26.1685,49.5853 31.5377,54.2651 38,54.2651C 44.4623,54.2651 49.8315,49.5854 50.9037,43.4299L 51.0985,43.0379C 51.0985,40.7643 52.6921,39.2955 54.9656,39.2955C 56.9428,39.2955 58.1863,41.1792 58.5833,43.0379C 57.6384,52.7654 47.9756,61.75 38,61.75C 28.0244,61.75 18.3616,52.7654 17.4167,43.0378C 17.8137,41.1792 19.0572,39.2954 21.0344,39.2954C 23.3079,39.2954 24.9015,40.7643 24.9015,43.0378 Z M 26.7727,20.5833C 29.8731,20.5833 32.3864,23.0966 32.3864,26.197C 32.3864,29.2973 29.8731,31.8106 26.7727,31.8106C 23.6724,31.8106 21.1591,29.2973 21.1591,26.197C 21.1591,23.0966 23.6724,20.5833 26.7727,20.5833 Z M 49.2273,20.5833C 52.3276,20.5833 54.8409,23.0966 54.8409,26.197C 54.8409,29.2973 52.3276,31.8106 49.2273,31.8106C 46.127,31.8106 43.6136,29.2973 43.6136,26.197C 43.6136,23.0966 46.127,20.5833 49.2273,20.5833 Z");
        //    }
        //    if (true == this.noresize.IsChecked)
        //    {
        //        wnd.ResizeMode = ResizeMode.NoResize;
        //    }
        //    else if (true == this.canminimize.IsChecked)
        //    {
        //        wnd.ResizeMode = ResizeMode.CanMinimize;
        //    }
        //    else if (true == this.canresize.IsChecked)
        //    {
        //        wnd.ResizeMode = ResizeMode.CanResize;
        //    }
        //    else if (true == this.canresizewithgrip.IsChecked)
        //    {
        //        wnd.ResizeMode = ResizeMode.CanResizeWithGrip;
        //    }

        //    wnd.Show();
        //}

    }
    public class SettingsAppearanceViewModel
        : NotifyPropertyChanged
    {
        private const string FontSmall = "Small";
        private const string FontLarge = "Large";

        private const string PaletteMetro = "Metro";
        private const string PaletteWP = "Windows phone";

        // 9 accent colors from metro design principles
        private Color[] metroAccentColors = new Color[]{
            Color.FromRgb(0x33, 0x99, 0xff),   // blue
            Color.FromRgb(0x00, 0xab, 0xa9),   // teal
            Color.FromRgb(0x33, 0x99, 0x33),   // green
            Color.FromRgb(0x8c, 0xbf, 0x26),   // lime
            Color.FromRgb(0xf0, 0x96, 0x09),   // orange
            Color.FromRgb(0xff, 0x45, 0x00),   // orange red
            Color.FromRgb(0xe5, 0x14, 0x00),   // red
            Color.FromRgb(0xff, 0x00, 0x97),   // magenta
            Color.FromRgb(0xa2, 0x00, 0xff),   // purple            
        };

        // 20 accent colors from Windows Phone 8
        private Color[] wpAccentColors = new Color[]{
            Color.FromRgb(0xa4, 0xc4, 0x00),   // lime
            Color.FromRgb(0x60, 0xa9, 0x17),   // green
            Color.FromRgb(0x00, 0x8a, 0x00),   // emerald
            Color.FromRgb(0x00, 0xab, 0xa9),   // teal
            Color.FromRgb(0x1b, 0xa1, 0xe2),   // cyan
            Color.FromRgb(0x00, 0x50, 0xef),   // cobalt
            Color.FromRgb(0x6a, 0x00, 0xff),   // indigo
            Color.FromRgb(0xaa, 0x00, 0xff),   // violet
            Color.FromRgb(0xf4, 0x72, 0xd0),   // pink
            Color.FromRgb(0xd8, 0x00, 0x73),   // magenta
            Color.FromRgb(0xa2, 0x00, 0x25),   // crimson
            Color.FromRgb(0xe5, 0x14, 0x00),   // red
            Color.FromRgb(0xfa, 0x68, 0x00),   // orange
            Color.FromRgb(0xf0, 0xa3, 0x0a),   // amber
            Color.FromRgb(0xe3, 0xc8, 0x00),   // yellow
            Color.FromRgb(0x82, 0x5a, 0x2c),   // brown
            Color.FromRgb(0x6d, 0x87, 0x64),   // olive
            Color.FromRgb(0x64, 0x76, 0x87),   // steel
            Color.FromRgb(0x76, 0x60, 0x8a),   // mauve
            Color.FromRgb(0x87, 0x79, 0x4e),   // taupe
        };

        private string selectedPalette = PaletteWP;

        private Color selectedAccentColor;
        private LinkCollection themes = new LinkCollection();
        private Link selectedTheme;
        private string selectedFontSize;

        public SettingsAppearanceViewModel()
        {
            // add the default themes
            this.themes.Add(new Link { DisplayName = "Dark", Source = AppearanceManager.DarkThemeSource });
            this.themes.Add(new Link { DisplayName = "Light", Source = AppearanceManager.LightThemeSource });


            this.themes.Add(new Link { DisplayName = "My Theme", Source = new Uri("Themes/ModernUI.Theme.xaml", UriKind.Relative) });

            // add additional themes
            //this.themes.Add(new Link { DisplayName = "bing image", Source = new Uri("Assets/ModernUI.BingImage.xaml", UriKind.Relative) });
            this.themes.Add(new Link { DisplayName = "Hello Kitty", Source = new Uri("Assets/ModernUI.HelloKitty.xaml", UriKind.Relative) });
            this.themes.Add(new Link { DisplayName = "Love", Source = new Uri("Assets/ModernUI.Love.xaml", UriKind.Relative) });
            this.themes.Add(new Link { DisplayName = "Snowflakes", Source = new Uri("Assets/ModernUI.Snowflakes.xaml", UriKind.Relative) });

            this.SelectedFontSize = AppearanceManager.Current.FontSize == FontSize.Large ? FontLarge : FontSmall;
            SyncThemeAndColor();
            
            AppearanceManager.Current.PropertyChanged += OnAppearanceManagerPropertyChanged;
        }

        private void SyncThemeAndColor()
        {
            // synchronizes the selected viewmodel theme with the actual theme used by the appearance manager.
            this.SelectedTheme = this.themes.FirstOrDefault(l => l.Source.Equals(AppearanceManager.Current.ThemeSource));

            // and make sure accent color is up-to-date
            this.SelectedAccentColor = AppearanceManager.Current.AccentColor;
        }

        private void OnAppearanceManagerPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ThemeSource" || e.PropertyName == "AccentColor")
            {
                SyncThemeAndColor();
            }
        }

        public LinkCollection Themes
        {
            get { return this.themes; }
        }

        public string[] FontSizes
        {
            get { return new string[] { FontSmall, FontLarge }; }
        }

        public string[] Palettes
        {
            get { return new string[] { PaletteMetro, PaletteWP }; }
        }

        public Color[] AccentColors
        {
            get { return this.selectedPalette == PaletteMetro ? this.metroAccentColors : this.wpAccentColors; }
        }

        public string SelectedPalette
        {
            get { return this.selectedPalette; }
            set
            {
                if (this.selectedPalette != value)
                {
                    this.selectedPalette = value;
                    OnPropertyChanged("AccentColors");

                    this.SelectedAccentColor = this.AccentColors.FirstOrDefault();
                }
            }
        }

        public Link SelectedTheme
        {
            get { return this.selectedTheme; }
            set
            {
                if (this.selectedTheme != value)
                {
                    this.selectedTheme = value;
                    OnPropertyChanged("SelectedTheme");

                    // and update the actual theme
                    AppearanceManager.Current.ThemeSource = value.Source;
                }
            }
        }

        public string SelectedFontSize
        {
            get { return this.selectedFontSize; }
            set
            {
                if (this.selectedFontSize != value)
                {
                    this.selectedFontSize = value;
                    OnPropertyChanged("SelectedFontSize");

                    AppearanceManager.Current.FontSize = value == FontLarge ? FontSize.Large : FontSize.Small;
                }
            }
        }

        public Color SelectedAccentColor
        {
            get { return this.selectedAccentColor; }
            set
            {
                if (this.selectedAccentColor != value)
                {
                    this.selectedAccentColor = value;
                    OnPropertyChanged("SelectedAccentColor");

                    AppearanceManager.Current.AccentColor = value;
                }
            }
        }
    }
}
