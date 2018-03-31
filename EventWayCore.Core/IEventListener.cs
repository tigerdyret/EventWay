﻿using System;
using System.Threading.Tasks;

namespace EventWayCore.Core
{
	public interface IEventListener
	{
		void OnEvent<T>(Func<OrderedEventPayload, Task> handler);
		void OnEvents<T>(Func<OrderedEventPayload[], Task> handler);
		Task Handle(OrderedEventPayload @event);
		Task Handle(OrderedEventPayload[] @event);
	}
}