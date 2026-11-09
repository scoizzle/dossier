# docs/ref/files/uploads

- Subject: docs/ref/files/uploads (id `a7e34cdc-e451-42e3-bbb8-187c21dfbf2f`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 20 of 84
- Conflicts: 0
- Gaps: 0

## Facts

- for line in uploadedfile: do_something_with(line) [7d444311]
- A dictionary containing extra parameters passed to the ``content-type`` header. This is typically provided by services, such as Google App Engine, that intercept and handle file uploads on your behalf. As a result your handler may not receive the uploaded file content, but instead a URL or other pointer to the file (see :rfc:`RFC 2388 <2388#section-5.3>`). [57cfbc7f]
- A file uploaded into memory (i.e. stream-to-memory). This class is used by the :class:`~django.core.files.uploadhandler.MemoryFileUploadHandler`. [4ddbab80]
- A file uploaded to a temporary location (i.e. stream-to-disk). This class is used by the :class:`~django.core.files.uploadhandler.TemporaryFileUploadHandler`. In addition to the methods from :class:`UploadedFile`, it has one additional method: [4c04bf33]
- A generator returning chunks of the file. If ``multiple_chunks()`` is ``True``, you should use this method in a loop instead of ``read()``. [2b6f4e7c]
- Allows the handler to completely override the parsing of the raw HTTP input. [0867293d]
- Callback signaling that a new file upload is starting. This is called before any data has been fed to any upload handlers. [4a807a5f]
- Callback signaling that the entire upload (all files) has completed. [20eb05fb]
- Callback signaling that the upload was interrupted, e.g. when the user closed their browser during file upload. [ccf90e89]
- Called when a file has finished uploading. [ee77a8e8]
- For :mimetype:`text/*` content-types, the character set (i.e. ``utf8``) supplied by the browser. Again, "trust but verify" is the best policy here. [2a7b153a]
- For maximum performance the chunk sizes should be divisible by ``4`` and should not exceed 2 GB (2\ :sup:`31` bytes) in size. When there are multiple chunk sizes provided by multiple handlers, Django will use the smallest chunk size defined by any handler. [df501fc6]
- If you raise a ``StopUpload`` or a ``SkipFile`` exception, the upload will abort or the file will be completely skipped. [ec990ddc]
- In practice, it's often easiest to use ``chunks()`` all the time. Looping over ``chunks()`` instead of using ``read()`` ensures that large files don't overwhelm your system's memory. [65518404]
- Like regular Python files, you can read the file line-by-line by iterating over the uploaded file:: [1ead0e41]
- Lines are split using :term:`python:universal newlines`. The following are recognized as ending a line: the Unix end-of-line convention ``'\n'``, the Windows convention ``'\r\n'``, and the old Macintosh convention ``'\r'``. [1dec3f79]
- Read the entire uploaded data from the file. Be careful with this method: if the uploaded file is huge it can overwhelm your system if you try to read it into memory. You'll probably want to use ``chunks()`` instead; see below. [28c03059]
- Receives a "chunk" of data from the file upload. [a137a1c2]
- Returns the full path to the temporary uploaded file. [4e133c43]
- .. note:: [942ae6c11625c81c-94]

## Beyond the budget

63 more facts did not fit in the budget: [c207d368] [70753c90] [b5b19f6f] [3bf8f6a9] [c192e07c] [be688325] [3e7cb9ef] [5b4812cd] [c8611838] [f8b44ee7] [b500f5c0] [1f9ffa72] [2b04b89e] [005a6350] [e3bfa5ad] [7f30e27a] [f522e9f3] [15e3731c] [ad734d1e] [3d4dc460] [ed3ef404] [a8e5bc9d] [b48e46a9] [9ed8f603] [2deb2a36] [02575bab] [5663b27e] [6205cb09] [d4b07198] [22895241] [ab664219] [f3d9364c] [9c8dee33] [cf9df614] [aa356a9d] [05048217] [7f507de5] [a3aaf0f8] [11330ed2] [3f2305cf] [db862a31] [3e10c15a] [d214b87d] [316cc367] [9cdfcb07] [50d0f5dd] [0ba5d612] [150d1e65] [0c318b6f] [75c2a59a] [ee5d80d7] [15fd9d73] [85aae550] [19475c6a] [41d389ae] [68188d7f] [0cca9d80] [b8d21c78] [d82539f8] [fa03716f] [918bb994] [542d382a] [d5815c48]
