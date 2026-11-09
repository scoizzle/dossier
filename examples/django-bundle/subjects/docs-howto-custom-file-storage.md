# docs/howto/custom-file-storage

- Subject: docs/howto/custom-file-storage (id `e68cd75f-c1f0-4021-9709-6257d37394c2`)
- Kind: subject
- Budget: 1200 tokens
- Used: 879 tokens
- Facts shown: 24 of 40
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

15 more facts did not fit in the budget: [6bb34b85] [3140bfe5] [7d37d8b7] [0755c483] [1696aec2] [d1cb8c6e] [cc90f635] [808a213e] [01ca55f3] [9d73afc5] [00d6a9b4] [62b56fe4] [8a9a348c] [20e8e719] [2ab8463a]
