﻿using Orchard;
using Orchard.Localization;
using Orchard.UI.Navigation;

namespace Urbanit.Polls
{
    public class AdminMenu : Component, INavigationProvider
    {
        public Localizer T { get; set; }

        public AdminMenu()
        {
            T = NullLocalizer.Instance;
        }

        public string MenuName { get { return "admin"; } }


        public void GetNavigation(NavigationBuilder builder)
        {
            builder.AddImageSet("Polls")
              .Add(T("Urbanit Polls"), "7",
                          menu => menu.Add(T("Urbanit Polls"), "0", item => item.Action("Index", "Admin", new { area = "Urbanit.Polls" })
                                                                                .Permission(Permissions.PollsManagePermission)));
        }
    }
}