# docs/ref/contrib/syndication

- Subject: docs/ref/contrib/syndication (id `3b0834bf-f7e8-4f54-86f2-0c2687f70739`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 19 of 304
- Conflicts: 0
- Gaps: 0

## Facts

- Default implementation preserves the old behavior of using {'obj': item, 'site': current_site} as the context. """ [7c20692b]
- def get_context_data(self, **kwargs): context = super().get_context_data(**kwargs) context["foo"] = "bar" return context [ceea7ad9]
- def items(self): return Article.objects.order_by("-pub_date")[:5] [4c7d69a2]
- # AUTHOR EMAIL --One of the following three is optional. The framework # looks for them in this order. [04db6766]
- # AUTHOR LINK --One of the following three is optional. The framework # looks for them in this order. In each case, the URL should include # the scheme (such as "https://") and domain name. [9b281b71]
- # CATEGORIES -- One of the following three is optional. The framework # looks for them in this order. In each case, the method/attribute # should return an iterable object that returns strings. [31fd43cb]
- # COPYRIGHT NOTICE -- One of the following three is optional. The # framework looks for them in this order. [47a313c1]
- # DESCRIPTION -- One of the following three is required. The framework # looks for them in this order. [98c2b48a]
- # FEED_URL -- One of the following three is optional. The framework # looks for them in this order. [abd1eb68]
- # First, the framework tries the two methods below, in # order. Failing that, it falls back to the get_absolute_url() # method on each item returned by items(). [62a6808d]
- # GET_OBJECT -- This is required for feeds that publish different data # for different URL parameters. (See "A complex example" above.) [5d9783d8]
- # GUID -- One of the following three is optional. The framework looks # for them in this order. This property is only used for Atom feeds # (where it is the feed-level ID element). If not provided, the feed # link is used as the ID. [e2e0ac2a]
- # Hardcoded stylesheets. stylesheets = ["/stylesheet1.xsl", "stylesheet2.xsl"] [2adad7bb]
- # ITEM AUTHOR EMAIL --One of the following three is optional. The # framework looks for them in this order. # # If you specify this, you must specify item_author_name. [0ad31e48]
- # ITEM AUTHOR LINK -- One of the following three is optional. The # framework looks for them in this order. In each case, the URL should # include the scheme (such as "https://") and domain name. # # If you specify this, you must specify item_author_name. [809d4f5c]
- # ITEM AUTHOR NAME -- One of the following three is optional. The # framework looks for them in this order. [15e41723]
- # ITEM CATEGORIES -- It's optional to use one of these three. This is # a hook that specifies how to get the list of categories for a given # item. In each case, the method/attribute should return an iterable # object that returns strings. [1ec7bc33]
- # ITEM COMMENTS URL -- It's optional to use one of these three. This is # a hook that specifies how to get the URL of a page for comments for a # given item. [e97beec3]
- # ITEM COPYRIGHT NOTICE (only applicable to Atom feeds) -- One of the # following three is optional. The framework looks for them in this # order. [1033f925]

## Beyond the budget

257 more facts did not fit in the budget: [48d58d29] [bc2652e4] [673eb429] [cd470061] [99315119] [9f59152a] [17bc16da] [ca8c2f8b] [ccc6d220] [b6fca62a] [b65397e1] [f0356687] [ecb1efeb] [af80c808] [4c22b185] [880c7e5c] [37195e54] [a86e7066] [66841023] [4a5493b5] [2502a6e5] [182fbc80] [8d967208] [a703ef18] [6ad15efd] [2b6ccc8b] [3b7e6858] [0da1da69] [c784c575] [9b78de9f] [d2a6eb5b] [954bc138] [214d372f] [731dad80] [c9dde723] [0ea32599] [e827b333] [ee92cd81] [1fc4ad3b] [8b4c413c] [151f3a28] [56744a54] [1f720138] [863e858f] [187e7248] [8b7c36a4] [2dac90f0] [94461676] [e4c4f022] [fdaf1c2f] [7b60fae0] [ec8a62f5] [16023b66] [70d4c7c2] [db57478d] [19a65a6f] [5d8f569a] [4b7b92b3] [a4d62df8] [5e29015d] [3754fd67] [f2e8ab05] [97a9fcd4] [eb9520893e312aa8] [d2af52a7] [f602be8f] [c4cfc0c4] [0cfa1940] [a4e7dc0f] [dafd1924] [74e57cc1] [6592c097] [ce137d63] [723e0519] [2917d848] [040be65c] [b77e9656] [291e68ae] [d8696160] [835f34c6] [de224c3f] [c5f73793] [29024a2a] [a7568eb0] [3c281c10] [65fcb2c3] [4e0cb259] [582d5d61] [1b23c5ad] [9cbad9bb] [2406491d] [cf450ae9] [228dc659] [c26e380d] [3357b396] [ea7d6d19] [028ff82f] [a82dcf26] [9dda90ef] [5b5321db] [ce0d6d5d] [8ff05544] [9d2967a5] [26959e001cf50789] [26959e001cf50789-2] [c1df9c31] [43608c48c853a2ec] [7a2698b0] [5f267909] [4244f9ec] [e3a5b232] [dbe71019] [d242a561] [38e8db6f] [60ccf40f] [ff21208b] [afd8b00b] [11ba3414] [02e43593] [594cdade] [e66ebf5a] [fcdb81de] [69c619ba] [281177d1] [f89edd8c] [fe18b198] [6d3665af] [7060746b] [fed48201] [6213a640] [f4be580e1354ac0a] [7786a036] [4b36744b] [bce3813b] [c6474577] [d8f5fbc4] [4c7b4dfe] [cccfeb08] [4e658e55] [62733d53] [eaf991cb] [1b67ee6f] [1cb87778] [2aa63dff] [0115c2be] [b220271f] [31ed3d0e] [506effdd] [c11bbdd7] [685d15dfb6eb2285-69] [3e476ed0] [3950a03d] [109b2fcb] [2032121a] [ba6314db] [5c1b56c1] [c3ba880d] [87c2473f] [b8bd0cff] [fc9ae8c6] [7a47c874] [8425ab43] [0c6aa6ad] [62898719] [69281e19] [eda5ef48] [72197566] [c74cdf76] [4548c8d5] [5eb468a1] [a8d93109] [9a619ae6] [1aecbe9f] [220952be] [65d688e4] [eaf050be34acb41d-267] [5e5c2ee8] [89133eaa] [4a896aab] [c54b54cb0805732a-31] [3fafc54e] [be48cf9f] [1e2202ad] [6358c4d7] [63622a71] [6b4cb9a7] [c6400103] [656f3d59] [1da4c118] [792effbd] [9a45cf5b] [1a2640b3] [afed7f89] [69e6c3af] [a88ebdeb] [6b267ed3] [8dc8a5ef] [3037b0c4] [3de5a5b7] [3b231af7] [4758145b] [e5c937c0] [82186856] [e655e922] [ea5f04ce] [bbcac1ee] [482c351c] [bbc7ea5c] [e145fdb3] [f01714c9] [b5236f3b] [1c937e42] [1053ce52] [15f488f3] [a7435091] [4c651fed] [174a72f8] [1224591e] [93ad56e8] [baa2e082d1d55e26-2] [84563bb1] [c7442268] [ba81c305] [435db3d9] [ec1511a2] [8bd6b01b] [6148fab3] [046099c1] [c08f4107] [dadcec59] [867732bf] [782d09bf] [9f5fa293] [a9354233] [366ccbd3] [fc5af06e] [6ad0eaf8] [86a801e2] [87d2ae35] [373e1b68] [f519214a] [d653aeb6] [c8dce435] [d56e5fb3] [3a41affc1b4582de-2] [eb70719c] [bb8c3579] [9857ef50] [b9b23992] [ad376974] [06e445fd] [699175ee] [b3be0893] [1219f382] [32b2e664] [636d899a] [f7291e02]
