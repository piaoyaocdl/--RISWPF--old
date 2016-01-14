// <copyright file="CeshiTest.cs" company="Microsoft">Copyright © Microsoft 2016</copyright>
using System;
using HSWRIS;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HSWRIS.Tests
{
    /// <summary>此类包含 Ceshi 的参数化单元测试</summary>
    [PexClass(typeof(Ceshi))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class CeshiTest
    {
        /// <summary>测试 main() 的存根</summary>
        [PexMethod]
        internal void mainTest()
        {
            Ceshi.main();
            // TODO: 将断言添加到 方法 CeshiTest.mainTest()
        }
    }
}
