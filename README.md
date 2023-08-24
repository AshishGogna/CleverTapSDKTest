# CleverTap SDK Test Package

- Click the "Releases" link, and download the latest archive as zip or gzip file.

## Documentation

As there are many steps to developing a Unity package, the documentation is currently split into a couple of parts, each covering a specific feature or overview:

## Install

### Through [Unity Package Manager](https://docs.unity3d.com/Manual/upm-ui-giturl.html)

Unity's own Package Manager supports [importing packages through a URL to a Git repo](https://docs.unity3d.com/Manual/upm-ui-giturl.html):

1. First, on this repository page, click the "Clone or download" button, and copy over this repository's HTTPS URL.  
2. Then click on the + button on the upper-left-hand corner of the Package Manager, select "Add package from git URL..." on the context menu, then paste this repo's URL!

While easier to follow than the first method, this one does not support dependency resolution and package upgrading when a new version is released.  So proceed with caution.