# Fact 2173b92d

Store id: 0d4b1464-1d8b-4b61-b909-f41ac88c669c

## Text

```text
def __set__(self, instance, value)
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
- posted_at: `2026-11-09T23:44:50.6698220+00:00`

## Data

```json
{
  "end_line": 403,
  "entity_kind": "method",
  "parent": "ImageFileDescriptor",
  "start_line": 389,
  "symbol": "ImageFileDescriptor.__set__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":389,"selector":"L389-L403","symbol":"ImageFileDescriptor.__set__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::ImageFileDescriptor.__set__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 403,
    "entity_kind": "method",
    "parent": "ImageFileDescriptor",
    "start_line": 389,
    "symbol": "ImageFileDescriptor.__set__"
  },
  "id": "0d4b1464-1d8b-4b61-b909-f41ac88c669c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6698220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 389,
        "selector": "L389-L403",
        "symbol": "ImageFileDescriptor.__set__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "a174f68c-ec35-4b9d-b22a-d81066d05541",
  "subject_name": "django/db/models/fields/files::ImageFileDescriptor.__set__",
  "tags": [
    "entity:method"
  ],
  "text": "def __set__(self, instance, value)"
}
```
