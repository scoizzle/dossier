# docs/howto/delete-app

- Subject: docs/howto/delete-app (id `db6a4389-be4b-455d-9d3e-a5ba5d37cc5e`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 365 tokens
- Facts shown: 10 facts
- Conflicts: 0
- Gaps: 0

## Facts

- #. :ref:`Squash <migration-squashing>` out references to the app in other apps' migrations. [809ef46e]
- #. Apply migrations locally, run tests, and verify the correctness of your project. [475011c7]
- #. Create relevant migrations by running :djadmin:`makemigrations`. This step generates a migration that deletes tables for the removed models, and any other required migration for updating relationships connected to those models. [d90847c1]
- #. Deploy/release your updated Django project. [a55c446e]
- #. Finally, remove the app's directory. [52a1cf31]
- #. Remove all models from the corresponding ``models.py`` file. [06c72085]
- #. Remove all references to the app (imports, foreign keys etc.). [8c729097]
- #. Remove the app from :setting:`INSTALLED_APPS`. [d13d6dc5]
- ================================== How to delete a Django application ================================== [632f57fb]
- Django provides the ability to group sets of features into Python packages called :doc:`applications</ref/applications/>`. When requirements change, apps may become obsolete or unnecessary. The following steps will help you delete an application safely. [d91dc581]
