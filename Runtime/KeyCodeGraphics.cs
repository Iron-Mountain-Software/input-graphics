using UnityEngine;

namespace IronMountain.InputGraphics
{
    [CreateAssetMenu(menuName = "Scriptable Objects/KeyCode Graphics")]
    public class KeyCodeGraphics : ScriptableObject
    {
        [SerializeField] private Sprite keyCodeAlt;
        [SerializeField] private Sprite keyCodeAsterisk;
        [SerializeField] private Sprite keyCodeBackspace;
        [SerializeField] private Sprite keyCodeBracketLeft;
        [SerializeField] private Sprite keyCodeBracketRight;
        [SerializeField] private Sprite keyCodeCapsLock;
        [SerializeField] private Sprite keyCodeCommand;
        [SerializeField] private Sprite keyCodeControl;
        [SerializeField] private Sprite keyCodeDelete;
        [SerializeField] private Sprite keyCodeEquals;
        [SerializeField] private Sprite keyCodeEnd;
        [SerializeField] private Sprite keyCodeEnter;
        [SerializeField] private Sprite keyCodeEscape;
        [SerializeField] private Sprite keyCodeHome;
        [SerializeField] private Sprite keyCodeInsert;
        [SerializeField] private Sprite keyCodeMinus;
        [SerializeField] private Sprite keyCodeNumLock;
        [SerializeField] private Sprite keyCodePageDown;
        [SerializeField] private Sprite keyCodePageUp;
        [SerializeField] private Sprite keyCodePlus;
        [SerializeField] private Sprite keyCodePrint;
        [SerializeField] private Sprite keyCodeQuestion;
        [SerializeField] private Sprite keyCodeQuote;
        [SerializeField] private Sprite keyCodeSemicolon;
        [SerializeField] private Sprite keyCodeShiftLeft;
        [SerializeField] private Sprite keyCodeShiftRight;
        [SerializeField] private Sprite keyCodeSlash;
        [SerializeField] private Sprite keyCodeSpace;
        [SerializeField] private Sprite keyCodeTab;
        [SerializeField] private Sprite keyCodeTilde;
        [SerializeField] private Sprite keyCodeWindows;
        [Space]
        [SerializeField] private Sprite keyCodeMouse0;
        [SerializeField] private Sprite keyCodeMouse1;
        [SerializeField] private Sprite keyCodeMouse2;
        [SerializeField] private Sprite keyCodeMouse3;
        [SerializeField] private Sprite keyCodeMouse4;
        [SerializeField] private Sprite keyCodeMouse5;
        [SerializeField] private Sprite keyCodeMouse6;
        [Space]
        [SerializeField] private Sprite keyCodeF1;
        [SerializeField] private Sprite keyCodeF2;
        [SerializeField] private Sprite keyCodeF3;
        [SerializeField] private Sprite keyCodeF4;
        [SerializeField] private Sprite keyCodeF5;
        [SerializeField] private Sprite keyCodeF6;
        [SerializeField] private Sprite keyCodeF7;
        [SerializeField] private Sprite keyCodeF8;
        [SerializeField] private Sprite keyCodeF9;
        [SerializeField] private Sprite keyCodeF10;
        [SerializeField] private Sprite keyCodeF11;
        [SerializeField] private Sprite keyCodeF12;
        [Space]
        [SerializeField] private Sprite keyCodeArrowDown;
        [SerializeField] private Sprite keyCodeArrowLeft;
        [SerializeField] private Sprite keyCodeArrowUp;
        [SerializeField] private Sprite keyCodeArrowRight;
        [Space]
        [SerializeField] private Sprite keyCode0;
        [SerializeField] private Sprite keyCode1;
        [SerializeField] private Sprite keyCode2;
        [SerializeField] private Sprite keyCode3;
        [SerializeField] private Sprite keyCode4;
        [SerializeField] private Sprite keyCode5;
        [SerializeField] private Sprite keyCode6;
        [SerializeField] private Sprite keyCode7;
        [SerializeField] private Sprite keyCode8;
        [SerializeField] private Sprite keyCode9;
        [Space]
        [SerializeField] private Sprite keyCodeA;
        [SerializeField] private Sprite keyCodeB;
        [SerializeField] private Sprite keyCodeC;
        [SerializeField] private Sprite keyCodeD;
        [SerializeField] private Sprite keyCodeE;
        [SerializeField] private Sprite keyCodeF;
        [SerializeField] private Sprite keyCodeG;
        [SerializeField] private Sprite keyCodeH;
        [SerializeField] private Sprite keyCodeI;
        [SerializeField] private Sprite keyCodeJ;
        [SerializeField] private Sprite keyCodeK;
        [SerializeField] private Sprite keyCodeL;
        [SerializeField] private Sprite keyCodeM;
        [SerializeField] private Sprite keyCodeN;
        [SerializeField] private Sprite keyCodeO;
        [SerializeField] private Sprite keyCodeP;
        [SerializeField] private Sprite keyCodeQ;
        [SerializeField] private Sprite keyCodeR;
        [SerializeField] private Sprite keyCodeS;
        [SerializeField] private Sprite keyCodeT;
        [SerializeField] private Sprite keyCodeU;
        [SerializeField] private Sprite keyCodeV;
        [SerializeField] private Sprite keyCodeW;
        [SerializeField] private Sprite keyCodeX;
        [SerializeField] private Sprite keyCodeY;
        [SerializeField] private Sprite keyCodeZ;
    
        public Sprite GetSprite(KeyCode keycode)
        {
            switch(keycode)
            {
                case KeyCode.LeftAlt:
                    return keyCodeAlt;
                case KeyCode.RightAlt:
                    return keyCodeAlt;
                case KeyCode.Asterisk:
                    return keyCodeAsterisk;
                case KeyCode.Backspace:
                    return keyCodeBackspace;
                case KeyCode.LeftBracket:
                    return keyCodeBracketLeft;
                case KeyCode.RightBracket:
                    return keyCodeBracketRight;
                case KeyCode.CapsLock:
                    return keyCodeCapsLock;
                case KeyCode.LeftCommand:
                    return keyCodeCommand;
                case KeyCode.RightCommand:
                    return keyCodeCommand;
                case KeyCode.LeftControl:
                    return keyCodeControl;
                case KeyCode.RightControl:
                    return keyCodeControl;
                case KeyCode.Delete:
                    return keyCodeDelete;
                case KeyCode.Equals:
                    return keyCodeEquals;
                case KeyCode.End:
                    return keyCodeEnd;
                case KeyCode.Escape:
                    return keyCodeEscape;
                case KeyCode.Home:
                    return keyCodeHome;
                case KeyCode.Insert:
                    return keyCodeInsert;
                case KeyCode.Minus:
                    return keyCodeMinus;
                case KeyCode.Numlock:
                    return keyCodeNumLock;
                case KeyCode.PageDown:
                    return keyCodePageDown;
                case KeyCode.PageUp:
                    return keyCodePageUp;
                case KeyCode.Plus:
                    return keyCodePlus;
                case KeyCode.Print:
                    return keyCodePrint;
                case KeyCode.Question:
                    return keyCodeQuestion;
                case KeyCode.Quote:
                    return keyCodeQuote;
                case KeyCode.Semicolon:
                    return keyCodeSemicolon;
                case KeyCode.LeftShift:
                    return keyCodeShiftLeft;
                case KeyCode.RightShift:
                    return keyCodeShiftRight;
                case KeyCode.Slash:
                    return keyCodeSlash;
                case KeyCode.Space:
                    return keyCodeSpace;
                case KeyCode.Tab:
                    return keyCodeTab;
                case KeyCode.Tilde:
                    return keyCodeTilde;
                case KeyCode.LeftWindows:
                    return keyCodeWindows;
                case KeyCode.RightWindows:
                    return keyCodeWindows;
            
                case KeyCode.Mouse0:
                    return keyCodeMouse0;
                case KeyCode.Mouse1:
                    return keyCodeMouse1;
                case KeyCode.Mouse2:
                    return keyCodeMouse2;
                case KeyCode.Mouse3:
                    return keyCodeMouse3;
                case KeyCode.Mouse4:
                    return keyCodeMouse4;
                case KeyCode.Mouse5:
                    return keyCodeMouse5;
                case KeyCode.Mouse6:
                    return keyCodeMouse6;
            
                case KeyCode.F1:
                    return keyCodeF1;
                case KeyCode.F2:
                    return keyCodeF2;
                case KeyCode.F3:
                    return keyCodeF3;
                case KeyCode.F4:
                    return keyCodeF4;
                case KeyCode.F5:
                    return keyCodeF5;
                case KeyCode.F6:
                    return keyCodeF6;
                case KeyCode.F7:
                    return keyCodeF7;
                case KeyCode.F8:
                    return keyCodeF8;
                case KeyCode.F9:
                    return keyCodeF9;
                case KeyCode.F10:
                    return keyCodeF10;
                case KeyCode.F11:
                    return keyCodeF11;
                case KeyCode.F12:
                    return keyCodeF12;
            
                case KeyCode.DownArrow:
                    return keyCodeArrowDown;
                case KeyCode.LeftArrow:
                    return keyCodeArrowLeft;
                case KeyCode.UpArrow:
                    return keyCodeArrowUp;
                case KeyCode.RightArrow:
                    return keyCodeArrowRight;
            
                case KeyCode.Keypad0:
                    return keyCode0;
                case KeyCode.Keypad1:
                    return keyCode1;
                case KeyCode.Keypad2:
                    return keyCode2;
                case KeyCode.Keypad3:
                    return keyCode3;
                case KeyCode.Keypad4:
                    return keyCode4;
                case KeyCode.Keypad5:
                    return keyCode5;
                case KeyCode.Keypad6:
                    return keyCode6;
                case KeyCode.Keypad7:
                    return keyCode7;
                case KeyCode.Keypad8:
                    return keyCode8;
                case KeyCode.Keypad9:
                    return keyCode9;
                case KeyCode.KeypadDivide:
                    return keyCodeSlash;
                case KeyCode.KeypadEnter:
                    return keyCodeEnter;
                case KeyCode.KeypadEquals:
                    return keyCodeEquals;
                case KeyCode.KeypadMinus:
                    return keyCodeMinus;
                case KeyCode.KeypadMultiply:
                    return keyCodeAsterisk;
                case KeyCode.KeypadPeriod:
                    return null;
                case KeyCode.KeypadPlus:
                    return keyCodePlus;
                
                case KeyCode.Alpha0:
                    return keyCode0;
                case KeyCode.Alpha1:
                    return keyCode1;
                case KeyCode.Alpha2:
                    return keyCode2;
                case KeyCode.Alpha3:
                    return keyCode3;
                case KeyCode.Alpha4:
                    return keyCode4;
                case KeyCode.Alpha5:
                    return keyCode5;
                case KeyCode.Alpha6:
                    return keyCode6;
                case KeyCode.Alpha7:
                    return keyCode7;
                case KeyCode.Alpha8:
                    return keyCode8;
                case KeyCode.Alpha9:
                    return keyCode9;
                
                case KeyCode.A:
                    return keyCodeA;
                case KeyCode.B:
                    return keyCodeB;
                case KeyCode.C:
                    return keyCodeC;
                case KeyCode.D:
                    return keyCodeD;
                case KeyCode.E:
                    return keyCodeE;
                case KeyCode.F:
                    return keyCodeF;
                case KeyCode.G:
                    return keyCodeG;
                case KeyCode.H:
                    return keyCodeH;
                case KeyCode.I:
                    return keyCodeI;
                case KeyCode.J:
                    return keyCodeJ;
                case KeyCode.K:
                    return keyCodeK;
                case KeyCode.L:
                    return keyCodeL;
                case KeyCode.M:
                    return keyCodeM;
                case KeyCode.N:
                    return keyCodeN;
                case KeyCode.O:
                    return keyCodeO;
                case KeyCode.P:
                    return keyCodeP;
                case KeyCode.Q:
                    return keyCodeQ;
                case KeyCode.R:
                    return keyCodeR;
                case KeyCode.S:
                    return keyCodeS;
                case KeyCode.T:
                    return keyCodeT;
                case KeyCode.U:
                    return keyCodeU;
                case KeyCode.V:
                    return keyCodeV;
                case KeyCode.W:
                    return keyCodeW;
                case KeyCode.X:
                    return keyCodeX;
                case KeyCode.Y:
                    return keyCodeY;
                case KeyCode.Z:
                    return keyCodeZ;
                default:
                    return null;
            }
        }
    }
}
