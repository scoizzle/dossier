# django/core/files/uploadedfile

- Subject: django/core/files/uploadedfile (id `701d80c6-09f5-4c50-ba26-9427881e1a06`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 22 of 27
- Conflicts: 0
- Gaps: 0

## Facts

- # File names longer than 255 characters can cause problems on older # OSes. if len(name) > 255: name, ext = os.path.splitext(name) ext = ext[:255] name = name[: 255 - len(ext)] + ext [b0203cc5]
- name = validate_file_name(name) [7a15a7da]
- self._name = name [94b7aebe]
- @classmethod def from_dict(cls, file_dict): """ Create a SimpleUploadedFile object from a dictionary with keys: - filename - content-type - content """ return cls( file_dict["filename"], file_dict["content"], file_dict.get("content-type", "text/plain"), ) [179b4b61]
- An ``UploadedFile`` object behaves somewhat like a file object and represents some file data that the user submitted with a form. """ [b442ccfa]
- def __bool__(self): return bool(self.name) [034c6bfffd6bb5ec]
- def __init__( self, file, field_name, name, content_type, size, charset, content_type_extra=None, ): super().__init__(file, name, content_type, size, charset, content_type_extra) self.field_name = field_name [9397e42f]
- def __init__(self, name, content, content_type="text/plain"): content = content or b"" super().__init__( BytesIO(content), None, name, content_type, len(content), None, None ) [87839a08]
- def __init__(self, name, content_type, size, charset, content_type_extra=None): _, ext = os.path.splitext(name) file = tempfile.NamedTemporaryFile( suffix=".upload" + ext, dir=settings.FILE_UPLOAD_TEMP_DIR ) super().__init__(file, name, content_type, size, charset, content_type_extra) [3418ca2b]
- def __repr__(self): return "<%s: %s (%s)>" % (self.__class__.__name__, self.name, self.content_type) [c2517704]
- def _get_name(self): return self._name [d12d2d77]
- def _set_name(self, name): # Sanitize the file name so that it can't be dangerous. if name is not None: # Just use the basename of the file -- anything else is dangerous. name = os.path.basename(name) [9b0b66a2]
- def chunks(self, chunk_size=None): self.file.seek(0) yield self.read() [80b5942f]
- def close(self): try: return self.file.close() except FileNotFoundError: # The file was moved or deleted before the tempfile could unlink # it. Still sets self.file.close_called and calls # self.file.file.close() before the exception. pass [a3aa5004]
- def multiple_chunks(self, chunk_size=None): # Since it's in memory, we'll never have multiple chunks. return False [3cc365a6]
- def open(self, mode=None): self.file.seek(0) return self [18ebe5f7]
- def temporary_file_path(self): """Return the full path of this file.""" return self.file.name [bf23b928]
- name = property(_get_name, _set_name) [6f27f8b1]
- """ Classes representing uploaded files. """ [853c365c]
- __all__ = ( "UploadedFile", "TemporaryUploadedFile", "InMemoryUploadedFile", "SimpleUploadedFile", ) [bed1b7d2]
- class InMemoryUploadedFile(UploadedFile): """ A file uploaded into memory (i.e. stream-to-memory). """ [ae72011c]
- class TemporaryUploadedFile(UploadedFile): """ A file uploaded to a temporary location (i.e. stream-to-disk). """ [d0510456]

## Beyond the budget

4 more facts did not fit in the budget: [a905089f] [df0b4398] [40afc2b4] [47f8f16b]
