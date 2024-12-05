﻿using InternetShop.BAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.BAL.Contracts
{
    public interface IImageUploader:IFileStorageClient<Result<IEnumerable<string>>>
    {
    }
}
