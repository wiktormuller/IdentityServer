﻿using IdentityModel.Client;
using System.Threading.Tasks;

namespace WeatherMVC.Services
{
    public interface ITokenService
    {
        Task<TokenResponse> GetToken(string scope);
    }
}
