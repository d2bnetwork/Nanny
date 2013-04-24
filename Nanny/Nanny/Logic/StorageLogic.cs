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

		Dictionary<string,string> _Settings = new Dictionary<string, string>();

		public Dictionary<string,string> Settings
		{
			get
			{
				//TODO cargar desde isolate storage
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
						//_Settings.Add(values[0], values[]
					}
				}
				return _Settings;
			}
		}

		void SaveStorageSettings ()
		{
			//guardar los settings en storage
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

