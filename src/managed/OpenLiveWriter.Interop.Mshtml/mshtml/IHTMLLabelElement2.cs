// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for details.

namespace mshtml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, Guid("3050F832-98B5-11CF-BB82-00AA00BDCE0B"), TypeLibType((short) 0x1040)]
    public interface IHTMLLabelElement2
    {
        [DispId(0x3ea)]
        IHTMLFormElement form { [return: MarshalAs(UnmanagedType.Interface)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x3ea)] get; }
    }
}

