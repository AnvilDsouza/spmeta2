﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMeta2.Regression.Services
{
    public abstract class RandomService
    {
        public abstract Guid Guid();

        public abstract byte[] Content();
        public abstract byte[] Content(int lenght);

        public abstract bool Bool();

        public abstract string String();
        public abstract string String(int lenght);

        public abstract int Int();
        public abstract int Int(int maxValue);

        public abstract double Double();
        public abstract double Double(double maxValue);

        public abstract string UserLogin();
        public abstract string UserName();

        public abstract string UserEmail();

        public abstract string ManagedPath();
    }
}