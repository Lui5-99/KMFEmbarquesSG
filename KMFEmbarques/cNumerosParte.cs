using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using KMFTools.Seguridad;

namespace KMFEmbarques
{
    namespace Catalogos
    {
        public static class cNumerosParte
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
            /// Nuevo número de parte
            /// </summary>
            /// <param name="NumeroParteCliente">np DEL CLIENTE</param>
            /// <param name="SAPPT">SAP</param>
            /// <returns>Id registro</returns>
            public static int Nuevo(string NumeroParteCliente, int SAPPT)
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
                    oCom.CommandText = "sp.catNumerosParte";
                    oCom.CommandType = CommandType.StoredProcedure;
                    oCom.Parameters.Add("@cAccion", SqlDbType.VarChar, 2).Value = "I";
                    oCom.Parameters.Add("@cNumeroParteCliente", SqlDbType.VarChar, 50).Value = NumeroParteCliente;
                    oCom.Parameters.Add("@iSAPPT ", SqlDbType.Int).Value = SAPPT;
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

            public static int Editar( int INumeroParte,string NumeroParteCliente, int SAPPT, bool bActivo )
            {
                int iReturn = 0;
                strConn = cSeguridad.LeerCadenaConexion();
                SqlConnection oConn = new SqlConnection(strConn);
                SqlCommand oCom = new SqlCommand();
                try
                {
                    oConn.Open();
                    oCom.Connection = oConn;
                    oCom.CommandText = "sp.catNumerosParte";
                    oCom.CommandType = CommandType.StoredProcedure;
                    oCom.Parameters.Add("@cAccion", SqlDbType.VarChar, 2).Value = "E";
                    oCom.Parameters.Add("@IdNumeroParte ", SqlDbType.Int).Value = INumeroParte;
                    oCom.Parameters.Add("@cNumeroParteCliente", SqlDbType.VarChar, 50).Value = NumeroParteCliente;
                    oCom.Parameters.Add("@iSAPPT ", SqlDbType.Int).Value = SAPPT;
                    oCom.Parameters.Add("@bActivo ", SqlDbType.Bit).Value = bActivo;
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
                    oCom.CommandText = "sp.catNumerosParte";
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
                    oCom.CommandText = "sp.catNumerosParte";
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
            public static DataTable ConsultaActivos(bool bActivo)
            {
                strConn = cSeguridad.LeerCadenaConexion();
                DataTable dsReturn = new DataTable();
                SqlConnection oConn = new SqlConnection(strConn);
                SqlCommand oCom = new SqlCommand();
                try
                {
                    oConn.Open();
                    oCom.Connection = oConn;
                    oCom.CommandText = "sp.catNumerosParte";
                    oCom.CommandType = CommandType.StoredProcedure;
                    oCom.Parameters.Add("@cAccion", SqlDbType.VarChar, 2).Value = "C2";
                    oCom.Parameters.Add("bActivo", SqlDbType.Bit).Value = bActivo;
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