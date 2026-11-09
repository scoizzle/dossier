# Fact 4aeb681c

Store id: 3587e1eb-fd61-4d6a-a665-64f1829bc63a

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
- posted_at: `2026-11-09T23:44:50.4971060+00:00`

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
  "id": "3587e1eb-fd61-4d6a-a665-64f1829bc63a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.4971060+00:00"
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
  "subject_id": "fa98b183-d419-46ad-8a88-a85a312ee323",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.value_to_string",
  "tags": [
    "entity:method"
  ],
  "text": "def value_to_string(self, obj)"
}
```
