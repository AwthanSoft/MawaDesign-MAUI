﻿namespace MawaMAUIDesign.Test;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
		//MainPage = new MainPage();
	}
}
