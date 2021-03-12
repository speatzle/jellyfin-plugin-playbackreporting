<h1 align="center">Jellyfin Playback Reporting Plugin</h1>
<h3 align="center">Part of the <a href="https://jellyfin.org">Jellyfin Project</a></h3>

<p align="center">
<img alt="Logo Banner" src="https://raw.githubusercontent.com/jellyfin/jellyfin-ux/master/branding/SVG/banner-logo-solid.svg?sanitize=true"/>
<br/>
<br/>
<a href="https://github.com/jellyfin/jellyfin-plugin-playbackreporting/actions?query=workflow%3A%22Test+Build+Plugin%22">
<img alt="GitHub Workflow Status" src="https://img.shields.io/github/workflow/status/jellyfin/jellyfin-plugin-playbackreporting/Test%20Build%20Plugin.svg">
</a>
<a href="https://github.com/jellyfin/jellyfin-plugin-playbackreporting">
<img alt="MIT License" src="https://img.shields.io/github/license/jellyfin/jellyfin-plugin-playbackreporting.svg"/>
</a>
<a href="https://github.com/jellyfin/jellyfin-plugin-playbackreporting/releases">
<img alt="Current Release" src="https://img.shields.io/github/release/jellyfin/jellyfin-plugin-playbackreporting.svg"/>
</a>
</p>

## About

The Jellyfin Playback Reporting plugin enables the collection and display of user and media activity on your server.
This information can be viewed as a multitude of different graphs, and can also be queried straight from the Jellyfin database.

## Build & Installation Process

1. Clone this repository

2. Ensure you have .NET Core SDK set up and installed

3. Build the plugin with your favorite IDE or the `dotnet` command:

```
dotnet publish --configuration Release --output bin
```

4. Place the resulting `Jellyfin.Plugin.PlaybackReporting.dll` file in a folder called `plugins/` inside your Jellyfin data directory
