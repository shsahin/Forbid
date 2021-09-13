﻿using System;

namespace Forbid
{
    public class Tester
    {
        private readonly IForbid _forbid;

        public Tester(IForbid forbid)
        {
            _forbid = forbid;
        }

        public void Test()
        {
            Forbid.From.Null(1);
            Forbid.From.NullOrEmpty(Guid.Empty, new Exception());
        }
    }
}