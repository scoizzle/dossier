# docs/ref/migration-operations

- Subject: docs/ref/migration-operations (id `008c2ed9-b111-46c6-9407-ae161ba33d44`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 28 of 183
- Conflicts: 0
- Gaps: 0

## Facts

- # If this is False, Django will refuse to reverse past this operation. reversible = False [8a55c079]
- # This categorizes the operation. The corresponding symbol will be # displayed by the makemigrations command. category = OperationCategory.ADDITION [e5294d39]
- *Symbol*: ``+`` [12ceeaa8]
- *Symbol*: ``-`` [befbe39a]
- *Symbol*: ``?`` [6a975dd5]
- *Symbol*: ``p`` [faf56479]
- *Symbol*: ``s`` [da9b7a07]
- *Symbol*: ``~`` [5bb76992]
- @property def migration_name_fragment(self): # Optional. A filename part suitable for automatically naming a # migration containing this operation, or None if not applicable. return "custom_operation_%s_%s" % (self.arg1, self.arg2) [fb3bc9ed]
- @property def migration_name_fragment(self): return "create_extension_%s" % self.name [bfc4cf8f]
- def __init__(self, arg1, arg2): # Operations are usually instantiated with arguments in migration # files. Store the values of them on self for later use. pass [c5832246]
- def __init__(self, name): self.name = name [320828c8]
- def database_backwards(self, app_label, schema_editor, from_state, to_state): # If reversible is True, this is called when the operation is reversed. pass [46416b01]
- def database_backwards(self, app_label, schema_editor, from_state, to_state): schema_editor.execute("DROP EXTENSION %s" % self.name) [08f0ccfe]
- def database_forwards(self, app_label, schema_editor, from_state, to_state): # The Operation should use schema_editor to apply any changes it # wants to make to the database. pass [75497e50]
- def database_forwards(self, app_label, schema_editor, from_state, to_state): schema_editor.execute("CREATE EXTENSION IF NOT EXISTS %s" % self.name) [e7aafb80]
- def describe(self): # This is used to describe what the operation does. return "Custom Operation" [2a50f8c6]
- def describe(self): return "Creates extension %s" % self.name [eaf7175c]
- def state_forwards(self, app_label, state): # The Operation should take the 'state' parameter (an instance of # django.db.migrations.state.ProjectState) and mutate it to match # any schema changes that have occurred. pass [b4951481]
- def state_forwards(self, app_label, state): pass [6a323705]
- operations = [ migrations.RunPython(forwards_func, reverse_func), ] [d96ed2fe]
- * Add the default value to your field and run the :djadmin:`makemigrations` command. This should generate a migration with an ``AlterField`` operation. [663c06a8]
- * Add the nullable field without the default value and run the :djadmin:`makemigrations` command. This should generate a migration with an ``AddField`` operation. [3157e7e0]
- .. attribute:: ADDITION [a600ee94]
- .. attribute:: ALTERATION [522e8d88]
- .. attribute:: MIXED [e43372e8]
- .. attribute:: PYTHON [2b8197f2]
- .. attribute:: SQL [87b91edb]

## Beyond the budget

150 more facts did not fit in the budget: [a31c832e] [591c8071] [03948fb8] [16bd5471] [901ee284] [d109c6bd] [0e30012a] [ae3db184] [275d1e40] [f3dd7c9d] [198441fb] [b524db95] [5dbd7696] [5041c755] [5dc39efb] [7d76bf5d] [5602f214839c9ad3-5] [d9b321265979488b] [54f1856d] [8007df53] [a4619044] [7da1779d] [77106d55] [cf223e94] [9cf72cb9] [8097a12b] [7d125b40] [ab1a09b2] [f92db2d8] [cce1b024] [4cca827b] [f92cb25e] [80e557c1] [80183f76] [17a75f64] [7a20a3ce] [9a67df01] [88eea868] [b9179947] [fc475a5e] [086aaa78] [28e00cad] [1fec632c] [2d1f18c6] [4a94bd67] [428df1c8] [05c7d9e4] [31821a78] [5852cdae] [fe19c691] [d8a7d0ab] [b6626724] [5f4004d7] [752460c2] [a34aba5b] [57739e32d87f6c76-12] [c54b54cb0805732a-41] [c54b54cb0805732a-42] [c54b54cb0805732a-43] [c54b54cb0805732a-44] [c54b54cb0805732a-45] [9de543ee] [0f2a5684] [6c0e57d0] [56c44f98] [37b1932e] [2a1918e7] [c9d6b38b] [11c03e06] [a8062f75] [a2304d91] [0f649a65] [1fa066f8] [2c8150c4] [1f16bede] [3900977b] [baed0e1b] [829646fe] [a8051a8f] [097fd7cc] [89570f94] [a6714199] [e8f0edbe] [9a273b9b] [ca1ffcad] [421d3154] [f0cfc602] [1ea4078d] [06529131] [43515141] [b74aa8cd] [4c1591d3] [7cc6c5f2] [8f0683f1] [744995eb] [8870af81] [edb71060] [a7354037] [456ff8a0] [0fac9447] [bb444d75] [129dce80] [1dc894b5] [7df4ba46] [0e566b36] [76d79dac] [536edc51] [ee3cdad2] [e94cb19e] [47487c20] [8436c64d] [0551d71b] [684cdffae40374da] [b49285e2] [9fa86356] [110ac9f9] [0272992c] [c144ef19] [fd4b9ccf] [f6c77428] [d6e3c396] [2df2bef6] [962c51df] [48fdd699] [ea351cd4] [9523e1ca] [bcb78b66] [5346ad6d] [b65adf0c] [899cba88] [614321da] [84aef530] [e7422bb0] [fd2a427a] [c6bbe029] [8655636b] [868c9e26] [6cc83a1c] [8be62668] [2724e27b] [6e6f9f85] [5a2f994f] [2ead21f0] [6501f50f] [38499ecb] [bb18bd0d] [46e12eb3] [18a71610] [1f66dd8a] [c0885fca]
