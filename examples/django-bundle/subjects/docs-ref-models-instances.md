# docs/ref/models/instances

- Subject: docs/ref/models/instances (id `176567bf-044a-4ffd-964b-e4b99da100d2`)
- Kind: subject
- Budget: 1200 tokens
- Used: 889 tokens
- Facts shown: 24 of 262
- Conflicts: 0
- Gaps: 0

## Facts

- @classmethod def create(cls, title): book = cls(title=title) # do something with the book return book [e54f8caf]
- def clean_fields(self, exclude=None): super().clean_fields(exclude=exclude) if self.status == "draft" and self.pub_date is not None: if exclude and "status" in exclude: raise ValidationError( _("Draft entries may not have a publication date.") ) else: raise ValidationError( { "status": _( "Set status to draft if there is not a publication date." ), } ) [f3834d35]
- objects = BookManager() [4eb42e10]
- In earlier versions, ``True`` was returned for ``DatabaseDefault`` values. [dd04da2a]
- The ``fetch_mode`` attribute was added. [38e7760d]
- book = Book.create("Pride and Prejudice") [5920b2ca]
- book = Book.objects.create_book("Pride and Prejudice") [a6cbfb60]
- class Article(models.Model): ... [a107874ed3ff2f8b]
- class Book(models.Model): title = models.CharField(max_length=100) [17cf7d31e7e8d657]
- class BookManager(models.Manager): def create_book(self, title): book = self.create(title=title) # do something with the book return book [39071eb2]
- def __str__(self): return f"{self.first_name} {self.last_name}" [6bdcabf3]
- def clean(self): # Don't allow draft entries to have a pub_date. if self.status == "draft" and self.pub_date is not None: raise ValidationError( {"pub_date": _("Draft entries may not have a publication date.")} ) ... [f9d215e5]
- def clean(self): # Don't allow draft entries to have a pub_date. if self.status == "draft" and self.pub_date is not None: raise ValidationError(_("Draft entries may not have a publication date.")) # Set the pub_date for published items if it hasn't been set already. if self.status == "published" and self.pub_date is None: self.pub_date = datetime.date.today() [b64a7da3]
- def get_absolute_url(self): return "/%s/" % self.name [c201aeee]
- from django.db import models [4af926756c29efa6-26]
- return reverse("people-detail", kwargs={"pk": self.pk}) [13889125]
- # Primary keys compared MyModel(id=1) == MyModel(id=1) MyModel(id=1) != MyModel(id=2) # Primary keys are None MyModel(id=None) != MyModel(id=None) # Same instance instance = MyModel(id=None) instance == instance # Proxy model MyModel(id=1) == MyProxyModel(id=1) # Multi-table inheritance MyModel(id=1) != MultitableInherited(id=1) [c623b5df]
- #. Add a classmethod on the model class:: [72748854]
- #. Add a method on a custom manager (usually preferred):: [d1a2b1f7]
- .. versionchanged:: 6.1 [2a966a198e13032b-16]
- .. versionchanged:: 6.1 [2a966a198e13032b-17]
- <!-- BAD template code. Avoid! --> <a href="/people/{{ object.id }}/">{{ object.name }}</a> [a1ddafb5]
- <a href="{{ object.get_absolute_url }}">{{ object.name }}</a> [d5acd89f]
- >>> b2 = Blog(name="Cheddar Talk", tagline="Thoughts on cheese.") >>> b2.id # Returns None, because b2 doesn't have an ID yet. >>> b2.save() >>> b2.id # Returns the ID of your new object. [bf26a11f]

## Beyond the budget

230 more facts did not fit in the budget: [b9e4a756] [022cccb3] [a22ff421] [79f1ecc4] [6b08990d] [b2dc2c1c] [e6cb83fe] [d0396177] [bcce4c1a] [840e5cb8] [24b0d17e] [e5e21c77] [78d2b34e] [45df2f38] [fc437f40] [ff7cef96] [3b9c2f7a] [704d2c606e749739] [6bb99922] [a859441c] [81828cec] [93ed737f] [e5302131] [72a1c9ea] [68ba1f49] [f9d8e77a] [75acec7d] [c2f567a8] [aa1fa934] [ab8db0e6] [cc6e503b] [faf0de29] [4f068a4a] [6272c218d11324a9-3] [ebd964b3] [8d83dbc0] [ec3e4eba] [170dde67] [798a61a8] [e2148d20c78ef2f1] [5eeeaab5] [b04ce7f2] [fac4cb54] [5aed7fc3] [6febadae] [e1607669] [3c1cc922] [0fe32170] [e0b3653a] [b1cb6fec] [4fd8186c] [21afae5f] [03a5cf95] [1fcde08d] [0ee13cdb] [e18ef61e] [cfdf76f3] [9dd17d6d4c96250c] [f10d83df] [b6273033] [05ae214f] [cbe092ea] [017f3a3a] [f638a68f] [ae52c346] [d5f8886e] [eef4fe66] [ef66837c] [19634cf7] [b12581a78f7d2838] [348476ea] [d8f1e420] [3ecbd156] [05ac5607] [026b3edb] [685d15dfb6eb2285-80] [eaf050be34acb41d-459] [eaf050be34acb41d-460] [eaf050be34acb41d-461] [eaf050be34acb41d-462] [eaf050be34acb41d-463] [eaf050be34acb41d-464] [3a368b18514a814b-12] [01aaf10861da6524-8] [8c84cc77] [7a297061] [63a9a47f] [6d9b72de] [8ec3056c] [050efc89] [ad94d73c] [1107109f] [f39c8618] [03e7b1f9] [6665b922] [0d6cebde] [44777b6e] [a4e39374] [dec979b3] [104a0f7d] [942ae6c11625c81c-114] [4912291b] [57739e32d87f6c76-16] [2a966a198e13032b-18] [2a966a198e13032b-19] [c54b54cb0805732a-55] [8b894b79] [009f60d2] [d2a0a92b] [4a732235] [d95971fb] [fc69c0d0] [2d9337ee] [f5d3cb33] [9ff396b8] [85cb27f3] [43ac16f6] [5364489b] [48dc83dd] [53540e6a] [b13258b6] [2107b922] [be764c38] [b9df65d3] [421a68d3] [4f6e0a92] [b6431628] [4fdc2c9c] [28edef836ab93f57-19] [28edef836ab93f57-20] [28edef836ab93f57-21] [28edef836ab93f57-22] [28edef836ab93f57-23] [a233eb56] [61d6039b] [f9d41b33] [28c4c40f] [5fbfcaaa] [45a05e31] [615d99ec] [c7174e07] [2ab1d79c] [660112f8] [0570b778] [12bef256] [f6d7f8e4] [47535daa] [cf642ffe] [13c9f43f] [2f12deae] [6846cd18] [dd8c5704] [c17ecf56] [a54a911f] [b6e43737] [954bf94a] [cb025485] [1585ece5] [db561665] [7bb75946] [e5aa8ec3] [92bc9b77] [7789f674] [bf1ae693] [102eca55] [28458e0a] [f63f20ac] [f0839da5] [4bd46567] [fee49113] [4320acac] [531e8590] [68983777] [af54de59] [56b002c7] [70769cb7] [03813475] [db8e299e] [0f97f341] [5566f1c1] [0cce015c] [4e391fa1] [adc5e773] [af190837] [a68dbc82] [6daf1a18] [0ed3ebbe] [f78beb8a] [a725d4f7] [62af8f2d] [b2019619] [a4872f23] [5570d076] [036a1417] [4f4fb195] [7efdb865] [2dd2e687] [79dab20d] [396b9abc] [6e289fc9] [6d7d2e4a] [b5cad9c5] [ea15c8be] [853ef64b] [6060173d] [858fbb41dd44aafc] [ce73f9f1] [ec3c3110] [a54aad56] [8d6d0b5a] [8bf1e305] [358b8ef9] [aaf777fc] [3cf7c260] [9cdae336] [e50c46cb] [d0e80e4c] [8301998d] [ad7624ee] [a14a4904] [5aa3d393] [61dcec24] [464dca47] [b898c42d] [3207d036] [c321ad94] [f53265f9] [ac86425b] [aae8b60d] [e9b7f874]
