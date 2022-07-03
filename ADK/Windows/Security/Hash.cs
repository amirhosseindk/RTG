using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADK.Windows.Security
{
    public static class Hash
    {
        public static string GetSha1(string value)
        {
            if (value == null)
            {
                return (string.Empty);
            }

            value = value.Trim();
            if (value == string.Empty)
            {
                return (string.Empty);
            }

            try
            {
                System.Security.Cryptography.SHA1 oHash =
                    System.Security.Cryptography.SHA1.Create();

                byte[] bytInputs =
                    System.Text.Encoding.ASCII.GetBytes(value);

                byte[] bytHashes = oHash.ComputeHash(bytInputs);

                // Convert the byte array to hexadecimal string
                System.Text.StringBuilder oStringBuilder =
                    new System.Text.StringBuilder();

                for (int intIndex = 0; intIndex < bytHashes.Length; intIndex++)
                {
                    oStringBuilder.Append(bytHashes[intIndex].ToString("X2"));

                    // To force the hex string to lower-case letters instead of
                    // upper-case, use he following line instead:
                    // sb.Append(hashBytes[i].ToString("x2")); 
                }

                return (oStringBuilder.ToString());

                //return (System.Web.Security.FormsAuthentication
                //	.HashPasswordForStoringInConfigFile(value, "SHA1"));
            }
            catch
            {
                return (string.Empty);
            }
        }
    }
}
