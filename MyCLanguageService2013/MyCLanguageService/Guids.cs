// Guids.cs
// MUST match guids.h
using System;

namespace Microsoft.MyCLanguageService
{
    static class GuidList
    {
        public const string guidMyCLanguageServicePkgString = "08c5446b-ed95-402f-82de-b3da37232913";
        public const string guidMyCLanguageServiceCmdSetString = "de0a8cb7-2b6d-4a96-865f-15a9d055bf2c";

        public static readonly Guid guidMyCLanguageServiceCmdSet = new Guid(guidMyCLanguageServiceCmdSetString);
    };
}