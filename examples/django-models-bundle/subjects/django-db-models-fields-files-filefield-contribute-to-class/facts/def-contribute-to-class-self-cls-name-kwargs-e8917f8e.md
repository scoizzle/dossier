# Fact e8917f8e

Store id: f871a7ac-6930-49be-b729-d8364f0d1e3c

## Text

```text
def contribute_to_class(self, cls, name, **kwargs)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:43.2449470+00:00`

## Data

```json
{
  "end_line": 346,
  "entity_kind": "method",
  "parent": "FileField",
  "start_line": 344,
  "symbol": "FileField.contribute_to_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":344,"selector":"L344-L346","symbol":"FileField.contribute_to_class"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FileField.contribute_to_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 346,
    "entity_kind": "method",
    "parent": "FileField",
    "start_line": 344,
    "symbol": "FileField.contribute_to_class"
  },
  "id": "f871a7ac-6930-49be-b729-d8364f0d1e3c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2449470+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 344,
        "selector": "L344-L346",
        "symbol": "FileField.contribute_to_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "8fc6006b-37b3-44bd-88de-113a0347143e",
  "subject_name": "django/db/models/fields/files::FileField.contribute_to_class",
  "tags": [
    "entity:method"
  ],
  "text": "def contribute_to_class(self, cls, name, **kwargs)"
}
```
