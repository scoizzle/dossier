# Fact 4aeb681c

Store id: 9f35a573-20c8-4baf-82b4-d948937d92b1

## Text

```text
def value_to_string(self, obj)
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
- posted_at: `2026-11-09T22:39:43.0190780+00:00`

## Data

```json
{
  "end_line": 146,
  "entity_kind": "method",
  "parent": "CompositePrimaryKey",
  "start_line": 140,
  "symbol": "CompositePrimaryKey.value_to_string"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":140,"selector":"L140-L146","symbol":"CompositePrimaryKey.value_to_string"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositePrimaryKey.value_to_string](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 146,
    "entity_kind": "method",
    "parent": "CompositePrimaryKey",
    "start_line": 140,
    "symbol": "CompositePrimaryKey.value_to_string"
  },
  "id": "9f35a573-20c8-4baf-82b4-d948937d92b1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.0190780+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 140,
        "selector": "L140-L146",
        "symbol": "CompositePrimaryKey.value_to_string"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "14c8bd13-7349-4551-a516-257ca4c4ca9c",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.value_to_string",
  "tags": [
    "entity:method"
  ],
  "text": "def value_to_string(self, obj)"
}
```
