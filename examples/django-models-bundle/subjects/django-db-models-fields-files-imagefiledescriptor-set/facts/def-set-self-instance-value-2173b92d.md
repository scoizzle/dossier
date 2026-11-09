# Fact 2173b92d

Store id: 9566ae57-c29a-4cf6-a0cd-f7d1d1fd3efb

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
- posted_at: `2026-11-09T22:39:43.2561250+00:00`

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
  "id": "9566ae57-c29a-4cf6-a0cd-f7d1d1fd3efb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2561250+00:00"
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
  "subject_id": "293812f6-f43e-4da7-bc15-0e09feacb4eb",
  "subject_name": "django/db/models/fields/files::ImageFileDescriptor.__set__",
  "tags": [
    "entity:method"
  ],
  "text": "def __set__(self, instance, value)"
}
```
