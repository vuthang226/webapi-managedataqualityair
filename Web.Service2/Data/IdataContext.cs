using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Web.Service2.Data
{
    public interface IdataContext
    {
        Task<int> CreateTableGeotiffIndex(int year);

        Task<int> CreateTableGeotiffVal(int year);

        Task<int> InsertGeotiffVal(int year, int row_index, double minx, double maxx, double miny, double maxy, string row_val, string category_id, string row_val_aqi);

        Task<int> InsertGeotiffIndex(int year, int row_index, string category_id, int from_cell, int to_cell);
    }
}
