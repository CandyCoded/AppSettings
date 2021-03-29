// Copyright (c) Scott Doxey. All Rights Reserved. Licensed under the MIT License. See LICENSE in the project root for license information.

namespace CandyCoded.AppSettings
{

    public static class AppSettings
    {

        public static bool GetBoolean(string key)
        {

#if UNITY_IOS && !UNITY_EDITOR
            return iOS.AppSettings.GetBoolean(key);
#endif

            return false;

        }

        public static double GetDouble(string key)
        {

#if UNITY_IOS && !UNITY_EDITOR
            return iOS.AppSettings.GetDouble(key);
#endif

            return 0;

        }

        public static float GetFloat(string key)
        {

#if UNITY_IOS && !UNITY_EDITOR
            return iOS.AppSettings.GetFloat(key);
#endif

            return 0;

        }

        public static int GetInteger(string key)
        {

#if UNITY_IOS && !UNITY_EDITOR
            return iOS.AppSettings.GetInteger(key);
#endif

            return 0;

        }

        public static string GetString(string key)
        {

#if UNITY_IOS && !UNITY_EDITOR
            return iOS.AppSettings.GetString(key);
#endif

            return "";

        }

    }

}
