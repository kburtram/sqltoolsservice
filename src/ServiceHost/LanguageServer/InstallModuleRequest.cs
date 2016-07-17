﻿//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

using Microsoft.SqlTools.EditorServices.Protocol.MessageProtocol;

namespace Microsoft.SqlTools.EditorServices.Protocol.LanguageServer
{
    class InstallModuleRequest
    {
        public static readonly
            RequestType<string, object> Type =
            RequestType<string, object>.Create("SqlTools/installModule");
    }
}