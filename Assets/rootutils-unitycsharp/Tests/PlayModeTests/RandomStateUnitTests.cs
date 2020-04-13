using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using RootUtils.Randomization;
using NSubstitute;

namespace Tests
{
    public class RandomStateUnitTests
    {
        [Test]
        public void Snapshot_Argument0_InitialEqualsSnapshot() {
            Random.State initialState = Random.state;
            Random.State snapshot = RandomState.Snapshot(0);

            Assert.AreEqual(initialState, snapshot);
        }

        [Test]
        public void Snapshot_Argument0_InitialDoesNotEqualCurrent() {
            Random.InitState(-1);
            Random.State initialState = Random.state;
            RandomState.Snapshot(0);

            Assert.AreNotEqual(initialState, Random.state); 
        }
    }
}
