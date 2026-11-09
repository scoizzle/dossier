# docs/ref/models/options

- Subject: docs/ref/models/options (id `be5d2630-6780-4dcd-82ee-aac7e117ae69`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 31 of 164
- Conflicts: 0
- Gaps: 0

## Facts

- class Meta: constraints = [ models.CheckConstraint(condition=models.Q(age__gte=18), name="age_gte_18"), ] [64f1beba]
- class Meta: indexes = [ models.Index(fields=["last_name", "first_name"]), models.Index(fields=["first_name"], name="first_name_idx"), ] [409a9f61]
- class Meta: order_with_respect_to = "question" [49b6ef78]
- # Latest by ascending order_date. get_latest_by = "order_date" [ea844ea8]
- # Latest by priority descending, order_date ascending. get_latest_by = ["-priority", "order_date"] [adf47244]
- :class:`.UniqueConstraint` provides more functionality than ``unique_together``. ``unique_together`` may be deprecated in the future. [19d867e7]
- >>> answer = Answer.objects.get(id=2) >>> answer.get_next_in_order() <Answer: 3> >>> answer.get_previous_in_order() <Answer: 1> [4e3d00af]
- >>> question = Question.objects.get(id=1) >>> question.get_answer_order() [1, 2, 3] [19db3772]
- >>> question.set_answer_order([3, 1, 2]) [30a5f3f2]
- app_label = "myapp" [3a2e11ac]
- class Answer(models.Model): question = models.ForeignKey(Question, on_delete=models.CASCADE) # ... [c6f56067]
- class Customer(models.Model): age = models.IntegerField() [b5e5c872]
- class Customer(models.Model): first_name = models.CharField(max_length=100) last_name = models.CharField(max_length=100) [fb6681fb]
- class Meta: db_table_comment = "Question answers" [0f79ae28]
- class Question(models.Model): text = models.TextField() # ... [4d2cc5bf]
- db_table = "music_album" [4d2ccc88]
- from django.db import models [4af926756c29efa6-31]
- from django.db.models import F [a345df786882bc74-5]
- ordering = ["-order_date"] [3e9aa1a3]
- ordering = ["-pub_date", "author"] [74c188fb]
- ordering = ["-pub_date"] [2901b7fd]
- ordering = ["pub_date"] [618400cc]
- ordering = [F("author").asc(nulls_last=True)] [cd0ba4f4]
- permissions = [("can_deliver_pizzas", "Can deliver pizzas")] [96425558]
- unique_together = ["driver", "restaurant"] [bf8d7f60]
- verbose_name = "pizza" [f0527518]
- verbose_name_plural = "stories" [062ffedf]
- If you need to change this default behavior, create the intermediary table as an explicit model (with ``managed`` set as needed) and use the :attr:`ManyToManyField.through` attribute to make the relation use your custom model. [9920accf]
- db_table = '"name_left_in_lowercase"' [dc7700e9]
- #. Adding an automatic primary key field to the model if you don't declare it. To avoid confusion for later code readers, it's recommended to specify all the columns from the database table you are modeling when using unmanaged models. [29171453]
- .. admonition:: Use :class:`.UniqueConstraint` with the :attr:`~Options.constraints` option instead. [ca4fedf5]

## Beyond the budget

128 more facts did not fit in the budget: [e19c2753] [eaf050be34acb41d-469] [eaf050be34acb41d-470] [eaf050be34acb41d-471] [088c309e] [f07e155e] [7f617abe] [e4ef1453] [bdddea1a] [e9fec9c1] [87d81d34] [399a2d2a] [acfcf117f82fd4c9-41] [e77ce44e] [fa63f6bb] [1bd7f678] [9f28a6f7] [4bbc4faa] [3122b184] [eabfb533] [b2745da2] [cd71dc2554c2863a] [8fb268a8] [c336a3d7] [2fb15b33] [612926a5] [4800561e] [b34f8acc] [e189287a] [1e32165d] [ea219dd4] [6fcc4011] [61a1a7af9c628685] [4343ee67] [5904ec80] [f475203a] [b725b95b] [746a3e48] [b39f7609] [a35b9de4] [c2928ace] [5613d11b] [57f7ef13] [2dabddd1] [2c232ab4] [bd44beba] [1f2dde83] [09847501] [1c03e3ac] [f3a4b5ee] [d91c3c28] [176a4836] [f49d8c30] [73d76281] [cd12dc9b] [0f290df9] [00011aa1] [43de47fd] [8aea328a] [03bbd140] [6044f01a] [10e08bd1] [6ceb0db4] [1c01e87d] [7f8d5b9a] [24fe5076] [bf126973] [0f20d743] [12701bbc] [e93db5fc] [a792423e] [5cd35ff6] [e0c499a3] [aaeb9659] [c152fbd7] [97b9410f] [0d4a9e7d] [8f69d9a3] [ac8824de] [a9b56077] [629296d3] [1ed60603] [fdb9e5fb] [aecac69e] [a33d6a7c] [bc0e92f4] [e303221c] [99bbdb6c] [f3b1f461] [6e9c3c4c] [119aa8d6] [3a368b18514a814b-14] [c54b54cb0805732a-56] [124a2ab1] [0887494c] [263f2ba3] [fb4396ad] [6c06efc9] [6c9405c9] [4cea4b27] [31e3d8cd] [fbb6e5bb] [c62b0e8c] [9fa0d5a4] [ed89917d] [12210084] [b63affaa] [22051bff] [ef83b707] [6aa45c0650f66404-3] [9f31baf2] [587554db] [aa6205a8] [19e822d3] [36fa2245] [b798d56c] [78b4b4b8375d4b6d-2] [4981119f] [79d3a505] [9a1c86c4] [4aee2da4] [3151dc5e] [99566e56] [9f6553a6] [d0b0de05] [8b5f6dc3] [b4170f59] [9e1a9078c61c7dcd-2]
