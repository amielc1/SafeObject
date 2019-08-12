using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SafeObject
{
    public class SafeObject<T>
    {
        ReaderWriterLock rwl = new ReaderWriterLock();
        int readTimeOut, writeTimeOut;
        public SafeObject(int readTimeOut,int writeTimeout )
        {
            this.readTimeOut = readTimeOut;
            this.writeTimeOut = writeTimeout;
        }
        public SafeObject(int timeOut)
        {
            this.readTimeOut = timeOut;
            this.writeTimeOut = timeOut;
        }
        public SafeObject() : this(Timeout.Infinite, Timeout.Infinite) { }

        T _Value;
        public T Value
        {
            get
            {
                rwl.AcquireReaderLock(readTimeOut);
                try
                {
                    return _Value;
                }
                finally
                {
                    rwl.ReleaseReaderLock();
                }
            }
            set
            {
                rwl.AcquireWriterLock(writeTimeOut);
                try
                {
                    _Value = value;
                }
                finally
                {
                    rwl.ReleaseWriterLock();
                }
            }
        }


    }
}
