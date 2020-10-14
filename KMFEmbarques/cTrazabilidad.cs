using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using KMFTools.Seguridad;
using System.Data;

namespace kmfembarquesSG
{
    namespace logTrazabilidad
    {
        public static class cTrazabilidad
        {
            /// <summary>
            /// Variable para cadena de conexión
            /// </summary>
            private static string strConn = string.Empty;
            /// <summary>
            /// 
            /// </summary>
            private static string strError = string.Empty;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="fTimeStamp"></param>
            /// <returns></returns>
            public static int Nuevo(int fTimeStamp)
            {
                int iReturn = 0;
                strConn = cSeguridad.LeerCadenaConexion();
                DataTable dsReturn = new DataTable();
                SqlConnection oConn = new SqlConnection(strConn);
                SqlCommand oCom = new SqlCommand();
                try
                {
                    oConn.Open();
                    oCom.Connection = oConn;
                    oCom.CommandText = "sp.logTrazabilidad";
                    oCom.CommandType = CommandType.StoredProcedure;
                    oCom.Parameters.Add("@cAccion", SqlDbType.VarChar, 2).Value = "I";
                    oCom.Parameters.Add("@fTimeStamp", SqlDbType.Int).Value = fTimeStamp;
                    SqlDataAdapter oAdapt = new SqlDataAdapter(oCom);
                    oAdapt.Fill(dsReturn);
                    if (dsReturn.Rows.Count > 0)
                        iReturn = Convert.ToInt32(dsReturn.Rows[0][0].ToString());
                    oAdapt.Dispose();
                    dsReturn.Dispose();
                    oCom.Dispose();
                    oConn.Dispose();
                }
                catch (Exception ex)
                {
                    strError = ex.Message;
                }
                finally
                {
                    if (oConn.State == ConnectionState.Open)
                        oConn.Dispose();
                }
                return iReturn;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <returns>Consulta en un datatable</returns>
            public static DataTable ConsultaGeneral()
            {
                strConn = cSeguridad.LeerCadenaConexion();
                DataTable dsReturn = new DataTable();
                SqlConnection oConn = new SqlConnection(strConn);
                SqlCommand oCom = new SqlCommand();
                try
                {
                    oConn.Open();
                    oCom.Connection = oConn;
                    oCom.CommandText = "sp.logTrazabilidad";
                    oCom.CommandType = CommandType.StoredProcedure;
                    oCom.Parameters.Add("@cAccion", SqlDbType.VarChar, 2).Value = "C1";
                    SqlDataAdapter oAdapt = new SqlDataAdapter(oCom);
                    oAdapt.Fill(dsReturn);
                    oAdapt.Dispose();
                    oCom.Dispose();
                    oConn.Dispose();
                }
                catch (Exception ex)
                {
                    strError = ex.Message;
                }
                finally
                {
                    if (oConn.State == ConnectionState.Open)
                        oConn.Dispose();
                }
                return dsReturn;
            }
        }
    }
}
