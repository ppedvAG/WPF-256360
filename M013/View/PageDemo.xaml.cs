using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
namespace M013.View;

public partial class PageDemo : Window
{
	public static UserControl CurrentPage { get; set; }

	public static void SwitchPage(string next)
	{
		switch (next)
		{
			case "Page1":
				CurrentPage = new Page1();
				break;
		}
	}

	public PageDemo()
	{
		InitializeComponent();
	}
}