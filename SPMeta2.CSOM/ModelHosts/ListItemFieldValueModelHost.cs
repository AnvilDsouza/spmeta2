﻿using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMeta2.CSOM.ModelHosts
{
    public class ListItemFieldValueModelHost : CSOMModelHostBase
    {
        #region properties

        public ListItem CurrentItem { get; set; }

        #endregion
    }
}
