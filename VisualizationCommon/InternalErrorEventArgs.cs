using System;

namespace Semantic.WpfCommon
{
  public class InternalErrorEventArgs : EventArgs
  {
    public Exception InternalErrorException { get; private set; }

    public InternalErrorEventArgs(Exception ex)
    {
      this.InternalErrorException = ex;
    }
  }
}
