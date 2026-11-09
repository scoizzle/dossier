# docs/ref/forms/models

- Subject: docs/ref/forms/models (id `5afca492-d3ae-49e2-b86a-fc02a13256f9`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 18 of 83
- Conflicts: 0
- Gaps: 0

## Facts

- A dictionary that maps a model field name to a :class:`django.forms.Widget`. [75ddb897]
- A dictionary that maps a model field name to a :class:`~django.forms.Field` class, which overrides the ``form_class`` used in the model field's :meth:`.Field.formfield` method. [32bb7359]
- A dictionary that maps a model field name to a dictionary of error message keys (``null``, ``blank``, ``invalid``, ``unique``, etc.) mapped to custom error messages. [cd36f763]
- A dictionary that maps a model field name to a help text string. [529e5b79]
- A dictionary that maps a model field names to a label string. [d91c7ef7]
- A function or callable that takes a model field and returns a :class:`django.forms.Field` object. [e3c8298f]
- A tuple or list of :attr:`~ModelFormOptions.model` field names to be excluded from the form. [9402f2ab]
- A tuple or list of :attr:`~ModelFormOptions.model` field names to be included in the form. The value ``'__all__'`` can be used to specify that all fields should be included. [e94b2417]
- A tuple or list of :attr:`~ModelFormOptions.model` field names to be localized. The value ``'__all__'`` can be used to specify that all fields should be localized. [47beffc6]
- Arguments ``formset``, ``extra``, ``can_delete``, ``can_order``, ``max_num``, ``validate_max``, ``min_num``, ``validate_min``, ``absolute_max``, ``can_delete_extra``, and ``renderer`` are passed through to :func:`~django.forms.formsets.formset_factory`. See :doc:`formsets </topics/forms/formsets>` for details. [ac143f17]
- Arguments ``model``, ``form``, ``fields``, ``exclude``, ``formfield_callback``, ``widgets``, ``localized_fields``, ``labels``, ``help_texts``, ``error_messages``, and ``field_classes`` are all passed through to :func:`~django.forms.models.modelform_factory`. [ea4c0498]
- By default, form fields are not localized, see :ref:`enabling localization of fields <modelforms-enabling-localization-of-fields>` for more details. [818da243]
- Either :attr:`~ModelFormOptions.fields` or :attr:`~ModelFormOptions.exclude` must be set. If neither are set, an :class:`~django.core.exceptions.ImproperlyConfigured` exception will be raised. [8fcdc72a]
- Either :attr:`~ModelFormOptions.fields` or :attr:`~ModelFormOptions.exclude` must be set. If neither are set, an :class:`~django.core.exceptions.ImproperlyConfigured` exception will be raised. If :attr:`~ModelFormOptions.exclude` is set and :attr:`~ModelFormOptions.fields` is unset, all model fields, except for those specified in :attr:`~ModelFormOptions.exclude`, are included in the form. [111e92e2]
- If any field is specified in :attr:`~ModelFormOptions.exclude`, this will not be included in the form despite being specified in :attr:`~ModelFormOptions.fields`. [8872f7cd]
- If your model has more than one :class:`~django.db.models.ForeignKey` to the ``parent_model``, you must specify a ``fk_name``. [6d3f2751]
- Invalid or excluded field names in an optional dictionary attribute have no effect, since fields that are not included are not accessed. [18f0fd3f]
- ``exclude`` ----------- [54aaa88b]

## Beyond the budget

65 more facts did not fit in the budget: [c44fded5] [e0b93c4d] [9ea7a5e8] [9eced123] [058fed15] [2b23aeab] [e2fa752c] [93a375a9] [8d029e7a] [4c2defad] [be10a9a3] [ea0a70c6] [7aec7606] [0893828b] [42077f99] [961dc894] [0cfe62c1] [a90a4e44] [a2f7ef58] [3c2b9180] [2f8a62da] [947efab8] [6fd74b90] [e488385a] [16dcf93d] [f41c126c] [620ab3e9] [b014ca44] [b32a416a] [e452d22f] [e8bb4756] [d4cbed64] [de20252c] [69482211] [5e1ed4b9] [380e80a4] [9bfcda43] [f20608a1] [0a79d47e] [23954fefb31ab08f-2] [8fdcae86] [2de434fb] [647e250b] [be633c3a] [013f9cf1] [213243f9] [803a79ca] [c0de3c8a] [76abfead] [7e7d5190] [eade2efe] [431054d3] [271731d9] [c0dce41f4f2e4c59-2] [bd06f4da] [87254620a027401c] [d7cc13a1] [cfb1cae8] [cf120e61] [b36e25c8] [328eb32a] [c26554f6] [49f79d1b] [3b8c6ed3] [93d8e8ea]
