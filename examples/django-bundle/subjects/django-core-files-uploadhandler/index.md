# django/core/files/uploadhandler

- Subject: django/core/files/uploadhandler (id `e4578008-5f83-4cd0-a1a4-586c54058834`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1968 tokens
- Facts shown: 40 facts
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [e1e38f66] def handle_raw_input( self, input_data, META, content_length, boundary, encoding=None ): """ Use the content_length to signal whether or not this handler should be used. """ # If the post is too large, we cannot use the Memory handler. # Content-Length can be absent or understated (for example # `Transfer-Encoding: chunked` on ASGI), so for seekable streams (such # as SpooledTemporaryFile on ASGI), check the actual size.
- [8507544f] def new_file( self, field_name, file_name, content_type, content_length, charset=None, content_type_extra=None, ): """ Signal that a new file has been started.
- [d4836f28] def new_file(self, *args, **kwargs): """ Create the file object to append to as data is coming in. """ super().new_file(*args, **kwargs) self.file = TemporaryUploadedFile( self.file_name, self.content_type, 0, self.charset, self.content_type_extra )
- [9298ffa0] def new_file(self, *args, **kwargs): super().new_file(*args, **kwargs) if self.activated: self.file = BytesIO() raise StopFutureHandlers()
- [b602d2db] def receive_data_chunk(self, raw_data, start): """ Receive data from the streamed upload parser. ``start`` is the position in the file of the chunk. """ raise NotImplementedError( "subclasses of FileUploadHandler must provide a receive_data_chunk() method" )
- [558f82dc] def receive_data_chunk(self, raw_data, start): """Add the data to the BytesIO file.""" if self.activated: self.file.write(raw_data) else: return raw_data
- [39f5fcad] def upload_complete(self): """ Signal that the upload is complete. Subclasses should perform cleanup that is necessary for this handler. """ pass
- [4c5be6f5] def upload_interrupted(self): """ Signal that the upload was interrupted. Subclasses should perform cleanup that is necessary for this handler. """ pass
- [b98348ed] def upload_interrupted(self): if hasattr(self, "file"): temp_location = self.file.temporary_file_path() try: self.file.close() os.remove(temp_location) except FileNotFoundError: pass
- [7655780f0d17b825-35] pass
- [7655780f0d17b825-36] pass
- [9869f90c] """ Base file upload handler classes, and the built-in concrete subclasses """
- [10a5d6b2] __all__ = [ "UploadFileException", "StopUpload", "SkipFile", "FileUploadHandler", "TemporaryFileUploadHandler", "MemoryFileUploadHandler", "load_handler", "StopFutureHandlers", ]
- [01563511] class FileUploadHandler: """ Base class for streaming upload handlers. """
- [db1cd839] class MemoryFileUploadHandler(FileUploadHandler): """ File upload handler to stream uploads into memory (used for small files). """
- [7bcc16a3] class SkipFile(UploadFileException): """ This exception is raised by an upload handler that wants to skip a given file. """
- [0284473f] class StopFutureHandlers(UploadFileException): """ Upload handlers that have handled a file and do not want future handlers to run should raise this exception instead of returning None. """
- [7884cda8] class StopUpload(UploadFileException): """ This exception is raised when an upload must abort. """
- [a5607ef6] class TemporaryFileUploadHandler(FileUploadHandler): """ Upload handler that streams data into a temporary file. """
- [d6594aae] class UploadFileException(Exception): """ Any error having to do with uploading files. """
- [995cabbd] def load_handler(path, *args, **kwargs): """ Given a path to a handler, return an instance of that handler.
- [53640b7f] from django.conf import settings from django.core.files.uploadedfile import InMemoryUploadedFile, TemporaryUploadedFile from django.utils.module_loading import import_string
- [d8c6fc5f] import os from io import BytesIO, UnsupportedOperation
