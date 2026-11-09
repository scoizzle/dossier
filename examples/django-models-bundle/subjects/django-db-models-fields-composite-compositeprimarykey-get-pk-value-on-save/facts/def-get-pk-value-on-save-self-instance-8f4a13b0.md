# Fact 8f4a13b0

Store id: 47387731-78dd-41d3-aa62-f80f7724be28

## Text

```text
def get_pk_value_on_save(self, instance)
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
- posted_at: `2026-11-09T22:39:43.0150520+00:00`

## Data

```json
{
  "end_line": 127,
  "entity_kind": "method",
  "parent": "CompositePrimaryKey",
  "start_line": 118,
  "symbol": "CompositePrimaryKey.get_pk_value_on_save"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":118,"selector":"L118-L127","symbol":"CompositePrimaryKey.get_pk_value_on_save"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositePrimaryKey.get_pk_value_on_save](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 127,
    "entity_kind": "method",
    "parent": "CompositePrimaryKey",
    "start_line": 118,
    "symbol": "CompositePrimaryKey.get_pk_value_on_save"
  },
  "id": "47387731-78dd-41d3-aa62-f80f7724be28",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.0150520+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 118,
        "selector": "L118-L127",
        "symbol": "CompositePrimaryKey.get_pk_value_on_save"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "6c03a898-0095-4c22-80ca-ad7d7bcdd52d",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.get_pk_value_on_save",
  "tags": [
    "entity:method"
  ],
  "text": "def get_pk_value_on_save(self, instance)"
}
```
