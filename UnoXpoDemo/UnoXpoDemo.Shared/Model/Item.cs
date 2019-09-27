
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UnoXpoDemo.Shared.Model
{
    public class Item : BaseModelObject
    {
        public Item()
        {
        }


        [Key] public string Id { get; set; }

        string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        string description;
        public string Description
        {
            get { return description; }
            set { SetProperty( ref description, value); }
        }

        bool _active;
        public bool Active
        {
            get => _active;
            set => SetProperty( ref _active, value);
        }


    }
}
