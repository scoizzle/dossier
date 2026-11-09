# docs/ref/contrib/postgres/fields

- Subject: docs/ref/contrib/postgres/fields (id `fd6a0362-494c-425d-838f-88d83492cded`)
- Kind: subject
- Budget: 1200 tokens
- Used: 893 tokens
- Facts shown: 25 of 289
- Conflicts: 0
- Gaps: 0

## Facts

- class ChessBoard(models.Model): board = ArrayField( ArrayField( models.CharField(max_length=10, blank=True), size=8, ), size=8, ) [4bfc7888]
- from django.contrib.postgres.fields import ArrayField from django.db import models [aa2427af22ca3464]
- # Not valid Board( pieces=[ [2, 3], [2], ] ) [675e6b85]
- # Valid Board( pieces=[ [2, 3], [2, 1], ] ) [8cc263c9]
- If ``False`` (default), the upper bound is exclusive ``')'``, otherwise it's inclusive ``']'``. [f5f8736f]
- If ``True`` (default), the lower bound is inclusive ``'['``, otherwise it's exclusive ``'('``. [60b8b90f]
- If passed, the array will have a maximum size as specified. This will be passed to the database, although PostgreSQL at present does not enforce the restriction. [67928282]
- It is possible to nest array fields - you can specify an instance of ``ArrayField`` as the ``base_field``. For example:: [ec07eb6d]
- Optional. The value of ``bounds`` for list and tuple inputs. The default is lower bound included, upper bound excluded, that is ``[)`` (see the PostgreSQL documentation for details about `different bounds`_). ``default_bounds`` is not used for ``django.db.backends.postgresql.psycopg_any.DateTimeTZRange`` inputs. [ee24b284]
- Specifies the underlying data type and behavior for the array. It should be an instance of a subclass of :class:`~django.db.models.Field`. For example, it could be an :class:`~django.db.models.IntegerField` or a :class:`~django.db.models.CharField`. Most field types are permitted, with the exception of those handling relational data (:class:`~django.db.models.ForeignKey`, :class:`~django.db.models.OneToOneField` and :class:`~django.db.models.ManyToManyField`) and file fields (:class:`~django.db.models.FileField` and :class:`~django.db.models.ImageField`). [b222edc9]
- The form field class to use. Should be a subclass of :class:`django.contrib.postgres.forms.BaseRangeField`. [b5b78621]
- The form field to use. [1e991c75]
- The model field class to use. [229e6dea]
- The range type to use. [26696acf55f6c9ac]
- This is a required argument. [53b65ff014e563d9]
- This is an optional argument. [0182a528]
- Transformation of values between the database and the model, validation of data and configuration, and serialization are all delegated to the underlying base field. [e004dba3]
- class Board(models.Model): pieces = ArrayField(ArrayField(models.IntegerField())) [47cd175e]
- def __str__(self): return self.name [560696855ea91c7e]
- #. Add ``'django.contrib.postgres'`` in your :setting:`INSTALLED_APPS`. #. :ref:`Set up the hstore extension <create-postgresql-extensions>` in PostgreSQL. [b84c5b10]
- .. attribute:: DateTimeRangeField.default_bounds [ef77a41b]
- .. attribute:: DecimalRangeField.default_bounds [142eacca]
- .. attribute:: base_field [a239bb8c6d3d6d84]
- .. attribute:: base_field [a239bb8c6d3d6d84-2]
- .. attribute:: base_field [a239bb8c6d3d6d84-3]

## Beyond the budget

240 more facts did not fit in the budget: [d97b9698] [2680a4bb] [7f8962a2] [168ad531c394c044] [168ad531c394c044-2] [77c39c8db15001c7] [54b136225a0cc227] [387074b4] [21733f84] [69960832] [c23aafc2] [01e4d71b] [f6997cdd] [5b1d9b0b] [326bddfa] [9e4c93ae] [af36658a] [5a74e263] [1d4ad6a1] [66bcbf94] [73da3225] [0a9fdc57] [2a8ced2d] [bfb95129] [761deac1] [81c66d89] [2a96639b] [c1129024] [175b3749] [885dfb83] [757b90d7] [3fb4cb89] [943226d3] [0fdc7d8b] [2b6f35e8] [e8ef9db9] [4009edee7723c770] [b82e75e6] [d805b15c] [e8d18c7d] [7ac9a736] [e7c86cb6] [d99ab854] [006eb5a2] [b49e7a23] [307a0e51] [5bdf8c32] [99c61115] [3a30269c] [a7bf2f5c] [04a10273] [cc8862b9] [e436c204] [51f454aa] [0c6eaeb8] [51e42033] [a3126dad] [138e6b16] [f861511d] [0458be85] [2d1b3c4e] [955a115b] [02b0d5c0] [638388476e77cbba] [f3db7b33] [ea69175c] [20f599f523dd1db1] [a33b900e] [34a2487a] [1d0e7eb6] [d57af247] [52ec10ff] [853568a9] [511117e0] [3ad88b03] [23154609] [5a650b83] [cdc9c667] [fe5ef936] [a3f24dab] [aa05b6d4] [b150ca3e] [bf4ccdd9] [3692a123] [898ac466] [21a04d38] [a24feea4] [63f2a7f0] [2df037d9] [adace94e] [beb3e40e] [b394a22e] [be23f508] [7078766b] [e1a4daed] [3064f010] [8098dc8e] [eaf050be34acb41d-220] [eaf050be34acb41d-221] [eaf050be34acb41d-222] [eaf050be34acb41d-223] [eaf050be34acb41d-224] [eaf050be34acb41d-225] [eaf050be34acb41d-226] [eaf050be34acb41d-227] [eaf050be34acb41d-228] [eaf050be34acb41d-229] [eaf050be34acb41d-230] [eaf050be34acb41d-231] [eaf050be34acb41d-232] [eaf050be34acb41d-233] [eaf050be34acb41d-234] [eaf050be34acb41d-235] [eaf050be34acb41d-236] [eaf050be34acb41d-237] [dfa717732ab88b73-2] [ab649f1e] [2adac9d5] [097322d1] [3cf808a1] [4fc8001d] [e6593296] [059f820d] [3f287691] [f22bcca8] [992d3e8d] [51798ea1] [754fd737] [2569cd81] [36c3bd3f] [dffb9aef] [83fc0f0f] [da5c9b35] [4b3e59b2] [f19b48b4] [d086a1e4] [af1c91bc] [e1955000] [e31013c1] [8e0ccbc4] [2b5ddc13] [9737250f] [ac2ce374] [a9e0c0ae] [f9ac7737] [2a9ba4aa] [942ae6c11625c81c-78] [942ae6c11625c81c-79] [942ae6c11625c81c-80] [942ae6c11625c81c-81] [942ae6c11625c81c-82] [c54b54cb0805732a-27] [23797ce3] [e54ccbba] [15d98dc7] [19e6b5ed] [ae19574d] [aa1534da] [2768c0d4] [771fbc0d] [03794d03] [31359eb9] [2b50c518] [3e87fc7f] [5737b2b0] [046b79b2] [0bf029ce] [9ed39bd7] [9ef3b584] [d1e11f42] [1751549e] [af1ee869] [76cbf4d4] [cd562a1a] [862d6b6f] [3da80b56] [efa27019] [fef2bf87] [410ac49c] [1a535ea2] [251bbf93] [071531ad] [8ce2629c] [52cfb4a3] [7c35847c] [851b78a3] [06eedecc] [5fffa67b] [810f1821] [4ea67478] [2c096a50] [5fa63762] [12bf889d] [2f0f3ffa] [b1442052] [57a3e9ad] [07107d94] [d64fc4c8] [57a94b9e] [9b432872] [8e4e16bb] [c742adbe] [f19869ce] [fd0c2ca8] [5d5fbb11] [23e1d434] [e756b280] [5db869b8] [d43c8631] [f96a466d] [93ad32c9] [dc310916] [b11dde26] [5537517d] [1699445e1da0f8e9] [1699445e1da0f8e9-2] [31c08c8d] [d0669849449bacb3] [d0669849449bacb3-2] [d923c04f] [27d0d74c] [1a807b61] [fce87af0] [ab7bde48] [c049598b] [b2e9baa2] [23a0ecfd] [fff56ad5] [2fe0c7b4] [864285b4] [bf0f2095] [ef23b74d] [7cb151dd] [a718102b] [0d00479e] [b4e94de5] [f509563c] [25125034] [ac086bf6] [8a8f10f0]
