/*-----------------------------------------------------------------------------+
 | This file is generated by NReact.Csx. Do not modify, changes could be lost. |
 +-----------------------------------------------------------------------------*/
#if NETFX_CORE
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
#else
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
#endif

namespace NReact
{
  public partial class NClock 
  {
    public override NElement Render()
    {
      return
        New(typeof(Grid), new { HorizontalAlignment = "Center", VerticalAlignment = "Center" }, 
          New(typeof(TextBlock), new { FontSize = Props.FS, Text =  string.Format("{0:o} #{1}", State.Time, State.Tick)  })
        );
    }
  }
}
