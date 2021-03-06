﻿using System;

namespace Ramda.NET
{
    public class PromiseContinuation
    {
        private dynamic value;

        public PromiseContinuation(dynamic value) {
            this.value = value;
        }

        public PromiseContinuation Then(Func<dynamic, dynamic> continuation) {
            value = continuation(value);

            return this;
        }
    }
}
