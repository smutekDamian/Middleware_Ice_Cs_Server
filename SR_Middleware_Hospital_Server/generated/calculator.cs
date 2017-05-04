// **********************************************************************
//
// Copyright (c) 2003-2016 ZeroC, Inc. All rights reserved.
//
// This copy of Ice is licensed to you under the terms described in the
// ICE_LICENSE file included in this distribution.
//
// **********************************************************************
//
// Ice version 3.6.3
//
// <auto-generated>
//
// Generated from file `calculator.ice'
//
// Warning: do not edit this file.
//
// </auto-generated>
//


using _System = global::System;
using _Microsoft = global::Microsoft;

#pragma warning disable 1591

namespace IceCompactId
{
}

namespace Demo
{
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.6.3")]
    public enum operation
    {
        MIN,
        MAX,
        AVG
    }

    [_System.Runtime.InteropServices.ComVisible(false)]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1715")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1722")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1724")]
    public partial interface Calc : Ice.Object, CalcOperations_, CalcOperationsNC_
    {
    }
}

namespace Demo
{
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.6.3")]
    public delegate void Callback_Calc_add(long ret__);

    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.6.3")]
    public delegate void Callback_Calc_subtract(long ret__);
}

namespace Demo
{
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.6.3")]
    public interface CalcPrx : Ice.ObjectPrx
    {
        long add(int a, int b);

        long add(int a, int b, _System.Collections.Generic.Dictionary<string, string> ctx__);

        Ice.AsyncResult<Demo.Callback_Calc_add> begin_add(int a, int b);

        Ice.AsyncResult<Demo.Callback_Calc_add> begin_add(int a, int b, _System.Collections.Generic.Dictionary<string, string> ctx__);

        Ice.AsyncResult begin_add(int a, int b, Ice.AsyncCallback cb__, object cookie__);

        Ice.AsyncResult begin_add(int a, int b, _System.Collections.Generic.Dictionary<string, string> ctx__, Ice.AsyncCallback cb__, object cookie__);

        long end_add(Ice.AsyncResult r__);

        long subtract(int a, int b);

        long subtract(int a, int b, _System.Collections.Generic.Dictionary<string, string> ctx__);

        Ice.AsyncResult<Demo.Callback_Calc_subtract> begin_subtract(int a, int b);

        Ice.AsyncResult<Demo.Callback_Calc_subtract> begin_subtract(int a, int b, _System.Collections.Generic.Dictionary<string, string> ctx__);

        Ice.AsyncResult begin_subtract(int a, int b, Ice.AsyncCallback cb__, object cookie__);

        Ice.AsyncResult begin_subtract(int a, int b, _System.Collections.Generic.Dictionary<string, string> ctx__, Ice.AsyncCallback cb__, object cookie__);

        long end_subtract(Ice.AsyncResult r__);
    }
}

namespace Demo
{
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.6.3")]
    public interface CalcOperations_
    {
        long add(int a, int b, Ice.Current current__);

        long subtract(int a, int b, Ice.Current current__);
    }

    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.6.3")]
    public interface CalcOperationsNC_
    {
        long add(int a, int b);

        long subtract(int a, int b);
    }
}

namespace Demo
{
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.6.3")]
    public sealed class seqofNumbersHelper
    {
        public static void write(IceInternal.BasicStream os__, long[] v__)
        {
            os__.writeLongSeq(v__);
        }

        public static long[] read(IceInternal.BasicStream is__)
        {
            long[] v__;
            v__ = is__.readLongSeq();
            return v__;
        }
    }

    [_System.Runtime.InteropServices.ComVisible(false)]
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.6.3")]
    public sealed class CalcPrxHelper : Ice.ObjectPrxHelperBase, CalcPrx
    {
        #region Synchronous operations

        public long add(int a, int b)
        {
            return this.add(a, b, null, false);
        }

        public long add(int a, int b, _System.Collections.Generic.Dictionary<string, string> ctx__)
        {
            return this.add(a, b, ctx__, true);
        }

        private long add(int a, int b, _System.Collections.Generic.Dictionary<string, string> context__, bool explicitCtx__)
        {
            checkTwowayOnly__(__add_name);
            return end_add(begin_add(a, b, context__, explicitCtx__, true, null, null));
        }

        public long subtract(int a, int b)
        {
            return this.subtract(a, b, null, false);
        }

        public long subtract(int a, int b, _System.Collections.Generic.Dictionary<string, string> ctx__)
        {
            return this.subtract(a, b, ctx__, true);
        }

        private long subtract(int a, int b, _System.Collections.Generic.Dictionary<string, string> context__, bool explicitCtx__)
        {
            checkTwowayOnly__(__subtract_name);
            return end_subtract(begin_subtract(a, b, context__, explicitCtx__, true, null, null));
        }

        #endregion

        #region Asynchronous operations

        public Ice.AsyncResult<Demo.Callback_Calc_add> begin_add(int a, int b)
        {
            return begin_add(a, b, null, false, false, null, null);
        }

        public Ice.AsyncResult<Demo.Callback_Calc_add> begin_add(int a, int b, _System.Collections.Generic.Dictionary<string, string> ctx__)
        {
            return begin_add(a, b, ctx__, true, false, null, null);
        }

        public Ice.AsyncResult begin_add(int a, int b, Ice.AsyncCallback cb__, object cookie__)
        {
            return begin_add(a, b, null, false, false, cb__, cookie__);
        }

        public Ice.AsyncResult begin_add(int a, int b, _System.Collections.Generic.Dictionary<string, string> ctx__, Ice.AsyncCallback cb__, object cookie__)
        {
            return begin_add(a, b, ctx__, true, false, cb__, cookie__);
        }

        private const string __add_name = "add";

        public long end_add(Ice.AsyncResult r__)
        {
            IceInternal.OutgoingAsync outAsync__ = IceInternal.OutgoingAsync.check(r__, this, __add_name);
            try
            {
                if(!outAsync__.wait())
                {
                    try
                    {
                        outAsync__.throwUserException();
                    }
                    catch(Ice.UserException ex__)
                    {
                        throw new Ice.UnknownUserException(ex__.ice_name(), ex__);
                    }
                }
                long ret__;
                IceInternal.BasicStream is__ = outAsync__.startReadParams();
                ret__ = is__.readLong();
                outAsync__.endReadParams();
                return ret__;
            }
            finally
            {
                outAsync__.cacheMessageBuffers();
            }
        }

        private Ice.AsyncResult<Demo.Callback_Calc_add> begin_add(int a, int b, _System.Collections.Generic.Dictionary<string, string> ctx__, bool explicitContext__, bool synchronous__, Ice.AsyncCallback cb__, object cookie__)
        {
            checkAsyncTwowayOnly__(__add_name);
            IceInternal.TwowayOutgoingAsync<Demo.Callback_Calc_add> result__ =  getTwowayOutgoingAsync<Demo.Callback_Calc_add>(__add_name, add_completed__, cookie__);
            if(cb__ != null)
            {
                result__.whenCompletedWithAsyncCallback(cb__);
            }
            try
            {
                result__.prepare(__add_name, Ice.OperationMode.Normal, ctx__, explicitContext__, synchronous__);
                IceInternal.BasicStream os__ = result__.startWriteParams(Ice.FormatType.DefaultFormat);
                os__.writeInt(a);
                os__.writeInt(b);
                result__.endWriteParams();
                result__.invoke();
            }
            catch(Ice.Exception ex__)
            {
                result__.abort(ex__);
            }
            return result__;
        }

        private void add_completed__(Ice.AsyncResult r__, Demo.Callback_Calc_add cb__, Ice.ExceptionCallback excb__)
        {
            long ret__;
            try
            {
                ret__ = end_add(r__);
            }
            catch(Ice.Exception ex__)
            {
                if(excb__ != null)
                {
                    excb__(ex__);
                }
                return;
            }
            if(cb__ != null)
            {
                cb__(ret__);
            }
        }

        public Ice.AsyncResult<Demo.Callback_Calc_subtract> begin_subtract(int a, int b)
        {
            return begin_subtract(a, b, null, false, false, null, null);
        }

        public Ice.AsyncResult<Demo.Callback_Calc_subtract> begin_subtract(int a, int b, _System.Collections.Generic.Dictionary<string, string> ctx__)
        {
            return begin_subtract(a, b, ctx__, true, false, null, null);
        }

        public Ice.AsyncResult begin_subtract(int a, int b, Ice.AsyncCallback cb__, object cookie__)
        {
            return begin_subtract(a, b, null, false, false, cb__, cookie__);
        }

        public Ice.AsyncResult begin_subtract(int a, int b, _System.Collections.Generic.Dictionary<string, string> ctx__, Ice.AsyncCallback cb__, object cookie__)
        {
            return begin_subtract(a, b, ctx__, true, false, cb__, cookie__);
        }

        private const string __subtract_name = "subtract";

        public long end_subtract(Ice.AsyncResult r__)
        {
            IceInternal.OutgoingAsync outAsync__ = IceInternal.OutgoingAsync.check(r__, this, __subtract_name);
            try
            {
                if(!outAsync__.wait())
                {
                    try
                    {
                        outAsync__.throwUserException();
                    }
                    catch(Ice.UserException ex__)
                    {
                        throw new Ice.UnknownUserException(ex__.ice_name(), ex__);
                    }
                }
                long ret__;
                IceInternal.BasicStream is__ = outAsync__.startReadParams();
                ret__ = is__.readLong();
                outAsync__.endReadParams();
                return ret__;
            }
            finally
            {
                outAsync__.cacheMessageBuffers();
            }
        }

        private Ice.AsyncResult<Demo.Callback_Calc_subtract> begin_subtract(int a, int b, _System.Collections.Generic.Dictionary<string, string> ctx__, bool explicitContext__, bool synchronous__, Ice.AsyncCallback cb__, object cookie__)
        {
            checkAsyncTwowayOnly__(__subtract_name);
            IceInternal.TwowayOutgoingAsync<Demo.Callback_Calc_subtract> result__ =  getTwowayOutgoingAsync<Demo.Callback_Calc_subtract>(__subtract_name, subtract_completed__, cookie__);
            if(cb__ != null)
            {
                result__.whenCompletedWithAsyncCallback(cb__);
            }
            try
            {
                result__.prepare(__subtract_name, Ice.OperationMode.Normal, ctx__, explicitContext__, synchronous__);
                IceInternal.BasicStream os__ = result__.startWriteParams(Ice.FormatType.DefaultFormat);
                os__.writeInt(a);
                os__.writeInt(b);
                result__.endWriteParams();
                result__.invoke();
            }
            catch(Ice.Exception ex__)
            {
                result__.abort(ex__);
            }
            return result__;
        }

        private void subtract_completed__(Ice.AsyncResult r__, Demo.Callback_Calc_subtract cb__, Ice.ExceptionCallback excb__)
        {
            long ret__;
            try
            {
                ret__ = end_subtract(r__);
            }
            catch(Ice.Exception ex__)
            {
                if(excb__ != null)
                {
                    excb__(ex__);
                }
                return;
            }
            if(cb__ != null)
            {
                cb__(ret__);
            }
        }

        #endregion

        #region Checked and unchecked cast operations

        public static CalcPrx checkedCast(Ice.ObjectPrx b)
        {
            if(b == null)
            {
                return null;
            }
            CalcPrx r = b as CalcPrx;
            if((r == null) && b.ice_isA(ice_staticId()))
            {
                CalcPrxHelper h = new CalcPrxHelper();
                h.copyFrom__(b);
                r = h;
            }
            return r;
        }

        public static CalcPrx checkedCast(Ice.ObjectPrx b, _System.Collections.Generic.Dictionary<string, string> ctx)
        {
            if(b == null)
            {
                return null;
            }
            CalcPrx r = b as CalcPrx;
            if((r == null) && b.ice_isA(ice_staticId(), ctx))
            {
                CalcPrxHelper h = new CalcPrxHelper();
                h.copyFrom__(b);
                r = h;
            }
            return r;
        }

        public static CalcPrx checkedCast(Ice.ObjectPrx b, string f)
        {
            if(b == null)
            {
                return null;
            }
            Ice.ObjectPrx bb = b.ice_facet(f);
            try
            {
                if(bb.ice_isA(ice_staticId()))
                {
                    CalcPrxHelper h = new CalcPrxHelper();
                    h.copyFrom__(bb);
                    return h;
                }
            }
            catch(Ice.FacetNotExistException)
            {
            }
            return null;
        }

        public static CalcPrx checkedCast(Ice.ObjectPrx b, string f, _System.Collections.Generic.Dictionary<string, string> ctx)
        {
            if(b == null)
            {
                return null;
            }
            Ice.ObjectPrx bb = b.ice_facet(f);
            try
            {
                if(bb.ice_isA(ice_staticId(), ctx))
                {
                    CalcPrxHelper h = new CalcPrxHelper();
                    h.copyFrom__(bb);
                    return h;
                }
            }
            catch(Ice.FacetNotExistException)
            {
            }
            return null;
        }

        public static CalcPrx uncheckedCast(Ice.ObjectPrx b)
        {
            if(b == null)
            {
                return null;
            }
            CalcPrx r = b as CalcPrx;
            if(r == null)
            {
                CalcPrxHelper h = new CalcPrxHelper();
                h.copyFrom__(b);
                r = h;
            }
            return r;
        }

        public static CalcPrx uncheckedCast(Ice.ObjectPrx b, string f)
        {
            if(b == null)
            {
                return null;
            }
            Ice.ObjectPrx bb = b.ice_facet(f);
            CalcPrxHelper h = new CalcPrxHelper();
            h.copyFrom__(bb);
            return h;
        }

        public static readonly string[] ids__ =
        {
            "::Demo::Calc",
            "::Ice::Object"
        };

        public static string ice_staticId()
        {
            return ids__[0];
        }

        #endregion

        #region Marshaling support

        public static void write__(IceInternal.BasicStream os__, CalcPrx v__)
        {
            os__.writeProxy(v__);
        }

        public static CalcPrx read__(IceInternal.BasicStream is__)
        {
            Ice.ObjectPrx proxy = is__.readProxy();
            if(proxy != null)
            {
                CalcPrxHelper result = new CalcPrxHelper();
                result.copyFrom__(proxy);
                return result;
            }
            return null;
        }

        #endregion
    }
}

namespace Demo
{
    [_System.Runtime.InteropServices.ComVisible(false)]
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.6.3")]
    public abstract class CalcDisp_ : Ice.ObjectImpl, Calc
    {
        #region Slice operations

        public long add(int a, int b)
        {
            return add(a, b, Ice.ObjectImpl.defaultCurrent);
        }

        public abstract long add(int a, int b, Ice.Current current__);

        public long subtract(int a, int b)
        {
            return subtract(a, b, Ice.ObjectImpl.defaultCurrent);
        }

        public abstract long subtract(int a, int b, Ice.Current current__);

        #endregion

        #region Slice type-related members

        public static new readonly string[] ids__ = 
        {
            "::Demo::Calc",
            "::Ice::Object"
        };

        public override bool ice_isA(string s)
        {
            return _System.Array.BinarySearch(ids__, s, IceUtilInternal.StringUtil.OrdinalStringComparer) >= 0;
        }

        public override bool ice_isA(string s, Ice.Current current__)
        {
            return _System.Array.BinarySearch(ids__, s, IceUtilInternal.StringUtil.OrdinalStringComparer) >= 0;
        }

        public override string[] ice_ids()
        {
            return ids__;
        }

        public override string[] ice_ids(Ice.Current current__)
        {
            return ids__;
        }

        public override string ice_id()
        {
            return ids__[0];
        }

        public override string ice_id(Ice.Current current__)
        {
            return ids__[0];
        }

        public static new string ice_staticId()
        {
            return ids__[0];
        }

        #endregion

        #region Operation dispatch

        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static Ice.DispatchStatus add___(Calc obj__, IceInternal.Incoming inS__, Ice.Current current__)
        {
            Ice.ObjectImpl.checkMode__(Ice.OperationMode.Normal, current__.mode);
            IceInternal.BasicStream is__ = inS__.startReadParams();
            int a;
            int b;
            a = is__.readInt();
            b = is__.readInt();
            inS__.endReadParams();
            long ret__ = obj__.add(a, b, current__);
            IceInternal.BasicStream os__ = inS__.startWriteParams__(Ice.FormatType.DefaultFormat);
            os__.writeLong(ret__);
            inS__.endWriteParams__(true);
            return Ice.DispatchStatus.DispatchOK;
        }

        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static Ice.DispatchStatus subtract___(Calc obj__, IceInternal.Incoming inS__, Ice.Current current__)
        {
            Ice.ObjectImpl.checkMode__(Ice.OperationMode.Normal, current__.mode);
            IceInternal.BasicStream is__ = inS__.startReadParams();
            int a;
            int b;
            a = is__.readInt();
            b = is__.readInt();
            inS__.endReadParams();
            long ret__ = obj__.subtract(a, b, current__);
            IceInternal.BasicStream os__ = inS__.startWriteParams__(Ice.FormatType.DefaultFormat);
            os__.writeLong(ret__);
            inS__.endWriteParams__(true);
            return Ice.DispatchStatus.DispatchOK;
        }

        private static string[] all__ =
        {
            "add",
            "ice_id",
            "ice_ids",
            "ice_isA",
            "ice_ping",
            "subtract"
        };

        public override Ice.DispatchStatus dispatch__(IceInternal.Incoming inS__, Ice.Current current__)
        {
            int pos = _System.Array.BinarySearch(all__, current__.operation, IceUtilInternal.StringUtil.OrdinalStringComparer);
            if(pos < 0)
            {
                throw new Ice.OperationNotExistException(current__.id, current__.facet, current__.operation);
            }

            switch(pos)
            {
                case 0:
                {
                    return add___(this, inS__, current__);
                }
                case 1:
                {
                    return Ice.ObjectImpl.ice_id___(this, inS__, current__);
                }
                case 2:
                {
                    return Ice.ObjectImpl.ice_ids___(this, inS__, current__);
                }
                case 3:
                {
                    return Ice.ObjectImpl.ice_isA___(this, inS__, current__);
                }
                case 4:
                {
                    return Ice.ObjectImpl.ice_ping___(this, inS__, current__);
                }
                case 5:
                {
                    return subtract___(this, inS__, current__);
                }
            }

            _System.Diagnostics.Debug.Assert(false);
            throw new Ice.OperationNotExistException(current__.id, current__.facet, current__.operation);
        }

        #endregion

        #region Marshaling support

        protected override void writeImpl__(IceInternal.BasicStream os__)
        {
            os__.startWriteSlice(ice_staticId(), -1, true);
            os__.endWriteSlice();
        }

        protected override void readImpl__(IceInternal.BasicStream is__)
        {
            is__.startReadSlice();
            is__.endReadSlice();
        }

        #endregion
    }
}