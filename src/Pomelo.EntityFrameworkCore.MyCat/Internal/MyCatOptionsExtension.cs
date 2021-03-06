// Copyright (c) Pomelo Foundation. All rights reserved.
// Licensed under the MIT. See LICENSE in the project root for license information.

using System;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Utilities;
using Microsoft.Extensions.DependencyInjection;

// ReSharper disable once CheckNamespace
namespace Microsoft.EntityFrameworkCore.Internal
{
    public class MyCatOptionsExtension : RelationalOptionsExtension
    {
        public MyCatOptionsExtension()
        {
            this.MaxBatchSize = 1;
        }

        public MyCatOptionsExtension([NotNull] MyCatOptionsExtension copyFrom)
            : base(copyFrom)
        {
        }

        public override void ApplyServices(IServiceCollection services)
                  => Check.NotNull(services, nameof(services)).AddEntityFrameworkMyCat();
    }
}
