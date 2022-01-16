using BoilerPlateMvc.Debugging;

namespace BoilerPlateMvc
{
    public class BoilerPlateMvcConsts
    {
        public const string LocalizationSourceName = "BoilerPlateMvc";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "6916477d51b849339255062a513d5f22";
    }
}
