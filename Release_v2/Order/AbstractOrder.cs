using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    /// <summary>
    /// Implementeert alle basisfunctionaliteit van
    /// orders voor computersystemen.
    /// </summary>
    public abstract class AbstractOrder
    {
        /// <summary>
        /// Unieke identifier van order.
        /// </summary>
        protected int _orderId;
        public int OrderId
        {
            get { return this._orderId; }
        }

        /// <summary>
        /// Huidige status van order.
        /// </summary>
        protected OrderStatus _status;
        public OrderStatus Status
        {
            get { return this._status; }
        }

        /// <summary>
        /// Type van order.
        /// </summary>
        protected string _type;
        public string Type
        {
            get { return this._type; }
        }

        /// <summary>
        /// Componenten die in dit order verwerkt zijn.
        /// </summary>
        protected List<IComponent> _components;
        public List<IComponent> Components
        {
            get { return this._components; }
        }

        /// <summary>
        /// Bestelde software.
        /// </summary>
        protected List<ISoftware> _apps;
        public List<ISoftware> Apps
        {
            get { return this._apps; }
        }

        /// <summary>
        /// Creëert een order met meegegeven ID en zet
        /// status op <c>Start</c>.
        /// </summary>
        /// <param name="orderId">Identifier voor order</param>
        public AbstractOrder(int orderId)
        {
            this._orderId = orderId;
            this._status = OrderStatus.Start;
            this._components = new List<IComponent>();
            this._apps = new List<ISoftware>();
        }

        /// <summary>
        /// Creëert een order met meegegeven ID en zet
        /// status op meegegeven status.
        /// </summary>
        /// <param name="orderId">Identifier voor order</param>
        /// <param name="os">Beginstatus van order</param>
        public AbstractOrder(int orderId, OrderStatus os)
        {
            this._orderId = orderId;
            this._status = os;
            this._components = new List<IComponent>();
            this._apps = new List<ISoftware>();
        }

        /// <summary>
        /// Creëert een order met meegegeven ID en zet
        /// status op meegegeven status.
        /// </summary>
        /// <param name="orderId">Identifier voor order</param>
        /// <param name="os">Beginstatus van order</param>
        /// <param name="components">Lijst van componenten</param>
        public AbstractOrder(int orderId, OrderStatus os, List<IComponent> components)
        {
            this._orderId = orderId;
            this._status = os;
            this._components = components;
            this._apps = new List<ISoftware>();
        }

        /// <summary>
        /// Creëert een order met meegegeven ID en zet
        /// status op meegegeven status.
        /// </summary>
        /// <param name="orderId">Identifier voor order</param>
        /// <param name="os">Beginstatus van order</param>
        /// <param name="components">Lijst van componenten</param>
        /// <param name="apps">Lijst van software</param>
        public AbstractOrder(int orderId, OrderStatus os, List<IComponent> components, List<ISoftware> apps)
        {
            this._orderId = orderId;
            this._status = os;
            this._components = components;
            this._apps = apps;
        }

        /// <summary>
        /// Verandert huidige status van order naar
        /// meegegeven status.
        /// </summary>
        /// <param name="os">Nieuwe status</param>
        public void ChangeStatus(OrderStatus os)
        {
            this._status = os;
        }

        /// <summary>
        /// Voegt meegegeven component toe aan order.
        /// </summary>
        /// <param name="comp">Hardware component</param>
        public void AddComponent(IComponent comp)
        {
            this._components.Add(comp);
        }

        /// <summary>
        /// Voegt lijst van componenten toe aan order.
        /// </summary>
        /// <param name="comps">Lijst met hardwarecomponenten</param>
        public void AddComponentList(List<IComponent> comps)
        {
            this._components = comps;
        }

        /// <summary>
        /// Voegt meegegeven software toe aan order.
        /// </summary>
        /// <param name="s">Softwareprogramma</param>
        public void AddSoftware(ISoftware s)
        {
            this._apps.Add(s);
        }

        /// <summary>
        /// Voegt lijst van applicaties toe aan order.
        /// </summary>
        /// <param name="apps">Lijst met applicaties</param>
        public void AddSoftwareList(List<ISoftware> apps)
        {
            this._apps = apps;
        }

        /// <summary>
        /// Retourneert een tekstuele weergave van order waarin 
        /// het ID, type en status worden weergegeven.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "ID: " + this._orderId + ", Type: " + this._type + ", Status: " + this._status.ToString(); ;
        }
    }
}
