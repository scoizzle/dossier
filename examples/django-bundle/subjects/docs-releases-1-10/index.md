# docs/releases/1.10

- Subject: docs/releases/1.10 (id `598c7333-1787-4493-a213-ef8235be9812`)
- Kind: subject
- Budget: 1200 tokens
- Used: 890 tokens
- Facts shown: 24 of 371
- Conflicts: 0
- Gaps: 0

## Facts

- >>> e.related_set.set([obj1, obj2, obj3]) [88f82b53]
- class Meta: default_related_name = "bars" [ca89ad8e]
- def as_mysql(self, compiler, connection): lhs, lhs_params = self.process_lhs(compiler, connection) rhs, rhs_params = self.process_rhs(compiler, connection) params = lhs_params + rhs_params return "MATCH (%s) AGAINST (%s IN BOOLEAN MODE)" % (lhs, rhs), params [b46db19d]
- # Unsalted MD5/SHA1: User.objects.filter(password__startswith="md5$$") User.objects.filter(password__startswith="sha1$$") # Salted MD5/SHA1: User.objects.filter(password__startswith="md5$").exclude(password__startswith="md5$$") User.objects.filter(password__startswith="sha1$").exclude(password__startswith="sha1$$") # Crypt hasher: User.objects.filter(password__startswith="crypt$$") [8308e452]
- >>> Book.objects.select_related("author__name") Traceback (most recent call last): ... FieldError: Non-relational field given in select_related: 'name' [207db6e9]
- >>> Book.objects.select_related("title") Traceback (most recent call last): ... FieldError: Non-relational field given in select_related: 'title' [6aafe15f]
- >>> Foo.objects.get(bars=bar) [212542f4]
- >>> bar = Bar.objects.get(pk=1) >>> Foo.objects.get(bar=bar) [f4192894]
- >>> new_list = [obj1, obj2, obj3] >>> e.related_set = new_list [4c851adf]
- CharField.register_lookup(Length) # Unsalted MD5 passwords might not have an 'md5$$' prefix: User.objects.filter(password__length=32) [24e3030e]
- In addition to the changes outlined in this section, be sure to review the :ref:`removed-features-1.10` for the features that have reached the end of their deprecation cycle and therefore been removed. If you haven't updated your code within the deprecation timeline for a given feature, its removal may appear as a backwards incompatible change. [2564c72b]
- MyField.register_lookup(MyFieldExact) [d5b2a87e]
- User = get_user_model() [1b00fce2]
- admin.site.unregister(User) admin.site.register(User, UserAdmin) [2236b4d4]
- class Bar(models.Model): foo = models.ForeignKey(Foo) [a035fb14]
- class Foo(models.Model): pass [c7396b3c]
- class MyField(Field): ... [04adb204]
- class MyFieldExact(Exact): def get_prep_lookup(self): # do_custom_stuff_for_myfield ... [63c48ff5]
- class MyModel(models.Model): numbers = models.CharField(..., validators=[validate_comma_separated_integer_list]) [4bd09129]
- class MyUserCreationForm(UserCreationForm): username = forms.CharField( max_length=30, help_text="Required. 30 characters or fewer. Letters, digits and @/./+/-/_ only.", ) [dbf95e96]
- class Search(models.Lookup): lookup_name = "search" [a0c0633c]
- class UserAdmin(BaseUserAdmin): add_form = MyUserCreationForm [c34afcd8]
- from django.contrib.auth import get_user_model [d7cd6e7b]
- from django.contrib.auth.admin import UserAdmin as BaseUserAdmin from django.contrib.auth.models import User [743ad40a]

## Beyond the budget

344 more facts did not fit in the budget: [debca5a7] [d7c117e5] [4af926756c29efa6-39] [ee1bc7ce] [7c49ba95] [7df81ca3] [4b79b6173f2ab5cf-2] [ca4d27e5] [aed4c088] [b2016dd76d16652a-2] [c5035934054b63e9-2] [b5518fa8266a666d-2] [8b9d03b6ddeb8c95-2] [b083168edd9bdd51-2] [54332501d2707298-2] [305e6540] [e863eb01] [df5ed215] [4618f139] [df06b632] [ee7da26d] [66f4c027] [a309e804] [2d3a182e] [9eb1d26b] [7e74d5c7] [4403af6d] [24812a7c] [ab66b67d] [4f01a75f] [d4072a14] [d8d4e90b] [64c84e25] [d0611b4f] [252da9b2] [abc705fe] [379be0ee] [ea6cebcd] [8a0c5b11] [6b1d6a5f] [683c7be9] [454501e9] [3c97a7cd] [53dcee66] [2c164eb1] [efd1e91c] [b659e60c] [1c71420a] [dd0fec92] [2e899122] [7ecb7b24] [bb40f3e5] [25403292] [ad3b83aa] [02ede617] [136a3969] [9fa5b6a9] [c997c59c] [9cecf374] [2a11926a] [c64dfe00] [9cd33a69] [d24f412f] [d9c09520] [151e0704] [0c0698c3] [0c8d1bb9] [ec253257] [341b739c] [383e422a] [42034346] [f4b8c908] [2ec78f53] [222c88e5] [a222348c] [b5eeaf64] [f9601055] [53a8ad1d] [f8cc6803] [0b2a5bd2] [01752b6c] [4fccdd79] [4b58efcb] [36492b58] [7facc766] [1bffdf38] [f44d89f9] [5fec7054] [5beaa39a] [e3bbc114] [afa17aa8] [e86b51a1] [79012170] [e6e2df1e] [fc73e43d] [5f511d93] [1040946a] [487cdf04] [bee31fdb] [b1512cfd] [db4009e2] [b7c14e7e] [026924f7] [ed80ebb0] [7212f6c4] [1ce650d6] [d7d51133] [73e42490] [c80c756f] [9a49f3c0] [32585fbd] [9c608bdf] [726d51e2] [49fc258a] [2ee22470] [572704af] [688e912d] [e4762e67] [dcbcfffd] [4cb0cb81] [2c0da412] [4881a3ac] [37f11755] [8f5c5da5] [502e216e] [c236c92e] [2ca171f6] [31fef45f] [805fe819] [ac238283] [3b138133] [207cf3e4] [382db17c] [b2ad7aad] [73839a33] [d383213e] [c172505a] [23a7eb38] [adfea0cf] [27fd70c5] [96a6824d] [9457b530] [064762d0] [c4111a87] [e30a62da] [ad5300d9] [69e7dc8f] [cabb65dc] [fe3eb7ee] [fe133ee3] [39262c76] [611979f0] [2fa85a9a] [334717e2] [f54ffccd] [fcaa7ff7] [7a648a75] [11ea632f] [8edff7ab] [2c4f5d37] [ec872b65] [700f5b8a] [ebf5880a] [2ed4b074] [d43b3690] [d1f9e4dd] [87cb02ef] [eaec37c1] [b8ff0ba8] [f98d364c] [453cf25e] [b658a66d] [ad35f60e] [6623dd80] [1333d250] [3bddbfba] [9f455d4f] [c4d82ad9] [1c123df3] [8662d7f4] [a8e41df4] [0581b583] [651ee37a] [6d49d5c0] [e260f289] [b55e2d7e] [4f77439e] [41e53d6e] [f2e81451] [185be927] [a2b867a1] [d70f71a8] [66d5654f] [de3b9479] [9d411392] [33e9baf9] [11cbcfdc] [dd25c307] [a87e277b] [45ec9d73] [a77475e3] [af34c298] [d37369dc] [b8a10fcf] [a38cce19] [68c7381e] [beebe53f] [3797cb2e] [aebe783f] [739c86bd] [6332c4a4] [48b19945] [5e9480e1] [1e54a998] [17e27b6e] [1e11ea3f] [be38a24a] [68f85f73] [ecba374e] [4b0c3c03d427622c-2] [4b8b8da5] [d5492beb] [fa90bf9c] [a1797ab6] [073c0f01] [3fdd31e3] [eaf050be34acb41d-605] [eaf050be34acb41d-606] [eaf050be34acb41d-607] [eaf050be34acb41d-608] [eaf050be34acb41d-609] [eaf050be34acb41d-610] [c54b54cb0805732a-91] [d479d386] [a9f4c876] [2bd5af6ca1e8da6e] [9208af79aedaac2a] [0d7f305806da573d] [796fd654b8a44e4f] [92df77a9] [d562ea7e] [097c2f5a] [b262ce27] [3e41ca3e] [1fcc1e48] [f7a772dc] [0eabaf8d] [6ca43053] [9e4d7502] [40907bc2] [7a6cb469] [4755786d40c065cc] [4027f94d73d6defd] [750d176f] [2dffac79] [031c6647] [80c94c9939092225] [81d18ad396e1bfe0] [34a01019] [02bcacd7] [50bbec75] [93b61a67] [215a338e] [513211ea] [f93c4be2] [146ddd77] [db0e4e6ac0dada48] [c7dcc4c5] [123098bdb4f38b7b] [c4dd37f6] [dfaeb06a] [f9c38ca2] [ce9019d9] [ea9319ca] [f3a70b44] [522c19ce] [665d83bc] [80b17716] [39fea0b8] [54b069d2] [34301cf1] [632d9888fdac6ff8] [97088df6] [a803fc84] [3e0f4a6cb3ed25ec] [ed7f4c43] [81a1cd28cbb21208] [32cecf2752c82bab] [7e0dde20fe81851d] [7e0dde20fe81851d-2] [8b84e8a4] [357763c49cce3029] [2859e996] [bb2d13f9] [c1a52e66] [ae34cf4ae6f76a23] [5346149d] [75de9609] [31c96b5b] [c1b0723dfb7860d4] [29b64ef38af97ab3] [0dd2c0a470c7b7f4] [d91f508a] [980094e5817f4bed] [5b32493384882077] [01cc28d6] [87126a2d] [baad014b] [c92e1657] [9206ee6c] [2ee8bc49] [4f060c80] [1e3437da] [5ed44953] [b116053f] [7b2bfb76] [c19c4113] [acee33bb] [87ddf82f] [df7e22ad] [ad2a4f69] [e3bf17ab] [aff5ee5f] [9938b590] [b126d0c4] [08dca043] [d27a2f4cf2a5e2ef] [e2cd39f3] [78bebdb2] [e74f1d40] [e65c097c] [107e9312] [6794c359] [49aa3e42] [060e9b02] [4ae73b18] [6ee9708e] [742d08b4] [8363e64a] [78b3245d] [318aa83a] [90e6891d] [c8177948] [fd75ee6d]
