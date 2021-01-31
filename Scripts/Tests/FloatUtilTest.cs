using NUnit.Framework;
using UnityEngine;

namespace HassakuLab.Numerics.Tests
{
    [TestFixture]
    public class FloatUtilTest
    {
        [Test]
        public void �v�Z�@�C�v�V������float�̍ŏ��\���l�����傫������()
        {
            Assert.IsTrue(FloatUtil.MachineEpsilon > float.Epsilon);
        }

        [Test]
        public void Mathf_Floor���\�z�ʂ�ɂȂ�Ȃ��P�[�X�ł�Floor������ɓ��삷�邱��()
        {
            float expected = 1f;
            float f = 0.96f + 0.03f + 0.01f;

            Assert.IsFalse(Mathf.Approximately(expected, Mathf.Floor(f)));
            Assert.IsTrue(Mathf.Approximately(expected, FloatUtil.Floor(f)));
        }

        [Test]
        public void ������Floor�����Ƃ��Ɍ��̒l�Ƌߎ����邱��()
        {
            float expected = 5f;
            float acutual = FloatUtil.Floor(expected);

            Assert.IsTrue(Mathf.Approximately(expected, acutual));
        }

        [Test]
        public void Mathf_Floor���\�z�ʂ�ɂȂ�Ȃ��P�[�X�ł�FloorToInt������ɓ��삷�邱��()
        {
            int expected = 1;
            float f = 0.96f + 0.03f + 0.01f;

            Assert.AreNotEqual(expected, Mathf.FloorToInt(f));
            Assert.AreEqual(expected, FloatUtil.FloorToInt(f));
        }

        [Test]
        public void ������FloorToInt�����Ƃ��Ɍ��̒l�ƈ�v���邱��()
        {
            int expected = 5;
            int acutual = FloatUtil.FloorToInt(expected);

            Assert.AreEqual(5, acutual);
        }

        [Test]
        public void Mathf_Ceil���\�z�ʂ�ɂȂ�Ȃ��P�[�X�ł�Ceil������ɓ��삷�邱��()
        {
            float expected = 0f;
            float f = 1f - 0.96f - 0.03f - 0.01f;

            Assert.IsFalse(Mathf.Approximately(expected, Mathf.Ceil(f)));
            Assert.IsTrue(Mathf.Approximately(expected, FloatUtil.Ceil(f)));
        }

        [Test]
        public void ������Ceil�����Ƃ��Ɍ��̒l�Ƌߎ����邱��()
        {
            float expected = 5f;
            float acutual = FloatUtil.Ceil(expected);

            Assert.IsTrue(Mathf.Approximately(expected, acutual));
        }

        [Test]
        public void Mathf_Ceil���\�z�ʂ�ɂȂ�Ȃ��P�[�X�ł�CeilToInt������ɓ��삷�邱��()
        {
            int expected = 0;
            float f = 1f - 0.96f - 0.03f - 0.01f;

            Assert.AreNotEqual(expected, Mathf.CeilToInt(f));
            Assert.AreEqual(expected, FloatUtil.CeilToInt(f));
        }

        [Test]
        public void ������CeilToInt�����Ƃ��Ɍ��̒l�ƈ�v���邱��()
        {
            int expected = 5;
            int acutual = FloatUtil.CeilToInt(expected);

            Assert.AreEqual(5, acutual);
        }

        [Test]
        public void �������Z�q��true�ɂȂ�Ȃ��P�[�X�ł�Approximately��true�ɂȂ邱��()
        {
            float x = 1f;
            float y = 0.96f + 0.03f + 0.01f;

            Assert.IsFalse(x == y);
            Assert.IsTrue(FloatUtil.Approximately(x, y));
        }
    }
}
