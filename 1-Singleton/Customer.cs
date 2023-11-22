using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Singleton
{
    #region singleton design pattern - 1
    //public class Customer
    //{
    //    static Customer _obj = null;
    //    private Customer() { }

    //    public static Customer Instance
    //    {
    //        get
    //        {
    //            if(_obj == null)
    //            {
    //                _obj = new Customer();
    //            }
    //            return _obj;
    //        }
    //    }

    //}
    #endregion singleton design pattern - 2

    #region singleton design pattern - 2
    //public class Customer
    //{
    //    static Customer _obj = null;
    //    private Customer() { }

    //    static object _o = new object();

    //    public static Customer Instance
    //    {
    //        get
    //        {
    //            lock (_o)
    //            {
    //                if (_obj == null)
    //                {
    //                    _obj = new Customer();
    //                }
    //                return _obj;
    //            }
    //        }
    //    }
    //}
    #endregion singleton design pattern - 2

    #region singleton design pattern - 3
    //public class Customer
    //{
    //    static Customer _obj = null;
    //    private Customer() { }

    //    static object _o = new object();

    //    public static Customer Instance
    //    {
    //        get
    //        {
    //            if (_obj == null)
    //            {
    //                lock (_o)
    //                {
    //                    if (_obj == null)
    //                    {
    //                        _obj = new Customer();
    //                    }
    //                    return _obj;
    //                }
    //            }
    //            return _obj;
    //        }
    //    }
    //}
    #endregion singleton design pattern - 3

    #region singleton design pattern - 4
    //public class Customer
    //{
    //    static Customer _obj = null;
    //    private Customer() { }

    //    static object _o = new object();

    //    //public static Customer Instance
    //    //{
    //    //    get
    //    //    {
    //    //        if (_obj == null)
    //    //        {
    //    //            lock (_o)
    //    //            {
    //    //                if (_obj == null)
    //    //                {
    //    //                    _obj = new Customer();
    //    //                }
    //    //                return _obj;
    //    //            }
    //    //        }
    //    //        return _obj;
    //    //    }
    //    //}

    //    public static Customer GetInstance()
    //    {
    //        if (_obj == null)
    //        {
    //            lock (_o)
    //            {
    //                if (_obj == null)
    //                {
    //                    _obj = new Customer();
    //                }
    //                return _obj;
    //            }
    //        }
    //        return _obj;
    //    }
    //}
    #endregion singleton design pattern - 4

    #region singleton design pattern - 5

    //// restrict object to 5 only
    //public class Customer
    //{
    //    static Customer _obj = null;
    //    static int _counter = 1;
    //    private Customer() { }

    //    static object _o = new object();

    //    public static Customer Instance
    //    {
    //        get
    //        {
    //            if (_counter <= 5)
    //            {
    //                _obj = new Customer();
    //                _counter++;
    //            }
    //            else
    //            {
    //                Console.WriteLine("Only 5 Objects are possible");
    //            }

    //            return _obj;
    //        }
    //    }
    //}
    #endregion singleton design pattern - 5

    #region singleton design pattern - 6
    public sealed class Customer
    {
        static Customer _obj = null;
        private Customer() { }

        static object _o = new object();

        public static Customer Instance
        {
            get
            {
                if (_obj == null)
                {
                    lock (_o)
                    {
                        if (_obj == null)
                        {
                            _obj = new Customer();
                        }
                        return _obj;
                    }
                }
                return _obj;
            }
        }
    }
    #endregion singleton design pattern - 6

}
