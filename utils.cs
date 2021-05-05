using System;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

// using Newtonsoft.Json;
// using Thread;

namespace csrunner
{

    public class jUtils
    {
        // private static readonly DateTime _epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static string InFile(string fname)
        {
            try
            {
                return File.ReadAllText(fname);
            }
            catch { return null; }
        }

        public static bool Run(string fname, string args){
                        try
            {
		    Process process = new Process();
                process.StartInfo.FileName = fname;
                process.StartInfo.Arguments = args;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                process.Start();
                process.WaitForExit();
                return true;
            }
            catch
            {
                
                return false;
            }

        }
    }

    //     public static void CreateDir(string dirname)
    //     {
    //         if (Directory.Exists(dirname)) return;
    //         Directory.CreateDirectory(dirname);
    //     }
    //     public static void PurgeDirectory(string dirname, string pattern, int lower, int upper)
    //     {
    //         string[] files = Directory.GetFiles(dirname, pattern);
    //         int n = files.Length;

    //         if (n <= upper) return;
    //         Array.Sort(files);

    //         n = n - lower;
    //         for (int i = 0; i < n; i++)
    //         {
    //             jLogger.Trace("deleting. ", i, " - ", files[i]);
    //             File.Delete(Path.Combine("", files[i]));
    //         }
    //     }
    //     public static void mSleep(int ms)
    //     {
    //         Thread.Sleep(ms);
    //     }

    //     public class jPQVar
    //     {
    //         readonly object _locker; uint _p, _q;
    //         public void Dump()
    //         {
    //             jLogger.Trace("(p, q)=(", _p, ", ", _q, ")");
    //         }
    //         public void IncP(uint i = 1) { lock (_locker) { _p += i; } }
    //         public void IncQ(uint i = 1) { lock (_locker) { _q += i; } }
    //         public void Sync() { _q = _p; }
    //         public uint Diff { get { return _p - _q; } }
    //         public bool CheckInc(uint i = 1)
    //         {
    //             bool ret;
    //             lock (_locker)
    //             {
    //                 ret = (_p == _q);
    //                 _p++;
    //             }
    //             return ret;
    //         }
    //         public jPQVar()
    //         {
    //             _locker = new object(); _q = _p = 0;
    //         }
    //         public jPQVar(uint p)
    //         {
    //             _locker = new object(); _q = 0; _p = p;
    //         }
    //     }

    //     public static string ToDateString(uint ticks = 0)
    //     {
    //         if (ticks == 0) return (DateTime.Now).ToString("yy/MM/dd HH:mm:ss.fff");
    //         return (_epoch.AddSeconds(ticks)).ToString("yyyy/MM/dd HH:mm:ss");
    //     }

    //     // public static int MyThreadId() {
    //     //     return System.Thread.CurrentThread.ManagedThreadId;
    //     //     }

    //     public static long LongEpoch()
    //     {
    //         DateTime now = DateTime.Now;
    //         TimeSpan diff = now - _epoch;
    //         return (long)diff.TotalMilliseconds;

    //     }

    //     public static void Fork(Action callback, bool sta = true, bool join = false)
    //     {
    //         Thread t = new Thread(() => callback.Invoke());
    //         if (sta) t.SetApartmentState(ApartmentState.STA);
    //         t.Start();
    //         if (join) t.Join(); else mSleep(100);
    //     }

    //     // public static string toJson(object obj)
    //     // {
    //     //     return JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
    //     // }

    //     // public static string toJsonNP(object obj)
    //     // {
    //     //     return JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.None);
    //     // }
    // }
    // public class iList<T> : List<T>
    // {
    //     public iList(T[] objs)
    //     {
    //         foreach (var s in objs)
    //             this.Add(s);
    //         //base(objs);
    //     }
    //     public T Pop()
    //     {
    //         if (this.Count == 0) return default(T);
    //         T ret = this[0];
    //         this.RemoveAt(0);
    //         return ret;
    //     }

    // }
}
