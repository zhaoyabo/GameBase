﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Game
{
    public class Enity
    {
        private Dictionary<string, object> _dictProperty = new Dictionary<string, object>();
        private Dictionary<string, BaseComponent> _dictComponent = new Dictionary<string, BaseComponent>();
        private EventComponent _event;
        private GameObject _go;

        public GameObject Go
        {
            get { return _go; }
            set
            {
                _go = value;
                Animator _animator = _go.GetComponentInChildren<Animator>();
                if (_animator != null)
                {
                    this.AddProperty("animator", _animator);
                }
            }
        }

        public Transform Transform
        {
            get { return _go.transform; }
        }
        public Enity()
        {
            Init();
        }

        public EventComponent Event
        {
            get { return _event; }
        }
        private void Init()
        {
            _event = new EventComponent();
            AddComponent("Event", _event);
        }

        public void AddProperty(string key, object value, bool isDispatcher = false)
        {
            if (_dictProperty.ContainsKey(key))
            {
                _dictProperty[key] = value;
            }
            else
            {
                _dictProperty.Add(key, value);
            }
            if (isDispatcher)
            {
                Event.DispatcherEvent(key);
            }
        }

        public void SetProperty(string key, object value, bool isDispatcher = false)
        {
            _dictProperty[key] = value;
            if (isDispatcher) Event.DispatcherEvent(key);
        }

        public bool HasProperty(string key)
        {
            return _dictProperty.ContainsKey(key);
        }

        public object GetProperty(string key)
        {
            if (HasProperty(key))
            {
                return _dictProperty[key];
            }
            return null;
        }

        public void AddComponent(string key, BaseComponent component)
        {
            _dictComponent.Add(key, component);
            component.Enity = this;
        }

        public T AddComponent<T>() where T : BaseComponent
        {
            string key = typeof(T).Name;
            if (_dictComponent.ContainsKey(key))
            {
                return (T)_dictComponent[key];
            }
            T t = System.Activator.CreateInstance<T>();
            t.Enity = this;
            _dictComponent.Add(key, t);
            return t;
        }

        public void RemoveComponent<T>() where T : BaseComponent
        {
            string key = typeof(T).Name;
            RemoveComponent(key);
        }

        public T GetComponent<T>() where T : BaseComponent
        {
            string key = typeof(T).Name;
            if (_dictComponent.ContainsKey(key))
            {
                return (T)_dictComponent[key];
            }
            return null;
        }

        public void RemoveComponent(string key)
        {
            if (_dictComponent.ContainsKey(key))
            {
                _dictComponent[key].RemoveEvent();
                _dictComponent.Remove(key);
            }
        }

        public void Update()
        {

        }

    }
}
