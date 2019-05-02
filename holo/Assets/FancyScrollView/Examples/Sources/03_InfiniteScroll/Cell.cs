using UnityEngine;
using UnityEngine.UI;

namespace FancyScrollView.Example03
{
    public class Cell : FancyScrollViewCell<ItemData, Context>
    {
        [SerializeField] Animator animator = default;
        [SerializeField] Text message = default;
        [SerializeField] Text messageLarge = default;
        [SerializeField] Image image = default;
        [SerializeField] Image imageLarge = default;
        [SerializeField] Button button = default;

        static class AnimatorHash
        {
            public static readonly int Scroll = Animator.StringToHash("scroll");
        }

        void Start()
        {
            button.onClick.AddListener(() => Context.OnCellClicked?.Invoke(Index));
        }

        public override void UpdateContent(ItemData itemData)
        {
            message.text = itemData.Message;
            messageLarge.text = Index.ToString();
            switch (Index)
            {
                case 0:
                    {
                        messageLarge.text = "ciao";
                        break;
                    }
                    
                case 1:
                    {
                        messageLarge.text = "ciaooooooooo";
                        break;
                    }
                case 2:
                    {
                        messageLarge.text = "peppe";
                        break;
                    }

            }

            var selected = Context.SelectedIndex == Index;
            imageLarge.color = image.color = selected
                ? new Color32(0, 255, 255, 100)
                : new Color32(255, 255, 255, 77);
        }

        public override void UpdatePosition(float position)
        {
            currentPosition = position;
            animator.Play(AnimatorHash.Scroll, -1, position);
            animator.speed = 0;
        }

        float currentPosition = 0;

        void OnEnable() => UpdatePosition(currentPosition);
    }
}
