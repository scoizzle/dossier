# docs/ref/files/file

- Subject: docs/ref/files/file (id `d5701397-16cd-4dde-8a66-6859e2f58dc4`)
- Kind: subject
- Budget: 1200 tokens
- Used: 893 tokens
- Facts shown: 32 of 58
- Conflicts: 0
- Gaps: 0

## Facts

- Some subclasses of :class:`File`, including :class:`~django.core.files.base.ContentFile` and :class:`~django.db.models.fields.files.FieldFile`, may replace this attribute with an object other than a Python :term:`file object`. In these cases, this attribute may itself be a :class:`File` subclass (and not necessarily the same subclass). Whenever possible, use the attributes and methods of the subclass itself rather than those of the subclass's ``file`` attribute. [3a7f4a1c]
- .. admonition:: Be careful with this attribute in subclasses. [d8d8dba2]
- >>> car.photo.save("myphoto.jpg", content, save=False) >>> car.save() [38bcc859]
- >>> car.photo.save("myphoto.jpg", content, save=True) [4e90220c]
- Close the file. [32f5d92f]
- Height of the image in pixels. [a79c4439]
- It can be used as a context manager, e.g. ``with file.open() as f:``. [546c6da8]
- Iterate over the file yielding "chunks" of a given size. ``chunk_size`` defaults to 64 KB. [74f22b11]
- Iterate over the file yielding one line at a time. [e5df7e9e]
- Open or reopen the file (which also does ``File.seek(0)``). The ``mode`` argument allows the same values as Python's built-in :func:`python:open`. ``*args`` and ``**kwargs`` are passed after ``mode`` to Python's built-in :func:`python:open`. [c753e279]
- Returns ``True`` if the file is large enough to require multiple chunks to access all of its content give some ``chunk_size``. [8f5124c7]
- The name of the file including the relative path from :setting:`MEDIA_ROOT`. [b745562e]
- The read/write mode for the file. [161ee34c]
- The size of the file in bytes. [6f1c40f5]
- The underlying :term:`file object` that this class wraps. [4f741665]
- This is especially useful with very large files since it allows them to be streamed off disk and avoids storing the whole file in memory. [9df62ac8]
- When reopening a file, ``mode`` will override whatever mode the file was originally opened with; ``None`` means to reopen with the original mode. [c35f8915]
- Width of the image in pixels. [3df97d2d]
- f1 = ContentFile("esta frase está en español") f2 = ContentFile(b"these are bytes") [3fba8e3d]
- from django.core.files.base import ContentFile [fbd604675a8db13c]
- .. attribute:: file [c914e6cd]
- .. attribute:: height [973f3cacdf2333a8-3]
- .. attribute:: mode [b5fe16f8]
- .. attribute:: name [80d47dc5547c9038-13]
- .. attribute:: size [77c39c8db15001c7-3]
- .. attribute:: width [294465fd5a8a6bbb-4]
- .. code-block:: pycon [eaf050be34acb41d-269]
- .. code-block:: pycon [eaf050be34acb41d-270]
- .. method:: __iter__() [b538d1d8949fe012-2]
- .. method:: chunks(chunk_size=None) [6fda931d]
- .. method:: close() [4d5f685f]
- .. method:: multiple_chunks(chunk_size=None) [09b5675e]

## Beyond the budget

25 more facts did not fit in the budget: [5cf06f62] [315f52d7] [2dff0e61] [998efc17] [30ca0bf2] [35b69558] [2c816712] [adf5ce36] [0a2b96cc] [974deb81] [380b6105] [1db74ab4] [a0a4af24] [22bd499994c75c8f] [1a221b1e] [6e009d74] [22bf3a91] [d627cb5e] [cbac843f] [b64de3af] [a35bc276] [cbbf8638] [9566dc9b] [5bd375cb] [ce7ba9c9]
