using System;
#if PLATFORM_WINDOWS
using System.Deployment.Application;
using System.Windows.Forms;
#endif
using System.Threading;
using JamCast;
using JamCast.Services;
using JamCast.Windows;
using Protoinject;

namespace JamCast
{
    public static class Program
    {
        internal static void Main(string[] args)
        {
#if PLATFORM_WINDOWS
            var thread = new Thread(CheckForUpdates);
            thread.IsBackground = true;
            thread.Start();
#endif

            var kernel = new StandardKernel();

            kernel.Bind<ISiteInfoService>().To<SiteInfoService>().InSingletonScope();
            kernel.Bind<IComputerInfoService>().To<ComputerInfoService>().InSingletonScope();
            kernel.Bind<IMacAddressReportingService>().To<MacAddressReportingService>().InSingletonScope();
            kernel.Bind<IUserInfoService>().To<UserInfoService>().InSingletonScope();
            kernel.Bind<IImageService>().To<ImageService>().InSingletonScope();
            kernel.Bind<IJamHostApiService>().To<JamHostApiService>().InSingletonScope();
            kernel.Bind<IRoleInfoService>().To<RoleInfoService>().InSingletonScope();
            kernel.Bind<IManager>().To<Manager>().InSingletonScope();
            kernel.Bind<IClientRole>().To<ClientRole>().InSingletonScope();
            kernel.Bind<IProjectorRole>().To<ProjectorRole>().InSingletonScope();
            kernel.Bind<IAuthenticator>().To<Authenticator>().InSingletonScope();

            var authenticator = kernel.Get<IAuthenticator>();
            authenticator.EnsureAuthenticated();

            var manager = kernel.Get<IManager>();
            manager.Run();
        }

#if PLATFORM_WINDOWS
        private static void CheckForUpdates()
        {
            while (true)
            {
                // Wait a minute.
                Thread.Sleep(60000);

                if (ApplicationDeployment.IsNetworkDeployed)
                {
                    Boolean updateAvailable = false;
                    ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

                    try
                    {
                        updateAvailable = ad.CheckForUpdate();
                    }
                    catch 
                    {
                        // Can't check; ignore.
                        continue;
                    }

                    if (updateAvailable)
                    {
                        try
                        {
                            ad.Update();
                            Application.Restart();
                        }
                        catch
                        {
                            // Can't auto-update.
                        }
                    }
                }
            }
        }
#endif
    }
}

