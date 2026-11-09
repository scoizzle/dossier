# Fact 10a22518

Store id: 84ae16c4-9c66-47ab-91a6-7d164d513b8f

## Text

```text
def __reduce__(self)
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
- posted_at: `2026-11-09T23:44:51.8860250+00:00`

## Data

```json
{
  "end_line": 654,
  "entity_kind": "method",
  "parent": "ReverseOneToOneDescriptor",
  "start_line": 652,
  "symbol": "ReverseOneToOneDescriptor.__reduce__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":652,"selector":"L652-L654","symbol":"ReverseOneToOneDescriptor.__reduce__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.__reduce__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 654,
    "entity_kind": "method",
    "parent": "ReverseOneToOneDescriptor",
    "start_line": 652,
    "symbol": "ReverseOneToOneDescriptor.__reduce__"
  },
  "id": "84ae16c4-9c66-47ab-91a6-7d164d513b8f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.8860250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 652,
        "selector": "L652-L654",
        "symbol": "ReverseOneToOneDescriptor.__reduce__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "e8f05245-2171-4f3a-8b48-25fb1818e2df",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.__reduce__",
  "tags": [
    "entity:method"
  ],
  "text": "def __reduce__(self)"
}
```
