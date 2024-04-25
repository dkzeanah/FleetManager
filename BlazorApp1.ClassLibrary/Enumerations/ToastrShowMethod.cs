using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.ClassLibrary.Enumerations
{
    public enum ToastrShowMethod
    {
        [Description("fadeIn")] FadeIn,
        [Description("slideDown")] SlideDown

    }
    public enum ToastrHideMethod
    {
        [Description("fadeOut")] FadeOut,
        [Description("slideUp")] SlideUp,

    }
    public enum ToastrPositionMethod 
    {
        [Description("toast-top-left")] TopLeft,
        [Description("toast-top-right")] TopRight,
        [Description("toast-bottom-left")] BottomLeft,
        [Description("toast-bottom-right")] BottomRight 

    }

}
