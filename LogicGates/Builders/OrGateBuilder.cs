﻿using System.Collections.Generic;

namespace LogicGates.Builders
{
    public class OrGateBuilder
    {
        private readonly List<IHaveOutput> _inputs = new List<IHaveOutput>();
        
        public OrGateBuilder WithInput(IHaveOutput input)
        {
            _inputs.Add(input);
            return this;
        }

        public OrGate Build()
        {
            var gate = new OrGate();
            foreach (var input in _inputs)
            {
                gate.AddInput(input);
            }

            return gate;
        }
    }
}