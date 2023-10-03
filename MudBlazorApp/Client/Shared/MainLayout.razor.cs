
using Synaplic.UniRH.Client.Infrastructure.Settings;

using Microsoft.JSInterop;
using MudBlazor;
using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using MudBlazorApp.Client.Shared.Dialogs;
using System.Collections.Generic;

namespace MudBlazorApp.Client.Shared
{
    public partial class MainLayout 
    {
        
        private string CurrentUserId { get; set; }
        private string ImageDataUrl { get; set; }
        private string FirstName { get; set; }
        private string SecondName { get; set; }
        private string Email { get; set; }
        private char FirstLetterOfName { get; set; }
        private string CascadingValue { get; set; }

        private MudTheme _currentTheme;
        private bool _drawerOpen = true;
        private bool _rightToLeft = false;
        private bool isDarkMode ;
        private async Task RightToLeftToggle()
        {
       
            _rightToLeft = false;
            _drawerOpen = false;
        }

        protected override async Task OnInitializedAsync()
        {
       
            _currentTheme = UniTheme.DefaultTheme;
            CascadingValue = "test";
            isDarkMode = false;
            await base.OnInitializedAsync();

        }

        private void Logout()
        {
            var parameters = new DialogParameters
            {
                {nameof(Dialogs.Logout.ContentText), $"{_l["Logout Confirmation"]}"},
                {nameof(Dialogs.Logout.ButtonText), $"{_l["Logout"]}"},
                {nameof(Dialogs.Logout.Color), Color.Error},
             
            };

            var options = new DialogOptions {CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true};

            _dialogService.Show<Dialogs.Logout>(_l["Logout"], parameters, options);
        }

        private void DrawerToggle()
        {
            _drawerOpen = !_drawerOpen;
        }

        private async Task DarkMode()
        {

            isDarkMode = !isDarkMode;
            if (!isDarkMode)
            {
                _currentTheme = UniTheme.DefaultTheme;
            }
            else if (isDarkMode)
            {
                _currentTheme = UniTheme.DarkTheme;
            }
            await InvokeAsync (()=> StateHasChanged());     
        
        }

      

    }
}