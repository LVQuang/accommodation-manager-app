﻿using System.Security.Cryptography;
using System.Text;

namespace AccommodationManagerApp.Util {
    public static class PasswordHelper {
        public static string HashPassword(string password) {
            using (var sha256Hash = SHA256.Create()) {
                var bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                var builder = new StringBuilder();
                for (var i = 0; i < bytes.Length; i++) {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}