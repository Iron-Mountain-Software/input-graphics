# Input Graphics
*Version: 1.0.2*
## Description: 
A tool for depicting graphics of all types of controllers.

NO CODING REQUIRED

There are an absurd number of input methods, but this package makes it easier to use and depict many of them.
## Use Cases: 
* Dynamically depict images of KeyCode inputs. 
* Graphic source files for many more input methods. 
## Directions for Use: 
1. Create a KeyCodeGraphics Scriptable Object, or use one of the defaults (light or dark).
2. Add a KeyCodeImage component to a GameObject with an Image component.
3. Connect a KeyCodeGraphics object to the KeyCodeImage's Graphics field. 
4. The KeyCodeImage will update the image's sprite according to its KeyCode field.
## Package Mirrors: 
[<img src='https://img.itch.zone/aW1nLzEzNzQ2ODg3LnBuZw==/original/npRUfq.png'>](https://github.com/Iron-Mountain-Software/input-graphics)[<img src='https://img.itch.zone/aW1nLzEzNzQ2ODk4LnBuZw==/original/Rv4m96.png'>](https://iron-mountain.itch.io/input-graphics)[<img src='https://img.itch.zone/aW1nLzEzNzQ2ODkyLnBuZw==/original/Fq0ORM.png'>](https://www.npmjs.com/package/com.iron-mountain.input-graphics)
---
## Key Scripts & Components: 
1. public class **KeyCodeGraphics** : ScriptableObject
   * Methods: 
      * public Sprite ***GetSprite***(KeyCode keycode)
1. public class **KeyCodeImage** : MonoBehaviour
   * Properties: 
      * public KeyCode ***KeyCode***  { get; set; }
