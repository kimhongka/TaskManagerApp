using Android.Content;
using Android.Content.Res;
using Android.Util;

namespace TaskManagerApp.Utilities
{
    public class DimensionUtils
    {
        public static float ConvertPixelsToDp(Context context, float pixelValue)
        {
            return pixelValue / context.Resources.DisplayMetrics.Density;
        }

        public static float ConvertDpToPixel(Context context, float dpValue)
        {
            return dpValue * context.Resources.DisplayMetrics.Density;
        }
    }
}
