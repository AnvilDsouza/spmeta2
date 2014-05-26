﻿using System;
using SPMeta2.Definitions;
using SPMeta2.Enumerations;

// <auto-generated>
//     This code was generated by SPMeta2 T4 file.
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace SPMeta2.T4.Model
{
    public static class T4SPQuickLaunchNavigation
    {
        #region properties

		public static QuickLaunchNavigationNodeDefinition ResourceLibrary = new QuickLaunchNavigationNodeDefinition
		{
			Title = "Resource Library",
			IsVisible = true,
			IsExternal = true,
			Url = "ResourceLibrary",
		};


		public static QuickLaunchNavigationNodeDefinition Google = new QuickLaunchNavigationNodeDefinition
		{
			Title = "Google",
			IsVisible = true,
			IsExternal = true,
			Url = "http://google.com",
		};


		public static QuickLaunchNavigationNodeDefinition Help = new QuickLaunchNavigationNodeDefinition
		{
			Title = "Help",
			IsVisible = true,
			IsExternal = true,
			Url = "/resources/help.aspx",
		};


        #endregion
    }
}