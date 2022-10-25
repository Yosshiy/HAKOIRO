using UnityEngine;
using UniRx;


namespace Model.MyColor
{

    /// <summary>
    /// ColorModelInterface
    /// </summary>
    public interface IColorModel : IGModel
    {
        IReactiveProperty<Color> ColorData { get; }
        void SaveData(Color color);
        Color LoadData();
    }

    /// <summary>
    /// ModelClass : ロジックのみを記載
    /// </summary>
    public class ColorModel : IColorModel
    {
        IReactiveProperty<Color> IColorModel.ColorData => ColorData;
        ReactiveProperty<Color> ColorData = new ReactiveProperty<Color>();

        void IColorModel.SaveData(Color color)
        {
            ColorData.Value = color;
        }

        Color IColorModel.LoadData()
        {
            return ColorData.Value;
        }


    }
}
