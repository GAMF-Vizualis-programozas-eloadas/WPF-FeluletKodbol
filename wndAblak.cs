using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Drawing;
using System.Windows.Media;

namespace WPF_Kodbol
{
	/// <summary>
	/// Ha egynél több komponenst akarunk elhelyezni az ablakon, akkor
	/// valamilyen rétegmenedzser komponensre (pl. rács) van szükségünk.
	/// </summary>
	partial class wndAblak : Window
  {
    public wndAblak()
    {
			InitializeComponent();
      Title = "Felület C#-ból";
      Width = 300;
      Height = 100;
      WindowStartupLocation = WindowStartupLocation.CenterScreen;
			// Egy soros és két oszlopos rács létrehozása.
			var ugRács = new UniformGrid
			{
				Columns = 2, Rows=1
			};

			// Üzenet nyomógomb létrehozása és tulajdonságainak beállítása. 
			var btÜzenet = new Button
			{
				Content = "Üzenet",
				Height = 30,
				Width = 100,
				VerticalAlignment = VerticalAlignment.Center,
				HorizontalAlignment = HorizontalAlignment.Center
			};
			btÜzenet.Click += btÜzenet_Click;

			// Kilépés nyomógomb létrehozása és tulajdonságainak beállítása.
			var btKilépés = new Button
			{
				Content = "Kilépés",
				Height = 30,
				Width = 100,
				VerticalAlignment = VerticalAlignment.Center,
				HorizontalAlignment = HorizontalAlignment.Center
			};
			btKilépés.Click += btKilépés_Click;

			// Nyomógombok elhelyezése a rácson.
			ugRács.Children.Add(btÜzenet);
			ugRács.Children.Add(btKilépés);

			// Rács elhelyezése az ablakon.
			AddChild(ugRács);
		}

		void btÜzenet_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Üzenet");
		}

		void btKilépés_Click(object sender, RoutedEventArgs e)
		{
			// Kilépés az alkalmazásból
			Application.Current.Shutdown();
		}
	}
}
