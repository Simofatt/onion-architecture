using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;
using System;
using System.IO;
using System.Threading.Tasks;
using Blazored.FluentValidation;
using Synaplic.UniRH.Client.Infrastructure.ApiClients;
using System.Text.RegularExpressions;
using System.Globalization;
using Blazored.LocalStorage.StorageOptions;
using Blazored.LocalStorage;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using MudBlazorApp.Shared.Constant;

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
        [Inject] ILocalStorageService LocalStorage { get; set; }

         public string _currentLanguage { get; set; }


        protected override async Task OnInitializedAsync()
        {
            _currentLanguage = CultureInfo.CurrentCulture.DisplayName;
            
            if(!string.IsNullOrEmpty(_currentLanguage) )
            {
                if(_currentLanguage.Replace(" ","").Equals("fr(FR)"))
                {
                    _currentLanguage = "Francais";
                }else if (_currentLanguage.Replace(" ", "").Equals("es(ES)"))
                {
                    _currentLanguage = "Spanish"; 
                }
            }

        }
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



     
    /*   CultureInfo Culture
        {
            get => CultureInfo.CurrentCulture; 
            set
            {
                if(CultureInfo.CurrentCulture !=value)
                {

                    LocalStorage.SetItemAsync<string>("culture",value);
                     InvokeAsync(() => StateHasChanged());
                    //_navigationManager.NavigateTo(_navigationManager.Uri, forceLoad: true);
                }
            }
        }*/

        public async Task ChangeLanguage(string value)
        {

            var currentCulture = CultureInfo.CurrentCulture;
            if (!currentCulture.Equals(value))
            {
              await  LocalStorage.SetItemAsync<string>("culture", value);
              await  InvokeAsync(() => StateHasChanged());
               _navigationManager.NavigateTo(_navigationManager.Uri, forceLoad: true);
            }
        }
    }
}