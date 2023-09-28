
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;
using System;
using System.IO;
using System.Threading.Tasks;
using Blazored.FluentValidation;
using Synaplic.UniRH.Client.Infrastructure.ApiClients;
using System.Text.RegularExpressions;

namespace MudBlazorApp.Client.Pages.Identity
{
    public partial class Account
    {
        public string AvatarImageLink { get; set; } = "images/avatar_jonny.jpg";
        public string AvatarIcon { get; set; }
        public string AvatarButtonText { get; set; } = "Delete Picture";
        public Color AvatarButtonColor { get; set; } = Color.Error;
        public string FirstName { get; set; } = "Jonny";
        public string LastName { get; set; } = "Larsson";
        public string JobTitle { get; set; } = "IT Consultant";
        public string Email { get; set; } = "Youcanprobably@findout.com";
        public bool FriendSwitch { get; set; } = true;
        public bool NotificationEmail_1 { get; set; } = true;
        public bool NotificationEmail_2 { get; set; }
        public bool NotificationEmail_3 { get; set; }
        public bool NotificationEmail_4 { get; set; } = true;
        public bool NotificationChat_1 { get; set; }
        public bool NotificationChat_2 { get; set; } = true;
        public bool NotificationChat_3 { get; set; } = true;
        public bool NotificationChat_4 { get; set; }

        void DeletePicture()
        {
            if (!String.IsNullOrEmpty(AvatarImageLink))
            {
                AvatarImageLink = null;
                AvatarIcon = Icons.Material.Outlined.SentimentVeryDissatisfied;
                AvatarButtonText = "Upload Picture";
                AvatarButtonColor = Color.Primary;
            }
            else
            {
                return;
            }
        }

        void SaveChanges(string message, Severity severity)
        {
            Snackbar.Add(message, severity, config =>
            {
                config.ShowCloseIcon = false;
            });
        }

        MudForm form;
        MudTextField<string> pwField1;

        private IEnumerable<string> PasswordStrength(string pw)
        {
            if (string.IsNullOrWhiteSpace(pw))
            {
                yield return "Password is required!";
                yield break;
            }
            if (pw.Length < 8)
                yield return "Password must be at least of length 8";
            if (!Regex.IsMatch(pw, @"[A-Z]"))
                yield return "Password must contain at least one capital letter";
            if (!Regex.IsMatch(pw, @"[a-z]"))
                yield return "Password must contain at least one lowercase letter";
            if (!Regex.IsMatch(pw, @"[0-9]"))
                yield return "Password must contain at least one digit";
        }

        private string PasswordMatch(string arg)
        {
            if (pwField1.Value != arg)
                return "Passwords don't match";
            return null;
        }
    }
}