using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KMFTools.Seguridad;
using System.Data;
using System.Data.SqlClient;


namespace KMFEmbarques
{
    namespace DeliveriesDetails
    {
        public static class cDeliveriesDetails
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
            /// <param name="iPiezasSolicitadas"></param>
            /// <param name="iPiezasEmbarcadas"></param>
            /// <returns>Id Registro</returns>
            public static int Nuevo(long IdDelivery, int iPiezasSolicitadas, int iSAPPT)
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
                    oCom.CommandText = "sp.mvDeliveriesDetails";
                    oCom.CommandType = CommandType.StoredProcedure;
                    oCom.Parameters.Add("@cAccion", SqlDbType.VarChar, 2).Value = "I";
                    oCom.Parameters.Add("@IdDelivery", SqlDbType.BigInt).Value = IdDelivery;
                    oCom.Parameters.Add("@iPiezasSolicitadas", SqlDbType.SmallInt).Value = iPiezasSolicitadas;
                    oCom.Parameters.Add("@iSAPPT", SqlDbType.Int).Value = iSAPPT;
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
            /// <param name="IdNumeroParte"></param>
            /// <param name="iPiezasSolicitadas"></param>
            /// <param name="iPiezasEmbarcadas"></param>
            /// <returns>0</returns>
            public static int Editar(int IdNumeroParte, int iPiezasSolicitadas, int iPiezasEmbarcadas)
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
                    oCom.Parameters.Add("@IdNumeroParte ", SqlDbType.Int).Value = IdNumeroParte;
                    oCom.Parameters.Add("@iPiezasSolicitadas", SqlDbType.Int).Value = iPiezasSolicitadas;
                    oCom.Parameters.Add("@iPiezasEmbarcadas ", SqlDbType.Int).Value = iPiezasEmbarcadas;
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
            /// <param name="IdNumeroParte"></param>
            /// <param name="bActivo"></param>
            /// <returns>0</returns>
            public static int Acivar(int IdNumeroParte, byte bActivo)
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
                    oCom.Parameters.Add("@cAccion", SqlDbType.VarChar, 2).Value = "A";
                    oCom.Parameters.Add("@IdNumeroParte ", SqlDbType.Int).Value = IdNumeroParte;
                    oCom.Parameters.Add("@bActivo", SqlDbType.Bit).Value = bActivo;
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
                return 0;
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
                    oCom.CommandText = "sp.mvDeliveriesDetails";
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
