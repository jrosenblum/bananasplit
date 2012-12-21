//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace BananaSplit.Data
{
    public partial class Member
    {
        #region Primitive Properties
    
        public virtual long MemberId
        {
            get;
            set;
        }
    
        public virtual string FirstName
        {
            get;
            set;
        }
    
        public virtual string LastName
        {
            get;
            set;
        }
    
        public virtual string Email
        {
            get;
            set;
        }
    
        public virtual bool IsVerfied
        {
            get;
            set;
        }
    
        public virtual bool IsActive
        {
            get;
            set;
        }
    
        public virtual System.DateTime DateCreated
        {
            get;
            set;
        }
    
        public virtual System.DateTime DateUpdated
        {
            get;
            set;
        }
    
        public virtual System.DateTime DateLastAccessed
        {
            get;
            set;
        }
    
        public virtual string FacebookId
        {
            get;
            set;
        }
    
        public virtual int MemberTypeId
        {
            get { return _memberTypeId; }
            set
            {
                if (_memberTypeId != value)
                {
                    if (MemberType != null && MemberType.MemberTypeId != value)
                    {
                        MemberType = null;
                    }
                    _memberTypeId = value;
                }
            }
        }
        private int _memberTypeId;
    
        public virtual string PhoneNumber
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<ApiAccess> ApiAccesses
        {
            get
            {
                if (_apiAccesses == null)
                {
                    var newCollection = new FixupCollection<ApiAccess>();
                    newCollection.CollectionChanged += FixupApiAccesses;
                    _apiAccesses = newCollection;
                }
                return _apiAccesses;
            }
            set
            {
                if (!ReferenceEquals(_apiAccesses, value))
                {
                    var previousValue = _apiAccesses as FixupCollection<ApiAccess>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupApiAccesses;
                    }
                    _apiAccesses = value;
                    var newValue = value as FixupCollection<ApiAccess>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupApiAccesses;
                    }
                }
            }
        }
        private ICollection<ApiAccess> _apiAccesses;
    
        public virtual ICollection<Invoice> Invoices
        {
            get
            {
                if (_invoices == null)
                {
                    var newCollection = new FixupCollection<Invoice>();
                    newCollection.CollectionChanged += FixupInvoices;
                    _invoices = newCollection;
                }
                return _invoices;
            }
            set
            {
                if (!ReferenceEquals(_invoices, value))
                {
                    var previousValue = _invoices as FixupCollection<Invoice>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupInvoices;
                    }
                    _invoices = value;
                    var newValue = value as FixupCollection<Invoice>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupInvoices;
                    }
                }
            }
        }
        private ICollection<Invoice> _invoices;
    
        public virtual ICollection<Invoice> Invoices1
        {
            get
            {
                if (_invoices1 == null)
                {
                    var newCollection = new FixupCollection<Invoice>();
                    newCollection.CollectionChanged += FixupInvoices1;
                    _invoices1 = newCollection;
                }
                return _invoices1;
            }
            set
            {
                if (!ReferenceEquals(_invoices1, value))
                {
                    var previousValue = _invoices1 as FixupCollection<Invoice>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupInvoices1;
                    }
                    _invoices1 = value;
                    var newValue = value as FixupCollection<Invoice>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupInvoices1;
                    }
                }
            }
        }
        private ICollection<Invoice> _invoices1;
    
        public virtual MemberType MemberType
        {
            get { return _memberType; }
            set
            {
                if (!ReferenceEquals(_memberType, value))
                {
                    var previousValue = _memberType;
                    _memberType = value;
                    FixupMemberType(previousValue);
                }
            }
        }
        private MemberType _memberType;
    
        public virtual ICollection<Partnership> Partnerships
        {
            get
            {
                if (_partnerships == null)
                {
                    var newCollection = new FixupCollection<Partnership>();
                    newCollection.CollectionChanged += FixupPartnerships;
                    _partnerships = newCollection;
                }
                return _partnerships;
            }
            set
            {
                if (!ReferenceEquals(_partnerships, value))
                {
                    var previousValue = _partnerships as FixupCollection<Partnership>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupPartnerships;
                    }
                    _partnerships = value;
                    var newValue = value as FixupCollection<Partnership>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupPartnerships;
                    }
                }
            }
        }
        private ICollection<Partnership> _partnerships;
    
        public virtual ICollection<PartnerTicket> PartnerTickets
        {
            get
            {
                if (_partnerTickets == null)
                {
                    var newCollection = new FixupCollection<PartnerTicket>();
                    newCollection.CollectionChanged += FixupPartnerTickets;
                    _partnerTickets = newCollection;
                }
                return _partnerTickets;
            }
            set
            {
                if (!ReferenceEquals(_partnerTickets, value))
                {
                    var previousValue = _partnerTickets as FixupCollection<PartnerTicket>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupPartnerTickets;
                    }
                    _partnerTickets = value;
                    var newValue = value as FixupCollection<PartnerTicket>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupPartnerTickets;
                    }
                }
            }
        }
        private ICollection<PartnerTicket> _partnerTickets;
    
        public virtual ICollection<TicketPrice> TicketPrices
        {
            get
            {
                if (_ticketPrices == null)
                {
                    var newCollection = new FixupCollection<TicketPrice>();
                    newCollection.CollectionChanged += FixupTicketPrices;
                    _ticketPrices = newCollection;
                }
                return _ticketPrices;
            }
            set
            {
                if (!ReferenceEquals(_ticketPrices, value))
                {
                    var previousValue = _ticketPrices as FixupCollection<TicketPrice>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupTicketPrices;
                    }
                    _ticketPrices = value;
                    var newValue = value as FixupCollection<TicketPrice>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupTicketPrices;
                    }
                }
            }
        }
        private ICollection<TicketPrice> _ticketPrices;

        #endregion
        #region Association Fixup
    
        private void FixupMemberType(MemberType previousValue)
        {
            if (previousValue != null && previousValue.Members.Contains(this))
            {
                previousValue.Members.Remove(this);
            }
    
            if (MemberType != null)
            {
                if (!MemberType.Members.Contains(this))
                {
                    MemberType.Members.Add(this);
                }
                if (MemberTypeId != MemberType.MemberTypeId)
                {
                    MemberTypeId = MemberType.MemberTypeId;
                }
            }
        }
    
        private void FixupApiAccesses(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (ApiAccess item in e.NewItems)
                {
                    item.Member = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ApiAccess item in e.OldItems)
                {
                    if (ReferenceEquals(item.Member, this))
                    {
                        item.Member = null;
                    }
                }
            }
        }
    
        private void FixupInvoices(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Invoice item in e.NewItems)
                {
                    item.Member = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Invoice item in e.OldItems)
                {
                    if (ReferenceEquals(item.Member, this))
                    {
                        item.Member = null;
                    }
                }
            }
        }
    
        private void FixupInvoices1(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Invoice item in e.NewItems)
                {
                    item.Member1 = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Invoice item in e.OldItems)
                {
                    if (ReferenceEquals(item.Member1, this))
                    {
                        item.Member1 = null;
                    }
                }
            }
        }
    
        private void FixupPartnerships(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Partnership item in e.NewItems)
                {
                    item.Member = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Partnership item in e.OldItems)
                {
                    if (ReferenceEquals(item.Member, this))
                    {
                        item.Member = null;
                    }
                }
            }
        }
    
        private void FixupPartnerTickets(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (PartnerTicket item in e.NewItems)
                {
                    item.Member = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (PartnerTicket item in e.OldItems)
                {
                    if (ReferenceEquals(item.Member, this))
                    {
                        item.Member = null;
                    }
                }
            }
        }
    
        private void FixupTicketPrices(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (TicketPrice item in e.NewItems)
                {
                    item.Member = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (TicketPrice item in e.OldItems)
                {
                    if (ReferenceEquals(item.Member, this))
                    {
                        item.Member = null;
                    }
                }
            }
        }

        #endregion
    }
}