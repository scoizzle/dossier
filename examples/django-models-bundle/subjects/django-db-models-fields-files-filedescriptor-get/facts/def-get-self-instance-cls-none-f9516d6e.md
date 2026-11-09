# Fact f9516d6e

Store id: a6ba26fc-22e3-4811-9a8e-5905cb724457

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
- posted_at: `2026-11-09T22:39:43.2232820+00:00`

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
  "id": "a6ba26fc-22e3-4811-9a8e-5905cb724457",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2232820+00:00"
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
  "subject_id": "92c41803-27ad-428e-b5a8-220d0534ed76",
  "subject_name": "django/db/models/fields/files::FileDescriptor.__get__",
  "tags": [
    "entity:method"
  ],
  "text": "def __get__(self, instance, cls=None)"
}
```
