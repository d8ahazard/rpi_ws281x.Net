//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


class rpi_ws281xPINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="SWIGRegisterExceptionCallbacks_rpi_ws281x")]
    public static extern void SWIGRegisterExceptionCallbacks_rpi_ws281x(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_rpi_ws281x")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_rpi_ws281x(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new global::System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new global::System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new global::System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new global::System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new global::System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new global::System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new global::System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new global::System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new global::System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new global::System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new global::System.SystemException(message, SWIGPendingException.Retrieve()));
    }

    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new global::System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArgumentNullException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentNullException(paramName, message));
    }
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_rpi_ws281x(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_rpi_ws281x(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [global::System.ThreadStatic]
    private static global::System.Exception pendingException = null;
    private static int numExceptionsPending = 0;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(global::System.Exception e) {
      if (pendingException != null)
        throw new global::System.ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(typeof(rpi_ws281xPINVOKE)) {
        numExceptionsPending++;
      }
    }

    public static global::System.Exception Retrieve() {
      global::System.Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(typeof(rpi_ws281xPINVOKE)) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="SWIGRegisterStringCallback_rpi_ws281x")]
    public static extern void SWIGRegisterStringCallback_rpi_ws281x(SWIGStringDelegate stringDelegate);

    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_rpi_ws281x(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static rpi_ws281xPINVOKE() {
  }


  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_WS2811_TARGET_FREQ_get")]
  public static extern int WS2811_TARGET_FREQ_get();

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_SK6812_STRIP_RGBW_get")]
  public static extern int SK6812_STRIP_RGBW_get();

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_SK6812_STRIP_RBGW_get")]
  public static extern int SK6812_STRIP_RBGW_get();

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_SK6812_STRIP_GRBW_get")]
  public static extern int SK6812_STRIP_GRBW_get();

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_SK6812_STRIP_GBRW_get")]
  public static extern int SK6812_STRIP_GBRW_get();

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_SK6812_STRIP_BRGW_get")]
  public static extern int SK6812_STRIP_BRGW_get();

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_SK6812_STRIP_BGRW_get")]
  public static extern int SK6812_STRIP_BGRW_get();

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_SK6812_SHIFT_WMASK_get")]
  public static extern int SK6812_SHIFT_WMASK_get();

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_WS2811_STRIP_RGB_get")]
  public static extern int WS2811_STRIP_RGB_get();

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_WS2811_STRIP_RBG_get")]
  public static extern int WS2811_STRIP_RBG_get();

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_WS2811_STRIP_GRB_get")]
  public static extern int WS2811_STRIP_GRB_get();

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_WS2811_STRIP_GBR_get")]
  public static extern int WS2811_STRIP_GBR_get();

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_WS2811_STRIP_BRG_get")]
  public static extern int WS2811_STRIP_BRG_get();

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_WS2811_STRIP_BGR_get")]
  public static extern int WS2811_STRIP_BGR_get();

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_WS2812_STRIP_get")]
  public static extern int WS2812_STRIP_get();

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_SK6812_STRIP_get")]
  public static extern int SK6812_STRIP_get();

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_SK6812W_STRIP_get")]
  public static extern int SK6812W_STRIP_get();

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_channel_t_gpionum_set")]
  public static extern void ws2811_channel_t_gpionum_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_channel_t_gpionum_get")]
  public static extern int ws2811_channel_t_gpionum_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_channel_t_invert_set")]
  public static extern void ws2811_channel_t_invert_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_channel_t_invert_get")]
  public static extern int ws2811_channel_t_invert_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_channel_t_count_set")]
  public static extern void ws2811_channel_t_count_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_channel_t_count_get")]
  public static extern int ws2811_channel_t_count_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_channel_t_strip_type_set")]
  public static extern void ws2811_channel_t_strip_type_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_channel_t_strip_type_get")]
  public static extern int ws2811_channel_t_strip_type_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_channel_t_leds_set")]
  public static extern void ws2811_channel_t_leds_set(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_channel_t_leds_get")]
  public static extern global::System.IntPtr ws2811_channel_t_leds_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_channel_t_brightness_set")]
  public static extern void ws2811_channel_t_brightness_set(global::System.Runtime.InteropServices.HandleRef jarg1, byte jarg2);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_channel_t_brightness_get")]
  public static extern byte ws2811_channel_t_brightness_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_channel_t_wshift_set")]
  public static extern void ws2811_channel_t_wshift_set(global::System.Runtime.InteropServices.HandleRef jarg1, byte jarg2);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_channel_t_wshift_get")]
  public static extern byte ws2811_channel_t_wshift_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_channel_t_rshift_set")]
  public static extern void ws2811_channel_t_rshift_set(global::System.Runtime.InteropServices.HandleRef jarg1, byte jarg2);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_channel_t_rshift_get")]
  public static extern byte ws2811_channel_t_rshift_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_channel_t_gshift_set")]
  public static extern void ws2811_channel_t_gshift_set(global::System.Runtime.InteropServices.HandleRef jarg1, byte jarg2);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_channel_t_gshift_get")]
  public static extern byte ws2811_channel_t_gshift_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_channel_t_bshift_set")]
  public static extern void ws2811_channel_t_bshift_set(global::System.Runtime.InteropServices.HandleRef jarg1, byte jarg2);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_channel_t_bshift_get")]
  public static extern byte ws2811_channel_t_bshift_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_channel_t_gamma_set")]
  public static extern void ws2811_channel_t_gamma_set(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_channel_t_gamma_get")]
  public static extern global::System.IntPtr ws2811_channel_t_gamma_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_new_ws2811_channel_t")]
  public static extern global::System.IntPtr new_ws2811_channel_t();

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_delete_ws2811_channel_t")]
  public static extern void delete_ws2811_channel_t(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_t_render_wait_time_set")]
  public static extern void ws2811_t_render_wait_time_set(global::System.Runtime.InteropServices.HandleRef jarg1, ulong jarg2);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_t_render_wait_time_get")]
  public static extern ulong ws2811_t_render_wait_time_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_t_device_set")]
  public static extern void ws2811_t_device_set(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_t_device_get")]
  public static extern global::System.IntPtr ws2811_t_device_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_t_rpi_hw_set")]
  public static extern void ws2811_t_rpi_hw_set(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_t_rpi_hw_get")]
  public static extern global::System.IntPtr ws2811_t_rpi_hw_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_t_freq_set")]
  public static extern void ws2811_t_freq_set(global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_t_freq_get")]
  public static extern uint ws2811_t_freq_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_t_dmanum_set")]
  public static extern void ws2811_t_dmanum_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_t_dmanum_get")]
  public static extern int ws2811_t_dmanum_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_t_channel_set")]
  public static extern void ws2811_t_channel_set(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_t_channel_get")]
  public static extern global::System.IntPtr ws2811_t_channel_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_new_ws2811_t")]
  public static extern global::System.IntPtr new_ws2811_t();

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_delete_ws2811_t")]
  public static extern void delete_ws2811_t(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_init")]
  public static extern int ws2811_init(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_fini")]
  public static extern void ws2811_fini(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_render")]
  public static extern int ws2811_render(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_wait")]
  public static extern int ws2811_wait(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_get_return_t_str")]
  public static extern string ws2811_get_return_t_str(int jarg1);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_led_get")]
  public static extern uint ws2811_led_get(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_led_set")]
  public static extern int ws2811_led_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, uint jarg3);

  [global::System.Runtime.InteropServices.DllImport("rpi_ws281x", EntryPoint="CSharp_ws2811_channel_get")]
  public static extern global::System.IntPtr ws2811_channel_get(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
}
