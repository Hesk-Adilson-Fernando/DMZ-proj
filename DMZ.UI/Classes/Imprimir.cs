using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using Microsoft.Reporting.WinForms;

namespace DMZ.UI.Classes
{
    public static class Imprimir
    {
        public static void DoPrint(PrintSetup Ps)
        {
            if (Ps !=null)
            {
                var f = new FrmReport
                {
                    label1 = { Text = $@"Imprimir {Ps.OrigemlabelText}" },
                    Ps = Ps
                };
                f.ShowForm(Ps.MdiForm);
            }
        }


        internal static void CallForm(DataTable dtPrint, DataTable fp, string cLocalStamp,
            bool inserindo, string text, string text2, string nomfile, string origem,
            Form frmFt, string xmlString, bool v2, DS d, string filtro, string CTituloRelatorio,
            List<ReportParameter> lista = null, DataTable DtProfessores = null,string nomfileA5 = null, string xmlStringA5 = null)
        {
            var frmset = new FrmPrintset();
            frmset.Ps.CLocalStamp = cLocalStamp;
            frmset.Ps.Inserindo = inserindo;
            frmset.Ps.OrigemlabelText = text;
            frmset.Ps.No = text2;
            frmset.Ps.Nomfile = nomfile;
            frmset.Ps.Origem = origem;
            frmset.Ps.MdiForm = frmFt;

            frmset.Ps.XmlString = xmlString;
            frmset.Ps.DtPrint = dtPrint;
            frmset.Ps.DMZ2 = DtProfessores;
            frmset.Ps.Formasp = fp;
            frmset.Ps.UseFormasp = true;
            frmset.Ps.Ds = d;
            frmset.Ps.Filtro = filtro;
            frmset.Ps.CTituloRelatorio = CTituloRelatorio;
            frmset.Ps.ListaParam = lista;
            frmset.Ps.XmlStringA5= xmlStringA5;
            frmset.Ps.NomfileA5 = nomfileA5;
            frmset.Ps.NomfileA4 = nomfile;
            frmset.Ps.XmlStringA4 = xmlString;
            frmset.ShowForm(frmFt, false, true);
        }


        internal static (bool Imprimir,string Messagem) Valido(Usracessos usracessos, string text, bool controlacessos =true)
        {
            (bool Imprimir, string Messagem) ret = (true,"");
            if (controlacessos)
            {
                if (usracessos == null)
                {
                    ret = (false, "Acessos do documento inválidos. Contacte o administrador!");
                }
                else if (!usracessos.Imprimir)
                {
                    ret = (false, "Não tem permissão para imprimir. Contacte o administrador!");
                }
            }
            if (text.IsNullOrEmpty())
            {
                ret = (false, "Deve indicar o documento!..");
            }
            return ret;
        }
        internal static void RepreencherCl((DataTable dtPrint, DataTable fp) ret, Cl _cliente)
        {
            if (_cliente != null)
            {
                foreach (DataRow row in ret.dtPrint.Rows)
                {
                    foreach (DataColumn col in ret.dtPrint.Columns)
                    {
                        col.ReadOnly = false;
                        if (_cliente != null)
                        {
                            if (col.ColumnName.ToLower().Equals("localidade"))
                            {
                                row[col.ColumnName] = _cliente.Localidade;
                            }
                            else if (col.ColumnName.ToLower().Equals("areafiscal"))
                            {
                                row[col.ColumnName] = _cliente.Areafiscal;
                            }
                            else if (col.ColumnName.ToLower().Equals("morada"))
                            {
                                row[col.ColumnName] = _cliente.Morada;
                            }
                            else if (col.ColumnName.ToLower().Equals("nuit"))
                            {
                                row[col.ColumnName] = _cliente.Nuit;
                            }
                            else if (col.ColumnName.ToLower().Equals("nome"))
                            {
                                row[col.ColumnName] = _cliente.Nome;
                            }
                            else if (col.ColumnName.ToLower().Equals("no"))
                            {
                                row[col.ColumnName] = _cliente.No;
                            }
                        }
                    }
                }
            }
        }


        public static (DataTable dtPrint, DataTable fp) FillDataEnt(DataTable dtPai,
         DataTable dtFilha, DataTable formasp, DataTable dtPrincipal, DataTable dtformasp)
        {
            (DataTable dtPrint, DataTable fp) ret = (null, null);
            if (dtFilha.HasRows())
            {
                dtPrincipal.PrimaryKey = null;
                if (dtPrincipal.HasRows())
                {
                    dtPrincipal.Rows.Clear();
                }
                int colReais = 0;
                if (dtPrincipal.TableName == "DMZ")
                {
                    if (dtPrincipal.Columns.Count > dtFilha.Columns.Count)
                    {
                        colReais = dtPrincipal.Columns.Count - (dtPrincipal.Columns.Count - dtFilha.Columns.Count);
                    }
                    else
                    {
                        colReais = dtPrincipal.Columns.Count;
                    }
                    for (var j = 0; j < colReais; j++)
                    {
                        dtPrincipal.Columns[j].DataType = dtFilha.Columns[j].DataType;
                    }
                }
                for (var i = 0; i < dtFilha.Rows.Count; i++)
                {
                    if (dtFilha.Rows[i] != null)
                    {
                        if (dtFilha.Rows[i].RowState != DataRowState.Deleted)
                        {
                            var rw = dtPrincipal.NewRow().InicializeEnty();
                            if (dtPrincipal.TableName == "DMZ" || dtPrincipal.TableName == "DMZ1")
                            {
                                for (var j = 0; j < colReais; j++)
                                {
                                    var tipo = dtFilha.Rows[i][j].GetType();
                                    if (tipo == typeof(DateTime))
                                    {
                                        rw[j] = ((DateTime)dtFilha.Rows[i][j]).ToString();
                                    }
                                    else if (tipo == typeof(decimal))
                                    {
                                        rw[j] = dtFilha.Rows[i][j].ToDecimal();
                                    }
                                    else if (tipo == typeof(DBNull))
                                    {
                                        rw[j] = dtFilha.Rows[i][j];
                                    }
                                    else
                                    {
                                        rw[j] = dtFilha.Rows[i][j].ToString();
                                    }
                                }
                            }
                            else
                            {
                                foreach (DataColumn col in dtPrincipal.Columns)
                                {
                                    if (dtFilha.Columns.Contains(col.ColumnName))
                                    {
                                        rw[col.ColumnName] = dtFilha.Rows[i][col.ColumnName];
                                    }
                                    if (dtPai.HasRows())
                                    {
                                        if (dtPai.Columns.Contains(col.ColumnName))
                                        {
                                            if (dtPai.TableName.ToLower() == "di")
                                            {
                                                if (col.ColumnName.ToLower() == "nuit")
                                                {
                                                    rw[col.ColumnName] = dtPai.Rows[0][col.ColumnName].ToDecimal();
                                                }
                                                else
                                                {
                                                    rw[col.ColumnName] = dtPai.Rows[0][col.ColumnName];
                                                }

                                            }
                                            else
                                            {
                                                rw[col.ColumnName] = dtPai.Rows[0][col.ColumnName];
                                            }

                                        }
                                    }
                                }
                            }
                            dtPrincipal.Rows.Add(rw);
                        }
                    }
                }
            }
            ret.fp = Helper.FillFormasP(formasp, dtformasp);
            ret.fp = dtformasp;
            ret.dtPrint = dtPrincipal;
            ret.dtPrint.TableName = dtPrincipal.TableName;
            return ret;
        }






        public static (DataTable dtPrint, DataTable fp) FillData(DataTable dtPai,
            DataTable dtFilha, DataTable formasp, DataTable dtPrincipal, DataTable dtformasp)
        {
            (DataTable dtPrint, DataTable fp) ret = (null, null);
            if (dtFilha.HasRows())
            {
                dtPrincipal.PrimaryKey = null;
                if (dtPrincipal.HasRows())
                {
                    dtPrincipal.Rows.Clear();
                }
                int colReais = 0;
                if (dtPrincipal.TableName == "DMZ")
                {
                    if (dtPrincipal.Columns.Count > dtFilha.Columns.Count)
                    {
                        colReais = dtPrincipal.Columns.Count - (dtPrincipal.Columns.Count - dtFilha.Columns.Count);
                    }
                    else
                    {
                        colReais = dtPrincipal.Columns.Count;
                    }
                    for (var j = 0; j < colReais; j++)
                    {
                        dtPrincipal.Columns[j].DataType = dtFilha.Columns[j].DataType;
                    }
                }
                for (var i = 0; i < dtFilha.Rows.Count; i++)
                {
                    if (dtFilha.Rows[i] != null)
                    {
                        if (dtFilha.Rows[i].RowState != DataRowState.Deleted)
                        {
                            var rw = dtPrincipal.NewRow().InicializeEnty();
                            if (dtPrincipal.TableName == "DMZ" || dtPrincipal.TableName == "DMZ1")
                            {
                                for (var j = 0; j < colReais; j++)
                                {
                                    var tipo = dtFilha.Rows[i][j].GetType();
                                    if (tipo == typeof(DateTime))
                                    {
                                        rw[j] = ((DateTime)dtFilha.Rows[i][j]).ToShortDateString();
                                    }
                                    else if (tipo == typeof(decimal))
                                    {
                                        rw[j] = dtFilha.Rows[i][j].ToDecimal();
                                    }
                                    else if (tipo == typeof(DBNull))
                                    {
                                        rw[j] = dtFilha.Rows[i][j];
                                    }
                                    else
                                    {
                                        rw[j] = dtFilha.Rows[i][j].ToString();
                                    }
                                }
                            }
                            else
                            {
                                foreach (DataColumn col in dtPrincipal.Columns)
                                {
                                    if (dtFilha.Columns.Contains(col.ColumnName))
                                    {
                                        rw[col.ColumnName] = dtFilha.Rows[i][col.ColumnName];
                                    }
                                    if (dtPai.HasRows())
                                    {
                                        if (dtPai.Columns.Contains(col.ColumnName))
                                        {
                                            if (dtPai.TableName.ToLower() == "di")
                                            {
                                                if (col.ColumnName.ToLower() == "nuit")
                                                {
                                                    rw[col.ColumnName] = dtPai.Rows[0][col.ColumnName].ToDecimal();
                                                }
                                                else
                                                {
                                                    rw[col.ColumnName] = dtPai.Rows[0][col.ColumnName];
                                                }

                                            }
                                            else
                                            {
                                                rw[col.ColumnName] = dtPai.Rows[0][col.ColumnName];
                                            }

                                        }
                                    }
                                }
                            }
                            dtPrincipal.Rows.Add(rw);
                        }
                    }
                }
            }
            ret.fp = Helper.FillFormasP(formasp, dtformasp);
            ret.fp = dtformasp;
            ret.dtPrint = dtPrincipal;
            ret.dtPrint.TableName = dtPrincipal.TableName;
            return ret;
        }
    }
}
