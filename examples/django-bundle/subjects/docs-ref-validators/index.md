# docs/ref/validators

- Subject: docs/ref/validators (id `4b79556d-0142-4565-859a-408eb48c93b4`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 22 of 122
- Conflicts: 0
- Gaps: 0

## Facts

- Values starting with ``file:///`` will not pass validation even when the ``file`` scheme is provided. Valid values must contain a host. [b72e9be5]
- .. _valid URI schemes: https://www.iana.org/assignments/uri-schemes/uri-schemes.xhtml [c59fba79]
- .. warning:: [c54b54cb0805732a-88]
- Allowlist of email domains. By default, a regular expression (the ``domain_regex`` attribute) is used to validate whatever appears after the ``@`` sign. However, if that string appears in the ``allowlist``, this validation is bypassed. If not provided, the default ``allowlist`` is ``['localhost']``. Other domains that don't contain a dot won't pass validation, so you'd need to add them to the ``allowlist`` as necessary. [896c0fac]
- Determines whether to accept internationalized domain names, that is, domain names that contain non-ASCII characters. Defaults to ``True``. [46b05756]
- Don't rely on validation of the file extension to determine a file's type. Files can be renamed to have any extension no matter what data they contain. [84227312]
- The :ref:`regex flags <python:contents-of-module-re>` used when compiling the regular expression string :attr:`regex`. If :attr:`regex` is a pre-compiled regular expression, and :attr:`flags` is overridden, :exc:`TypeError` is raised. Defaults to ``0``. [e875cc24]
- The error code used by :exc:`~django.core.exceptions.ValidationError` if validation fails. Defaults to ``"invalid"``. [36a46f1d7b5b66fb]
- The error code used by :exc:`~django.core.exceptions.ValidationError` if validation fails. Defaults to ``"null_characters_not_allowed"``. [9fcc6bc6]
- The error message used by :exc:`~django.core.exceptions.ValidationError` if validation fails. Defaults to ``"Enter a valid email address"``. [4f03403a]
- The match mode for :attr:`regex`. Defaults to ``False``. [4aa171f1]
- The maximum length of values that could be considered valid. Defaults to 2048 characters. [045c126d]
- The regular expression pattern to search for within the provided ``value``, using :func:`re.search`. This may be a string or a pre-compiled regular expression created with :func:`re.compile`. Defaults to the empty string, which will be found in every possible ``value``. [d76c22cd]
- URL/URI scheme list to validate against. If not provided, the default list is ``['http', 'https', 'ftp', 'ftps']``. As a reference, the IANA website provides a full list of `valid URI schemes`_. [fa08574d]
- - ``'max_digits'`` if the number of digits is larger than ``max_digits``. - ``'max_decimal_places'`` if the number of decimals is larger than ``decimal_places``. - ``'max_whole_digits'`` if the number of whole digits is larger than the difference between ``max_digits`` and ``decimal_places``. [5a7d0f9e]
- .. attribute:: accept_idna [e7c30b53]
- .. attribute:: allowlist [4da2850d]
- .. attribute:: code [45a89107dd5a8d11]
- .. attribute:: code [45a89107dd5a8d11-2]
- .. attribute:: code [45a89107dd5a8d11-3]
- .. attribute:: flags [c13db343]
- .. warning:: [c54b54cb0805732a-89]

## Beyond the budget

92 more facts did not fit in the budget: [dca5ac95] [97f6c5ac0309812d-3] [a2ccad91f7facea1] [a2ccad91f7facea1-2] [a2ccad91f7facea1-3] [37a52266edd51262-2] [68f24f00] [9f1966ce] [591e0ac7] [a386c7db] [ebe86162] [08eafab8] [86cab147] [ce28ad23] [87de617d] [b232721a] [41408d37] [d148c1ab] [e0878073] [20e32da4] [e1e99b01] [5570b1fb] [e053ea63] [5b6e4a84] [a4284729] [19bfcfbb] [f9d658ba] [5058d80a] [b8c671ff] [b2ed702c] [c9abab84] [c498259c] [3c9ff8c3] [9ee3a9405e27875c-10] [92d2d276] [4af926756c29efa6-38] [b6ed703b] [89f96840] [4181df80] [271fcc05] [bd7a2a99] [fe67f6c9] [25d9ccd1] [6abab4af] [75b5b9d4] [2b34a5c7] [851f9666] [1069b32e] [de6fd191] [26b67ab3] [005ba330] [ce6a3346] [2459f293] [ad01567c] [31966975] [6f72dcac] [8d62d027] [4b5ed9d0] [cbdc64b2] [fa3715790913edf5-2] [3158bd1b] [4b2a1f02] [39ad0ba6] [ccae5b26] [c05f9046] [c66478a0] [6b3316de] [c73f986b] [4281788e] [c1fc4cf4] [49603ee8] [0d102573] [d8d2c3ff] [3ce1f78b] [03cf1e37] [448f93ad] [e0e3f941] [c1ea9a65] [86c2859f] [7bdcae33] [ea41647b] [875aea33] [81545b71] [54c78848] [8d46fbd5] [de8c4d83] [0aacf31a] [9c06eaa6] [459d5b4a] [78aa0e5c] [69505c6c] [54298227]
