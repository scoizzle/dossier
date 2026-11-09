# Fact 6f034384

Store id: 7c24fa85-485a-4223-914e-317c720bbea6

## Text

```text
def contribute_to_class(self, cls, name, private_only=False)
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
- posted_at: `2026-11-09T23:44:50.4850720+00:00`

## Data

```json
{
  "end_line": 95,
  "entity_kind": "method",
  "parent": "CompositePrimaryKey",
  "start_line": 92,
  "symbol": "CompositePrimaryKey.contribute_to_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":92,"selector":"L92-L95","symbol":"CompositePrimaryKey.contribute_to_class"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositePrimaryKey.contribute_to_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 95,
    "entity_kind": "method",
    "parent": "CompositePrimaryKey",
    "start_line": 92,
    "symbol": "CompositePrimaryKey.contribute_to_class"
  },
  "id": "7c24fa85-485a-4223-914e-317c720bbea6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.4850720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 92,
        "selector": "L92-L95",
        "symbol": "CompositePrimaryKey.contribute_to_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "e48c704a-9257-41b8-a3b5-0f0f00e3fbc9",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.contribute_to_class",
  "tags": [
    "entity:method"
  ],
  "text": "def contribute_to_class(self, cls, name, private_only=False)"
}
```
