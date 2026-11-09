# docs/ref/models/relations

- Subject: docs/ref/models/relations (id `ef3b87c3-a9f2-491d-9bb6-d95f4bf2c14c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 31 of 68
- Conflicts: 0
- Gaps: 0

## Facts

- # No need to call e.save() at this point -- it's already been saved. [104a51f6]
- >>> b = Blog.objects.get(id=1) >>> b.entry_set.clear() [81b08433]
- >>> b = Blog.objects.get(id=1) >>> e = Entry(blog=b, headline="Hello", body_text="Hi", pub_date=datetime.date(2005, 1, 1)) >>> e.save(force_insert=True) [51e11987]
- >>> b = Blog.objects.get(id=1) >>> e = Entry.objects.get(id=234) >>> b.entry_set.add(e) # Associates Entry e with Blog b. [19c69d93]
- >>> b = Blog.objects.get(id=1) >>> e = Entry.objects.get(id=234) >>> b.entry_set.remove(e) # Disassociates Entry e from Blog b. [a19248e7]
- >>> b = Blog.objects.get(id=1) >>> e = b.entry_set.create( ... headline="Hello", body_text="Hi", pub_date=datetime.date(2005, 1, 1) ... ) [94138921]
- >>> new_list = [obj1, obj2, obj3] >>> e.related_set.set(new_list) [173c24ce]
- class Blog(models.Model): # ... pass [70e4c119]
- class Entry(models.Model): blog = models.ForeignKey(Blog, on_delete=models.CASCADE, null=True) [090a9609]
- class Pizza(models.Model): toppings = models.ManyToManyField(Topping) [5b908e68]
- class Topping(models.Model): # ... pass [e7700ff1e52b3085]
- from django.db import models [4af926756c29efa6-37]
- *Asynchronous version*: ``aadd`` [9ad4cfb6]
- *Asynchronous version*: ``aclear`` [d24fbd50]
- *Asynchronous version*: ``acreate`` [3caae2c2]
- *Asynchronous version*: ``aremove`` [0f1cd166]
- *Asynchronous version*: ``aset`` [b6463577]
- .. code-block:: pycon [eaf050be34acb41d-544]
- .. code-block:: pycon [eaf050be34acb41d-545]
- .. code-block:: pycon [eaf050be34acb41d-546]
- .. code-block:: pycon [eaf050be34acb41d-547]
- .. code-block:: pycon [eaf050be34acb41d-548]
- .. code-block:: pycon [eaf050be34acb41d-549]
- Adds the specified model objects to the related object set. [f73ff225]
- Creates a new object, saves it and puts it in the related object set. Returns the newly created object: [4af3a42d]
- Example: [20ed93bf2591ccc0-22]
- For :class:`~django.db.models.ForeignKey` objects, the ``bulk`` argument is passed on to :meth:`add` and :meth:`remove`. [3c84c601]
- For :class:`~django.db.models.ForeignKey` objects, this method accepts a ``bulk`` argument to control how to perform the operation. If ``True`` (the default), ``QuerySet.update()`` is used. If ``bulk=False``, the ``save()`` method of each individual model instance is called instead. This triggers the :data:`~django.db.models.signals.pre_save` and :data:`~django.db.models.signals.post_save` signals and comes at the expense of performance. [83d92019]
- For many-to-many relationships ``add()`` accepts either model instances or field values, normally primary keys, as the ``*objs`` argument. [746022cf]
- For many-to-many relationships, the ``bulk`` keyword argument doesn't exist. [cb95ecd41e9850cb]
- .. note:: [942ae6c11625c81c-130]

## Beyond the budget

33 more facts did not fit in the budget: [c0864313] [fa4c3026] [c6a6b170] [07e27966] [8338898c] [242a34b4] [a5484014] [86fc389e] [6d7e2518] [642c6ce7] [be59b5bd] [7dcaeccc] [4bd58941] [958a78aec9e70475] [8e7ce208] [a37f7ff6] [8ba2151d] [aa4d726b] [2c883292] [3ccd74f3] [d01520a2] [a0205a8f] [01ac8ce9] [980fb500] [71d26b72] [bb6ad7fc] [c9482ea0] [4861948b] [171fe48c] [c90ca7f0] [dece027f] [9b68b6f0] [3e966cf9]
