﻿using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductsWithTypesAndBrandsSpecification()
        {
            AddInclude(p => p.ProductType);
            AddInclude(p => p.ProductBrand);
        }

        public ProductsWithTypesAndBrandsSpecification(int id)
            : base(r => r.Id == id)
        {
            AddInclude(p => p.ProductType);
            AddInclude(p => p.ProductBrand);
        }
    }
}
