using DMZ.Model.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DMZ.DAL.Migrations;
using DMZ.Model.Generic;
using DMZ.DAL.Classes;

namespace DMZ.DAL.Context
{
    public class DataContext: DbContext
    {
        //public DataContext():base("DefaultConnection")
        //{
        //    Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext,Configuration>());
        //}
        public DataContext() : base(SqlHelper.GetConString())
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>());
        }
        #region Tabelas Reservas de mesas e quartos ...
        public virtual DbSet<Part> Part { get; set; } //Partidas de combios 
        public virtual DbSet<Clas> Clas { get; set; } //Calsses de comboio  
        public virtual DbSet<FactConcet> FactConcet { get; set; } //Bombas de combustivel 
        public virtual DbSet<BombaBico> BombaBico { get; set; } //Bombas de combustivel FactConcet
        public virtual DbSet<Bomba> Bomba { get; set; } //Bombas de combustivel 
        public virtual DbSet<Bico> Bico { get; set; } //Bicos de Bombas de combustivel 
        public virtual DbSet<Numdocs> Numdocs { get; set; } //Numero de Partida.. de documentos 
        public virtual DbSet<Ditec> Ditec { get; set; } //Mecanicos de folha da obra.....
        public virtual DbSet<FncBomb> FncBomb { get; set; } //Bombas de combustivel do fornecedor 
        public virtual DbSet<Ctauxiliar> Ctauxiliar { get; set; }//Auxiliar da contabilidade 
        public virtual DbSet<Pect> Pect { get; set; }//Contas de contabilidade de pessoal 
        public virtual DbSet<TPercl> TPercl { get; set; }//Configuração de Recibos de trabalhador 
        public virtual DbSet<Pecc> Pcc { get; set; }//Conta corrente de trabalhador 
        public virtual DbSet<Percl> Percl { get; set; }
        public virtual DbSet<Percll> Percll { get; set; }
        public virtual DbSet<Dianexo> Dianexo { get; set; }
        public virtual DbSet<Faccanexo> Faccanexo { get; set; }
        public virtual DbSet<Factanexo> Factanexo { get; set; }
        public virtual DbSet<TdocPj> TdocPj { get; set; }
        public virtual DbSet<HoraExtra> HoraExtra { get; set; }
        public virtual DbSet<Falta> Falta { get; set; }
       public virtual DbSet<Cpoc> Cpoc { get; set; }
       public virtual DbSet<CpocCompra> CpocCompra { get; set; }
       public virtual DbSet<CpocVend> CpocVend { get; set; }

        public virtual DbSet<Tirps> Tirps { get; set; }//Tabelas de IRPS
        public virtual DbSet<Tirpsl> Tirpsl { get; set; }//Tabelas de IRPS
        public virtual DbSet<Rltsql> Rltsql { get; set; }//
        public virtual DbSet<Rdlcxml> Rdlcxml { get; set; }//
        public virtual DbSet<Usrmudapreco> Usrmudapreco { get; set; }//Paramemail
        public virtual DbSet<Paramemail> Paramemail { get; set; }//
        public virtual DbSet<Reserva> Reserva { get; set; }
        public virtual DbSet<Reserval> Reserval { get; set; }
        #endregion
        public virtual DbSet<Aulino> Aulino { get; set; }//
        public virtual DbSet<MatriculaAluno> MatriculaAluno { get; set; }//

        public virtual DbSet<calendario> Calendario { get; set; }//calendario

        public virtual DbSet<Maquina> Maquina { get; set; }//                                                //
        public virtual DbSet<Planoaval> Planoaval { get; set; }
        public virtual DbSet<Tiporesult> Tiporesult { get; set; }
        public virtual DbSet<Processo> Processo { get; set; }//Aulino
        public virtual DbSet<Dclasse> Dclasse { get; set; }//Grupo
        public virtual DbSet<Anolect> Anolect { get; set; }//Grupo
        public virtual DbSet<Grupo> Grupo { get; set; }
        public virtual DbSet<Docac> Docac { get; set; }//Fing
        public virtual DbSet<Fing> Fing { get; set; }//
        public virtual DbSet<Sala> Sala { get; set; }//Horario
        public virtual DbSet<Horario> Horario { get; set; }//Turno
        public virtual DbSet<Turno> Turno { get; set; }//AnoLectivo
        public virtual DbSet<AnoLectivo> AnoLectivo { get; set; }//
        public virtual DbSet<Planomulta> Planomulta { get; set; }
        public virtual DbSet<Planobolsa> Planobolsa { get; set; }
        public virtual DbSet<Planopag> Mensalconf { get; set; }
        public virtual DbSet<AnoSem> AnoSem { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Sem> Sem { get; set; }
        public virtual DbSet<Grade> Grade { get; set; }
        public virtual DbSet<DiasFeria> DiasFeria { get; set; }
        public virtual DbSet<PlanoFeria> PlanoFeria { get; set; }        
        public virtual DbSet<Tdocpe> Tdocpe { get; set; }
        public virtual DbSet<TContrato> TContrato { get; set; }
        public virtual DbSet<Parampv> Parampv { get; set; }//Unimesa
        public virtual DbSet<Unimesa> Unimesa { get; set; }//Unimesa
        public virtual DbSet<Modulosfrmdoc> Modulosfrmdoc { get; set; }
        public virtual DbSet<Clst> Clst { get; set; }
        public virtual DbSet<ClMorada> ClMorada { get; set; }
        public virtual DbSet<Ccutv> Ccutv { get; set; }
        public virtual DbSet<Ccutvdoc> Ccutvdoc { get; set; }
        public virtual DbSet<Ccutvdocdi> Ccutvdocdi { get; set; }
        public virtual DbSet<Caixal> Caixal { get; set; }
        public virtual DbSet<Feriado> Feriado { get; set; }
        public virtual DbSet<Feriadol> Feriadol { get; set; }
        //Parametros para modulo adaacademia
        public virtual DbSet<Paramac> Paramac { get; set; }
        public virtual DbSet<ClBolsa> ClBolsa { get; set; }
        public virtual DbSet<Alauxiliar> Alauxiliar { get; set; }
        public virtual DbSet<Alauxiliarl> Alauxiliarl { get; set; }
        public virtual DbSet<Vtmanunt> Vtmanunt { get; set; }
        public virtual DbSet<Peemp> Peemp { get; set; }
        public virtual DbSet<Peempcc> Peempcc { get; set; }
        public virtual DbSet<Peempl> Peempl { get; set; }
        public virtual DbSet<PeForm> PeForm { get; set; }
        public virtual DbSet<Proces> Process { get; set; }
        public virtual DbSet<Profiss> Profiss { get; set; }
        public virtual DbSet<Meses> Meses { get; set; }
        public virtual DbSet<Desconto> Desconto { get; set; }
        public virtual DbSet<Sub> Sub { get; set; }
        public virtual DbSet<PeAuxiliar> PeAuxiliar { get; set; }
        public virtual DbSet<Empresadep> Empresadep { get; set; }
        public virtual DbSet<Dill> Dill { get; set; }
        public virtual DbSet<Mat> Mat { get; set; }
        public virtual DbSet<Matdisc> Matdisc { get; set; }
        public virtual DbSet<Turmanota> Lnota { get; set; }
        public virtual DbSet<Inst> Inst { get; set; }
        public virtual DbSet<Instunid> Instunid { get; set; }
        public virtual DbSet<Instunidl> Instunidl { get; set; }
        public virtual DbSet<Turmal> Turhl { get; set; }
        public virtual DbSet<ClCur> ClCur { get; set; }
        public virtual DbSet<ClCursem> ClCursem { get; set; }
        public virtual DbSet<ClCursemdisc> ClCursemdisc { get; set; }
        public virtual DbSet<ClDoenca> ClDoenca { get; set; }
        public virtual DbSet<ClFam> ClFam { get; set; }
        public virtual DbSet<ClTur> ClTurma { get; set; }
        public virtual DbSet<Peri> Peri { get; set; }
        public virtual DbSet<Pericur> Pericur { get; set; }
        public virtual DbSet<Pericursem> Pericursem { get; set; }
        public virtual DbSet<Pericursemtur> Pericursemtur { get; set; }
        public virtual DbSet<ClDoc> Cldoc { get; set; }
        public virtual DbSet<Transp> Transp { get; set; }
        public virtual DbSet<Transpvt> Transpvt { get; set; }
        public virtual DbSet<ClCt> ClCt { get; set; }
        public virtual DbSet<FncCt> FncCt { get; set; }
        public virtual DbSet<ClContact> ClContact { get; set; }
        public virtual DbSet<Paramgct> Paramgct { get; set; }
        public virtual DbSet<Laranja> Laranja { get; set; }
        public virtual DbSet<Apparam> Apparam { get; set; }
        public virtual DbSet<Apivded> Apivded { get; set; }
        public virtual DbSet<Apivliq> Apivliq { get; set; }
        //Tabela de configuracao de impressoras em parametros 
        public virtual DbSet<ParamImp> ParamImp { get; set; }
        //Tabela de modulos licenciados a empresa 
        public virtual DbSet<EmpresaMod> EmpresaMod { get; set; }
        public virtual DbSet<Mescont> Mescont { get; set; }
        public virtual DbSet<IV> IV { get; set; }
        public virtual DbSet<IVL> IVL { get; set; }
        public virtual DbSet<Auxiliar2> Auxiliar2 { get; set; }
        public virtual DbSet<Pgcsa> Pgcsa { get; set; }
        #region Tabelas de cadastro de viaturas actualizado
        public virtual DbSet<StVtTrailer> VtTrailer { get; set; }
        public virtual DbSet<StVtdoc> StVtdoc { get; set; }
        public virtual DbSet<StVtman> StVtman { get; set; }
        #endregion
        #region Tabelas de projectos e seus relacionalementos 
        public virtual DbSet<Pj> Pj { get; set; }
        public virtual DbSet<Pjvt> Pjvt { get; set; }
        public virtual DbSet<Pjpe> Pjpes { get; set; }

        public virtual DbSet<Pjdepart> Pjdepart { get; set; }
        public virtual DbSet<Pjclpe> Pjclpe { get; set; }
        public virtual DbSet<Pjesc> Pjesc { get; set; }
        public virtual DbSet<Pjescl> Pjescl { get; set; }
        public virtual DbSet<Pjdoc> Pjdoc { get; set; }
        #endregion
        #region Tabelas do modulo de RH Incluindo o proc de salarios
        public virtual DbSet<Prc> Prc { get; set; }
        public virtual DbSet<Pe> Pe { get; set; }
        //Contratos
        public virtual DbSet<Pecontra> Pecontra { get; set; }
        public virtual DbSet<Pedesc> Pedesc { get; set; }
        public virtual DbSet<Pefalta> Pefalta { get; set; }
        public virtual DbSet<Pefer> Pefer { get; set; }
        public virtual DbSet<Pehextra> Pehextra { get; set; }
        public virtual DbSet<Pesub> Pesub { get; set; }
        public virtual DbSet<Pedoc> Pedoc { get; set; }
        public virtual DbSet<Petur> Petur { get; set; }
        //Contactos 
        public virtual DbSet<Pecont> Pecont { get; set; }
        public virtual DbSet<Pebanc> Pebanc { get; set; }
        public virtual DbSet<Peling> Peling { get; set; }
        public virtual DbSet<Pesind> Pesind { get; set; }
        public virtual DbSet<Peaux> Peaux { get; set; }
        #endregion
        public virtual DbSet<Codtz> Codtz { get; set; }//
        //Tabela de fornecedores de um produto
        public virtual DbSet<StFnc> StFnc { get; set; }//
        public virtual DbSet<Diario> Diario { get; set; }//StFnc
        public virtual DbSet<Dc> Dc { get; set; }
        public virtual DbSet<Dcli> Dcli { get; set; }
        public DbSet<Caixa> Caixa { get; set; }
        //Tabela de Cadastro de postos de vendas ..... 
        public DbSet<Pv> Pv { get; set; }
        //Tabela de Cadastro de sectores de Mesas ..... 
        public DbSet<Sector> Sector { get; set; }
        //Tabela de Cadastro de mesas de sectores..... 
        public DbSet<SectMesas> SectMesas { get; set; }
        //Tabela de Cadastro de Mesas ..... 
        public DbSet<Mesas> Mesas { get; set; }
        //Tabela de Modulos associados ao usuario ..... 
        public DbSet<Rltusr> Rltusr { get; set; }
        //Tabela de Modulos associados ao usuario ..... 
        public DbSet<UsrModulo> UsrModulo { get; set; }

        //Tabela de Acessos associados ao usuario ..... 
        public DbSet<Usracessos> Usracessos { get; set; }
        //Tabela de Parametros Gerais 
        public DbSet<Param> Param { get; set; }
        //Tabela de Entidades
        public DbSet<Ent> Ent { get; set; }
        //Tabela de produtos e servicos 
        public DbSet<St> St { get; set; }
        //Tabela de clientes 
        public DbSet<Cl> Cl { get; set; }
        //Tabela de distritos 
        public DbSet<Dist> Dist { get; set; }
        public DbSet<Auxiliar> Auxiliar { get; set; }
        public DbSet<Paises> Paises { get; set; }
        public DbSet<Banco> Banco { get; set; }
        public DbSet<Armazem> Armazem { get; set; }
        //Tabela de familia de produtos 
        public DbSet<Familia> Familia { get; set; }
        //Tabela de Usuarios 
        public DbSet<Usr> Usr { get; set; }
        //Tabela de subfamilias de produtos 
        public DbSet<SubFam> SubFam { get; set; }
        //Tabela de fornecedores 
        public DbSet<Fnc> Fnc { get; set; }
        //Tabela de Centro de custos 
        public DbSet<CCu> CCu { get; set; }
        public DbSet<Ccu_Arm> Ccu_Arm { get; set; }
        public DbSet<Ccu_Caixa> Ccu_Caixa { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Pad> Pad { get; set; }
        //Tabela de contas de tesouraria 
        public DbSet<Contas> Contas { get; set; }
        //Tabela de  produto composto 
        public DbSet<Stcp> Stcp { get; set; }
        //Tabela de precos de produtos 
        public DbSet<StPrecos> ProdPrecos  { get; set; }
        //Tabela de tipos de documentos de facturacao de clientes 
        public DbSet<Tdoc> Tdoc { get; set; }
        public DbSet<Codcc> Codcc { get; set; }
        public DbSet<Codstk> Codstk { get; set; }
        //Tabela de facturacao de clientes 
        public DbSet<Fact> Fact { get; set; }
        //Tabela de linhas de facturacao de clientes 
        public DbSet<Factl> Factl { get; set; }
        //Tabela de conta corrente de clientes  
        public DbSet<Cc> Cc { get; set; }
        //Tabela de formas de pagamento 
        public DbSet<Formasp> Formasp { get; set; }
        public DbSet<Fcc> Fcc { get; set; }
        public DbSet<Fpagam> Fpagam { get; set; }
        public DbSet<Moedas> Moedas { get; set; }
        public DbSet<Mvt> Mvt { get; set; }
        public DbSet<Vend> Vend { get; set; }
        public DbSet<RCL> Rcl { get; set; }
        public DbSet<Rcll> Rcll { get; set; }
        public DbSet<Mstk> Mstk { get; set; }
        public DbSet<Tdi> Tdi { get; set; }
        public DbSet<Pgf> Pgf { get; set; }
        public virtual DbSet<Dil> Dil { get; set; }
        public virtual DbSet<Facc> Facc { get; set; }
        public virtual DbSet<Faccl> Faccl { get; set; }
        public virtual DbSet<Faccprest> Faccprest { get; set; }
        public virtual DbSet<Tdocf> Tdocf { get; set; }
        public virtual DbSet<Docmodulo> Docmodulo { get; set; }
        public virtual DbSet<TRcl> Trcl { get; set; }
        public virtual DbSet<Trd> Trd { get; set; }
        public virtual DbSet<Trdf> Trdf { get; set; }
        public virtual DbSet<Rlt> Rlt { get; set; }
        public virtual DbSet<Modulos> Modulos { get; set; }
        public virtual DbSet<Tpgf> Tpgf { get; set; }
        public virtual DbSet<Pgfl> Pgfl { get; set; }
        public virtual DbSet<Starm> Starm { get; set; }
        public virtual DbSet<Lcont> Lcont { get; set; }
        public virtual DbSet<Ml> Ml { get; set; }
        public virtual DbSet<Pgc> Pgc { get; set; }
        public virtual DbSet<Cambio> Cambio { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<StCt> StCt { get; set; }
        public virtual DbSet<StDrp> StDrp { get; set; }
        public virtual DbSet<Condpag> Condpag { get; set; }
        public virtual DbSet<Condpagl> Condpagl { get; set; }
        public virtual DbSet<St2> St2 { get; set; }
        public virtual DbSet<TabelaAmort> TaxasAmort { get; set; }
        public virtual DbSet<UsrLog> UsrLog { get; set; }
        public virtual DbSet<StDrpc> StDrpc { get; set; }
        public virtual DbSet<Dlei> Dlei { get; set; }
        public virtual DbSet<Dleil> Dleil { get; set; }
        public virtual DbSet<Stimpar> Stimpar { get; set; }
        public virtual DbSet<Streaval> Streaval { get; set; }
        public virtual DbSet<Streval> Streval { get; set; }
        public virtual DbSet<Tpgp> Tpgp { get; set; }
        //Tabelas de Procurmente 
        public virtual DbSet<Procurm> Procurm { get; set; }
        public virtual DbSet<Procurml> Procurml { get; set; }
        public virtual DbSet<FncProc> FncProc { get; set; }
        public virtual DbSet<ProcAnalFnc> ProcAnalFnc { get; set; }
        public virtual DbSet<ProcCrt> ProcCrt { get; set; }
        public virtual DbSet<TdocMat> TdocMat { get; set; }
        //Fim de Procurment 
        public virtual DbSet<Ctauxiliarl> Ctauxiliarl { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Add(new DateConvention());
            modelBuilder.Properties<string>().Configure(x => x.HasMaxLength(80));
            //modelBuilder.Properties<string>().Configure(x => x.IsRequired());
            modelBuilder.Properties<string>().Configure(x => x.IsRequired());
            modelBuilder.Properties<decimal>().Configure(x => x.HasPrecision(9, 0));

            //modelBuilder.Entity<Rlt>().Property(x => x.CrQuery).HasMaxLength(30000);
            //modelBuilder.Entity<Rlt>().Property(x => x.ReportXml).HasMaxLength(30000);
            //modelBuilder.Entity<Rltsql>().Property(x => x.Querry).HasMaxLength(30000);
            modelBuilder.Entity<Rlt>().Property(x => x.ComboQry1).HasMaxLength(600);
            modelBuilder.Entity<Rlt>().Property(x => x.ComboQry2).HasMaxLength(600);
            modelBuilder.Entity<Rlt>().Property(x => x.ComboQry3).HasMaxLength(600);
            modelBuilder.Entity<Rlt>().Property(x => x.ComboQry4).HasMaxLength(600);
            modelBuilder.Entity<Rlt>().Property(x => x.ComboQry5).HasMaxLength(600);
            modelBuilder.Entity<Rlt>().Property(x => x.ComboQry6).HasMaxLength(600);
            modelBuilder.Entity<Rlt>().Property(x => x.ComboQry7).HasMaxLength(600);
            modelBuilder.Entity<Rlt>().Property(x => x.ComboQry8).HasMaxLength(600);
            modelBuilder.Entity<Rlt>().Property(x => x.ComboQry9).HasMaxLength(600);
            modelBuilder.Entity<Rlt>().Property(x => x.Filtros).HasMaxLength(600);
            modelBuilder.Entity<Rlt>().Property(x => x.ClmMask).HasMaxLength(600);
            modelBuilder.Entity<Rlt>().Property(x => x.TmGrid).HasMaxLength(600);
            modelBuilder.Entity<Rlt>().Property(x => x.ClnHeader).HasMaxLength(600);
            modelBuilder.Entity<Rlt>().Property(x => x.ClnCor).HasMaxLength(600);
            modelBuilder.Entity<Rlt>().Property(x => x.ClnBold).HasMaxLength(600);
            modelBuilder.Entity<Rlt>().Property(x => x.ClnAlign).HasMaxLength(600);
            modelBuilder.Entity<A_param>().Property(x => x.motivoiva).HasMaxLength(200);
            modelBuilder.Entity<A_param>().Property(x => x.motivoivaeng).HasMaxLength(200);
            modelBuilder.Entity<A_param>().Property(x => x.outGoingEmailp).HasMaxLength(100);
            modelBuilder.Entity<A_param>().Property(x => x.subjp).HasMaxLength(100);
            modelBuilder.Entity<Factl>().Property(x => x.Descricao).HasMaxLength(600);
            modelBuilder.Entity<St>().Property(x => x.Descricao).HasMaxLength(600);
            modelBuilder.Entity<Dil>().Property(x => x.Descricao).HasMaxLength(600);
            modelBuilder.Entity<Faccl>().Property(x => x.Descricao).HasMaxLength(600);

            modelBuilder.Entity<Tpgp>().Property(e => e.XmlString).HasMaxLength(1000000);
            modelBuilder.Entity<Tpgp>().Property(e => e.XmlStringa5).HasMaxLength(1000000);

            modelBuilder.Entity<Tdoc>().Property(e => e.XmlString).HasMaxLength(1000000);
            modelBuilder.Entity<Rltsql>().Property(e => e.XmlString).HasMaxLength(1000000);
            modelBuilder.Entity<Tdocf>().Property(e => e.XmlString).HasMaxLength(1000000);
            modelBuilder.Entity<TRcl>().Property(e => e.XmlString).HasMaxLength(1000000);
            modelBuilder.Entity<Tpgf>().Property(e => e.XmlString).HasMaxLength(1000000);
            modelBuilder.Entity<Tpgf>().Property(e => e.XmlString2).HasMaxLength(1000000);
            modelBuilder.Entity<Tdi>().Property(e => e.XmlString).HasMaxLength(1000000);
            modelBuilder.Entity<Rlt>().Property(e => e.XmlString).HasMaxLength(1000000);
            modelBuilder.Entity<Rdlcxml>().Property(e => e.XmlString).HasMaxLength(1000000);
            modelBuilder.Entity<TPercl>().Property(e => e.XmlString).HasMaxLength(1000000);
            modelBuilder.Entity<TRcl>().Property(e => e.XmlStringA5).HasMaxLength(1000000);
            modelBuilder.Entity<TRcl>().Property(e => e.XmlStringPOS).HasMaxLength(1000000);
            modelBuilder.Entity<Tdoc>().Property(e => e.XmlStringA5).HasMaxLength(1000000);
            modelBuilder.Entity<Tdoc>().Property(e => e.XmlStringPOS).HasMaxLength(1000000);
            //

            modelBuilder.Entity<Factl>().Property(x => x.Contatz).HasColumnAnnotation("Default","0");
            modelBuilder.Entity<Fnc>().Property(x => x.Saldo).HasColumnAnnotation("Default","(0)");
            modelBuilder.Entity<Cl>().Property(x => x.Saldo).HasColumnAnnotation("Default","((0))");
            NullForeignKeys(modelBuilder);
            modelBuilder.Conventions.Add(new DecimalPrecisionAttributeConvention());
        }
        private void NullForeignKeys(DbModelBuilder modelBuilder)
        {
            //Campos que devem ser nulos no SQL
            //Tabela conta corrente do cliente
            modelBuilder.Entity<Docmodulo>().Property(p => p.Rltstamp).IsOptional();
            modelBuilder.Entity<Docmodulo>().Property(p => p.Tdistamp).IsOptional();
            modelBuilder.Entity<Docmodulo>().Property(p => p.Tdocfstamp).IsOptional();
            modelBuilder.Entity<Docmodulo>().Property(p => p.Tdocstamp).IsOptional();
            //Tabela de conta corrente de cliente 
            modelBuilder.Entity<Cc>().Property(p => p.Factstamp).IsOptional();
            modelBuilder.Entity<Cc>().Property(p => p.Rdstamp).IsOptional();
            modelBuilder.Entity<Cc>().Property(p => p.Rclstamp).IsOptional();
            //Tabela de conta corrente de trabalhador 
            modelBuilder.Entity<Pecc>().Property(p => p.Prcstamp).IsOptional();
            modelBuilder.Entity<Pecc>().Property(p => p.Perclstamp).IsOptional();
            //Tabela conta corrente do Fornecedor
            modelBuilder.Entity<Fcc>().Property(p => p.Pgfstamp).IsOptional();
            modelBuilder.Entity<Fcc>().Property(p => p.Faccstamp).IsOptional();
            modelBuilder.Entity<Fcc>().Property(p => p.Rdfstamp).IsOptional();
            modelBuilder.Entity<Fcc>().Property(p => p.Pgflstamp).IsOptional();
            modelBuilder.Entity<Fcc>().Property(p => p.Numinterno).IsOptional();
            modelBuilder.Entity<Fcc>().Property(p => p.Reffornec).IsOptional();
            //Tabela Movimento de Stock entrada e saida de produtos  
            modelBuilder.Entity<Mstk>().Property(p => p.Facclstamp).IsOptional();
            modelBuilder.Entity<Mstk>().Property(p => p.Faccstamp).IsOptional();
            modelBuilder.Entity<Mstk>().Property(p => p.Factlstamp).IsOptional();
            modelBuilder.Entity<Mstk>().Property(p => p.Factstamp).IsOptional();
            modelBuilder.Entity<Mstk>().Property(p => p.Dilstamp).IsOptional();
            modelBuilder.Entity<Mstk>().Property(p => p.Distamp).IsOptional();
            modelBuilder.Entity<Mstk>().Property(p => p.Ivlstamp).IsOptional();
            modelBuilder.Entity<Mstk>().Property(p => p.Ivstamp).IsOptional();
            modelBuilder.Entity<Pgc>().Property(p => p.Oristamp).IsOptional();
            //Tabela Movimento de Tesouraria 
            modelBuilder.Entity<Mvt>().Property(p => p.Oristamp).IsOptional();
            modelBuilder.Entity<Mvt>().Property(p => p.Formaspstamp).IsOptional();
            //Tabela Formas de pagamento que por sua vez movimenta a tesouraria 
            modelBuilder.Entity<Formasp>().Property(p => p.Rclstamp).IsOptional();
            modelBuilder.Entity<Formasp>().Property(p => p.Factstamp).IsOptional();
            modelBuilder.Entity<Formasp>().Property(p => p.Faccstamp).IsOptional();
            modelBuilder.Entity<Formasp>().Property(p => p.Oristamp).IsOptional();
            modelBuilder.Entity<Formasp>().Property(p => p.Distamp).IsOptional();
            modelBuilder.Entity<Formasp>().Property(p => p.Pgfstamp).IsOptional();
            modelBuilder.Entity<Formasp>().Property(p => p.Perclstamp).IsOptional();
        }
        public void DefaultValuesSetting()
        {  
            //var db = new DataContext()..GetAllTableProperties().ToList();
            //foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(this))
            //{
            //    var myAttribute = (DefaultValueAttribute)property.Attributes[typeof(DefaultValueAttribute)];

            //    if (myAttribute != null)
            //    {
            //        property.SetValue(this, myAttribute.Value);
            //    }
            //}
        }
    }


}
