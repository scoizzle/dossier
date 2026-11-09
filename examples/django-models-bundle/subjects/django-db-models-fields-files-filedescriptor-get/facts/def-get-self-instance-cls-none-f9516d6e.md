# Fact f9516d6e

Store id: 9be634f2-054e-4319-812d-f8805e342e0a

## Text

```text
def __get__(self, instance, cls=None)
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
- posted_at: `2026-11-09T23:31:57.3830500+00:00`

## Data

```json
{
  "end_line": 233,
  "entity_kind": "method",
  "parent": "FileDescriptor",
  "start_line": 174,
  "symbol": "FileDescriptor.__get__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":174,"selector":"L174-L233","symbol":"FileDescriptor.__get__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FileDescriptor.__get__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 233,
    "entity_kind": "method",
    "parent": "FileDescriptor",
    "start_line": 174,
    "symbol": "FileDescriptor.__get__"
  },
  "id": "9be634f2-054e-4319-812d-f8805e342e0a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.3830500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 174,
        "selector": "L174-L233",
        "symbol": "FileDescriptor.__get__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "acc2a418-4eb2-4862-9760-f4a2ea9cd423",
  "subject_name": "django/db/models/fields/files::FileDescriptor.__get__",
  "tags": [
    "entity:method"
  ],
  "text": "def __get__(self, instance, cls=None)"
}
```
