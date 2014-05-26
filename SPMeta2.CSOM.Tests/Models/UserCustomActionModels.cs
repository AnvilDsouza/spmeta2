﻿using SPMeta2.Definitions;

namespace SPMeta2.CSOM.Tests.Models
{
    public class UserCustomActionModels
    {
        #region peoprties

        public static UserCustomActionDefinition SiteScriptJQuery = new UserCustomActionDefinition
        {
            Title = "SiteScriptJQuery",
            Name = "SiteScriptJQuery",
            ScriptSrc = "~sitecollection/style library/jQuery/jquery-2.1.0.js",
            Location = "ScriptLink",
            Sequence = 100
        };

        #endregion
    }
}
