using NUnit.Framework;
using UnityEngine;

namespace HassakuLab.Numerics.Tests
{
    [TestFixture]
    public class FloatUtilTest
    {
        [Test]
        public void 計算機イプシロンはfloatの最小表現値よりも大きいこと()
        {
            Assert.IsTrue(FloatUtil.MachineEpsilon > float.Epsilon);
        }

        [Test]
        public void Mathf_Floorが予想通りにならないケースでもFloorが正常に動作すること()
        {
            float expected = 1f;
            float f = 0.96f + 0.03f + 0.01f;

            Assert.IsFalse(Mathf.Approximately(expected, Mathf.Floor(f)));
            Assert.IsTrue(Mathf.Approximately(expected, FloatUtil.Floor(f)));
        }

        [Test]
        public void 整数をFloorしたときに元の値と近似すること()
        {
            float expected = 5f;
            float acutual = FloatUtil.Floor(expected);

            Assert.IsTrue(Mathf.Approximately(expected, acutual));
        }

        [Test]
        public void Mathf_Floorが予想通りにならないケースでもFloorToIntが正常に動作すること()
        {
            int expected = 1;
            float f = 0.96f + 0.03f + 0.01f;

            Assert.AreNotEqual(expected, Mathf.FloorToInt(f));
            Assert.AreEqual(expected, FloatUtil.FloorToInt(f));
        }

        [Test]
        public void 整数をFloorToIntしたときに元の値と一致すること()
        {
            int expected = 5;
            int acutual = FloatUtil.FloorToInt(expected);

            Assert.AreEqual(5, acutual);
        }

        [Test]
        public void Mathf_Ceilが予想通りにならないケースでもCeilが正常に動作すること()
        {
            float expected = 0f;
            float f = 1f - 0.96f - 0.03f - 0.01f;

            Assert.IsFalse(Mathf.Approximately(expected, Mathf.Ceil(f)));
            Assert.IsTrue(Mathf.Approximately(expected, FloatUtil.Ceil(f)));
        }

        [Test]
        public void 整数をCeilしたときに元の値と近似すること()
        {
            float expected = 5f;
            float acutual = FloatUtil.Ceil(expected);

            Assert.IsTrue(Mathf.Approximately(expected, acutual));
        }

        [Test]
        public void Mathf_Ceilが予想通りにならないケースでもCeilToIntが正常に動作すること()
        {
            int expected = 0;
            float f = 1f - 0.96f - 0.03f - 0.01f;

            Assert.AreNotEqual(expected, Mathf.CeilToInt(f));
            Assert.AreEqual(expected, FloatUtil.CeilToInt(f));
        }

        [Test]
        public void 整数をCeilToIntしたときに元の値と一致すること()
        {
            int expected = 5;
            int acutual = FloatUtil.CeilToInt(expected);

            Assert.AreEqual(5, acutual);
        }

        [Test]
        public void 等価演算子でtrueにならないケースでもApproximatelyがtrueになること()
        {
            float x = 1f;
            float y = 0.96f + 0.03f + 0.01f;

            Assert.IsFalse(x == y);
            Assert.IsTrue(FloatUtil.Approximately(x, y));
        }
    }
}
