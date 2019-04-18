﻿using System.Threading.Tasks;

namespace SpiraAPI.Client.Connection
{
    internal interface ISpiraConnection
    {
        string ServiceUrl { get; }

        TOutput Get<TOutput>(string endpoint);
        Task<TOutput> GetAsync<TOutput>(string endpoint);
        TOutput Post<TInput, TOutput>(string endpoint, TInput data);
        Task<TOutput> PostAsync<TInput, TOutput>(string endpoint, TInput data);
        TOutput Put<TInput, TOutput>(string endpoint, TInput data);
        Task<TOutput> PutAsync<TInput, TOutput>(string endpoint, TInput data);
        TOutput Delete<TOutput>(string endpoint);
        Task<TOutput> DeleteAsync<TOutput>(string endpoint);
    }
}
