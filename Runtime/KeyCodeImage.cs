using UnityEngine;
using UnityEngine.UI;

namespace IronMountain.InputGraphics
{
    [ExecuteAlways]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Image))]
    public class KeyCodeImage : MonoBehaviour
    {
        [SerializeField] private KeyCode keyCode;
        [SerializeField] private KeyCodeGraphics graphics;
        [SerializeField] private Image image;
        
        public KeyCode KeyCode
        {
            get => keyCode;
            set
            {
                if (keyCode == value) return;
                keyCode = value;
                Refresh();
            }
        }

        private void OnEnable() => Refresh();
        private void OnValidate() => Refresh();

        private void Refresh()
        {
            if (!image) image = GetComponent<Image>();
            if (!image) return;
            image.sprite = graphics ? graphics.GetSprite(keyCode) : null;
            image.enabled = image.sprite;
        }
    }
}
