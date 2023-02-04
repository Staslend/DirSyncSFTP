﻿/*
    DirSyncSFTP
    Copyright (C) 2023  Raphael Beck

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/

namespace DirSyncSFTP;

public class SynchronizedDirectory
{
    public string LocalDirectory { get; set; }
    public string RemoteDirectory { get; set; }
    public string SshKeyFilePath { get; set; }
    public string SshKeyPassphrase { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Host { get; set; }
    public ushort Port { get; set; }

    public string GetDictionaryKey()
    {
        return $"{LocalDirectory}:{RemoteDirectory}";
    }
}