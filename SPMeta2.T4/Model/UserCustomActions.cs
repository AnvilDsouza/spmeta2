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
    public static class T4SPUserCustomAction
    {
        #region properties

		public static UserCustomActionDefinition SiteScriptJQuery = new UserCustomActionDefinition
		{
			Name = "SiteScriptJQuery",
			Title = "SiteScriptJQuery",
			Description = "",
			ScriptSrc = "~sitecollection/style library/jQuery/jquery-2.1.0.js",
			ScriptBlock = "",
			Group = "",
			Location = "ScriptLink",
			Sequence = 100,
		};


		public static UserCustomActionDefinition SiteScriptAngularJs = new UserCustomActionDefinition
		{
			Name = "SiteScriptAngularJs",
			Title = "SiteScriptAngularJs",
			Description = "",
			ScriptSrc = "~sitecollection/style library/AngularJs/angular.js",
			ScriptBlock = "",
			Group = "",
			Location = "ScriptLink",
			Sequence = 200,
		};


        #endregion
    }
}