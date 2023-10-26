using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;

namespace DMZ.UI.IMB
{
    public partial class FrmDep : FrmClasse2
    {
        public FrmDep(FrmActivo frmActivo)
        {
            InitializeComponent();
            _frmActivo = frmActivo;
        }

        private readonly FrmActivo _frmActivo;
        private void button3_Click(object sender, EventArgs e)
        {
            if (!cbFiscal.cb1.Checked || !cbContabilistico.cb1.Checked)
            {
                DataRow dataRowr;
                decimal total = 0;
                var valoraquis = _frmActivo.txtValorAquisicaoTotal.tb1.Text.ToDecimal();
                if (!valoraquis.IsZero())
                {
                    var percdep = txtPercentagem.tB1.Text.ToDecimal();
                    var vidautil = 100 / percdep;//Sera que corresponde o numero de anos ????
                    _frmActivo.tbVidaFiscal.tb1.Text = vidautil.ToRound((int)Pbl.Param.Aredondamento).ToString();
                    if (_frmActivo.dtDtAquisicao.dt1.Value.Year>1900)
                    {
                        var data = _frmActivo.dtDtAquisicao.dt1.Value;
                        var validade = data.AddYears(vidautil.ToInt());
                        #region Região para obter a diferença em anos

                        var dias = ((Pbl.SqlDate - data).TotalDays / 365).ToDecimal().ToRound((int)Pbl.Param.Aredondamento);
                        var difanos = dias == 0 ? 1 : dias;
                        #endregion
                        decimal tota = 0;
                        #region Cálculo de número total de meses
                        var totalMeses = data.Month-1 == 0 ? 1 : data.Month-1;
                        #endregion
                        if (validade >= data)
                        {
                            decimal totdepactual;
                            if (cbFiscal.cb1.Checked)
                            {
                                if (_frmActivo.gridUiFiscal.DtDS.HasRows())
                                {
                                    total = _frmActivo.gridUiFiscal.DtDS.Sum("Valdepact");
                                }
                                dataRowr = _frmActivo.gridUiFiscal.DtDS.NewRow().Inicialize();
                                if (_frmActivo.cbQuotas.cb1.Checked)//Quotas Constantes
                                {
                                    #region Método de depreciações fiscais(Método das quotas constantes)
                                    //totdepactual = (valoraquis * (percdep / 100) * difanos).ToDecimal();
                                    totdepactual = (valoraquis * (percdep / 100)).ToDecimal();
                                    tota = totdepactual + total;
                                    #endregion
                                    PassarDados(dataRowr, _frmActivo.gridUiFiscal, valoraquis, tota);
                                }

                                if (_frmActivo.cbDuodessimos.cb1.Checked)//Por duodécimos
                                {
                                    #region Método de depreciações fiscais (Método das quotas constantes)
                                    //if (difanos > 1)//Apartir do segundo ano
                                    //{
                                    //    var dd = (valoraquis * (percdep / 100) * (totalMeses / 12)).ToDecimal();
                                    //    var totalMesesNaoMexido = 12 - totalMeses;
                                    //    tota += dd;
                                    //    if (validade > Pbl.SqlDate)//Apartir do segundo ano até ao último ano de vida útil
                                    //    {
                                    //        for (var i = 0; i < difanos - 1; i++)
                                    //        {
                                    //            tota += (valoraquis * (percdep / 100) * 1).ToDecimal();
                                    //        }
                                    //    }
                                    //    else if (validade.Year + 1 == Pbl.SqlDate.Year && data.Year < Pbl.SqlDate.Year)//Uma percentagem que não foi usada  e que
                                    //        //deve ser usada no ano asseguir depois da vida útil
                                    //    {
                                    //        tota += (valoraquis * (percdep / 100) * totalMesesNaoMexido / 12).ToDecimal();
                                    //    }
                                    //    else
                                    //    {
                                    //        tota = 0;
                                    //    }
                                    //}
                                    //else if (difanos == 1)//Primeiro ano de depreçiação
                                    //{
                                    //    tota += (valoraquis * (percdep / 100) * totalMeses / 12).ToDecimal();
                                    //}
                                    tota += (valoraquis * (percdep / 100) * totalMeses / 12).ToDecimal();
                                    #endregion
                                    PassarDados(dataRowr, _frmActivo.gridUiFiscal, valoraquis, tota);

                                }
                            }
                            if (cbContabilistico.cb1.Checked)
                            {
                                if (_frmActivo.cbDuodessimos.cb1.Checked)
                                {
                                    dataRowr = _frmActivo.gridUiContabilistico.DtDS.NewRow().Inicialize();
                                    //#region Método de depreciações Contabilísticas Duodécimos

                                    //if (difanos > 1)//Apartir do Segundo ano de depreçiação
                                    //{
                                    //    totdepactual = (valoraquis * (percdep / 100) * (totalMeses / 12)).ToDecimal() / totalMeses;
                                    //    tota += totdepactual / (12 - _frmActivo.dtDtAquisicao.dt1.Value.Month.ToDecimal());
                                    //    var totalMesesNaoMexido = 12 - totalMeses;
                                    //    //======/=======Verifica em que ano está na depreciação
                                    //    //validade
                                    //    if (validade > Pbl.SqlDate)
                                    //    {
                                    //        for (var i = 0; i < difanos - 1; i++)
                                    //        {
                                    //            tota += (valoraquis * (percdep / 100) * 1).ToDecimal() / 12;
                                    //        }
                                    //    }
                                    //    else if (validade.Year + 1 == Pbl.SqlDate.Year && data.Year < Pbl.SqlDate.Year)
                                    //    {
                                    //        tota += (valoraquis * (percdep / 100) * totalMesesNaoMexido / 12).ToDecimal() / totalMesesNaoMexido;
                                    //    }
                                    //    else
                                    //    {
                                    //        tota = 0;
                                    //    }
                                    //}
                                    //else if (difanos == 1)//Primeiro ano de depreçiação
                                    //{
                                    //    tota += (valoraquis * (percdep / 100) * totalMeses / 12).ToDecimal() / totalMeses;
                                    //}
                                    //#endregion

                                    tota += (valoraquis * (percdep / 100) * totalMeses / 12).ToDecimal() / totalMeses;
                                    PassarDados(dataRowr, _frmActivo.gridUiContabilistico, valoraquis, tota);
                                }
                            }
                        }
                        //else
                        //{
                        //    if (cbFiscal.cb1.Checked)
                        //    {
                        //        dataRowr = _frmActivo.gridUiFiscal.DtDS.NewRow().Inicialize();
                        //        if (_frmActivo.cbDuodessimos.cb1.Checked)
                        //        {
                        //            #region Método de depreciações fiscais (Método das quotas constantes)
                        //            if (difanos > 1)
                        //            {
                        //                var dd = 12 - data.Month == 0 ? 1 : 12 -data.Month.ToDecimal();
                        //                dd = (valoraquis * (percdep / 100) * (dd / 12)).ToDecimal();
                        //                tota += dd;
                        //                for (var i = 0; i < difanos - 1; i++)
                        //                {
                        //                    tota += (valoraquis * (percdep / 100) * 1).ToDecimal();
                        //                }
                        //            }
                        //            #endregion
                        //            PassarDados(dataRowr, _frmActivo.gridUiFiscal, valoraquis, tota);
                        //        }
                        //    }
                        //    if (cbContabilistico.cb1.Checked)
                        //    {
                        //        dataRowr = _frmActivo.gridUiContabilistico.DtDS.NewRow().Inicialize();
                        //        if (_frmActivo.cbDuodessimos.cb1.Checked)
                        //        {
                        //            #region Método de depreciações fiscais (Método das quotas constantes)


                        //            if (vidautil >= difanos)
                        //            {
                        //                if (difanos > 1)
                        //                {
                        //                    var dd = 12 - _frmActivo.dtDtAquisicao.dt1.Value.Month.ToDecimal() == 0 ? 1 : 12 - _frmActivo.dtDtAquisicao.dt1.Value.Month.ToDecimal();
                        //                    dd = (valoraquis * (percdep / 100) * (dd / 12)).ToDecimal();
                        //                    var mesult = 12 - dd.ToDecimal();

                        //                    tota += dd / (12 - _frmActivo.dtDtAquisicao.dt1.Value.Month.ToDecimal());
                        //                    for (var i = 0; i < difanos - 1; i++)
                        //                    {
                        //                        tota += (valoraquis * (percdep / 100) * mesult / 12).ToDecimal() / 12;
                        //                    }
                        //                }
                        //            }
                        //            #endregion

                        //            PassarDados(dataRowr, _frmActivo.gridUiContabilistico, valoraquis, tota);

                        //        }
                        //    }
                        //}
                    }
                    else
                    {
                        MsBox.Show(Messagem.ParteInicial() + "A Data de Aquisição deve ser superior que 1900");
                    }
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial() + "O Campo valor total de compra não pode ser Zero");
                }
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "Deve preencher os campos de Tipo de depreciação e percentagem !");
            }
            Close();
        }
        void PassarDados(DataRow dataRowr, GridUi grid,decimal valoraquis,decimal tota)
        {

            dataRowr["Ststamp"] = _frmActivo.CLocalStamp;
            dataRowr["Data"] = dtDataFiscal.dt1.Value;
            dataRowr["Valdepact"] = valoraquis;
            if (grid.DtDS.Columns.Contains("Valdepnact"))
            {
                dataRowr["Valdepnact"] = 0;
                //dataRowr["Valdepnact"] = valoraquis - tota;
                //if (dataRowr["Valdepnact"].ToDecimal() < 0)
                //{
                //    dataRowr["Valdepnact"] = 0;
                //}
            }
            dataRowr["Valdep"] = tota;
            dataRowr["TaxaDeprec"] = txtPercentagem.tB1.Text;
            grid.DtDS.Rows.Add(dataRowr);
            _frmActivo.tabControl1.SelectedTab = _frmActivo.tabPage5;
            _frmActivo.tabControl2.SelectedTab = grid.Name.Equals("gridUiContabilistico") ? _frmActivo.tabPageContabilistico : _frmActivo.tabPageFiscais;
            grid.Update();
        }

        private void FrmDep_Load(object sender, EventArgs e)
        {

        }
    }
}
