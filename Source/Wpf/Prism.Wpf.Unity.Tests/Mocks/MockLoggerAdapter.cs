// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using Prism.Logging;

namespace Prism.Wpf.Unity.Tests.Mocks
{
    internal class MockLoggerAdapter : ILoggerFacade
    {
        public IList<string> Messages = new List<string>();

        public void Log(string message, Category category, Priority priority)
        {
            Messages.Add(message);
        }
    }
}