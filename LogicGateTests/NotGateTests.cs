﻿using LogicGates;
using LogicGateTests.Builders;
using Xunit;

namespace LogicGateTests
{
    public class NotGateTests
    {
        private readonly NotGateBuilder NotGateBuilder = new NotGateBuilder();

        [Fact]
        public void Zero_Negated_Is_One()
        {
            var notGate = NotGateBuilder
                .WithInput(
                    new Signal(false)
                )
                .Build();

            Assert.True(notGate.State());
        }

        [Fact]
        public void One_Negated_Is_Zero()
        {
            var notGate = NotGateBuilder
                .WithInput(
                    new Signal(true)
                )
                .Build();

            Assert.False(notGate.State());
        }
    }
}