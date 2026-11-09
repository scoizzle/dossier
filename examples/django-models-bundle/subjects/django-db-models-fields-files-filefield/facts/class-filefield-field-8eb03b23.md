# Fact 8eb03b23

Store id: 61b681b7-40cb-4307-adad-3b3b9c29bf4c

## Text

```text
class FileField(Field)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:50.6487300+00:00`

## Data

```json
{
  "end_line": 380,
  "entity_kind": "class",
  "parent": "files",
  "start_line": 239,
  "symbol": "FileField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":239,"selector":"L239-L380","symbol":"FileField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FileField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 380,
    "entity_kind": "class",
    "parent": "files",
    "start_line": 239,
    "symbol": "FileField"
  },
  "id": "61b681b7-40cb-4307-adad-3b3b9c29bf4c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6487300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 239,
        "selector": "L239-L380",
        "symbol": "FileField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "1ed7c651-e32e-4d7a-b9a1-5521c842a297",
  "subject_name": "django/db/models/fields/files::FileField",
  "tags": [
    "entity:class"
  ],
  "text": "class FileField(Field)"
}
```
