# Fact 10a22518

Store id: 33dd1bf4-d8e7-468d-94ea-cbe65ad1b9f8

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
- posted_at: `2026-11-09T23:31:59.2105420+00:00`

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
  "id": "33dd1bf4-d8e7-468d-94ea-cbe65ad1b9f8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.2105420+00:00"
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
  "subject_id": "1fa7fbcd-b81f-4a6f-ae99-2040aae2344c",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.__reduce__",
  "tags": [
    "entity:method"
  ],
  "text": "def __reduce__(self)"
}
```
