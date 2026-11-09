# docs/howto/custom-file-storage

- Subject: docs/howto/custom-file-storage (id `0a8c04f8-19b1-4b55-b7ce-74669807256b`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1764 tokens
- Facts shown: 39 of 40
- Conflicts: 0
- Gaps: 0

## Highlights

- class MyStorage(Storage): def __init__(self, option=None): if not option: option = settings.CUSTOM_STORAGE_OPTIONS ... [0a5aa218]
- class MyStorage(Storage): ... [1c5bb757]
- from django.conf import settings from django.core.files.storage import Storage [fbb6912b]
- from django.core.files.storage import Storage [9a737fee]
- example_storage = storages["example"] [ac6b4bb1]
- In addition, if your class provides local file storage, it must override the ``path()`` method. [b3a862e1]
- #. Django must be able to instantiate your storage system without any arguments. This means that any settings should be taken from ``django.conf.settings``:: [f2d72073]
- #. Your custom storage system must be a subclass of ``django.core.files.storage.Storage``:: [379c23e2]
- #. Your storage class must be :ref:`deconstructible <custom-deconstruct-method>` so it can be serialized when it's used on a field in a migration. As long as your field has arguments that are themselves :ref:`serializable <migration-serializing>`, you can use the ``django.utils.deconstruct.deconstructible`` class decorator for this (that's what Django uses on FileSystemStorage). [41bce875]
- #. Your storage class must implement the :meth:`_open` and :meth:`_save` methods, along with any other methods appropriate to your storage class. See below for more on these methods. [fece7033]
- * :meth:`Storage.delete` * :meth:`Storage.exists` * :meth:`Storage.listdir` * :meth:`Storage.size` * :meth:`Storage.url` [3d8acaa5]
- **Required**. [cee4457c]
- .. _using-custom-storage-engine: [19afde77]
- .. currentmodule:: django.core.files.storage [a111ca2d]
- .. method:: _open(name, mode='rb') [358ad629]
- .. method:: _save(name, content) [425057c1]
- .. method:: get_alternative_name(file_root, file_ext) [bd797ff1393b1f3b]
- .. method:: get_available_name(name, max_length=None) [11fedd4125163ab9]
- .. method:: get_valid_name(name) [cd2ce08a59414809]
- =================================== How to write a custom storage class =================================== [c0c53cae]
- Another example would be a backend that only handles writing to files. In this case, you would not need to implement any of the above methods. [fe6a48ee]
- By default, the following methods raise ``NotImplementedError`` and will typically have to be overridden: [14cc9064]
- By way of example, if listing the contents of certain storage backends turns out to be expensive, you might decide not to implement ``Storage.listdir()``. [815d7a37]
- Called by ``Storage.open()``, this is the actual mechanism the storage class uses to open the file. This must return a ``File`` object, though in most cases, you'll want to return some subclass here that implements logic specific to the backend storage system. The :exc:`FileNotFoundError` exception should be raised when a file doesn't exist. [3b385453]

## All facts

- [6bb34b85] Called by ``Storage.save()``. The ``name`` will already have gone through ``get_valid_name()`` and ``get_available_name()``, and the ``content`` will be a ``File`` object itself.
- [3140bfe5] If a file with ``name`` already exists, ``get_alternative_name()`` is called to obtain an alternative name.
- [7d37d8b7] If you need to provide custom file storage -- a common example is storing files on some remote system -- you can do so by defining a custom storage class. You'll need to follow these steps:
- [0755c483] Note however that not all these methods are required and may be deliberately omitted. As it happens, it is possible to leave each method unimplemented and still have a working Storage.
- [1696aec2] Returns a filename suitable for use with the underlying storage system. The ``name`` argument passed to this method is either the original filename sent to the server or, if ``upload_to`` is a callable, the filename returned by that method after any path information is removed. Override this to customize how non-standard characters are converted to safe filenames.
- [d1cb8c6e] Returns a filename that is available in the storage mechanism, possibly taking the provided filename into account. The ``name`` argument passed to this method will have already cleaned to a filename valid for the storage system, according to the ``get_valid_name()`` method described above.
- [cc90f635] Returns an alternative filename based on the ``file_root`` and ``file_ext`` parameters. By default, an underscore plus a random 7 character alphanumeric string is appended to the filename before the extension.
- [808a213e] Should return the actual name of the file saved (usually the ``name`` passed in, but if the storage needs to change the file name return the new name instead).
- [01ca55f3] Storages are then accessed by alias from the :data:`django.core.files.storage.storages` dictionary::
- [9d73afc5] The code provided on ``Storage`` retains only alpha-numeric characters, periods and underscores from the original filename, removing everything else.
- [00d6a9b4] The first step to using your custom storage with Django is to tell Django about the file storage backend you'll be using. This is done using the :setting:`STORAGES` setting. This setting maps storage aliases, which are a way to refer to a specific storage throughout Django, to a dictionary of settings for that specific storage backend. The settings in the inner dictionaries are described fully in the :setting:`STORAGES` documentation.
- [62b56fe4] The length of the filename will not exceed ``max_length``, if provided. If a free unique filename cannot be found, a :exc:`SuspiciousFileOperation <django.core.exceptions.SuspiciousOperation>` exception is raised.
- [8a9a348c] Ultimately, which of these methods are implemented is up to you. Leaving some methods unimplemented will result in a partial (possibly broken) interface.
- [20e8e719] Use your custom storage engine ==============================
- [2ab8463a] You'll also usually want to use hooks specifically designed for custom storage objects. These are:
