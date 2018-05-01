﻿// <copyright file="RawMessageDispatcher.cs" company="Cognisant">
// Copyright (c) Cognisant. All rights reserved.
// </copyright>

namespace CR.MessageDispatch.Core
{
    using System;

    /// <summary>
    /// A Deserializing message handler with no actual deserialization, just passes things through
    /// </summary>
    /// <typeparam name="TMessage"></typeparam>
    public class RawMessageDispatcher<TMessage> : DeserializingMessageDispatcher<TMessage, Type>
    {
        public RawMessageDispatcher(IMessageHandlerLookup<Type> handlers)
            : base(handlers)
        {
        }

        protected override bool TryGetMessageType(TMessage rawMessage, out Type type)
        {
            type = rawMessage.GetType();
            return true;
        }

        protected override bool TryDeserialize(Type messageType, TMessage rawMessage, out object deserialized)
        {
            deserialized = rawMessage;
            return true;
        }
    }
}
