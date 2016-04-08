/****NOTICE: DO NOT REMOVE
 * Credits go to Artex for helping me fix Path issues and
 * contributing his code.
 ****NOTICE: DO NOT REMOVE.*
*Log Header
 *Format: (date,Version) AuthorName, Changes.
 * (Mar 12,2014,0.2.12) Gerolkae, Adapted Paths to work with a Supplied path
*/
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace Furcadia.IO
{
	/// <summary>
	/// Contains functions for getting some base paths related to Furcadia.
	/// </summary>
	public class Paths
	{
        public Paths()
        {
            _installpath = null;
        }
        public Paths(string path)
        {
            _installpath = path;
        }

        private string _FurcadiaCharactersPath = null;


        /// <summary>
        /// Gets the location of the Furcadia Character Files
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> containing the location of Furcadia Characters folder in "My Documents".
        /// </returns>
        public string GetFurcadiaCharactersPath()
        {
            if (!String.IsNullOrEmpty(_FurcadiaCharactersPath)) return _FurcadiaCharactersPath;
            string path = System.IO.Path.Combine(GetFurcadiaDocPath(),"Furcadia Characters");
            if (!System.IO.Directory.Exists(path))
                path = GetFurcadiaDocPath();
            if (Directory.Exists(path))
            {
                _FurcadiaCharactersPath = path;
                return _FurcadiaCharactersPath;
            }
            return null;
          //  throw new DirectoryNotFoundException("Furcadia Characters path not found.\n" + path);
        }


		private  string _FurcadiaDocpath;
		/// <summary>
		/// Gets the location of the Furcadia folder located in "My Documents"
		/// </summary>
		/// <returns>
		/// A <see cref="System.String"/> containing the location of Furcadia folder in "My Documents".
		/// </returns>
		public  string GetFurcadiaDocPath()
		{
			if (!String.IsNullOrEmpty(_FurcadiaDocpath)) return _FurcadiaDocpath;
			string path = GetLocaldirPath();
			if (String.IsNullOrEmpty(path))
				path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
									"Furcadia");

			if (Directory.Exists(path))
			{
				_FurcadiaDocpath = path;
				return _FurcadiaDocpath;
			}
			return null;
			//throw new DirectoryNotFoundException("Furcadia documents path not found.\n" + path);
		}

		/// <summary>
		/// Determines the registry path by platform. (x32/x64)
		/// Thanks to Ioka for this one.
		/// </summary>
		/// <returns>
		/// A path to the Furcadia registry folder or NullReferenceException.
		/// </returns>
		public  string GetRegistryPath()
		{
             if( 8 == IntPtr.Size 
        || (!String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))))
			{
				return @"SOFTWARE\Wow6432Node\Dragon's Eye Productions\Furcadia\";
			}
			else
			{
				return @"SOFTWARE\Dragon's Eye Productions\Furcadia\";
			}
		}
static string ProgramFilesx86()
{
    if( 8 == IntPtr.Size 
        || (!String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))))
    {
        return Environment.GetEnvironmentVariable("ProgramFiles(x86)");
    }

    return Environment.GetEnvironmentVariable("ProgramFiles");
}

        //public  string InstallPath
        //{
        //    set { _installpath = value; }
        //}



		private  string _installpath;
		/// <summary>
		/// Find the path to Furcadia data files currently installed on this
		/// system.
		/// </summary>
		/// <returns>Path to the Furcadia program folder or null if not found/not installed.</returns>
		public  string GetInstallPath()
		{
			//If path already found return it.
			if (!string.IsNullOrEmpty(_installpath)) return _installpath;
			string path = null;

			// Checking registry for a path (WINDOWS ONLY)
			if (Environment.OSVersion.Platform == PlatformID.Win32Windows ||
				Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				RegistryKey regkey = Registry.LocalMachine;
				try
				{
					regkey = regkey.OpenSubKey(GetRegistryPath() + "Programs", false);
					path = regkey.GetValue("path").ToString();
					regkey.Close();
					if (System.IO.Directory.Exists(path))
					{
						_installpath = path;
						return _installpath; // Path found
					}
				}
				catch
				{
				}

				// Making a guess from the FurcadiaDefaultPath property.
				path = Path.Combine(ProgramFilesx86(), "Furcadia");
			}
			// Scanning registry for a path (NON-WINDOWS ONLY)
			else
			{
				path = RegistryExplorerForWine.ReadSubKey("\\HKEY_LOCAL_MACHINE\\" + GetRegistryPath().Replace("\\", "/") + "Programs", "Path");
				if (path == null)
					path = RegistryExplorerForWine.ReadSubKey("\\HKEY_CURRENT_USER\\" + GetRegistryPath().Replace("\\", "/") + "Programs", "Path");
			}
			if (System.IO.Directory.Exists(path))
			{
				_installpath = path;
				return _installpath; // Path found
			}
			// All options were exhausted - assume Furcadia not installed.
			return null;
			//throw new DirectoryNotFoundException("Furcadia Install path not found." + "\n" + path);
		}

		private  string _defaultpatchpath;
		/// <summary>
		/// Find the path to the default patch folder on the current machine.
		/// </summary>
		/// <returns>Path to the default patch folder or null if not found.</returns>
		public  string GetDefaultPatchPath()
		{
			//If path already found return it.
			if (!string.IsNullOrEmpty(_defaultpatchpath)) return _defaultpatchpath;
			string path;

			// Checking registry for a path first of all.
			if (Environment.OSVersion.Platform == PlatformID.Win32Windows ||
				Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				RegistryKey regkey = Registry.LocalMachine;
				try
				{
					regkey = regkey.OpenSubKey(GetRegistryPath() + "Patches", false);
					path = regkey.GetValue("default").ToString();
					regkey.Close();
					if (System.IO.Directory.Exists(path))
					{
						_defaultpatchpath = path;
						return _defaultpatchpath; // Path found
					}
				}
				catch
				{ //NullReference Exception = regkey not found.
				}

				// Making a guess from the FurcadiaPath or FurcadiaDefaultPath property.
				path = GetInstallPath();
				if (path == string.Empty)
					path = Path.Combine(ProgramFilesx86(), "Furcadia");

				path = Path.Combine(path, "/patches/default");
			}
			else
			{
				path = RegistryExplorerForWine.ReadSubKey("HKEY_LOCAL_MACHINE\\" + GetRegistryPath() + "Patches", "default");
			}
			if (System.IO.Directory.Exists(path))
			{
				_defaultpatchpath = path;
				return _defaultpatchpath; // Path found
			}

			// All options were exhausted - assume Furcadia not installed.
			return null;
			//throw new DirectoryNotFoundException("Furcadia Install path not found.");
		}

		private  string _localsettingspath;
		/// <summary>
		/// Get the path to the Local Settings directory for Furcadia.
		/// </summary>
		/// <returns>Furcadia local settings directory.</returns>
		public  string GetLocalSettingsPath()
		{
            if (!string.IsNullOrEmpty(_localsettingspath)) return _localsettingspath;
            else _localsettingspath = GetLocaldirPath() + "settings/";
            if (String.IsNullOrEmpty(GetLocaldirPath()))
				_localsettingspath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
												  "Dragon's Eye Productions/Furcadia");
			return _localsettingspath;
		}

		private  string _cachepath;
		/// <summary>
		/// Get the All Users Application Data path for Furcadia.
		/// </summary>
		/// <returns>All Users Application Data path for Furcadia.</returns>
		public  string GetCachePath()
		{
			if (!String.IsNullOrEmpty(_cachepath)) return _cachepath;
			else _cachepath = GetLocaldirPath();
			if (String.IsNullOrEmpty(_cachepath))
				_cachepath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
										  "Dragon's Eye Productions/Furcadia");
			return _cachepath;
		}

		private  string _dynavpath;
		/// <summary>
		/// Get the All Dynamic Avatar path for Furcadia.
		/// </summary>
		/// <returns>All Dynamic Avatar path for Furcadia.</returns>
		public  string GetDynAvatarPath()
		{
            if (!String.IsNullOrEmpty(_dynavpath)) return _dynavpath;
            else _dynavpath = GetLocaldirPath();
            if (String.IsNullOrEmpty(_dynavpath))
                _dynavpath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
										  "Dragon's Eye Productions/Furcadia/Dynamic Avatars");
            return _dynavpath;
		}

		private  string _localdirpath;
		/// <summary>
		/// Find the current localdir path where data files would be stored
		/// on the current machine.
		/// </summary>
		/// <returns>Path to the data folder from localdir.ini or null if not found.</returns>
		public  string GetLocaldirPath()
		{
			if (!string.IsNullOrEmpty(_localdirpath)) return _localdirpath;
			string path;
			string install_path = GetInstallPath();

			// If we can't find Furc, we won't find localdir.ini
			if (install_path == null)
				return null; // Furcadia install path not found.

			// Try to locate localdir.ini
			string ini_path = String.Format("{0}/localdir.ini", install_path);
			if (!System.IO.File.Exists(ini_path))
				return null; // localdir.ini not found - regular path structure applies.

			// Read localdir.ini for remote path and verify it.
			StreamReader sr = new StreamReader(ini_path);
			path = sr.ReadLine();
            if (!string.IsNullOrEmpty(path))
                path.Trim();
			sr.Close();
            if (String.IsNullOrEmpty(path))
                path = install_path;
			if (!System.IO.Directory.Exists(path))
				throw new DirectoryNotFoundException("Path not found in localdir.ini"); // localdir.ini found, but the path in it is missing.
			_localdirpath = path;
			return _localdirpath; // Localdir path found!
		}


  

	}



}
