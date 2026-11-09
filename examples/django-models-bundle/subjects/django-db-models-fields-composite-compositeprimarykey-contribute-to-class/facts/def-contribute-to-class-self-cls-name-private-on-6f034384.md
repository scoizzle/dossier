# Fact 6f034384

Store id: dc5d65fc-716a-4b40-8573-f12dd1185340

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
- posted_at: `2026-11-09T22:39:43.0012000+00:00`

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
  "id": "dc5d65fc-716a-4b40-8573-f12dd1185340",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.0012000+00:00"
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
  "subject_id": "1d0c05db-fd90-4331-a76a-1a4fd731a612",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.contribute_to_class",
  "tags": [
    "entity:method"
  ],
  "text": "def contribute_to_class(self, cls, name, private_only=False)"
}
```
