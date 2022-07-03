using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Persistence.Data
{
    public static class CRUD : object
    {
        static CRUD()
        {

        }

        static DB.DatabaseContext databaseContext = null;

        public static void Create(string user , string pss , DateTime sub)
        {
            try
            {
                databaseContext = CFG.ConfigReader.ReadDB();
                Domain.User newuser = new Domain.User
                {
                    Username = user,
                    Password = pss,
                    Subscription = sub,
                    VolumeSerial = " "
                };

                databaseContext.Users.Add(newuser);

                databaseContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                }
            }
        }

        public static bool Login(string user , string pss)
        {
            try
            {
                databaseContext = CFG.ConfigReader.ReadDB();

                var users =
                    databaseContext.Users
                    .Where(current => current.Username == user && current.Password == pss)
                    .FirstOrDefault()
                    ;

                if (users!=null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                }
            }
        }

        public static Domain.User GetUser(string user)
        {
            try
            {
                databaseContext = CFG.ConfigReader.ReadDB();

                var users =
                    databaseContext.Users
                    .Where(current => current.Username == user)
                    .FirstOrDefault()
                    ;

                return users;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                }
            }
        }

        public static List<Domain.User> Read()
        {
            var users
                = databaseContext.Users.ToList();
            return users;
        }

        public static Guid GetId(string user)
        {
            databaseContext = CFG.ConfigReader.ReadDB();

            var users =
                databaseContext.Users
                .Where(current => current.Username == user)
                .FirstOrDefault()
                ;

            return (users.Id);

        }

        public static DateTime GetSub(Guid id)
        {
            try
            {
                databaseContext = CFG.ConfigReader.ReadDB();

                var users =
                    databaseContext.Users
                    .Where(current => current.Id == id)
                    .FirstOrDefault()
                    ;

                return (users.Subscription);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                }
            }
        }

        public static string GetVS(Guid id)
        {
            try
            {
                databaseContext = CFG.ConfigReader.ReadDB();

                var users =
                    databaseContext.Users
                    .Where(current => current.Id == id)
                    .FirstOrDefault()
                    ;

                return (users.VolumeSerial);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                }
            }
        }

        public static void Delete(Guid id)
        {
            try
            {
                databaseContext = CFG.ConfigReader.ReadDB();

                var users =
                    databaseContext.Users
                    .Where(current => current.Id == id)
                    .FirstOrDefault()
                    ;

                databaseContext.Remove(users);

                databaseContext.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                }
            }
        }

        public static void UpdateVS(Guid id)
        {
            try
            {
                databaseContext = CFG.ConfigReader.ReadDB();

                var users =
                    databaseContext.Users
                    .Where(current => current.Id == id)
                    .FirstOrDefault()
                    ;

                users.VolumeSerial = GetVolumeSerial();

                databaseContext.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                }
            }
        }

        public static bool CheckVS(Guid id)
        {
            if(GetVS(id) == " ")
            {
                UpdateVS(id);
                return true;
            }
            else if (GetVolumeSerial() == GetVS(id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string GetVolumeSerial(char driveLetter = 'C')
        {
            try
            {
                using (ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + driveLetter + ":\""))
                {
                    if (disk == null)
                        return null;
                    disk.Get();
                    object diskObj = disk["VolumeSerialNumber"];
                    if (diskObj != null)
                        return diskObj.ToString();
                }
            }
            catch (System.Threading.ThreadAbortException)
            {
                throw;
            }
            catch (Exception ex)
            {
                Trace.TraceWarning("Failed to read DiskID\r\n" + ex.Message);
            }

            try
            {
                uint serialNum, serialNumLength, flags;
                StringBuilder volumename = new StringBuilder(256);
                StringBuilder fstype = new StringBuilder(256);

                bool ok = GetVolumeInformation(driveLetter.ToString() + ":\\", volumename, (uint)volumename.Capacity - 1, out serialNum, out serialNumLength, out flags, fstype, (uint)fstype.Capacity - 1);
                if (ok)
                {
                    return string.Format("{0:X4}{1:X4}", serialNum >> 16, serialNum & 0xFFFF);
                }
            }
            catch (System.Threading.ThreadAbortException)
            {
                throw;
            }
            catch (Exception ex2)
            {
                Trace.TraceWarning("Failed to read DiskID\r\n" + ex2.Message);
            }

            return null;

        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        static extern bool GetVolumeInformation(string Volume, StringBuilder VolumeName, uint VolumeNameSize, out uint SerialNumber, out uint SerialNumberLength, out uint flags, StringBuilder fs, uint fs_size);


    }
}
