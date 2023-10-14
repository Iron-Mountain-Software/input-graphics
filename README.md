Input Graphics
====================

_A tool for depicting graphics of all types of controllers._

NO CODING REQUIRED

There are an absurd number of input methods, but this package makes it easier to use and depict many of them.

Use Cases
---------

*   Depict images of KeyCode inputs dynamically.
*   Graphic source files for many more input methods.

Directions for Use
------------------

1.  Create a KeyCodeGraphics Scriptable Object, or use one of the defaults (light or dark). 
2.  Add a KeyCodeImage component to a GameObject with an Image component.
3.  Connect a KeyCodeGraphics object to the KeyCodeImage's Graphics field. 
4.  The KeyCodeImage will update the image's sprite according to its KeyCode field.

Key Components
--------------

1.  KeyCodeGraphics
    1.  Database of sprites that map to KeyCode values
2.  KeyCodeImage
    1.  Depicts a KeyCode according to it's KeyCodeGraphics reference.