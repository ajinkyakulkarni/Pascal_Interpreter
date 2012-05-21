﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter.intermediate
{
    public interface ICode
    {
        public ICodeNode SetRoot(ICodeNode node);
        public ICodeNode GetRoot();
    }
}
