using System;
using System.Collections.Generic;
using System.Text;
using Result.Localization;
using Volo.Abp.Application.Services;

namespace Result;

/* Inherit your application services from this class.
 */
public abstract class ResultAppService : ApplicationService
{
    protected ResultAppService()
    {
        LocalizationResource = typeof(ResultResource);
    }
}
