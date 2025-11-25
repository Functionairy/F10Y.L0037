using System;


namespace F10Y.L0037
{
    public class OverloadTokens : IOverloadTokens
    {
        #region Infrastructure

        public static IOverloadTokens Instance { get; } = new OverloadTokens();


        private OverloadTokens()
        {
        }

        #endregion
    }
}
