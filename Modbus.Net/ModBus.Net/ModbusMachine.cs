﻿using System;
using System.Collections.Generic;

namespace ModBus.Net
{
    public class ModbusMachine : BaseMachine
    {
        public ModbusMachine(ModbusType connectionType, string connectionString,
            IEnumerable<AddressUnit> getAddresses, bool keepConnect) : base(getAddresses, keepConnect)
        {
            BaseUtility = new ModbusUtility(connectionType, connectionString);
            AddressFormater = new AddressFormaterBase();
            AddressCombiner = new AddressCombinerContinus();
        }

        public ModbusMachine(ModbusType connectionType, string connectionString,
            IEnumerable<AddressUnit> getAddresses)
            : this(connectionType, connectionString, getAddresses, false)
        {
        }
    }
}