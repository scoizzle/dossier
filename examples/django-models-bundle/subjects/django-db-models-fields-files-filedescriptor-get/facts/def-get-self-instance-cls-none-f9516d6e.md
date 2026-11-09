# Fact f9516d6e

Store id: c6b30878-2cb5-4b27-b595-a83779466730

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
- posted_at: `2026-11-09T23:44:50.6458870+00:00`

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
  "id": "c6b30878-2cb5-4b27-b595-a83779466730",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6458870+00:00"
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
  "subject_id": "621f1f54-e110-4515-bd9d-c5a34c85b384",
  "subject_name": "django/db/models/fields/files::FileDescriptor.__get__",
  "tags": [
    "entity:method"
  ],
  "text": "def __get__(self, instance, cls=None)"
}
```
