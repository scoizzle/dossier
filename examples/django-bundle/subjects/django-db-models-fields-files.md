# django/db/models/fields/files

- Subject: django/db/models/fields/files (id `5c765bde-d503-45e3-8b3c-704bfdd38c80`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 13 of 83
- Conflicts: 0
- Gaps: 0

## Facts

- # Finally, because of the (some would say boneheaded) way pickle works, # the underlying FieldFile might not actually itself have an associated # file. So we need to reset the details of the FieldFile in those # cases. elif isinstance(file, FieldFile) and not hasattr(file, "field"): file.instance = instance file.field = self.field file.storage = self.field.storage [229d340a]
- # If this value is a DatabaseDefault, initialize the attribute class # for this field with its db_default value. elif isinstance(file, DatabaseDefault): attr = self.field.attr_class(instance, self.field, self.field.db_default) instance.__dict__[self.field.attname] = attr [f3b1f5cd]
- # If this value is a string (instance.file = "path/to/file") or None # then we simply wrap it with the appropriate attribute class according # to the file field. [This is FieldFile for FileFields and # ImageFieldFile for ImageFields; it's also conceivable that user # subclasses might also want to subclass the attribute class]. This # object understands how to convert a path to a file, and also how to # handle None. if isinstance(file, str) or file is None: attr = self.field.attr_class(instance, self.field, file) instance.__dict__[self.field.attname] = attr [4aafc014]
- # Make sure that the instance is correct. elif isinstance(file, FieldFile) and instance is not file.instance: file.instance = instance [89314e62]
- # Nothing to update if we have no file and not being forced to update. if not file and not force: return [f051ed31]
- # Other types of files may be assigned as well, but they need to have # the FieldFile interface added to them. Thus, we wrap any other type # of File inside a FieldFile (well, the field's attr_class, which is # usually FieldFile). elif isinstance(file, File) and not isinstance(file, FieldFile): file_copy = self.field.attr_class(instance, self.field, file.name) file_copy.file = file file_copy._committed = False instance.__dict__[self.field.attname] = file_copy [6fd8fdd6]
- # Save the object because it has changed, unless save is False if save: self.instance.save() [9e8a9a2b]
- # That was fun, wasn't it? return instance.__dict__[self.field.attname] [84d55a9f]
- # The instance dict contains whatever was originally assigned # in __set__. file = super().__get__(instance, cls) [57445ed3]
- # This is slightly complicated, so worth an explanation. # instance.file needs to ultimately return some instance of `File`, # probably a subclass. Additionally, this returned object needs to have # the FieldFile API so that users can easily do things like # instance.file.path and have that delegated to the file storage # engine. Easy enough if we're strict about assignment in __set__, but # if you peek below you can see that we're not. So depending on the # current value of the field we have to dynamically construct some sort # of "thing" to return. [45274d05]
- # Update the width and height fields. if self.width_field: setattr(instance, self.width_field, width) if self.height_field: setattr(instance, self.height_field, height) [3ee7dd1e]
- >>> from myapp.models import MyModel >>> instance = MyModel.objects.get(pk=1) >>> instance.file.size [744095df]
- if save: self.instance.save() [2fadbc3a]

## Beyond the budget

70 more facts did not fit in the budget: [6cd32dce] [8e3c2517] [907d2b60] [68b4cf4c] [f05e4dbe] [fa7e4902] [bbeef244] [ad6ef699] [aa18b62f] [ec56b9a8] [160aed8e] [b13caeb9] [4f39daaf] [2a08393c] [7acbdf81] [bf8530e7] [16e4a1d5] [d1d7d9be] [46fa6746] [d8581fa7] [7da30068] [034c6bfffd6bb5ec-2] [bba04d42] [6cb055affe3d46b9-2] [64d4e489] [68a43251e1e51512-2] [50534d7c] [edc2f433] [78e6eb78] [bc83f179] [de1c6965] [45cbf3e9] [b1a8897c] [dd736a5a] [6c2f32bb] [fb07a31d] [5299e48a] [27710248] [38b118c4] [6ec5bbd3] [845e8d2c] [3bae6c50] [77da06d0] [3e430240] [be4ab236] [55f9e6b3] [2b50d48e] [47fbc30d] [5113b397] [bfa5942b] [8fe6b2c5] [61b41759] [60407416] [de646a85] [77adf4fe] [d5bc376b] [98015134] [5f9c5e87] [75c7536c6c9c38ef-2] [2239c766] [dde2d03f] [f5d522f57fd5e2a5-2] [fe1af9d1] [7f3180e2] [087b93bf] [a29b2905] [eeb614ca] [80d9d1d9] [ec8770e8] [e56269b0]
