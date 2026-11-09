# Fact f1a12679

Store id: b7a6a01c-889e-4e3c-b233-1bc91d34b691

## Text

```text
def to_python(self, value)
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
- posted_at: `2026-11-09T22:39:42.7190290+00:00`

## Data

```json
{
  "end_line": 2863,
  "entity_kind": "method",
  "parent": "UUIDField",
  "start_line": 2852,
  "symbol": "UUIDField.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2852,"selector":"L2852-L2863","symbol":"UUIDField.to_python"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::UUIDField.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2863,
    "entity_kind": "method",
    "parent": "UUIDField",
    "start_line": 2852,
    "symbol": "UUIDField.to_python"
  },
  "id": "b7a6a01c-889e-4e3c-b233-1bc91d34b691",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.7190290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2852,
        "selector": "L2852-L2863",
        "symbol": "UUIDField.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "fa804efc-48dc-4f99-b42f-89ef979044c4",
  "subject_name": "django/db/models/fields/__init__::UUIDField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
