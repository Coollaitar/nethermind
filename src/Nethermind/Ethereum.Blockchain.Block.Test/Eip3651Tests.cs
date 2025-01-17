// SPDX-FileCopyrightText: 2022 Demerzel Solutions Limited
// SPDX-License-Identifier: LGPL-3.0-only

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ethereum.Test.Base;
using FluentAssertions;
using NUnit.Framework;

namespace Ethereum.Blockchain.Block.Test;

[TestFixture]
[Parallelizable(ParallelScope.All)]
public class Eip3651Tests : BlockchainTestBase
{
    [TestCaseSource(nameof(LoadTests))]
    public async Task Test(BlockchainTest test)
    {
        await RunTest(test);
    }

    public static IEnumerable<BlockchainTest> LoadTests()
    {
        var loader = new TestsSourceLoader(new LoadLocalTestsStrategy(), "eip3651");
        return (IEnumerable<BlockchainTest>)loader.LoadTests();
    }
}
