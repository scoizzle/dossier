# docs/ref/files/file

- Subject: docs/ref/files/file (id `aa40ec87-8b9f-4ccf-8ac1-54ffb1f124f0`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1832 tokens
- Facts shown: 58 facts
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [5cf06f62] .. method:: open(mode=None, *args, **kwargs)
- [315f52d7] :class:`File` objects have the following attributes and methods:
- [2dff0e61] Django provides a built-in class specifically for images. :class:`django.core.files.images.ImageFile` inherits all the attributes and methods of :class:`~django.core.files.File`, and additionally provides the following:
- [998efc17] In addition to the listed methods, :class:`~django.core.files.File` exposes the following attributes and methods of its ``file`` object: ``encoding``, ``fileno``, ``flush``, ``isatty``, ``newlines``, ``read``, ``readinto``, ``readline``, ``readlines``, ``seek``, ``tell``, ``truncate``, ``write``, ``writelines``, ``readable()``, ``writable()``, and ``seekable()``.
- [30ca0bf2] Note that the ``content`` argument must be an instance of either :class:`File` or of a subclass of :class:`File`, such as :class:`~django.core.files.base.ContentFile`.
- [35b69558] Removes the file from the model instance and deletes the underlying file. If ``save`` is ``True``, the model's ``save()`` method will be called once the file is deleted.
- [2c816712] Saves a new file with the file name and contents provided. This will not replace the existing file, but will create a new file and update the object to point to it. If ``save`` is ``True``, the model's ``save()`` method will be called once the file is saved. That is, these two lines:
- [adf5ce36] The :class:`File` class is a thin wrapper around a Python :term:`file object` with some Django-specific additions. Internally, Django uses this class when it needs to represent a file.
- [0a2b96cc] The ``ContentFile`` class inherits from :class:`~django.core.files.File`, but unlike :class:`~django.core.files.File` it operates on string content (bytes also supported), rather than an actual file. For example::
- [974deb81] are equivalent to:
- [380b6105] .. class:: ContentFile(content, name=None)
- [1db74ab4] .. class:: File(file_object, name=None)
- [a0a4af24] .. class:: ImageFile(file_object, name=None)
- [22bd499994c75c8f] .. currentmodule:: django.core.files
- [22bd499994c75c8f-2] .. currentmodule:: django.core.files
- [1a221b1e] .. currentmodule:: django.core.files.base
- [6e009d74] .. currentmodule:: django.core.files.images
- [22bf3a91] .. method:: File.delete(save=True)
- [d627cb5e] .. method:: File.save(name, content, save=True)
- [cbac843f] =================== The ``File`` object ===================
- [b64de3af] Additional methods on files attached to objects ===============================================
- [a35bc276] Any :class:`File` that is associated with an object (as with ``Car.photo``, below) will also have a couple of extra methods:
- [cbbf8638] The :mod:`django.core.files` module and its submodules contain built-in classes for basic file handling in Django.
- [9566dc9b] The ``ContentFile`` class =========================
- [5bd375cb] The ``File`` class ==================
- [ce7ba9c9] The ``ImageFile`` class =======================
