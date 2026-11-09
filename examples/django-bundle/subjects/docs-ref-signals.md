# docs/ref/signals

- Subject: docs/ref/signals (id `cc59e319-8e47-43f1-a5fe-474e74d4b633`)
- Kind: subject
- Budget: 1200 tokens
- Used: 894 tokens
- Facts shown: 18 of 239
- Conflicts: 0
- Gaps: 0

## Facts

- :attr:`instance._state <django.db.models.Model._state>` isn't set before sending the ``post_init`` signal, so ``_state`` attributes always have their default values. For example, ``_state.db`` is ``None``. [a307eed3]
- def ready(self): post_migrate.connect(my_callback, sender=self) [651fe04c]
- .. note:: [942ae6c11625c81c-146]
- .. versionadded:: 6.1 [0cf180bcf4ecfab5-26]
- >>> p = Pizza.objects.create(...) >>> t = Topping.objects.create(...) >>> p.toppings.add(t) [2aa4fa8c]
- >>> t.pizza_set.remove(p) [0f85fa57]
- A boolean; ``True`` if the model is saved exactly as presented (i.e. when loading a :ref:`fixture <fixtures-explanation>`). One should not query/modify other records in the database as the database might not be in a consistent state yet. [e8fe3ae8]
- For example, the :mod:`django.contrib.auth` app only prompts to create a superuser when ``interactive`` is ``True``. [b25861e4c736794c]
- For performance reasons, you shouldn't perform queries in receivers of ``pre_init`` or ``post_init`` signals because they would be executed for each instance returned during queryset iteration. [10ddc7ea]
- For the ``pre_clear`` and ``post_clear`` actions, this is ``None``. [432dc810]
- For the ``pre_remove`` and ``post_remove`` actions, this is a set of primary key values that was submitted to be removed from the relation. This is not dependent on whether the values actually will be, or have been, removed. In particular, non-existent values may be submitted, and will appear in ``pk_set``, even though they have no effect on the database. [4618b5cd]
- Functions which listen for :data:`post_migrate` should adjust what they output to the screen based on the value of this argument. [09341330]
- If you override these methods on your model, you must call the parent class' methods for these signals to be sent. [630fb83e]
- If you provide an :class:`~django.apps.AppConfig` instance as the sender argument, please ensure that the signal is registered in :meth:`~django.apps.AppConfig.ready`. ``AppConfig``\s are recreated for tests that run with a modified set of :setting:`INSTALLED_APPS` (such as when settings are overridden) and such signals should be connected for each new ``AppConfig`` instance. [338ed99b]
- Many of these signals are sent by various model methods like ``__init__()`` or :meth:`~django.db.models.Model.save` that you can override in your own code. [68f5fa5a]
- Model signals ``sender`` model can be lazily referenced when connecting a receiver by specifying its full application label. For example, an ``Question`` model defined in the ``polls`` application could be referenced as ``'polls.Question'``. This sort of reference can be quite handy when dealing with circular import dependencies and swappable models. [12d97a85]
- Note also that Django stores signal handlers as weak references by default, so if your handler is a local function, it may be garbage collected. To prevent this, pass ``weak=False`` when you call the signal's :meth:`~django.dispatch.Signal.connect`. [aa5511c2]
- class MyAppConfig(AppConfig): ... [e3e1f276]

## Beyond the budget

178 more facts did not fit in the budget: [56e78c32] [f028967e] [a55fe753] [3b8b5bf9] [55ca1d10] [bec5ac8f] [b5fd9980] [e7700ff1e52b3085-2] [09f65761] [a1b66fc7] [b7745c55] [5ea19b95] [2f3a3773] [f86aae76] [6419d23d] [6fd30e9d] [eaf050be34acb41d-580] [eaf050be34acb41d-581] [f8eac47f] [c340e1d1] [714a097f] [88c2b899] [e6ac0052] [94a1930b] [0d033e2a] [4330d8d3] [cb1c3e75] [41339040] [e1c9158f] [8b2c8dfd] [9c371ed2] [af6da862] [61ebe83e] [14ee79f2] [ec28ffa9] [0ee990f4] [0dac46c6] [7393af6f] [dce664a5] [545c9e88] [942ae6c11625c81c-147] [942ae6c11625c81c-148] [6b4a5e54e001d097-25] [a1eb26d754a3d60c-33] [c54b54cb0805732a-78] [c54b54cb0805732a-79] [c54b54cb0805732a-80] [c54b54cb0805732a-81] [66d1a43d] [8f0b655f] [1219195139e22f0a] [7d443ec4] [804ad222] [f0f31d135f4abac9-2] [2a9c99cc] [50147c04] [91dde4ad] [8103bf8c] [a5c58035] [c78cd834] [f6e24bcd] [c0ed454a] [58036967] [311edd00] [ad0eedb4] [e38fffd7] [3951a64e] [fcb4bc60] [7571e1ae] [436ba902] [d66278bc] [6dc5e7db] [21e8f6b2] [016c9f3f] [a84adf97] [88a550dd] [59fbdc08] [e858a4dc] [a29687f1] [d81c4e4a] [40c0027c] [e1ffa1b0] [d320454b] [6aadb3ad] [43a8e7c1] [2bc44fff] [36f94008] [c83804a0] [7e41a1e3] [d65eed15] [c47c7643] [50fc036a] [71883a36] [2bb3e47e] [65136423] [fd9fd879] [deaa51c1] [a9ec025a] [933146e406f5a738] [39de69ec] [b6719aad] [ecdf6c13] [0bfcb592] [1d1a1854] [6f9ed3a2] [5c7a9d95] [8e9da803] [d44e9954] [5ebbf8ac] [efa5cf1407ef4292] [b6164f448ddacd90] [e41a26e8] [d9a321ec] [537ca0b8] [7e4d7501] [e1447255e2ddd0c7] [08b70f8e] [86a25d6d] [c8346950] [bce1a0ca] [a9845b58] [bed0d799] [1e8687e3b0189897] [5eda9137] [fc905735] [34419854] [1502ed1f] [d0f9f806] [e314851c] [d33782dc] [f546e300] [1709f657] [5f0d10c3] [49a678e1] [2fea6dad] [0517bc77] [e0b5e608b97ae7d8] [db924753] [c00ed516] [413957eb] [98b751e6] [ff22ffad] [7c333164] [94a2faf1] [97c7bfc4] [0bda8258] [39378e9c] [773ab5befddcbbbd] [b522dad9] [e8f03fad] [08faa68c] [19fb5faa] [07cccc5c] [821787af] [184508f11de6c3d2] [a9e801ff] [f88ed64d] [88a71e84] [02d35e59] [03a73d61deffeee0] [def78e5a] [5cae73b5] [732fe2fb] [1dfef9ba] [ce0850eb] [0b32b0b2] [0f0df9b9] [75c4d4dc] [b5cf9ae5dff65b84] [9f9172f2] [f6f8499fa102d0d5] [66ea7d19] [51252e300cc5c7d8] [c0ac09f1] [6d77b51bb5ce56c0] [002be2c5] [67fe6b3e] [c9c14253]
