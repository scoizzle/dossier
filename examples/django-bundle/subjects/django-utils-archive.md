# django/utils/archive

- Subject: django/utils/archive (id `cb98cc92-d0cd-4fd1-86a3-b5ed2c30bdff`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 12 of 34
- Conflicts: 0
- Gaps: 0

## Facts

- @staticmethod def _archive_cls(file): cls = None if isinstance(file, str): filename = file else: try: filename = file.name except AttributeError: raise UnrecognizedArchiveFormat( "File object not a recognized archive format." ) base, tail_ext = os.path.splitext(filename.lower()) cls = extension_map.get(tail_ext) if not cls: base, ext = os.path.splitext(base) cls = extension_map.get(ext) if not cls: raise UnrecognizedArchiveFormat( "Path not a recognized archive format: %s" % filename ) return cls [c91c4211]
- @staticmethod def _copy_permissions(mode, filename): """ If the file in the archive has some permissions (this assumes a file won't be writable/executable without being readable), apply those permissions to the unarchived file. """ if mode & stat.S_IROTH: os.chmod(filename, mode) [11692cd1]
- def __enter__(self): return self [3ef33e95d940f83e-4]
- def __exit__(self, exc_type, exc_value, traceback): self.close() [13fbb7dd43764b1a-2]
- def __init__(self, file): self._archive = self._archive_cls(file)(file) [d650a8e0]
- def close(self): self._archive.close() [bc9e991491347ef6]
- def extract(self): raise NotImplementedError( "subclasses of BaseArchive must provide an extract() method" ) [d36037c4]
- def extract(self, to_path): members = self._archive.getmembers() leading = self.has_leading_dir(x.name for x in members) for member in members: name = member.name if leading: name = self.split_leading_dir(name)[1] filename = self.target_filename(to_path, name) if member.isdir(): if filename: os.makedirs(filename, exist_ok=True) else: try: extracted = self._archive.extractfile(member) except (KeyError, AttributeError) as exc: # Some corrupt tar files seem to produce this # (specifically bad symlinks) print( "In the tar file %s the member %s is invalid: %s" % (name, member.name, exc) ) else: dirname = os.path.dirname(filename) if dirname: os.makedirs(dirname, exist_ok=True) with open(filename, "wb") as outfile: shutil.copyfileobj(extracted, outfile) self._copy_permissions(member.mode, filename) finally: if extracted: extracted.close() [247348b1]
- def extract(self, to_path): namelist = self._archive.namelist() leading = self.has_leading_dir(namelist) for name in namelist: data = self._archive.read(name) info = self._archive.getinfo(name) if leading: name = self.split_leading_dir(name)[1] if not name: continue filename = self.target_filename(to_path, name) if name.endswith(("/", "\\")): # A directory os.makedirs(filename, exist_ok=True) else: dirname = os.path.dirname(filename) if dirname: os.makedirs(dirname, exist_ok=True) with open(filename, "wb") as outfile: outfile.write(data) # Convert ZipInfo.external_attr to mode mode = info.external_attr >> 16 self._copy_permissions(mode, filename) [45fbd340]
- def extract(self, to_path): self._archive.extract(to_path) [9fe195a5]
- def has_leading_dir(self, paths): """ Return True if all the paths have the same leading path name (i.e., everything is in one subdirectory in an archive). """ common_prefix = None for path in paths: prefix, rest = self.split_leading_dir(path) if not prefix: return False elif common_prefix is None: common_prefix = prefix elif prefix != common_prefix: return False return True [7fbddcd1]
- def list(self): self._archive.list() [f9e9cf58]

## Beyond the budget

19 more facts did not fit in the budget: [87a0a4b7] [a4366e63] [43c8c5ad] [36e44d97] [601c5f36] [30e2c063] [dbfc264b] [65635e8d] [fc376f77] [6b61e305] [962572aa] [52b0d7d6] [0db2c928] [68b3e49a] [bb830f1d] [8b699017] [77be20a2] [5132f8c967779d0c-2] [88847408]
