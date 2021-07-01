using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using StkMS.Client.Services.Exceptions;
using StkMS.Client.Services.Interfaces;

namespace StkMS.Shared
{
    public partial class UserStatus
    {
        [Inject]
        public IAuthenticationService AuthenticationService { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }
        [Inject]
        public AuthenticationStateProvider authenticationStateProvider { get; set; }
        async Task Logout()
        {
            var localStateProvider = (JwtAuthenticationStateProvider) authenticationStateProvider;
            await localStateProvider.LogoutAsync();
            Navigation.NavigateTo("Login");
        }
    }
}
