﻿using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMeta2.CSOM.ModelHosts
{
    public class ModuleFileModelHost : CSOMModelHostBase
    {
        #region properties

        public File CurrentFile { get; set; }

        #endregion
    }
}
