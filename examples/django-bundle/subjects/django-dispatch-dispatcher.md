# django/dispatch/dispatcher

- Subject: django/dispatch/dispatcher (id `4d112cf2-d46a-4233-b563-7ccb49afefd7`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 21 of 97
- Conflicts: 0
- Gaps: 0

## Facts

- If a receiver is connected with a dispatch_uid argument, it will not be added if another receiver was already connected with that dispatch_uid. [4010b8f8]
- If weak is True, then receiver must be weak referenceable. [00dfa43e]
- Receivers must be able to accept keyword arguments. [a2349180]
- @sync_to_async def sync_send(): responses = [] for receiver in sync_receivers: response = receiver(signal=self, sender=sender, **named) responses.append((receiver, response)) return responses [196c7a09]
- @sync_to_async def sync_send(): responses = [] for receiver in sync_receivers: try: response = receiver(signal=self, sender=sender, **named) except Exception as err: self._log_robust_failure(receiver, err) responses.append((receiver, err)) else: responses.append((receiver, response)) return responses [eb3bb3bd]
- async def asend(): async_responses = await _run_parallel( *( asend_and_wrap_exception(receiver) for receiver in async_receivers ) ) return zip(async_receivers, async_responses) [77a51040]
- async def asend(): async_responses = await _run_parallel( *( receiver(signal=self, sender=sender, **named) for receiver in async_receivers ) ) return zip(async_receivers, async_responses) [35447762]
- async def asend_and_wrap_exception(receiver): try: response = await receiver(signal=self, sender=sender, **named) except Exception as err: self._log_robust_failure(receiver, err) return err return response [0fd23e87c4d6b637]
- async def sync_send(): return [] [0378c06d4ac90666]
- dispatch_uid An identifier used to uniquely identify a particular instance of a receiver. This will usually be a string, though it may be anything hashable. """ from django.conf import settings [e388b69a]
- dispatch_uid the unique identifier of the receiver to disconnect """ if dispatch_uid: lookup_key = (dispatch_uid, _make_id(sender)) else: lookup_key = (_make_id(receiver), _make_id(sender)) [59cecb88]
- named Named arguments which will be passed to receivers. [c223d289ad75d32d]
- receiver A function or an instance method which is to receive signals. Receivers must be hashable objects. Receivers can be asynchronous. [15c27375]
- receiver The registered receiver to disconnect. May be none if dispatch_uid is specified. [abe2ecda]
- responses.extend(async_to_sync(asend)()) return responses [b0d0c7c3b3c727bf]
- sender The registered sender to disconnect [eec36258]
- sender The sender of the signal. Can be any Python object (normally one registered with a connect if you actually want something to occur). [dd77d9ed9e2b74af]
- sender The sender of the signal. Either a specific object or None. [a1ed2aba955c08cf]
- sender The sender to which the receiver should respond. Must either be a Python object, or None to receive events from any sender. [2b94fb88]
- weak Whether to use weak references to the receiver. By default, the module will attempt to use weak references to the receiver objects. If this parameter is false, then strong references will be used. [897e49ae]
- Arguments: [dea1c6b335d81087]

## Beyond the budget

62 more facts did not fit in the budget: [31bb8c5b] [08bc40b0] [136a3dc2] [43f36770] [9998d380] [788f3bca] [403fbad4] [dea1c6b335d81087-2] [dea1c6b335d81087-3] [dea1c6b335d81087-4] [dea1c6b335d81087-5] [dea1c6b335d81087-6] [b69010e8e8ab62dc] [201030d2] [511e3cf663f79182] [d9e16113] [c104428b3618211b] [1277d08d] [21f584563857cbd0] [f320ba54] [8e7c99f4] [aeab917c] [f4bab134] [6ad07797f4838346-11] [6ad07797f4838346-12] [590bf0cb] [d717f2315d74a46b] [d717f2315d74a46b-2] [59fece61] [a42c3fc0] [89ccf8fd] [71bfa99d] [006dbc8a] [066fc3b6] [86f1308a] [751668df] [15b2abb3] [82c89583] [56266c7e] [88a955c0] [ced694c8] [4759964d] [ffa60f16] [b1938fa6] [a3c6cd98] [76ab4434] [d21dda4e] [33014764] [3f12faf0] [5a6b3e7c887d3755] [c74a2ed0] [7ae30ad5] [eaa8fdd8] [299051d8] [64b6429f] [712ad1f5] [a45048b0] [ad3334a8] [cf6bbf2daef2deb8-3] [312e9dde] [f404ce4c] [126c4f64]
