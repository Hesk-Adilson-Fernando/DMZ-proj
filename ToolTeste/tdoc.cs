//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToolTeste
{
    using System;
    using System.Collections.Generic;
    
    public partial class tdoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tdoc()
        {
            this.docmodulo = new HashSet<docmodulo>();
        }
    
        public string tdocstamp { get; set; }
        public decimal numdoc { get; set; }
        public string descricao { get; set; }
        public string sigla { get; set; }
        public bool Alteranum { get; set; }
        public bool ctrlData { get; set; }
        public bool ctrlPlaf { get; set; }
        public bool Armazem { get; set; }
        public decimal armdefeito { get; set; }
        public bool movstk { get; set; }
        public decimal codmovstk { get; set; }
        public string descmovstk { get; set; }
        public bool movcc { get; set; }
        public string descmovcc { get; set; }
        public decimal codmovcc { get; set; }
        public bool recibo { get; set; }
        public bool movtes { get; set; }
        public bool Composto { get; set; }
        public bool obgccusto { get; set; }
        public string qmc { get; set; }
        public System.DateTime qmcdathora { get; set; }
        public string qma { get; set; }
        public System.DateTime qmadathora { get; set; }
        public decimal codtz { get; set; }
        public string contastesoura { get; set; }
        public bool movtz { get; set; }
        public bool nalteratz { get; set; }
        public bool activo { get; set; }
        public bool defa { get; set; }
        public bool pos { get; set; }
        public bool introdir { get; set; }
        public string ccusto { get; set; }
        public bool copia { get; set; }
        public bool reserva { get; set; }
        public bool noneg { get; set; }
        public bool Armapenas { get; set; }
        public bool Copyqtt { get; set; }
        public bool copyvalor { get; set; }
        public bool prestacao { get; set; }
        public string coment { get; set; }
        public string titulo { get; set; }
        public bool Facturar { get; set; }
        public decimal ndocfact { get; set; }
        public string docfact { get; set; }
        public bool CopiaDocs { get; set; }
        public decimal Dias { get; set; }
        public bool nc { get; set; }
        public string descdoc { get; set; }
        public bool noimp { get; set; }
        public string Nomfile { get; set; }
        public string ecran { get; set; }
        public string Titimpress { get; set; }
        public decimal tipodoc { get; set; }
        public string Obs2 { get; set; }
        public string descpreco { get; set; }
        public string campopreco { get; set; }
        public decimal no { get; set; }
        public string nome { get; set; }
        public bool usaemail { get; set; }
        public bool usaanexo { get; set; }
        public bool ligapj { get; set; }
        public bool obrigapj { get; set; }
        public bool usaserie { get; set; }
        public bool usalote { get; set; }
        public bool adjudica { get; set; }
        public bool aprova { get; set; }
        public string expressemidoc { get; set; }
        public string expresstitulo { get; set; }
        public bool autoemail { get; set; }
        public bool usaattach { get; set; }
        public string destinationEmail { get; set; }
        public string subj { get; set; }
        public string emailText { get; set; }
        public bool integra { get; set; }
        public decimal noDiario { get; set; }
        public string diario { get; set; }
        public decimal nDocCont { get; set; }
        public string descdoccont { get; set; }
        public decimal tesouraPgc { get; set; }
        public string maskqtt { get; set; }
        public string maskpreco { get; set; }
        public string maskoprecos { get; set; }
        public bool usatec { get; set; }
        public bool nopergtec { get; set; }
        public bool obrigalote { get; set; }
        public bool usaqttmedida { get; set; }
        public string descqttmedida { get; set; }
        public bool noalteramedida { get; set; }
        public bool etpemiss { get; set; }
        public bool etpimpress { get; set; }
        public bool etpemail { get; set; }
        public string etpemisstxt { get; set; }
        public string etpimpresstxt { get; set; }
        public string etpemailtxt { get; set; }
        public bool ctrqttorig { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<docmodulo> docmodulo { get; set; }
    }
}
