using UnityEngine;

namespace HassakuLab.Numerics
{
    /// <summary>
    /// �ۂߌ덷���l������Float���Z���[�e�B���e�B
    /// </summary>
    public static class FloatUtil
    {
        /// <summary>
        /// �v�Z�@�C�v�V����
        /// </summary>
        public const float MachineEpsilon = 1e-6f;

        /// <summary>
        /// �����_�ȉ���؂艺����
        /// </summary>
        /// <param name="f">�Ώۂ̒l</param>
        /// <returns>�؂艺����ꂽ�l</returns>
        public static float Floor(float f) => Mathf.Floor(f + MachineEpsilon);

        /// <summary>
        /// �����_�ȉ���؂艺����int�^�ɕϊ�����
        /// </summary>
        /// <param name="f">�Ώۂ̒l</param>
        /// <returns>�؂艺����ꂽ�l(int�^)</returns>
        public static int FloorToInt(float f) => Mathf.FloorToInt(f + MachineEpsilon);

        /// <summary>
        /// �����_�ȉ���؂�グ��
        /// </summary>
        /// <param name="f">�Ώۂ̒l</param>
        /// <returns>�؂�グ��ꂽ�l</returns>
        public static float Ceil(float f) => Mathf.Ceil(f - MachineEpsilon);

        /// <summary>
        /// �����_�ȉ���؂�グ��int�^�ɕϊ�����
        /// </summary>
        /// <param name="f">�Ώۂ̒l</param>
        /// <returns>�؂�グ��ꂽ�l(int�^)</returns>
        public static int CeilToInt(float f) => Mathf.CeilToInt(f - MachineEpsilon);

        /// <summary>
        /// a��b���ߎ����Ă��邩
        /// </summary>
        /// <param name="a">��r����l</param>
        /// <param name="b">��r����l</param>
        /// <returns>a��b�Ȃ�true, �����łȂ��Ȃ�false</returns>
        public static bool Approximately(float a, float b) => Mathf.Abs(b - a) < MachineEpsilon;

        /// <summary>
        /// a > b�ł��邩���擾����
        /// </summary>
        /// <param name="a">��r����l</param>
        /// <param name="b">��r����l</param>
        /// <returns>a > b�Ȃ�true, �����łȂ��Ȃ�false</returns>
        public static bool GreaterThan(float a, float b) => a > b + MachineEpsilon;

        /// <summary>
        /// a >= b�ł��邩���擾����
        /// </summary>
        /// <param name="a">��r����l</param>
        /// <param name="b">��r����l</param>
        /// <returns>a >= b�Ȃ�true, �����łȂ��Ȃ�false</returns>
        public static bool GreaterThanOrEqual(float a, float b) => a > b - MachineEpsilon;

        /// <summary>
        /// a < b�ł��邩���擾����
        /// </summary>
        /// <param name="a">��r����l</param>
        /// <param name="b">��r����l</param>
        /// <returns>a < b�Ȃ�ture, �����łȂ��Ȃ�false</returns>
        public static bool LessThan(float a, float b) => a < b - MachineEpsilon;

        /// <summary>
        /// a <= b�ł��邩���擾����
        /// </summary>
        /// <param name="a">��r����l</param>
        /// <param name="b">��r����l</param>
        /// <returns>a <= b�Ȃ�true, �����łȂ��Ȃ�false</returns>
        public static bool LessThanOrEqual(float a, float b) => a < b + MachineEpsilon;
    }
}
