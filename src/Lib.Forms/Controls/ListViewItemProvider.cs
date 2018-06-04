// <eddie_source_header>
// This file is part of Eddie/AirVPN software.
// Copyright (C)2014-2016 AirVPN (support@airvpn.org) / https://airvpn.org
//
// Eddie is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Eddie is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with Eddie. If not, see <http://www.gnu.org/licenses/>.
// </eddie_source_header>

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Eddie.Core;

namespace Eddie.Forms.Controls
{
    public class ListViewItemProvider : ListViewItem
    {
		public Core.Provider Provider;	
		
		public void Update()
		{
			SubItems.Clear();

			Text = Provider.Title;
			if (Provider.Enabled)
				ImageKey = "on";
			else
				ImageKey = "off";

			SubItems.Add(Provider.DefinitionTitle);
			SubItems.Add(Provider.DefinitionSubTitle);
			SubItems.Add(Provider.DefinitionHref);
			if (Provider is Core.Providers.OpenVPN)
				SubItems.Add((Provider as Core.Providers.OpenVPN).Path);			
		}
	}
}