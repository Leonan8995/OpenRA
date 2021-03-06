#region Copyright & License Information
/*
 * Copyright 2007-2012 The OpenRA Developers (see AUTHORS)
 * This file is part of OpenRA, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation. For more information,
 * see COPYING.
 */
#endregion

using System;
using System.Collections.Generic;
using OpenRA.Widgets;

namespace OpenRA.Mods.D2k.Widgets.Logic
{
	public class D2kInstallLogic
	{
		[ObjectCreator.UseCtor]
		public D2kInstallLogic(Widget widget, Dictionary<string,string> installData)
		{
			var panel = widget.Get("INSTALL_PANEL");
			var args = new WidgetArgs()
			{
				{ "afterInstall", () => { Ui.CloseWindow(); Game.Exit(); } },
				{ "installData", installData }
			};

			panel.Get<ButtonWidget>("DOWNLOAD_BUTTON").OnClick = () =>
				Ui.OpenWindow("INSTALL_DOWNLOAD_PANEL", args);

			panel.Get<ButtonWidget>("COPY_BUTTON").OnClick = () =>
				Ui.OpenWindow("INSTALL_FROMCD_PANEL", args);

			panel.Get<ButtonWidget>("EXTRACT_BUTTON").OnClick = () =>
				Ui.OpenWindow("EXTRACT_GAMEFILES_PANEL", args);

			panel.Get<ButtonWidget>("QUIT_BUTTON").OnClick = Game.Exit;
		}
	}
}
