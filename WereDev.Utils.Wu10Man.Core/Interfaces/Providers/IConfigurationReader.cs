﻿namespace WereDev.Utils.Wu10Man.Core.Interfaces.Providers
{
    public interface IConfigurationReader
    {
        string[] GetWindowsUpdateHosts();

        string[] GetWindowsServices();
    }
}
