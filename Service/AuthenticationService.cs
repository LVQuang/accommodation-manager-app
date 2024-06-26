﻿using System;
using System.Windows.Forms;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Util;


namespace AccommodationManagerApp.Service {
    public class AuthenticationService {
        public User CurrentUser { get; set; }
        private readonly UserService _userService;
        
        public AuthenticationService(UserService userService) {
            _userService = userService;
        }
        
        public bool Authenticate(string email, string password) {
            var user = _userService.GetUserByEmail(email);
            var result = user != null && user.Password == PasswordHelper.HashPassword(password);
            Console.WriteLine(PasswordHelper.HashPassword(password));
            if (result) {
                CurrentUser = user;
            }
            
            return result;
        }
        public void Logout()
        {
            CurrentUser = null;
        }
        
        public bool IsAuthenticated() {
            return CurrentUser != null;
        }
    }
}