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
    public partial class Profile
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

        void SaveChanges(string message, Severity severity)
        {
            Snackbar.Add(message, severity, config =>
            {
                config.ShowCloseIcon = false;
            });
        }
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
    }
}