# docs/howto/custom-model-fields

- Subject: docs/howto/custom-model-fields (id `01014ec8-b31e-4358-907e-42150a15c29a`)
- Kind: subject
- Budget: 1200 tokens
- Used: 893 tokens
- Facts shown: 24 of 182
- Conflicts: 0
- Gaps: 0

## Facts

- # Set up some defaults while letting the caller override them. defaults = {"form_class": MyFormField} defaults.update(kwargs) return super().formfield(**defaults) [872eac83]
- if value is None: return value [cc5d6e5b]
- return parse_hand(value) [78ddb51f]
- # ... (other possibly useful methods omitted) ... [3638afd1]
- def __init__(self, *args, **kwargs): kwargs["max_length"] = 104 super().__init__(*args, **kwargs) [b15bf5f6]
- def __init__(self, north, east, south, west): # Input parameters are lists of cards ('Ah', '9s', etc.) self.north = north self.east = east self.south = south self.west = west [c43de498]
- def __init__(self, separator=",", *args, **kwargs): self.separator = separator super().__init__(*args, **kwargs) [45eb9b4e]
- def db_type(self, connection): return "char(%s)" % self.max_length [7c5d5a3b]
- def deconstruct(self): name, path, args, kwargs = super().deconstruct() # Only include kwarg if it's not the default if self.separator != ",": kwargs["separator"] = self.separator return name, path, args, kwargs [a65b1a22]
- def deconstruct(self): name, path, args, kwargs = super().deconstruct() del kwargs["max_length"] return name, path, args, kwargs [d7eadd24]
- def formfield(self, **kwargs): # Exclude the field from the ModelForm when some condition is met. some_condition = kwargs.get("some_condition", False) if some_condition: return None [e355ff8c]
- def from_db_value(self, value, expression, connection): if value is None: return value return parse_hand(value) [b8235b29]
- def get_internal_type(self): return "CharField" [c50671a8]
- def get_prep_value(self, value): return "".join( ["".join(l) for l in (value.north, value.east, value.south, value.west)] ) [2146fbcd]
- def rel_db_type(self, connection): return "integer UNSIGNED" [54df41af]
- def to_python(self, value): if isinstance(value, Hand): return value [b7a7db75]
- def value_to_string(self, obj): value = self.value_from_object(obj) return self.get_prep_value(value) [d28386d7]
- # In the model: class MyModel(models.Model): # ... my_field = BetterCharField(25) [d11b39f1]
- # In the model: class MyModel(models.Model): # ... my_field = CharMaxlength25Field() [07632537]
- # MySQL unsigned integer (range 0 to 4294967295). class UnsignedAutoField(models.AutoField): def db_type(self, connection): return "integer UNSIGNED AUTO_INCREMENT" [5712d131]
- # This is a much more flexible example. class BetterCharField(models.Field): def __init__(self, max_length, *args, **kwargs): self.max_length = max_length super().__init__(*args, **kwargs) [cbb0d5ea]
- # This is a silly example of hardcoded parameters. class CharMaxlength25Field(models.Field): def db_type(self, connection): return "char(25)" [4b88ddd8]
- class CommaSepField(models.Field): "Implements comma-separated storage of lists" [73ef369e]
- class CustomCharField(models.CharField): ... [db002ca80c243089]

## Beyond the budget

145 more facts did not fit in the budget: [96b29ac5] [afa90066] [7fee143a] [3b1d293b] [66d005c0] [8e8a28a1] [85485b6c] [11fef55405ab69e8] [1d0de7d4] [7bf9b803] [c995f037] [e71505fa] [a517560c] [4868b1b4] [21859e01] [9a1ff3a2427febce] [39abfa72] [43eff7d9] [4af926756c29efa6] [90f4387cea1dbdff] [a6ff8aad] [b748c67d] [a1ba5ed5] [8cb6b87c] [b4d85913] [4335727c] [74a6a9e7] [74254151] [8b602194] [3daafb25] [aa4561b1] [d9b33531] [dff9b58d] [44fc715f] [2b3b26b0] [0c4d2d7e] [cdaaf566] [c47e020e] [0877a611] [c090e185] [f2a87e16] [8fec0b4f] [e254bc5e] [8f97ddab] [dc8dde84] [3a368b18514a814b-2] [942ae6c11625c81c-3] [562e3053] [c54b54cb0805732a-3] [f017b1b4] [24727be6] [86b45bd8] [92e5a466] [b488c214] [8ab4c48a] [cdf16ca6] [48cb90da] [74350d5c] [1149b744] [e8691e56] [aa607cd1] [dbb5910c] [46ec62d8] [7c1b4245] [a90c6376] [ec1cb3b6] [26b47113] [8d016f71] [4babe141] [248a5d87] [45fc150e] [4e3a4ff6] [8c6484d4] [c2aace6f] [b75ad3e7] [d34bb442] [28edef836ab93f57] [28edef836ab93f57-2] [28edef836ab93f57-3] [28edef836ab93f57-4] [b20f5626] [eaf85645] [274d87fc] [962b32df] [c271e421] [6b4596b8] [d7523d6f] [87813cca] [c644bb6c] [be139099] [6571bbbf] [ee904286] [8eaff23f] [ec66fde0] [79116464] [efb5f45a] [c9bfe5a5] [f7f68b46] [8e52e125] [d2b2868f] [8c516b4c] [2edcdce89eec848d] [0dcf287d] [2538c1d5] [fcacb7d2] [0177f910] [6b046064] [f87a1038] [6e2b9ce8] [889884bd] [72d6f012] [c1a3218c] [b6c744f6] [7c8e32bc] [caa746d2] [ffb83964] [654f56d6] [fe8ebe62] [56bb5dd1] [163c0c9d] [b1eb03c9] [ba6027fd] [5e280a0a] [bd97b5c3] [66a2ef25] [04c5fde5] [f0e6a927] [d0fc7fa3] [344351f8] [eec23d09] [d929b180] [6c368fd0] [b6064d57] [a8511ae8] [3069ef62] [dc9c2919] [d5d78ce3] [d5c463c2] [6a59acb9] [bdcd34cc] [15f9040b] [1176438b] [c575e753] [2472471e] [73a18341]
