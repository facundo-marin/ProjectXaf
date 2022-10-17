using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ProjectXaf.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Semiterminados : BaseObject
    { 
        public Semiterminados(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        string condicionAlmacenamiento;
        string origen;
        string descripcion;
        int codigo;
        private XPCollection<AuditDataItemPersistent> audiTrail;

        public int Codigo
        {
            get => codigo;
            set => SetPropertyValue(nameof(Codigo), ref codigo, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Descripcion
        {
            get => descripcion;
            set => SetPropertyValue(nameof(Descripcion), ref descripcion, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Origen
        {
            get => origen;
            set => SetPropertyValue(nameof(Origen), ref origen, value);
        }

        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string CondicionAlmacenamiento
        {
            get => condicionAlmacenamiento;
            set => SetPropertyValue(nameof(CondicionAlmacenamiento), ref condicionAlmacenamiento, value);
        }

        [CollectionOperationSet(AllowAdd = false, AllowRemove = false)]
        public XPCollection<AuditDataItemPersistent> AudiTrail
        {
            get
            {
                if(audiTrail == null)
                {
                    audiTrail = AuditedObjectWeakReference.GetAuditTrail(Session, this);
                }
                return audiTrail;
            }
        }

    }
}