using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace WinApi
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct Startupinfo
    {
        public Int32 cb;
        public string lpReserved;
        public string lpDesktop;
        public string lpTitle;
        public Int32 dwX;
        public Int32 dwY;
        public Int32 dwXSize;
        public Int32 dwYSize;
        public Int32 dwXCountChars;
        public Int32 dwYCountChars;
        public Int32 dwFillAttribute;
        public Int32 dwFlags;
        public Int16 wShowWindow;
        public Int16 cbReserved2;
        public IntPtr lpReserved2;
        public IntPtr hStdInput;
        public IntPtr hStdOutput;
        public IntPtr hStdError;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct ProcessInformation
    {
        public IntPtr hProcess;
        public IntPtr hThread;
        public int dwProcessId;
        public int dwThreadId;
    }
    public class WinApiFuncs
    {
        public const uint GENERIC_RW = 0xC0000000;
        public const uint FILE_SHARE_RW = 3;
        public const uint FILE_SHARE_RWI = 19;
        public const uint FILE_ATTR_NORMAL = 0x80;
        public const uint CREATE_ALWAYS = 2;

        public const uint INFINITE = 0xFFFFFFFF;
        public const uint WAIT_ABANDONED = 0x00000080;
        public const uint WAIT_OBJECT_0 = 0x00000000;
        public const uint WAIT_TIMEOUT = 0x00000102;
        public static IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);
        public const uint CREATE_SUSPENDED = 4;
        public const uint CREATE_NEW_CONSOLE = 0x00000010;
        public const uint CREATE_NO_WINDOW = 0x08000000;

        public const int STARTF_USECOUNTCHARS = 0x00000008;
        public const int STARTF_USEFILLATTRIBUTE = 0x00000010;
        public const int STARTF_USEPOSITION = 0x00000004;
        public const int STARTF_USESIZE = 0x00000002;
        public const int STARTF_USESTDHANDLES = 0x00000100;


        public const uint STANDARD_RIGHTS_REQUIRED = 0x000F0000;
        public const uint SYNCHRONIZE = 0x00100000;
        public const uint EVENT_ALL_ACCESS = (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0x3);
        public const uint EVENT_MODIFY_STATE = 0x0002;
        public const uint ERROR_ALREADY_EXISTS = 183;
        
        public const UInt32 MUTEX_ALL_ACCESS = 0x1F0001;
        public const UInt32 MUTEX_MODIFY_STATE = 0x0001;

        public const uint TIMER_ALL_ACCESS = (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0x3);
        public const uint TIMER_MODIFY_STATE = 0x0002;

        public const uint SEMAPHORE_ALL_ACCESS = (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0x3);
        public const uint SEMAPHORE_MODIFY_STATE = 0x0002;

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr CreateFile(string fileName, uint mode, uint share, IntPtr secur, 
                                                uint creation, uint attr, IntPtr temp);
        public static IntPtr CreateFile(string fileName)
        {
            return CreateFile(fileName, GENERIC_RW, FILE_SHARE_RW,IntPtr.Zero, CREATE_ALWAYS, FILE_ATTR_NORMAL, IntPtr.Zero);
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool CreateProcess(string lpApplicationName, 
                                            string lpCommandLine, 
                                            IntPtr lpProcessAttributes, 
                                            IntPtr lpThreadAttributes, 
                                            bool bInheritHandles,
                                            uint dwCreationFlags, 
                                            IntPtr lpEnvironment, 
                                            string lpCurrentDirectory,
                                            [In] ref Startupinfo lpStartupInfo,
                                            out ProcessInformation lpProcessInformation);
        public static ProcessInformation CreateProcess(string lpApplicationName, string lpCommandLine, uint dwCreationFlags = 0)
        {
            ProcessInformation pi;
            var si = new Startupinfo();
            si.cb = Marshal.SizeOf(si);
            var ret = CreateProcess(lpApplicationName, lpCommandLine, IntPtr.Zero, IntPtr.Zero, false, dwCreationFlags,
                                    IntPtr.Zero, null, ref si, out pi);
            return ret ? pi : new ProcessInformation { hProcess = INVALID_HANDLE_VALUE, hThread = INVALID_HANDLE_VALUE };

        }
        public static ProcessInformation CreateProcess(string lpCommandLine, uint dwCreationFlags = 0)
        {
            ProcessInformation pi;
            var si = new Startupinfo();
            si.cb = Marshal.SizeOf(si);
            var ret = CreateProcess(null, lpCommandLine, IntPtr.Zero, IntPtr.Zero, false, dwCreationFlags,
                                    IntPtr.Zero, null, ref si, out pi);
            return ret ? pi : new ProcessInformation { hProcess = INVALID_HANDLE_VALUE, hThread = INVALID_HANDLE_VALUE };

        }
        public static ProcessInformation CreateProcess(string lpCommandLine, Startupinfo si, uint dwCreationFlags = CREATE_NEW_CONSOLE)
        {
            ProcessInformation pi;
            var ret = CreateProcess(null, lpCommandLine, IntPtr.Zero, IntPtr.Zero, false, dwCreationFlags,
                                    IntPtr.Zero, null, ref si, out pi);
            return ret ? pi : new ProcessInformation { hProcess = INVALID_HANDLE_VALUE, hThread = INVALID_HANDLE_VALUE };

        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseHandle(IntPtr hObject);
        [DllImport("kernel32.dll")]
        public static extern void ExitProcess(uint uExitCode);
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TerminateProcess(IntPtr hProcess, uint uExitCode = 0);
        public static int GetLastError()
        {
            return Marshal.GetLastWin32Error();
        }
        // Wait functions
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds = INFINITE);
        [DllImport("kernel32.dll")]
        public static extern uint WaitForMultipleObjects(uint nCount, IntPtr[] lpHandles, bool bWaitAll, uint dwMilliseconds = INFINITE);

        //  Threads
        public delegate void ThreadMethod(IntPtr data);
        //System.Threading.ThreadStart

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr CreateThread(IntPtr securityAttributes, uint stackSize, 
            ThreadMethod startFunction, IntPtr threadParameter, uint creationFlags, out uint threadId);
        //public static IntPtr CreateThread(ThreadMethod startFunction, IntPtr threadParameter, uint creationFlags = 0)
        //{
        //    uint dw;
        //    return CreateThread(IntPtr.Zero, 0, startFunction, threadParameter, creationFlags, out dw);
        //}
        public static IntPtr CreateThread(ThreadMethod startFunction, object threadParameter, uint creationFlags = 0)
        {
            if(threadParameter == null)
            {
                return CreateThread(IntPtr.Zero, 0, startFunction, IntPtr.Zero, creationFlags, out _);
            }
            var gptr = GCHandle.Alloc(threadParameter);
            var ptr = GCHandle.ToIntPtr(gptr);
            return CreateThread(IntPtr.Zero, 0, startFunction, ptr, creationFlags, out _);
        }
        public static object ToObject(IntPtr ptr)
        {
            if (ptr.Equals(IntPtr.Zero)) return null;
            GCHandle gch = GCHandle.FromIntPtr(ptr);
            var obj = gch.Target;
            gch.Free();
            return obj;
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint ResumeThread(IntPtr hThread);
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint SuspendThread(IntPtr hThread);
        [DllImport("kernel32.dll")]
        public static extern void ExitThread(uint dwExitCode = 0);
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TerminateThread(IntPtr hThread, uint dwExitCode = 0);
        // EVENTS
        [DllImport("kernel32.dll")]
        public static extern IntPtr CreateEvent(IntPtr lpEventAttributes, bool bManualReset, bool bInitialState, string lpName = null);
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetEvent(IntPtr hEvent);
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ResetEvent(IntPtr hEvent);
        [DllImport("Kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenEvent(uint dwDesiredAccess, bool bInheritHandle, string lpName);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr CreateMutex(IntPtr lpMutexAttributes, bool bInitialOwner, string lpName = null);
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReleaseMutex(IntPtr hMutex);
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenMutex(uint dwDesiredAccess, bool bInheritHandle, string lpName);

        // Waitable Timers
        
        public const long NanoToSec = -10000000;

        public delegate void TimerApcProc(IntPtr arg, uint lowTime, uint highTime);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr CreateWaitableTimer(IntPtr lpTimerAttributes, bool bManualReset, string lpTimerName);
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWaitableTimer(IntPtr hTimer, [In] ref long ft, int lPeriod, 
            TimerApcProc pfnCompletionRoutine, IntPtr pArgToCompletionRoutine, bool fResume);
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CancelWaitableTimer(IntPtr hTimer);
        [DllImport("Kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenWaitableTimer(uint dwDesiredAccess, bool bInheritHandle, string lpName);


        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr CreateSemaphore(IntPtr lpSemaphoreAttributes, long lInitialCount, long lMaxCount, string lpName = null);
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenSemaphore(uint dwDesiredAccess, bool bInheritHandle, string lpName);
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReleaseSemaphore(IntPtr hSemaphore, long lReleaseCount, out long lpPreviousCount);

        public static void Sleep(int timeMs)
        {
            Thread.Sleep(timeMs);
        }
        public static void Exit()
        {
            Console.WriteLine("Press <Enter> to exit.");
            Console.ReadLine();
            ExitProcess(0);
        }
        public class Barrier2 : IDisposable
        {
            public volatile int num_of_threads_that_entered_barrier = 0;
            public volatile int num_of_threads_that_exited_barrier = 0;
            public int Thread_count = 0;
            IntPtr entrance_semaphore = CreateSemaphore(IntPtr.Zero, 0, 4096, null);
            IntPtr exit_semaphore = CreateSemaphore(IntPtr.Zero, 0, 4096, null);
            public Barrier2(int thcount)
            {
                Thread_count = thcount;
            }
            public Barrier2():this(2)            {
            }

            public void Dispose()
            {
                CloseHandle(entrance_semaphore);
                CloseHandle(exit_semaphore);
            }
            public void Wait()
            {
                // Wait until all threads enter the barrier 
                if (Interlocked.Increment( ref num_of_threads_that_entered_barrier) < Thread_count)
                    WaitForSingleObject(entrance_semaphore, INFINITE);
                else
                {
                    num_of_threads_that_exited_barrier = 0;
                    //single_thread_callback();
                    ReleaseSemaphore(entrance_semaphore, Thread_count - 1, out _);
                }

                //all_threads_callback();

                // Wait until all threads exit the barrier 
                if (Interlocked.Increment(ref  num_of_threads_that_exited_barrier) < Thread_count)
                    WaitForSingleObject(exit_semaphore, INFINITE);
                else
                {
                    num_of_threads_that_entered_barrier = 0;
                    ReleaseSemaphore(exit_semaphore, Thread_count - 1, out _);
                }
            }
        }
    }
}
