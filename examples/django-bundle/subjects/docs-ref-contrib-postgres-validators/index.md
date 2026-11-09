# docs/ref/contrib/postgres/validators

- Subject: docs/ref/contrib/postgres/validators (id `865c1b74-e655-4190-ba3e-be00807eb7ae`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 421 tokens
- Facts shown: 15 of 15
- Conflicts: 0
- Gaps: 0

## Facts

- .. note:: Note that this checks only for the existence of a given key, not that the value of a key is non-empty. [fc56deed]
- The ``messages`` passed should be a dict containing the keys ``missing_keys`` and/or ``extra_keys``. [d0a45765]
- Validates that the given keys are contained in the value. If ``strict`` is ``True``, then it also checks that there are no other keys present. [d64342cd]
- Validates that the lower bound of the range is not less than the ``limit_value``. [115c765d]
- Validates that the upper bound of the range is not greater than ``limit_value``. [fe574233]
- .. class:: KeysValidator(keys, strict=False, messages=None) [63c27df9]
- .. class:: RangeMaxValueValidator(limit_value, message=None) [ee52a897]
- .. class:: RangeMinValueValidator(limit_value, message=None) [6b907826]
- .. module:: django.contrib.postgres.validators [80c4ea98]
- ========== Validators ========== [fa3715790913edf5]
- Range validators ================ [726b4cda]
- These validators are available from the ``django.contrib.postgres.validators`` module. [81742f74]
- ``KeysValidator`` ================= [6ab36be1]
- ``RangeMaxValueValidator`` -------------------------- [c343dd67]
- ``RangeMinValueValidator`` -------------------------- [3690b185]
