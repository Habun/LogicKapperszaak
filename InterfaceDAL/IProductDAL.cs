﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
   public interface IProductDAL
    {
        void UpdateProduct(ProductInfoDal productInfo);
        ProductInfoDal ProductIdOphalen(int productId);
    }
}
