/*Copyright 2011 Arash Norouzi

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

﻿using System.Collections.Generic;

namespace MoonAPNS
{
	/// <summary>
	/// Alert Portion of the Notification Payload
	/// </summary>
	public class NotificationAlert
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public NotificationAlert()
		{
			Body = null;
			ActionLocalizedKey = null;
			LocalizedKey = null;
			LocalizedArgs = new List<object>();
		}

		/// <summary>
		/// Body Text of the Notification's Alert
		/// </summary>
		public string Body
		{
			get;
			set;
		}

		/// <summary>
		/// Action Button's Localized Key
		/// </summary>
		public string ActionLocalizedKey
		{
			get;
			set;
		}

		/// <summary>
		/// Localized Key
		/// </summary>
		public string LocalizedKey
		{
			get;
			set;
		}

		/// <summary>
		/// Localized Argument List
		/// </summary>
		public List<object> LocalizedArgs
		{
			get;
			set;
		}

		public void AddLocalizedArgs(params object[] values)
		{
			this.LocalizedArgs.AddRange(values);
		}

		/// <summary>
		/// Determines if the Alert is empty and should be excluded from the Notification Payload
		/// </summary>
		public bool IsEmpty
		{
			get
			{
				if (!string.IsNullOrEmpty(Body)
					|| !string.IsNullOrEmpty(ActionLocalizedKey)
					|| !string.IsNullOrEmpty(LocalizedKey)
					|| (LocalizedArgs != null && LocalizedArgs.Count > 0))
					return false;
				else
					return true;
			}
		}
	}
}
