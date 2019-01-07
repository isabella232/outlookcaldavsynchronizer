// This file is Part of CalDavSynchronizer (http://outlookcaldavsynchronizer.sourceforge.net/)
// Copyright (c) 2015 Gerhard Zehetbauer
// Copyright (c) 2015 Alexander Nimmervoll
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;

namespace CalDavSynchronizer
{
  public static class WebResourceUrls
  {
    public static Uri GlobalOptionsFile => new Uri ("https://github.com/snapappointments/outlookcaldavsynchronizer/raw/snap-caldav/GlobalOptions.xml");
    public static Uri SiteContainingCurrentVersion => new Uri ("https://github.com/snapappointments/outlookcaldavsynchronizer/releases/latest/");
    public static Uri LatestVersionZipFile => new Uri ("https://github.com/snapappointments/outlookcaldavsynchronizer/releases/download/$LATEST_TAG/SnapAppointmentsOutlookSync-$LATEST_VERSION.exe");
    public static Uri ReadMeFile => new Uri ("https://github.com/snapappointments/outlookcaldavsynchronizer/raw/snap-caldav/README.md");
    public static Uri ReadMeFileDownloadSite => new Uri ("https://github.com/snapappointments/outlookcaldavsynchronizer/raw/snap-caldav/README.md");
    public static Uri HelpSite => new Uri ("http://caldavsynchronizer.org/documentation/");
    public static Uri DonationSite => new Uri("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=PWA2N6P5WRSJJ&lc=US");
    public static Uri ProjectHomeSite => new Uri("http://caldavsynchronizer.org/");
  }
}