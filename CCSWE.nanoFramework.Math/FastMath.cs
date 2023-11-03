namespace CCSWE.nanoFramework
{
    /// <summary>
    /// Provides constants and static methods for trigonometric, logarithmic, and other common mathematical functions.
    /// </summary>
    /// <remarks>
    /// In some cases IEEE 754:2019 compliance has been sacrificed in order to achieve higher performance.
    /// If IEEE 754:2019 compliance is important to your use case then you should check out <see cref="CCSWE.nanoFramework.Math"/>
    /// which delegates to <see cref="System.Math"/> unless I have a faster variant that hasn't been accepted into
    /// the core library yet.</remarks>
    public static partial class FastMath
    {
        /// <inheritdoc cref="Math.PI"/>
        public const double PI = Math.PI;

        /// <inheritdoc cref="Math.E"/>
        public const double E = Math.E;
    }
}
