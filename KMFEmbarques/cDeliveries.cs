using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KMFTools.Seguridad;
using System.Data.SqlClient;
using System.Data;

namespace KMFEmbarques
{
    namespace Deliveries
    {
        public static class cDeliveries
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
            /// <param name="IdDelivery"></param>
            /// <param name="dFecha"></param>
            /// <param name="dHora"></param>
            /// <returns>0</returns>
            public static int Nuevo(long IdDelivery, string dFecha, string dHora)
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
                    oCom.CommandText = "sp.mvDeliveries";
                    oCom.CommandType = CommandType.StoredProcedure;
                    oCom.Parameters.Add("@cAccion", SqlDbType.VarChar, 2).Value = "I";
                    oCom.Parameters.Add("@IdDelivery", SqlDbType.BigInt).Value = IdDelivery;
                    oCom.Parameters.Add("@dFecha", SqlDbType.DateTime).Value = dFecha;
                    oCom.Parameters.Add("@dHora", SqlDbType.SmallDateTime).Value = dHora;
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
            /// <param name="IdDelivery"></param>
            /// <param name="dFecha"></param>
            /// <param name="dHora"></param>
            /// <returns>0</returns>
            public static int Editar(int IdDelivery, string dFecha, string dHora)
            {
                int iReturn = 0;
                strConn = cSeguridad.LeerCadenaConexion();
                SqlConnection oConn = new SqlConnection(strConn);
                SqlCommand oCom = new SqlCommand();
                try
                {
                    oConn.Open();
                    oCom.Connection = oConn;
                    oCom.CommandText = "sp.mvDeliveriesDetails";
                    oCom.CommandType = CommandType.StoredProcedure;
                    oCom.Parameters.Add("@cAccion", SqlDbType.VarChar, 2).Value = "E";
                    oCom.Parameters.Add("@IdDelivery ", SqlDbType.Int).Value = IdDelivery;
                    oCom.Parameters.Add("@dFecha", SqlDbType.DateTime).Value = dFecha;
                    oCom.Parameters.Add("@dHora ", SqlDbType.SmallDateTime).Value = dHora;
                    iReturn = oCom.ExecuteNonQuery();
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
                    oCom.CommandText = "sp.mvDeliveries";
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
            public static DataTable ConsultaStatus(int IdStatus)
            {
                strConn = cSeguridad.LeerCadenaConexion();
                DataTable dsReturn = new DataTable();
                SqlConnection oConn = new SqlConnection(strConn);
                SqlCommand oCom = new SqlCommand();
                try
                {
                    oConn.Open();
                    oCom.Connection = oConn;
                    oCom.CommandText = "sp.mvDeliveries";
                    oCom.CommandType = CommandType.StoredProcedure;
                    oCom.Parameters.Add("@cAccion", SqlDbType.VarChar, 2).Value = "C3";
                    oCom.Parameters.Add("@IdStatus", SqlDbType.Int).Value = IdStatus;
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
            public static DataTable ConsultaInnerJoin()
            {
                strConn = cSeguridad.LeerCadenaConexion();
                DataTable dsReturn = new DataTable();
                SqlConnection oConn = new SqlConnection(strConn);
                SqlCommand oCom = new SqlCommand();
                try
                {
                    oConn.Open();
                    oCom.Connection = oConn;
                    oCom.CommandText = "sp.mvDeliveries";
                    oCom.CommandType = CommandType.StoredProcedure;
                    oCom.Parameters.Add("@cAccion", SqlDbType.VarChar, 2).Value = "C4";
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
