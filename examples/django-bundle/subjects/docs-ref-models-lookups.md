# docs/ref/models/lookups

- Subject: docs/ref/models/lookups (id `c64595d3-0866-4021-b2b9-590cfd4116a3`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 20 of 73
- Conflicts: 0
- Gaps: 0

## Facts

- DateField.register_lookup(YearExact) User._meta.get_field("date_joined").register_lookup(MonthExact) [ec0eac15]
- Book.objects.annotate(is_short_story=LessThan(F("word_count"), 7500)) [fb599212]
- Book.objects.filter(LessThan(F("word_count"), 7500)) [c9f45b68]
- A boolean indicating whether this transformation should apply to both ``lhs`` and ``rhs``. Bilateral transformations will be applied to ``rhs`` in the same order as they appear in the lookup expression. By default it is set to ``False``. For example usage, see :doc:`/howto/custom-lookups`. [34d7fe13]
- Behaves the same way as :meth:`process_lhs`, for the right-hand side. [c3c56540]
- Defaults to ``True``. When :attr:`rhs` is a plain value, :attr:`prepare_rhs` determines whether it should be prepared for use as a parameter in a query. In order to do so, ``lhs.output_field.get_prep_value()`` is called if defined, or ``rhs`` is wrapped in :class:`Value() <django.db.models.Value>` otherwise. [13cf8002]
- Defines the class this transformation outputs. It must be a :class:`~django.db.models.Field` instance. By default is the same as its ``lhs.output_field``. [6c6af9b3]
- Registers a new lookup in the class or class instance. For example:: [7641db95]
- Returns a :class:`Transform` named ``transform_name`` registered in the class or class instance. The default implementation looks recursively on all parent classes to check if any has the registered transform named ``transform_name``, returning the first match. [5f3ec011]
- Returns a dictionary of each lookup name registered in the class or class instance mapped to the :class:`Lookup` class. [b463fc93]
- Returns a tuple ``(lhs_string, lhs_params)``, as returned by ``compiler.compile(lhs)``. This method can be overridden to tune how the ``lhs`` is processed. [00427525]
- Returns the :class:`Lookup` named ``lookup_name`` registered in the class or class instance depending on what calls it. The default implementation looks recursively on all parent classes and checks if any has a registered lookup named ``lookup_name``, returning the first match. Instance lookups would override any class lookups with the same ``lookup_name``. [3cd960ac]
- The left-hand side - what is being looked up. The object typically follows the :ref:`Query Expression API <query-expression>`. It may also be a plain value. [ce444f1c]
- The left-hand side - what is being transformed. It must follow the :ref:`Query Expression API <query-expression>`. [3ce16a64]
- The name of the lookup, used for identifying it on parsing query expressions. It cannot contain the string ``"__"``. [cf7235cd]
- The name of this lookup, used to identify it on parsing query expressions. It cannot contain the string ``"__"``. [7a865da3]
- The right-hand side - what ``lhs`` is being compared against. It can be a plain value, or something that compiles into SQL, typically an ``F()`` object or a ``QuerySet``. [a3432931]
- .. attribute:: bilateral [472e1826]
- .. attribute:: lhs [b0dbed4dff4b1a81]
- .. attribute:: lhs [b0dbed4dff4b1a81-2]

## Beyond the budget

50 more facts did not fit in the budget: [4d249a15] [3c0bd6df] [b6b4932b390b03d7] [b6b4932b390b03d7-2] [170db39ad8c0049c] [45aed56b] [376be338] [50583464] [f72035e4291ffb79] [1662497f] [82933397ffb0dabb] [3815ced2] [e4bd0c88] [36123c10] [a5c37dcb] [2c9d7f65] [efa06f92] [70d4ef35] [f57e1331] [0ebd1f9d] [c37dbc3c] [7c104639] [5298b900] [68a70f84] [7471d23a] [657d6366] [8a05e3c1] [519f3dcf] [6adb5443] [f3aad5f7] [170db39ad8c0049c-2] [26bff5b7] [ccb6bd44] [2e16d855] [3a368b18514a814b-13] [9f5adfe6] [2b68146c] [a7f0b73e] [89c74e3e] [a844ce35] [43cd2805] [8f88eca5] [94cca115] [f43e6b6d] [a253579e] [79b24ae5] [3f574045] [17a30752] [33a5cf70] [b1a68e86]
