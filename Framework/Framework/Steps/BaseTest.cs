﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Framework.Actions.Common;

namespace Framework.Steps
{
    [Binding]
    public sealed class BaseTest
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        BrowserManager browserManager;
        [BeforeScenario]
        public void BeforeScenario()
        {
            browserManager.OpenBrowser(Constant.browser);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            browserManager.CloseBrowser();
        }
    }
}
