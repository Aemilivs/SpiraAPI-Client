﻿namespace SpiraAPI.Client.Middleware
{
    /// <summary>
    /// RSA Token should be provided in a format of GIUD e.g. xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx
    /// </summary>
    public interface ISpiraCredentials
    {
        string Username { get; }
        string RsaToken { get; }
    }
}
