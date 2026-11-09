# Fact 6f034384

Store id: 0252eca2-db84-4738-bcf7-28d40e355ad5

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
- posted_at: `2026-11-09T23:31:57.1272750+00:00`

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
  "id": "0252eca2-db84-4738-bcf7-28d40e355ad5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.1272750+00:00"
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
  "subject_id": "8e9e467d-9a27-49d1-aac0-d75425b5fcc0",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.contribute_to_class",
  "tags": [
    "entity:method"
  ],
  "text": "def contribute_to_class(self, cls, name, private_only=False)"
}
```
