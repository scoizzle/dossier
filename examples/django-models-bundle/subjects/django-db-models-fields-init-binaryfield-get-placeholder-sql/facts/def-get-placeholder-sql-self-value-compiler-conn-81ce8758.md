# Fact 81ce8758

Store id: 0526d78b-3cc9-4aed-a524-22d9ce5b4578

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
- posted_at: `2026-11-09T22:39:42.6974400+00:00`

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
  "id": "0526d78b-3cc9-4aed-a524-22d9ce5b4578",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6974400+00:00"
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
  "subject_id": "21c73c24-8950-477b-815f-39a11967999f",
  "subject_name": "django/db/models/fields/__init__::BinaryField.get_placeholder_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def get_placeholder_sql(self, value, compiler, connection)"
}
```
