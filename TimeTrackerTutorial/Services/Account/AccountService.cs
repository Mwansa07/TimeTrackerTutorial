﻿using System;
using System.Threading.Tasks;

namespace TimeTrackerTutorial.Services.Account
{
    public class AccountService : IAccountService
    {
        public AccountService()
        {
        }

        public Task<bool> LoginAsync(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return Task.FromResult(false);
            }
            return Task.Delay(1000).ContinueWith((task) => true);
        }
    }
}