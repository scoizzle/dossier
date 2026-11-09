# docs/ref/files/storage

- Subject: docs/ref/files/storage (id `be92177e-7063-4b5f-b108-17b1e0fd51aa`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 18 of 88
- Conflicts: 0
- Gaps: 0

## Facts

- >>> from django.core.files.storage import storages >>> storages.backends {'default': {'BACKEND': 'django.core.files.storage.FileSystemStorage'}, 'staticfiles': {'BACKEND': 'django.contrib.staticfiles.storage.StaticFilesStorage'}, 'custom': {'BACKEND': 'package.storage.CustomStorage'}} >>> storage_instance = storages.create_storage({"BACKEND": "package.storage.CustomStorage"}) [4dcc073f]
- Absolute path to the directory name assigned to files. Defaults to the value of your :setting:`MEDIA_ROOT` setting. [e5a1132a]
- Absolute path to the directory that will hold the files. Defaults to the value of your :setting:`MEDIA_ROOT` setting. [29492c35]
- Deletes the file referenced by ``name``. If deletion is not supported on the target storage system this will raise ``NotImplementedError`` instead. [93aa4ea9]
- Flag to control allowing saving a new file over an existing one. Defaults to ``False``. [41213a48]
- If :setting:`USE_TZ` is ``True``, returns an aware ``datetime``, otherwise returns a naive ``datetime`` in the local timezone. [d79a0ce2d045b2c6]
- If a file with ``name`` already exists, :meth:`get_alternative_name` is called to obtain an alternative name. [6ae2f5dc]
- Lists the contents of the specified path, returning a 2-tuple of lists; the first item being directories, the second item being files. For storage systems that aren't able to provide such a listing, this will raise a ``NotImplementedError`` instead. [cbf8635a]
- Opens the file given by ``name``. Note that although the returned file is guaranteed to be a ``File`` object, it might actually be some subclass. In the case of remote file storage this means that reading/writing could be quite slow, so be warned. [da67d749]
- Returns ``True`` if a file referenced by the given name already exists in the storage system. [004e34c7]
- Returns a :class:`~datetime.datetime` of the creation time of the file. For storage systems unable to return the creation time this will raise :exc:`NotImplementedError`. [c26455d0]
- Returns a :class:`~datetime.datetime` of the system's ctime, i.e. :func:`os.path.getctime`. On some systems (like Unix), this is the time of the last metadata change, and on others (like Windows), it's the creation time of the file. [12ab6f90]
- Returns a filename based on the ``name`` parameter that's free and available for new content to be written to on the target storage system. [e477dc61]
- Returns a filename based on the ``name`` parameter that's suitable for use on the target storage system. [a7e2a61a]
- Returns an alternative filename based on the ``file_root`` and ``file_ext`` parameters, an underscore plus a random 7 character alphanumeric string is appended to the filename before the extension. [79cd2a6d]
- Returns the URL where the contents of the file referenced by ``name`` can be accessed. For storage systems that don't support access by URL this will raise ``NotImplementedError`` instead. [dc4799bd]
- The ``FileSystemStorage.delete()`` method will not raise an exception if the given file name does not exist. [22a9dc4b]
- .. note:: [942ae6c11625c81c-93]

## Beyond the budget

61 more facts did not fit in the budget: [1655a9a8] [965a7e34] [c65d6726] [01064c2f] [a6067ed4] [8fa6bb60] [e65799e7] [0707ad73] [89649391] [0def82e8] [9c0bf2ca] [4ad3eef3148e184b] [503b4e84] [80540a40] [6ea6ed78119e1f0b] [6ea6ed78119e1f0b-2] [7cc9f774c57cbf78] [58eb84c4517fcc57] [e7aefde6f7263b24] [e7aefde6f7263b24-2] [eaf050be34acb41d-271] [e07f8f14] [a5105793] [03e4a52f] [afcb9b1e] [bd797ff1393b1f3b-2] [11fedd4125163ab9-2] [5d770e3b662b3467] [b3818c5f] [cd2ce08a59414809-2] [908d2944] [f994c1b5] [6376882f] [2a8936ed] [548cc3ea] [14e20c01] [a22ed217] [76abb848] [bc647458] [d600b035] [b540b1c2] [c32843ea] [2e488acc] [3949e7be] [0627d663] [3d6e6899] [b19aa22a] [8736580b] [bbcccc1b] [d52953a6] [c0b7fcb2] [491fc94d] [63d99489] [6b8dfbe3] [3f69bc34] [25ea4f6c] [72596f2b] [d602aa0a] [03dac9cc] [8fa07e5b] [7959433b]
