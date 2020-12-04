﻿using TinaX;
using TinaX.Services;
using UnityEngine;


namespace Nekonya.Example
{
    public class AppStartup : MonoBehaviour
    {
        private async void Start()
        {
            var core = XCore.New()
            .UseVFS()
            .UseUIKit()
                .UseUIKitMVVM()
            .UseI18N()
            .OnServicesStartException((service, err) =>
            {
                //
            });
            await core.RunAsync();

            //startup TinaX Framework 
        }
    }
}

