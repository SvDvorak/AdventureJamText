using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Zifmia.FyreVM.Service;

namespace Assets.Code
{
	public class GlulxStateService
	{
		#region Singleton Pattern
		protected static GlulxStateService _instance;

		public static GlulxStateService Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new GlulxStateService();
				}

				return _instance;
			}
		}
		#endregion

		public event Action<string> UpdatedMainState;

		private EngineWrapper _fyreVmWrapper;
		public string CurrentMainText { get; private set; }

		public void LoadGlulxData(object data)
		{
			if (data == null)
			{
				return;
			}

			var ulxFile = data as TextAsset;
			if (ulxFile == null)
			{
				return;
			}

			var buffer = ulxFile.bytes;

			_fyreVmWrapper = new EngineWrapper(buffer);
		}

		public void InitialScene()
		{
			Perform("look");
		}

		public void Perform(string text)
		{
			_fyreVmWrapper.SendCommand(text);

			CurrentMainText = _fyreVmWrapper.FromHash("MAIN");
            SendMainStateChanged();
        }

		private void SendMainStateChanged()
		{
			if (UpdatedMainState != null)
			{
				UpdatedMainState(CurrentMainText);
			}
		}
	}
}
