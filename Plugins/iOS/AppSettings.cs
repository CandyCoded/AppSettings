// Copyright (c) Scott Doxey. All Rights Reserved. Licensed under the MIT License. See LICENSE in the project root for license information.

using System.Runtime.InteropServices;

namespace CandyCoded.AppSettings.iOS
{

    public static class AppSettings
    {

        [DllImport("__Internal")]
        public static extern bool GetBoolean(string key);

        [DllImport("__Internal")]
        public static extern double GetDouble(string key);

        [DllImport("__Internal")]
        public static extern float GetFloat(string key);

        [DllImport("__Internal")]
        public static extern int GetInteger(string key);

        [DllImport("__Internal")]
        public static extern string GetString(string key);

    }

}
