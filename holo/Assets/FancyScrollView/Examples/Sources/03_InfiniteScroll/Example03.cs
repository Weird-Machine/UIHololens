using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace FancyScrollView.Example03
{
    public class Example03 : MonoBehaviour
    {
        [SerializeField] ScrollView scrollView = default;

        void Start()
        {
            var items = Enumerable.Range(0, 6)
                .Select(i => new ItemData {Message = $"istruzione {i}"})
                .ToArray();

            scrollView.UpdateData(items);
            scrollView.SelectCell(0);
        }
    }
}
