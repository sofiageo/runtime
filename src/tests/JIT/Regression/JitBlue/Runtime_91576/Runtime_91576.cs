// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.aa

// Generated by Fuzzlyn v1.6 on 2023-09-03 15:59:01
// Run on X64 Windows
// Seed: 11520325105937570553
// Reduced from 294.5 KiB to 0.7 KiB in 00:04:32
// Debug: Outputs False
// Release: Outputs True
using System;
using System.Runtime.CompilerServices;
using Xunit;

public class Runtime_91576
{
    [Fact]
    public static int TestEntryPoint()
    {
        Assert.Throws<NullReferenceException>(() =>
        {
            Run(new int[1]);
            Run(null);
        });

        return s_result;
    }

    static int s_result;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void Run(int[] l)
    {
        bool b = false;
        try
        {
            int result = l[0];
            b = true;
        }
        finally
        {
            Check(ref b);
        }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void Check(ref bool b)
    {
        s_result = b ? 101 : 100;
    }
}

