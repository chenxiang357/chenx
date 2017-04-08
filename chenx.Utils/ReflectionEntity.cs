using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace chenx.Utils
{
    /// <summary>
    /// 从数据库中查询出来的数据反射给实体
    /// </summary>
    public static class ReflectionEntity
    {
        /// <summary>
        /// 数据反射给实体
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="data">数据集</param>
        /// <returns>实体</returns>
        /// <remarks>
        /// 没有数据，则返回null;
        /// </remarks>
        public static T GetEntity<T>(this DataSet data) where T : new()
        {
            if (data.Tables[0].Rows.Count > 0)
                return data.Tables[0].GetEntity<T>();
            else
                return default(T);
        }

        /// <summary>
        /// 数据反射给实体
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="data">数据集</param>
        /// <returns>实体</returns>
        /// <remarks>
        /// 没有数据，则返回null;
        /// </remarks>
        public static T GetEntity<T>(this DataTable data) where T : new()
        {
            if (data.Rows.Count > 0)
                return data.Rows[0].GetReflectionEntity(new T());
            else
                return default(T);
        }

        /// <summary>
        /// 数据反射给实体列表
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="data">数据集</param>
        /// <returns>实体列表</returns>
        /// <remarks>
        /// 没有数据，则返回实例化之后的列表
        /// </remarks>
        public static IList<T> GetEntityList<T>(this DataSet data) where T : new()
        {
            return data.Tables[0].GetEntityList<T>();
        }

        /// <summary>
        /// 数据反射给实体列表
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="data">数据集</param>
        /// <returns>实体列表</returns>
        /// <remarks>
        /// 没有数据，则返回实例化之后的列表
        /// </remarks>
        public static IList<T> GetEntityList<T>(this DataTable data) where T : new()
        {
            IList<T> EntityList = new List<T>();
            foreach (DataRow row in data.Rows)
                EntityList.Add(row.GetReflectionEntity(new T()));
            return EntityList;
        }

        /// <summary>
        /// 数据反射给实体
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="data">数据集</param>
        /// <returns>实体列表</returns>
        /// <remarks>实体没有数据，返回已经实例化后的IEnumerable</remarks>
        public static IEnumerable<T> GetEntityEnumerable<T>(this DataSet data) where T : new()
        {
            return GetEntityEnumerable<T>(data.Tables[0]);
        }

        /// <summary>
        /// 数据反射给实体
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="data">数据集</param>
        /// <returns>实体列表</returns>
        /// <remarks>
        /// 实体没有数据，返回已经实例化后的IEnumerable
        /// </remarks>
        public static IEnumerable<T> GetEntityEnumerable<T>(this DataTable data) where T : new()
        {
            foreach (DataRow item in data.Rows)
                yield return GetReflectionEntity(item, new T());
        }

        /// <summary>
        /// 具体的给实体赋值
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="row">数据集的行</param>
        /// <param name="entity">实体</param>
        /// <returns>实体</returns>
        private static T GetReflectionEntity<T>(this DataRow row, T entity) where T : new()
        {
            //
            foreach (PropertyInfo item in typeof(T).GetProperties())
            {
                if (row.Table.Columns.Contains(item.Name))
                {
                    if (DBNull.Value != row[item.Name])
                    {
                        if (item.PropertyType.IsEnum)
                        {
                            item.SetValue(entity, Enum.Parse(item.PropertyType, row[item.Name].ToString()), null);
                            //item.SetValue(entity, Enum.ToObject(item.PropertyType, row[item.Name]), null);
                        }
                        else
                            item.SetValue(entity, Convert.ChangeType(row[item.Name], item.PropertyType), null);
                        //else if (item.PropertyType.IsClass)
                        //{
                        //    item.SetValue(entity,GetReflectionEntity)
                        //}
                    }
                }
            }
            return entity;
        }
    }

}
