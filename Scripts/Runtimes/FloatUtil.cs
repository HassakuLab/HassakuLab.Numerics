using UnityEngine;

namespace HassakuLab.Numerics
{
    /// <summary>
    /// 丸め誤差を考慮したFloat演算ユーティリティ
    /// </summary>
    public static class FloatUtil
    {
        /// <summary>
        /// 計算機イプシロン
        /// </summary>
        public const float MachineEpsilon = 1e-6f;

        /// <summary>
        /// 小数点以下を切り下げる
        /// </summary>
        /// <param name="f">対象の値</param>
        /// <returns>切り下げられた値</returns>
        public static float Floor(float f) => Mathf.Floor(f + MachineEpsilon);

        /// <summary>
        /// 小数点以下を切り下げてint型に変換する
        /// </summary>
        /// <param name="f">対象の値</param>
        /// <returns>切り下げられた値(int型)</returns>
        public static int FloorToInt(float f) => Mathf.FloorToInt(f + MachineEpsilon);

        /// <summary>
        /// 小数点以下を切り上げる
        /// </summary>
        /// <param name="f">対象の値</param>
        /// <returns>切り上げられた値</returns>
        public static float Ceil(float f) => Mathf.Ceil(f - MachineEpsilon);

        /// <summary>
        /// 小数点以下を切り上げてint型に変換する
        /// </summary>
        /// <param name="f">対象の値</param>
        /// <returns>切り上げられた値(int型)</returns>
        public static int CeilToInt(float f) => Mathf.CeilToInt(f - MachineEpsilon);

        /// <summary>
        /// aとbが近似しているか
        /// </summary>
        /// <param name="a">比較する値</param>
        /// <param name="b">比較する値</param>
        /// <returns>a≒bならtrue, そうでないならfalse</returns>
        public static bool Approximately(float a, float b) => Mathf.Abs(b - a) < MachineEpsilon;

        /// <summary>
        /// a > bであるかを取得する
        /// </summary>
        /// <param name="a">比較する値</param>
        /// <param name="b">比較する値</param>
        /// <returns>a > bならtrue, そうでないならfalse</returns>
        public static bool GreaterThan(float a, float b) => a > b + MachineEpsilon;

        /// <summary>
        /// a >= bであるかを取得する
        /// </summary>
        /// <param name="a">比較する値</param>
        /// <param name="b">比較する値</param>
        /// <returns>a >= bならtrue, そうでないならfalse</returns>
        public static bool GreaterThanOrEqual(float a, float b) => a > b - MachineEpsilon;

        /// <summary>
        /// a < bであるかを取得する
        /// </summary>
        /// <param name="a">比較する値</param>
        /// <param name="b">比較する値</param>
        /// <returns>a < bならture, そうでないならfalse</returns>
        public static bool LessThan(float a, float b) => a < b - MachineEpsilon;

        /// <summary>
        /// a <= bであるかを取得する
        /// </summary>
        /// <param name="a">比較する値</param>
        /// <param name="b">比較する値</param>
        /// <returns>a <= bならtrue, そうでないならfalse</returns>
        public static bool LessThanOrEqual(float a, float b) => a < b + MachineEpsilon;
    }
}
