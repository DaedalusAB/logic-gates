﻿using System.Collections.Generic;
using System.Linq;

namespace LogicGates
{
    public class AndGate : LogicGate
    {
        public AndGate(Signal output) : base(output)
        {
        }

        public override void Emit() =>
            Output.SetState(Inputs.All(signal => signal.State()));

    }
}
