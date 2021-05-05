using System;
using System.Diagnostics;

// using System.Text;
// using System.Runtime.InteropServices;


// #define MCIERR_BASE            256
// #define MCIERR_INVALID_DEVICE_ID        (MCIERR_BASE + 1)
// #define MCIERR_UNRECOGNIZED_KEYWORD     (MCIERR_BASE + 3)
// #define MCIERR_UNRECOGNIZED_COMMAND     (MCIERR_BASE + 5)
// #define MCIERR_HARDWARE                 (MCIERR_BASE + 6)
// #define MCIERR_INVALID_DEVICE_NAME      (MCIERR_BASE + 7)
// #define MCIERR_OUT_OF_MEMORY            (MCIERR_BASE + 8)
// #define MCIERR_DEVICE_OPEN              (MCIERR_BASE + 9)
// #define MCIERR_CANNOT_LOAD_DRIVER       (MCIERR_BASE + 10)

namespace csrunner
{

    // public class Media
    // {
    //     public const int MM_MCINOTIFY = 0x3B9;

    //     private string fileName;
    //     private bool isOpen = false;
    //     // private Form notifyForm;
    //     private string mediaName = "media";

    //     //mciSendString 
    //     [DllImport("winmm.dll")]
    //     private static extern long mciSendString(
    //         string command,
    //         StringBuilder returnValue,
    //         int returnLength,
    //         IntPtr winHandle);

    //     private void ClosePlayer()
    //     {
    //         if (isOpen)
    //         {
    //             String playCommand = "Close " + mediaName;
    //             mciSendString(playCommand, null, 0, IntPtr.Zero);
    //             isOpen = false;
    //         }
    //     }


    //     private void OpenMediaFile()
    //     {
    //         ClosePlayer();
    //         string playCommand = "Open \"" + fileName +
    //                             "\" type mpegvideo alias " + mediaName;
    //         long ret = mciSendString(playCommand, null, 0, IntPtr.Zero);
    //         isOpen = true;
    //     }


    //     private void PlayMediaFile()
    //     {
    //         if (isOpen)
    //         {
    //             string playCommand = "Play " + mediaName + " notify";
    //             mciSendString(playCommand, null, 0, IntPtr.Zero); // notifyForm.Handle);
    //         }
    //     }


    //     public void Play(string fileName) //, Form notifyForm)
    //     {
    //         this.fileName = fileName;
    //         // this.notifyForm = notifyForm;
    //         OpenMediaFile();
    //         PlayMediaFile();
    //     }

    //     public void Stop()
    //     {
    //         ClosePlayer();
    //     }

    // }

    class Program
    {
        // [DllImport("winmm.dll")]
        // private static extern long mciSendString(string command, StringBuilder returnValue, int returnLength, IntPtr winHandle);

        static void Main(string[] args)
        {
            // Media m = new Media();
            // m.Play(fname);
            // ret = mciSendString(fname, null, 0, (IntPtr)0);
            String si = jUtils.InFile("csrunner.cmd");
            if (!si){
                Console.WriteLine(si);    
            }
            jUtils.Run("cmd.exe", "dir");
            Console.WriteLine("Hello World!");
        }
    }
}
