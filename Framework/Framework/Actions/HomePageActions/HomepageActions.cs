﻿using Framework.Actions.Common;
using System;
namespace Framework.Actions.HomePageActions
{
   public class HomepageActions:CommonActions
    {
        public  void NavigateToURL()
        {
            GoToUrl();
        }

        public static string getLinkName()
        {
            return GetText();
        }

        
    }
}
