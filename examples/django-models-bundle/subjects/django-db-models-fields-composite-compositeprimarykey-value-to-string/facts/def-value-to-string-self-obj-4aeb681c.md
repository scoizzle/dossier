# Fact 4aeb681c

Store id: f282c723-9dbe-4591-b9d9-35ef58522f8c

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
- posted_at: `2026-11-09T23:31:57.1442430+00:00`

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
  "id": "f282c723-9dbe-4591-b9d9-35ef58522f8c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.1442430+00:00"
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
  "subject_id": "1a510ef0-0f31-4013-91e8-1bfe4f99575b",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.value_to_string",
  "tags": [
    "entity:method"
  ],
  "text": "def value_to_string(self, obj)"
}
```
