using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.IO;

namespace Nanny
{
	public class StorageLogic
	{
		private string c_SettingsFileName ="Settings.txt";

		private static StorageLogic _Instance;
		private StorageLogic ()
		{
		}
		
		public static StorageLogic Instance 
		{
			get
			{
				if(_Instance == null)
					_Instance = new StorageLogic();
				return _Instance;
			}
		}

		Dictionary<string,string> _Settings;

		public Dictionary<string,string> Settings
		{
			get
			{
				if(_Settings!=null)
					return _Settings;

				IsolatedStorageFile isoStore= IsolatedStorageFile.GetStore(IsolatedStorageScope.Application, null,null);
				_Settings = new Dictionary<string, string>();
				if(isoStore.FileExists(c_SettingsFileName))
				{
					StreamReader reader = new StreamReader(isoStore.OpenFile(c_SettingsFileName, System.IO.FileMode.Open));
					string fileContent = reader.ReadToEnd();
					reader.Close();


					foreach (var line in fileContent.Split('\n')) 
					{
						var values = line.Split(';');
						string key = values[0].Replace("#n#", "\n").Replace("#,#", ";");
						string val = values[1].Replace("#n#", "\n").Replace("#,#", ";");
						_Settings.Add(key, val);
					}
				}
				return _Settings;
			}
		}

		void SaveStorageSettings ()
		{
			//guardar los settings en storage
			string fileContent = "";
			foreach (var item in _Settings) {
				fileContent += item.Key.Replace("\n", "#n#").Replace(";", "#,#") + ";" +item.Value.Replace("\n", "#n#").Replace(";", "#,#") + "\n";
			}
			IsolatedStorageFile isoStore= IsolatedStorageFile.GetStore(IsolatedStorageScope.Application, null,null);
			StreamWriter writer = new StreamWriter(isoStore.OpenFile(c_SettingsFileName, FileMode.OpenOrCreate));
			writer.Write(fileContent);
			writer.Close();
		}

		public void SaveSetting(string key, string val)
		{
			if(!Settings.ContainsKey(key))
				Settings.Add(key,val);
			else
				Settings[key] = val;
			SaveStorageSettings();
		}

	}
}

