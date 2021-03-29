# App Settings

> ⚙️ Get app specific settings from the OS.

[![npm](https://img.shields.io/npm/v/xyz.candycoded.appsettings)](https://www.npmjs.com/package/xyz.candycoded.appsettings)

### Unity Package Manager

<https://docs.unity3d.com/Packages/com.unity.package-manager-ui@2.0/manual/index.html>

#### Git

```json
{
  "dependencies": {
    "xyz.candycoded.appsettings": "https://github.com/CandyCoded/appsettings.git#v1.0.0",
    ...
  }
}
```

#### Scoped UPM Registry

```json
{
  "dependencies": {
    "xyz.candycoded.appsettings": "1.0.0",
    ...
  },
  "scopedRegistries": [
    {
      "name": "candycoded",
      "url": "https://registry.npmjs.com",
      "scopes": ["xyz.candycoded"]
    }
  ]
}
```

## Usage

### Create `Settings.bundle` in iOS project

> Note: This will have to be done on each new build so safe the `.bundle` file somewhere outside the `Builds/` folder.

<https://developer.apple.com/library/archive/documentation/Cocoa/Conceptual/UserDefaults/Preferences/Preferences.html>

1. Right-click on the project in the project navigator
1. Click **New File...**
1. Search for **Resources / Settings Bundle**
1. Click **Next**
1. Rename the file if necessary
1. Click **Create**
1. Click on the newly created **Settings.bundle/Root.plist** file in the project navigator
1. Make necessary changes

### Reference the values from your app

> Note: The key used is the field **Identifier** in the **Settings.bundle/Root.plist** file.

```csharp
using CandyCoded.AppSettings;
using UnityEngine;

public class TestAppSettings : MonoBehaviour
{

    private void Start()
    {

        Debug.Log(AppSettings.GetFloat("version"));

    }

}
```
