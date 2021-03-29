// Copyright (c) Scott Doxey. All Rights Reserved. Licensed under the MIT License. See LICENSE in the project root for license information.

#import <Foundation/Foundation.h>

extern "C"
{

    const bool GetBoolean(const char* key) {

        NSString* keyString = [NSString stringWithUTF8String: key];

        const bool value = [[NSUserDefaults standardUserDefaults] boolForKey: keyString];

        return value;

    }

    const double GetDouble(const char* key) {

        NSString* keyString = [NSString stringWithUTF8String: key];

        const double value = [[NSUserDefaults standardUserDefaults] doubleForKey: keyString];

        return value;

    }

    const float GetFloat(const char* key) {

        NSString* keyString = [NSString stringWithUTF8String: key];

        const float value = [[NSUserDefaults standardUserDefaults] floatForKey: keyString];

        return value;

    }

    const int GetInteger(const char* key) {

        NSString* keyString = [NSString stringWithUTF8String: key];

        const int value = (int)[[NSUserDefaults standardUserDefaults] integerForKey: keyString];

        return value;

    }

    const char* GetString(const char* key) {

        NSString* keyString = [NSString stringWithUTF8String: key];
        
        NSString* nsValue = [[NSUserDefaults standardUserDefaults] stringForKey: keyString];
        
        if (nsValue) {
            
            char* value = (char*)malloc(nsValue.length + 1);
            
            strcpy(value, [nsValue UTF8String]);

            return value;
            
        }
        
        return NULL;
    
    }

}
