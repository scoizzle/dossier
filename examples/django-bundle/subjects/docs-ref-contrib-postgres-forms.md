# docs/ref/contrib/postgres/forms

- Subject: docs/ref/contrib/postgres/forms (id `516725d4-a9a5-42a8-bd4c-2d73f6b45baa`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 23 of 77
- Conflicts: 0
- Gaps: 0

## Facts

- >>> class GridForm(forms.Form): ... places = SimpleArrayField(SimpleArrayField(IntegerField()), delimiter="|") ... [fd83cdbf]
- >>> class NumberListForm(forms.Form): ... numbers = SimpleArrayField(forms.IntegerField()) ... [ba1d668a]
- >>> form = GridForm({"places": "1,2|2,1|4,3"}) >>> form.is_valid() True >>> form.cleaned_data {'places': [[1, 2], [2, 1], [4, 3]]} [d197f426]
- >>> form = NumberListForm({"numbers": "1,2,3"}) >>> form.is_valid() True >>> form.cleaned_data {'numbers': [1, 2, 3]} [0bce2116]
- >>> form = NumberListForm({"numbers": "1,2,a"}) >>> form.is_valid() False [729f67dd]
- >>> from django import forms >>> from django.contrib.postgres.forms import SimpleArrayField [49db9a65b62c4b71]
- SplitArrayField(IntegerField(required=False), size=3, remove_trailing_nulls=False) [f5cf2e1e]
- SplitArrayField(IntegerField(required=True), size=3, remove_trailing_nulls=True) [22eb472c]
- The field does not support escaping of the delimiter, so be careful in cases where the delimiter is a valid character in the underlying field. The delimiter does not need to be only one character. [39ea75ea]
- ["1", "2", "3"] # -> [1, 2, 3] ["1", "2", ""] # -> ValidationError - third entry required. ["1", "", "3"] # -> ValidationError - second entry required. ["", "2", ""] # -> ValidationError - first and third entries required. [ef8a25ae]
- ["1", "2", "3"] # -> [1, 2, 3] ["1", "2", ""] # -> [1, 2, None] ["1", "", "3"] # -> [1, None, 3] ["", "2", ""] # -> [None, 2, None] [0d520df5]
- ["1", "2", "3"] # -> [1, 2, 3] ["1", "2", ""] # -> [1, 2] ["1", "", "3"] # -> ValidationError - second entry required. ["", "2", ""] # -> ValidationError - first entry required. [e598ed24]
- .. code-block:: pycon [eaf050be34acb41d-238]
- .. code-block:: pycon [eaf050be34acb41d-239]
- .. note:: [942ae6c11625c81c-83]
- A :class:`~RangeWidget` comprises a 2-tuple of ``base_widget``. [9b458b0e]
- By default, this is set to ``False``. When ``False``, each value from the repeated fields is stored. When set to ``True``, any trailing values which are blank will be stripped from the result. If the underlying field has ``required=True``, but ``remove_trailing_nulls`` is ``True``, then null values are only allowed at the end, and will be stripped. [f3347c92]
- It specifies the underlying form field for the array. This is not used to render any HTML, but it is used to process the submitted data and validate it. For example: [45613dae]
- On occasions it may be useful to require or restrict the keys which are valid for a given field. This can be done using the :class:`~django.contrib.postgres.validators.KeysValidator`. [638388476e77cbba-2]
- Some examples:: [f2aec5f5]
- Takes a single "compressed" value of a field, for example a :class:`~django.contrib.postgres.fields.DateRangeField`, and returns a tuple representing a lower and upper bound. [f9dca67e]
- This is a required argument. [53b65ff014e563d9-2]
- This is the fixed number of times the underlying field will be used. [497ed292]

## Beyond the budget

48 more facts did not fit in the budget: [23d76687] [27239e3c] [b38ce6bf] [79607f9b] [fc3123a6] [468dab28d53e1630] [a239bb8c6d3d6d84-4] [a239bb8c6d3d6d84-5] [c9108199] [540795b5b1824d0c-2] [97f6c5ac0309812d] [92b7388f] [ea2c11e5] [77c39c8db15001c7-2] [4e885956f001b283] [942ae6c11625c81c-84] [322e9667] [debd9f61] [0c15f05d] [a3ad4495] [922ccd56] [e966dcda] [8cf1dba5] [7f90829e] [57823667] [2d186d2e] [cd18cc82] [04e1cccd] [41617016] [9b3c8e0a] [18f85f31] [7f8415b7] [de407210] [d026f2a6] [3b1819fc] [83bc6e00] [3aa7b56d] [210a25ca] [af3b9b12] [93412fe3] [cf466576] [019efd96] [75847229] [0e2b396d] [a92d87dc] [2281c4a5] [a392e7fa] [49a90e73]
