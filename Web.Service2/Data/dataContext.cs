using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using Web.Data2.EF;


namespace Web.Service2.Data
{
    public class dataContext:IdataContext
    {
        private readonly apom_app_svContext _context;
        public dataContext(apom_app_svContext context)
        {
            _context = context;
        }

        public async Task<int> CreateTableGeotiffIndex(int year)
        {
            string sqlQuery = $@"CREATE TABLE IF NOT EXISTS public.a_component_geotiff_index_mem_pm25_{year} 
            ( 
                oid serial, 
                row_index integer, 
                category_id character varying(50) COLLATE pg_catalog.""default"", 
                from_cell integer, 
                to_cell integer, 
                CONSTRAINT a_component_geotiff_index_pm25_{year}_pkey PRIMARY KEY(oid), 
                CONSTRAINT a_component_geotiff_index_mem_pm25_{year}_category_id_fkey FOREIGN KEY(category_id) 
                    REFERENCES public.a_component_geotiff_daily(category_id) MATCH SIMPLE 
                    ON UPDATE NO ACTION 
                    ON DELETE NO ACTION 
                    NOT VALID 
            ) 
            TABLESPACE pg_default; 
            ALTER TABLE IF EXISTS public.a_component_geotiff_index_mem_pm25_{year} 
                OWNER to sv;";
            var item = await _context.Database.ExecuteSqlRawAsync(sqlQuery);
            return item;
        }

        public async Task<int> CreateTableGeotiffVal(int year)
        {
            string sqlQuery = $@"CREATE TABLE IF NOT EXISTS public.a_component_geotiff_val_mem_pm25_{year} 
            ( 
                oid serial, 
                row_index integer, 
                minx double precision, 
                maxx double precision, 
                miny double precision, 
                maxy double precision, 
                row_val text COLLATE pg_catalog.""default"", 
                category_id character varying(50) COLLATE pg_catalog.""default"", 
                row_val_aqi text COLLATE pg_catalog.""default"", 
                CONSTRAINT a_component_geotiff_val_pm25_{year}_pkey PRIMARY KEY(oid), 
                CONSTRAINT a_component_geotiff_val_mem_pm25_{year}_category_id_fkey FOREIGN KEY(category_id) 
                    REFERENCES public.a_component_geotiff_daily(category_id) MATCH SIMPLE 
                    ON UPDATE NO ACTION 
                    ON DELETE NO ACTION 
                    NOT VALID 
            ) 
            TABLESPACE pg_default; 
            ALTER TABLE IF EXISTS public.a_component_geotiff_val_mem_pm25_{year}
                OWNER to sv;";
            var item = await _context.Database.ExecuteSqlRawAsync(sqlQuery);
            return item;
        }

        public async Task<int> InsertGeotiffVal(int year, int row_index, double minx, double maxx, double miny, double maxy, string row_val, string category_id, string row_val_aqi)
        {
            string sqlQuery = $@"INSERT INTO public.a_component_geotiff_val_mem_pm25_{year}(row_index, minx, maxx, miny, maxy, row_val, category_id, row_val_aqi) 
            VALUES({row_index}, {minx.ToString(CultureInfo.InvariantCulture)}, {maxx.ToString(CultureInfo.InvariantCulture)}, {miny.ToString(CultureInfo.InvariantCulture)}, {maxy.ToString(CultureInfo.InvariantCulture)}, '{row_val}', '{category_id}', '{row_val_aqi}');";
            var item = await _context.Database.ExecuteSqlRawAsync(sqlQuery);
            return item;
        }

        public async Task<int> InsertGeotiffIndex(int year, int row_index, string category_id, int from_cell, int to_cell)
        {
            string sqlQuery = $@"INSERT INTO public.a_component_geotiff_index_mem_pm25_{year}(row_index, category_id, from_cell, to_cell) 
            VALUES({row_index}, '{category_id}', {from_cell}, {to_cell})";
            var item = await _context.Database.ExecuteSqlRawAsync(sqlQuery);
            return item;
        }

    }
}
