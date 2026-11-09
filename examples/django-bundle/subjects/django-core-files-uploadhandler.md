# django/core/files/uploadhandler

- Subject: django/core/files/uploadhandler (id `9492df23-5ee8-4804-9d98-d3d0099b631c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 17 of 40
- Conflicts: 0
- Gaps: 0

## Facts

- :input_data: An object that supports reading via .read(). :META: ``request.META``. :content_length: The (integer) value of the Content-Length header from the client. :boundary: The boundary from the Content-Type header. Be sure to prepend two '--'. """ pass [17573f61]
- Parameters: [a2108a8b]
- Subclasses should return a valid ``UploadedFile`` object. """ raise NotImplementedError( "subclasses of FileUploadHandler must provide a file_complete() method" ) [5db30bb4]
- Warning: As with any data from the client, you should not trust content_length (and sometimes won't even get it). """ self.field_name = field_name self.file_name = file_name self.content_type = content_type self.content_length = content_length self.charset = charset self.content_type_extra = content_type_extra [151fc292]
- self.file.seek(0) return InMemoryUploadedFile( file=self.file, field_name=self.field_name, name=self.file_name, content_type=self.content_type, size=file_size, charset=self.charset, content_type_extra=self.content_type_extra, ) [a1cf2c2e]
- stream = getattr(input_data, "_stream", input_data) try: content_length = stream.seek(0, os.SEEK_END) except (UnsupportedOperation, AttributeError): # Cannot seek; fall back to the Content-Length parameter. # On WSGI the stream enforces this value so it is trustworthy. pass else: stream.seek(0) self.activated = ( content_length is not None and content_length <= settings.FILE_UPLOAD_MAX_MEMORY_SIZE ) [b97edfc8]
- E.g.:: >>> from django.http import HttpRequest >>> request = HttpRequest() >>> load_handler( ... 'django.core.files.uploadhandler.TemporaryFileUploadHandler', ... request, ... ) <TemporaryFileUploadHandler object at 0x...> """ return import_string(path)(*args, **kwargs) [a0fcb899]
- chunk_size = 64 * 2**10 # : The default chunk size is 64 KB. [e4f73916]
- def __init__(self, connection_reset=False): """ If ``connection_reset`` is ``True``, Django knows will halt the upload without consuming the rest of the upload. This will cause the browser to show a "connection reset" error. """ self.connection_reset = connection_reset [bec6bdce]
- def __init__(self, request=None): self.file_name = None self.content_type = None self.content_length = None self.charset = None self.content_type_extra = None self.request = request [28f2da25]
- def __str__(self): if self.connection_reset: return "StopUpload: Halt current upload." else: return "StopUpload: Consume request data, then halt." [96fa9309]
- def file_complete(self, file_size): """ Signal that a file has completed. File size corresponds to the actual size accumulated by all the chunks. [0784ac44]
- def file_complete(self, file_size): """Return a file object if this handler is activated.""" if not self.activated: return [1ae08d72]
- def file_complete(self, file_size): self.file.seek(0) self.file.size = file_size return self.file [db6a85d5]
- def handle_raw_input( self, input_data, META, content_length, boundary, encoding=None ): """ Handle the raw input from the client. [29487a4d]
- def receive_data_chunk(self, raw_data, start): self.file.write(raw_data) [056b7bb5]
- pass [7655780f0d17b825-34]

## Beyond the budget

23 more facts did not fit in the budget: [e1e38f66] [8507544f] [d4836f28] [9298ffa0] [b602d2db] [558f82dc] [39f5fcad] [4c5be6f5] [b98348ed] [7655780f0d17b825-35] [7655780f0d17b825-36] [9869f90c] [10a5d6b2] [01563511] [db1cd839] [7bcc16a3] [0284473f] [7884cda8] [a5607ef6] [d6594aae] [995cabbd] [53640b7f] [d8c6fc5f]
