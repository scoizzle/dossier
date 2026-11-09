# Fact 6cdc90c4

Store id: 8dd5d64e-fd2a-4e7c-bc73-95f17a168de8

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
- posted_at: `2026-11-09T23:31:57.4404390+00:00`

## Data

```json
{
  "end_line": 476,
  "entity_kind": "method",
  "parent": "ImageField",
  "start_line": 468,
  "symbol": "ImageField.contribute_to_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":468,"selector":"L468-L476","symbol":"ImageField.contribute_to_class"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::ImageField.contribute_to_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 476,
    "entity_kind": "method",
    "parent": "ImageField",
    "start_line": 468,
    "symbol": "ImageField.contribute_to_class"
  },
  "id": "8dd5d64e-fd2a-4e7c-bc73-95f17a168de8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.4404390+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 468,
        "selector": "L468-L476",
        "symbol": "ImageField.contribute_to_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "f7425896-041d-45d0-8de6-6b3696bac828",
  "subject_name": "django/db/models/fields/files::ImageField.contribute_to_class",
  "tags": [
    "entity:method"
  ],
  "text": "def contribute_to_class(self, cls, name, **kwargs)"
}
```
