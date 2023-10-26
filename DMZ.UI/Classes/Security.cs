using System.Configuration;
using System.Windows.Forms;

namespace DMZ.UI.Classes
{
    public class Security
    {
        public static void ProtectConnectionString()
        {
            ToggleConnectionStringProtection(Application.ExecutablePath, true);
        }

        public static void UnprotectConnectionString()
        {
            ToggleConnectionStringProtection(Application.ExecutablePath, false);
        }
        private static void ToggleConnectionStringProtection (string pathName, bool protect)
        {
            // Define the Dpapi provider name.
            var strProvider = "DataProtectionConfigurationProvider";
            // string strProvider = "RSAProtectedConfigurationProvider";

            Configuration oConfiguration;
            ConnectionStringsSection oSection;

            try
            {
                // Open the configuration file and retrieve 
	            // the connectionStrings section.

                // For Web!
                // oConfiguration = System.Web.Configuration.
	            //WebConfigurationManager.OpenWebConfiguration("~");

                // For Windows!
                // Takes the executable file name without the config extension.
                oConfiguration = ConfigurationManager.OpenExeConfiguration(pathName);
                var blnChanged = false;
                oSection = oConfiguration.GetSection("connectionStrings") as ConnectionStringsSection;
                if (oSection == null) return;
                if (!oSection.ElementInformation.IsLocked && !oSection.SectionInformation.IsLocked)
                {
                    if (protect)
                    {
                        if (!oSection.SectionInformation.IsProtected)
                        {
                            blnChanged = true;

                            // Encrypt the section.
                            oSection.SectionInformation.ProtectSection
                                (strProvider);
                        }
                    }
                    else
                    {
                        if (oSection.SectionInformation.IsProtected)
                        {
                            blnChanged = true;

                            // Remove encryption.
                            oSection.SectionInformation.UnprotectSection();
                        }
                    }
                }

                if (blnChanged)
                {
                    // Indicates whether the associated configuration section 
                    // will be saved even if it has not been modified.
                    oSection.SectionInformation.ForceSave = true;

                    // Save the current configuration.
                    oConfiguration.Save();
                }
            }
            catch (System.Exception ex)
            {
                throw (ex);
            }
        }
    }
}
