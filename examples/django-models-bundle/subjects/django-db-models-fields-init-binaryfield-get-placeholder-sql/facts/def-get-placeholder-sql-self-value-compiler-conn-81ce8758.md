# Fact 81ce8758

Store id: 2781c6a7-5ad3-48e3-be09-dbe08ed3e3e8

## Text

```text
def get_placeholder_sql(self, value, compiler, connection)
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
- posted_at: `2026-11-09T23:31:56.8566870+00:00`

## Data

```json
{
  "end_line": 2784,
  "entity_kind": "method",
  "parent": "BinaryField",
  "start_line": 2783,
  "symbol": "BinaryField.get_placeholder_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2783,"selector":"L2783-L2784","symbol":"BinaryField.get_placeholder_sql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BinaryField.get_placeholder_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2784,
    "entity_kind": "method",
    "parent": "BinaryField",
    "start_line": 2783,
    "symbol": "BinaryField.get_placeholder_sql"
  },
  "id": "2781c6a7-5ad3-48e3-be09-dbe08ed3e3e8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8566870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2783,
        "selector": "L2783-L2784",
        "symbol": "BinaryField.get_placeholder_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "3c5f512b-d00f-40ce-a798-db11e88630f0",
  "subject_name": "django/db/models/fields/__init__::BinaryField.get_placeholder_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def get_placeholder_sql(self, value, compiler, connection)"
}
```
