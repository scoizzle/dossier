# Fact be379d1f

Store id: 30629fe0-5b8e-4a22-889f-0aac6b36e39b

## Text

```text
def identity(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:50.9943990+00:00`

## Data

```json
{
  "end_line": 160,
  "entity_kind": "method",
  "parent": "Join",
  "start_line": 152,
  "symbol": "Join.identity"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/datastructures.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":152,"selector":"L152-L160","symbol":"Join.identity"}`

## Referenced by

None.

## Subject

[django/db/models/sql/datastructures::Join.identity](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 160,
    "entity_kind": "method",
    "parent": "Join",
    "start_line": 152,
    "symbol": "Join.identity"
  },
  "id": "30629fe0-5b8e-4a22-889f-0aac6b36e39b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.9943990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 152,
        "selector": "L152-L160",
        "symbol": "Join.identity"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/datastructures.py"
    }
  ],
  "status": "live",
  "subject_id": "eb4533ca-6b05-4df7-9819-f6f255d5aa1a",
  "subject_name": "django/db/models/sql/datastructures::Join.identity",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def identity(self)"
}
```
