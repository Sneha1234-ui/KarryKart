﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace Contracts
    {
        public interface ISEO
        {
            Task<IEnumerable<SEO>> GetSEO();
            Task<SEO> AddSEO(SEO seo);
            Task<SEO> UpdateSEO(SEO seo);
            Task<SEO> DeleteSEO(SEO seo);
            Task<SEO> GetSEOById(int seoId);
            Task<IQueryable<SEO>> GetSEOByName(string name);
    }
    }

