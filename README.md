# 去除 WinForm 控件焦点虚线边框，可用于所有控件


本项目以 TrackBar 控件为例，简单展示了去除虚线边框的过程


1. 创建一个“用户控件”类，并使其继承你想要的控件类，例如“public partial class MyButton : Button”
2. 在该控件类中填入以下代码

   ```
   [System.Runtime.InteropServices.DllImport("user32.dll")]
           public extern static int SendMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

           private static int MakeParam(int loWord, int hiWord)
           {
               return (hiWord << 16) | (loWord & 0xffff);
           }

           protected override void OnGotFocus(EventArgs e)
           {
               base.OnGotFocus(e);
               SendMessage(this.Handle, 0x0128, MakeParam(1, 0x1), 0);
   ```
3. Compile 之后工具箱中就会出现你创建的新控件，使用这个新控件替代之前已经放上去的默认控件就行了
